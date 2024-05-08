using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CASA_FUNERARIA
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente CLIENTE = new FrmCliente();

            CLIENTE.Show();
        }

        private void BtnResumen_Click(object sender, EventArgs e)
        {
            FrmResumen RESUMEN = new FrmResumen();

            RESUMEN.Show();
        }

        private void BtnPaquetes_Click(object sender, EventArgs e)
        {
            FrmPaquetes PAQUETE = new FrmPaquetes();

            PAQUETE.Show();
            //PAQUETE.WindowState = WindowState.Maximized;

        }

        private void BtnFichas_Click(object sender, EventArgs e)
        {
            FichasPago fichas = new FichasPago();
            fichas.Show();
        }
    }
}
