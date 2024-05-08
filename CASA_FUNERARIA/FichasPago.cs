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

namespace CASA_FUNERARIA
{
    public partial class FichasPago : Form
    {
        string f1="", f2="";
        public FichasPago()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                f1 = dtpFecha1.Value.Month + "/" + dtpFecha1.Value.Day + "/" + dtpFecha1.Value.Year;
                f2 = dtpFecha2.Value.Month + "/" + dtpFecha2.Value.Day + "/" + dtpFecha2.Value.Year;
                dgFichas.DataSource = null;
                dgFichas.Refresh();
                DataTable dataTable = new DataTable();
                cargardg(f1,f2);
                //MessageBox.Show(dtpFecha2.Text);
                //MessageBox.Show(dtpFecha2.Value.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        void cargardg(string fecha1, string fecha2)
        {
            SqlConnection con = new SqlConnection($"Data Source = localhost\\SQLSERVER2019; Initial Catalog = Funeraria;User = sa; Password = 21030561");
            string query = $"select * from FichasPago where Fp_Fecha between '{fecha1}' and '{fecha2}'";
            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dgFichas.DataSource = dt;
            con.Close();
        }


    }
}
