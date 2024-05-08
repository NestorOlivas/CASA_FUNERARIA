using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CASA_FUNERARIA.Models;

namespace CASA_FUNERARIA
{
    public partial class FrmCliente : Form
    {
        String idMax = "";
        DataTable dataTable = new DataTable();

        public static string connectionString = "Data Source = localhost\\SQLSERVER2019; Initial Catalog = Funeraria;User = sa; Password = 21030561";
        //public static string connectionString = "Data Source=DESKTOP-M9JI4S2\\SQLEXPRESS;Initial Catalog=Funeraria;Persist Security Info=True;User ID=si;Password=21030676;TrustServerCertificate=True";
        public FrmCliente()
        {
            InitializeComponent();
            CBHIJOS.Enabled = false;
            TXTINGRESOMENSUAL.Enabled = false;
        }

        private void BtnRegresarregistroC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            TXTNOMBRE.Clear();
            TXTDOMICILIO.Clear();
            CBESTADOCIVIL.SelectedIndex = -1;
            CBHIJOS.SelectedIndex = -1;
            TXTINGRESOMENSUAL.Clear();
            TXTINGRESOSACOMULABLES.Clear();
            TXTPLANSUGERIDO.Clear();
        }

        private void CbEstCiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBESTADOCIVIL.SelectedIndex == 0)
            {
                CBHIJOS.Enabled = false;
                TXTINGRESOMENSUAL.Enabled = true;
                CBHIJOS.SelectedIndex = -1;
            }
            else
            {
                CBHIJOS.Enabled = true;
                TXTINGRESOMENSUAL.Enabled = true;
            }
        }

        private void TxtIngMen_Leave(object sender, EventArgs e)
        {
            CalcularPlan();
        }

        void CalcularPlan()
        {
            if (TXTINGRESOMENSUAL.Text.Length == 0)
            {
                MessageBox.Show("Por favor registre su ingreso mensual");
            }
            else
            {
                double mensual = 0, acumulable = 0;
                int hijos = 0;

                mensual = Convert.ToDouble(TXTINGRESOMENSUAL.Text);

                if (CBESTADOCIVIL.Text == "Soltero")
                {
                    acumulable = mensual * 0.80;
                }
                else if (CBESTADOCIVIL.Text == "Casado" || CBESTADOCIVIL.Text == "Divorciado")
                {
                    if (CBHIJOS.Text == "" || CBHIJOS.Text == "0")
                    {
                        acumulable = mensual * 0.60;
                    }
                    else if (CBHIJOS.Text == "1")
                    {
                        acumulable = mensual * 0.50;
                    }
                    else if (CBHIJOS.Text == "2")
                    {
                        acumulable = mensual * 0.45;
                    }
                    else if (CBHIJOS.Text == "3")
                    {
                        acumulable = mensual * 0.40;
                    }
                    else if (CBHIJOS.Text == "4 O MÁS")
                    {
                        acumulable = mensual * 0.40;
                    }
                }

                TXTINGRESOSACOMULABLES.Text = acumulable.ToString();

                //MessageBox.Show("Estado civil: " + CbEstCiv.Text + ", Hijos: " + CbHijos.Text);

                if (acumulable <= 3000)
                {
                    TXTPLANSUGERIDO.Text = "ECONOMICO";
                }
                else if (acumulable >= 3001 && acumulable <= 8000)
                {
                    TXTPLANSUGERIDO.Text = "ESTANDAR";
                }
                else if (acumulable >= 8001 && acumulable <= 15000)
                {
                    TXTPLANSUGERIDO.Text = "ORO";
                }
                else if (acumulable >= 15001)
                {
                    TXTPLANSUGERIDO.Text = "DIAMANTE";
                }

            }
        }

        private void TxtIngMen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                CalcularPlan();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
                if(TXTNOMBRE.Text == "" || TXTDOMICILIO.Text == "" || CBESTADOCIVIL.SelectedIndex == -1 || TXTINGRESOMENSUAL.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar");
            }
            else
            {
                try
                {
                    if (ObetenerIdMax(ref dataTable))
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            idMax = row[0].ToString();
                        }
                        if (idMax == null | idMax == string.Empty)
                        {
                            idMax = "1";
                        }
                    }
                    else
                    {
                        idMax = "1";
                    }

                    GuardarCliente(Convert.ToInt32(idMax), TXTNOMBRE.Text, TXTDOMICILIO.Text, CBESTADOCIVIL.Text, CBHIJOS.Text, Convert.ToDecimal(TXTINGRESOMENSUAL.Text), Convert.ToDecimal(TXTINGRESOSACOMULABLES.Text), TXTPLANSUGERIDO.Text);

                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(idMax);
                    cliente.Nombre = TXTNOMBRE.Text;
                    cliente.Domicilio = TXTDOMICILIO.Text;
                    cliente.EstadoCivil = CBESTADOCIVIL.Text;
                    cliente.Hijos = CBHIJOS.Text;
                    cliente.IngresosMensuales = Convert.ToDouble(TXTINGRESOMENSUAL.Text);
                    cliente.IngresosAcumulables = Convert.ToDouble(TXTINGRESOSACOMULABLES.Text);
                    cliente.Plan = TXTPLANSUGERIDO.Text;

                    MessageBox.Show("El cliente se guardo correctamente");
                    FrmResumen resumen = new FrmResumen(cliente);
                    resumen.Show();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void GuardarCliente(int id, string nombre, string domicilio, string estadoCivil, string hijos, decimal ingresosMensuales, decimal ingresosAcumulables, string planSugerido)
        {
            // Crear la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL
                string consulta = @"INSERT INTO Clientes (Cli_id, Cli_Nombre, Cli_Domicilio, Cli_EstadoCivil, Cli_Hijos, Cli_IngresosMensuales, Cli_IngresosAcumulables, Cli_PlanSugerido)
                            VALUES (@id, @nombre, @domicilio, @estadoCivil, @hijos, @ingresosMensuales, @ingresosAcumulables, @planSugerido)";
                SqlCommand comando = new SqlCommand(consulta, connection);

                // Agregar los parámetros
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@domicilio", domicilio);
                comando.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                comando.Parameters.AddWithValue("@hijos", hijos);
                comando.Parameters.AddWithValue("@ingresosMensuales", ingresosMensuales);
                comando.Parameters.AddWithValue("@ingresosAcumulables", ingresosAcumulables);
                comando.Parameters.AddWithValue("@planSugerido", planSugerido);

                // Ejecutar el comando
                comando.ExecuteNonQuery();
                connection.Close();
            }
        }

        public Boolean ObetenerIdMax(ref DataTable tabla)
        {
            Boolean bAllok = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLSERVER2019; Initial Catalog = Funeraria;User = sa; Password = 21030561; Persist security Info = true"))
                {
                    connection.Open();
                    string Query = $"select max(Cli_id)+1 from Clientes";
                    SqlCommand command = new SqlCommand(Query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(tabla);
                    bAllok = true;
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                string x = e.Message;
                MessageBox.Show("Error: " + x);
            }
            return bAllok;

        }
    }
}
