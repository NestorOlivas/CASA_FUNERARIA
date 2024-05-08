using CASA_FUNERARIA.Models;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CASA_FUNERARIA
{
    public partial class FrmResumen : Form
    {
        

        public static string connectionString = "Data Source = localhost\\SQLSERVER2019; Initial Catalog = Funeraria;User = sa; Password = 21030561";

        int id = 0, inicio = 0;
        string nom = "", dom = "", estadocv = "", hijos = "", plan = "", planOriginal = "";
        double ingresosMen = 0, ingresosAc = 0, enganche = 0, mensualidad = 0;
        double enganche2 = 0, men2 = 0, cFinanciar = 0;
        string f1 = "", f2 = "", f3 = "", f4 = "";
        int dia = 0, mes = 0, year = 0;
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            GenerarFichas();
            MessageBox.Show("Las fichas se elaboraron correctamente");

            //printDocument1 = new PrintDocument();
            //PrinterSettings ps = new PrinterSettings();
            //printDocument1.PrinterSettings = ps;
            //printDocument1.PrintPage += Imprimir;
            //printDocument1.Print();
            //MessageBox.Show("funciona correctamente");

            //---------------------------------Código para mostrar fichas de pago--------------------------------------------------
            string nombre = "Juan Pérez";
            string concepto = "Pago de salario";
            double monto = 1500.0;
            DateTime fecha = DateTime.Now;

            // Ruta donde se guardará el PDF
            string rutaPDF = @"C:\UAdeO\6 Semestre\Toma de Decisiones\ficha_pago.pdf";

            // Crear un nuevo documento PDF
            PdfDocument pdfDoc = new PdfDocument(new PdfWriter(rutaPDF));
            Document doc = new Document(pdfDoc);

            // Agregar contenido al PDF
            doc.Add(new Paragraph("FICHA DE PAGO"));
            doc.Add(new Paragraph($"Nombre: {nombre}"));
            doc.Add(new Paragraph($"Concepto: {concepto}"));
            doc.Add(new Paragraph($"Monto: {monto}"));
            doc.Add(new Paragraph($"Fecha: {fecha.ToString("dd/MM/yyyy HH:mm:ss")}"));

            // Cerrar el documento
            doc.Close();

            //-----------------------------------------------------------------------------------
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Point);
            int width = 200;
            int y = 20;
            e.Graphics.DrawString("funciona", font, Brushes.Black, new RectangleF(0,y+20,width,20));
            e.Graphics.DrawString("muy bien", font, Brushes.Black, new RectangleF(0, y + 20, width, 20));
        }

        void ModificarFecha()
        {
            switch (mes)
            {
                case 1:
                    mes = 2;
                    break;
                case 2:
                    mes = 3;
                    break;
                case 3:
                    mes = 4;
                    break;
                case 4:
                    mes = 5;
                    break;
                case 5:
                    mes = 6;
                    break;
                case 6:
                    mes = 7;
                    break;
                case 7:
                    mes = 8;
                    break;
                case 8:
                    mes = 9;
                    break;
                case 9:
                    mes = 10;
                    break;
                case 10:
                    mes = 11;
                    break;
                case 11:
                    mes = 12;
                    break;
                case 12:
                    mes = 1;
                    year = year + 1;
                    break;
            }

        }
        void ModificarDia()
        {
            switch (mes)
            {
                case 1:
                    if(dia >= 28)
                    {
                        dia = 28;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 2:
                    dia++;
                    break;
                case 3:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 4:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 5:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 6:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 7:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 8:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 9:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 10:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 11:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
                case 12:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    else
                    {
                        dia++;
                    }
                    break;
            }
        }
        void ModificarDia2()
        {
            switch (mes)
            {
                case 1:
                    if (dia >= 28)
                    {
                        dia = 28;
                    }
                    break;
                case 2:
                    //dia++;
                    break;
                case 3:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    break;
                case 4:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    break;
                case 5:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    break;
                case 6:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    break;
                case 7:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    break;
                case 8:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    break;
                case 9:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    break;
                case 10:
                    if (dia >= 30)
                    {
                        dia = 30;
                    }
                    break;
                case 11:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    break;
                case 12:
                    if (dia >= 31)
                    {
                        dia = 31;
                    }
                    break;
            }
        }
        void GenerarFichas()
        {
            f1 = DateTime.Now.ToString();
            dia = DateTime.Now.Day;
            mes = DateTime.Now.Month;
            year = DateTime.Now.Year;

            ModificarDia();

            ModificarFecha();

            f2 = dia + "/" + mes + "/" + year;

            ModificarDia2();
            ModificarFecha();
            

            f3 = dia + "/" + mes + "/" + year;

            ModificarDia2();
            ModificarFecha();

            f4 = dia + "/" + mes + "/" + year;

            

            //MessageBox.Show(f1 + " | " + Convert.ToDateTime(f2));
            GuardarFichas(1, Convert.ToDateTime(f1), Convert.ToDecimal(enganche2), cbPlan.Text, id);
            GuardarFichas(2, Convert.ToDateTime(f2), Convert.ToDecimal(men2), cbPlan.Text, id);
            GuardarFichas(3, Convert.ToDateTime(f3), Convert.ToDecimal(men2), cbPlan.Text, id);
            GuardarFichas(4, Convert.ToDateTime(f4), Convert.ToDecimal(men2), cbPlan.Text, id);
        }

        public Boolean ObetenerIdMax(ref DataTable tabla)
        {
            Boolean bAllok = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source = localhost\SQLSERVER2019; Initial Catalog = Funeraria;User = sa; Password = 21030561; Persist security Info = true"))
                {
                    connection.Open();
                    string Query = $"select max(Fp_id)+1 from FichasPago";
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

        public void GuardarFichas(int Folio, DateTime Fecha, decimal Monto, string paquete, int idcliente)
        {
            String idMax = "";
            DataTable dataTable = new DataTable();
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
            // Crear la conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando SQL
                string consulta = @"INSERT INTO FichasPago (Fp_id, Fp_Folio, Fp_Fecha, Fp_Monto, Fp_Paquete, Fp_IdCliente, Fp_Status)
                            VALUES (@id, @folio, @fecha, @monto, @paquete, @idcliente, @status)";
                SqlCommand comando = new SqlCommand(consulta, connection);

                // Agregar los parámetros
                comando.Parameters.AddWithValue("@id", idMax);
                comando.Parameters.AddWithValue("@folio", Folio);
                comando.Parameters.AddWithValue("@fecha", Fecha);
                comando.Parameters.AddWithValue("@monto", Monto);
                comando.Parameters.AddWithValue("@paquete", paquete);
                comando.Parameters.AddWithValue("@idcliente", idcliente);
                comando.Parameters.AddWithValue("@status", "PENDIENTE");

                // Ejecutar el comando
                comando.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void cbPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtCliente.Text != "")
            {
                plan = cbPlan.Text;
                if (planOriginal == plan)
                {
                    Enganche();
                }
                else
                {
                    Enganche2();
                }
                Mensualidad();
                enganche2 = enganche;
                men2 = mensualidad;
                LBMOSTRARENGACHE.Text = "$" + enganche.ToString() + ".00";
                LBMOSTRARMENSUALIDAD.Text = "$" + mensualidad.ToString();
                LBCANTIDADFINANCIAR.Text = "$" + cFinanciar.ToString();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaClientes busqueda = new frmBusquedaClientes();
            busqueda.Show();

            this.Close();
        }

        double eco = 25600, estandar = 43400, oro = 85400, diamante = 155200;
        public FrmResumen()
        {
            InitializeComponent();
            //inicio = 0;
            //btnBuscar.Visible = false;
        }

        public FrmResumen(Cliente cliente)
        {
            InitializeComponent();
            id = cliente.Id;
            nom = cliente.Nombre;
            dom = cliente.Domicilio;
            estadocv = cliente.EstadoCivil;
            hijos = cliente.Hijos;
            plan = cliente.Plan;
            ingresosMen = cliente.IngresosMensuales;
            ingresosAc = cliente.IngresosAcumulables;
            //inicio = 1;
            planOriginal = plan;
            Enganche();
            Mensualidad();
            enganche2 = enganche;
            men2 = mensualidad;
            txtCliente.Text = nom;
            //TxtPaquete.Text = plan;
            LBMOSTRARENGACHE.Text = "$"+enganche.ToString() + ".00";
            LBMOSTRARMENSUALIDAD.Text = "$" + mensualidad.ToString();
            LBMOSTRARMESES.Text = "3";
            LBCANTIDADFINANCIAR.Text = "$" + cFinanciar.ToString();
        }

        void Enganche()
        {
            if(plan == "ECONOMICO")
            {
                enganche = eco * 0.30;
                cbPlan.SelectedIndex = 0;
            }
            else if(plan == "ESTANDAR")
            {
                enganche = estandar * 0.30;
                cbPlan.SelectedIndex = 1;
            }
            else if (plan == "ORO")
            {
                enganche = oro * 0.30;
                cbPlan.SelectedIndex = 2;
            }
            else if (plan == "DIAMANTE")
            {
                enganche = diamante * 0.30;
                cbPlan.SelectedIndex = 3;
            }
            enganche = Math.Truncate(enganche * 100) / 100;
        }

        void Enganche2()
        {
            if (plan == "ECONOMICO")
            {
                enganche = eco * 0.75;
            }
            else if (plan == "ESTANDAR")
            {
                enganche = estandar * 0.75;
            }
            else if (plan == "ORO")
            {
                enganche = oro * 0.75;
            }
            else if (plan == "DIAMANTE")
            {
                enganche = diamante * 0.75;
            }
        }

        void Mensualidad()
        {
            if (plan == "ECONOMICO")
            {
                cFinanciar = eco - enganche;
                mensualidad = cFinanciar / 3;
            }
            else if (plan == "ESTANDAR")
            {
                cFinanciar = estandar - enganche;
                mensualidad = cFinanciar / 3;
            }
            else if (plan == "ORO")
            {
                cFinanciar = oro - enganche;
                mensualidad = cFinanciar / 3;
            }
            else if (plan == "DIAMANTE")
            {
                cFinanciar = diamante - enganche;
                mensualidad = cFinanciar / 3;
            }
            mensualidad = Math.Truncate(mensualidad * 100) / 100;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //TxtPaquete.Clear();
            cbPlan.SelectedIndex = -1;
            txtCliente.Clear();
            LBMOSTRARENGACHE.Text = "";
            LBMOSTRARMENSUALIDAD.Text = "";
            LBMOSTRARMESES.Text = "";
            LBCANTIDADFINANCIAR.Text = "";
            
        }
    }
}
