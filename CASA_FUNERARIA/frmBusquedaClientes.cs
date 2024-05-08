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
    public partial class frmBusquedaClientes : Form
    {
        Cliente cliente = new Cliente();
        public frmBusquedaClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmBusquedaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsCliente.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.dsCliente.Clientes);

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dgClientes.DataSource = null;
                dgClientes.Refresh();
                DataTable dataTable = new DataTable();
                cargardg(txtBusqueda.Text);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        void cargardg(string Clave)
        {
            SqlConnection con = new SqlConnection($"Data Source = localhost\\SQLSERVER2019; Initial Catalog = Funeraria;User = sa; Password = 21030561");
            string query = $"Select * from Clientes where Cli_Nombre like '%{Clave}%'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgClientes.DataSource = dt;
            con.Close();
        }

        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgr = dgClientes.Rows[e.RowIndex];
            cliente.Id = Convert.ToInt32(dgr.Cells[0].Value);
            cliente.Nombre = Convert.ToString(dgr.Cells[1].Value);
            cliente.Domicilio = Convert.ToString(dgr.Cells[2].Value);
            cliente.EstadoCivil = Convert.ToString(dgr.Cells[3].Value);
            cliente.Hijos = Convert.ToString(dgr.Cells[4].Value);
            cliente.IngresosMensuales = Convert.ToDouble(dgr.Cells[5].Value);
            cliente.IngresosAcumulables = Convert.ToDouble(dgr.Cells[6].Value);
            cliente.Plan = Convert.ToString(dgr.Cells[7].Value);

            FrmResumen frmResumen = new FrmResumen(cliente);
            frmResumen.Show();

            this.Close();
            //MessageBox.Show(cliente.Nombre + "   " + cliente.Plan);
        }
    }
}
