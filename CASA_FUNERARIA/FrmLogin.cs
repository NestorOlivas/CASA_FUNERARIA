using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CASA_FUNERARIA
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "" || TxtContra.Text == "")
            {
                MessageBox.Show("Intente Nuevamente", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                FrmMenu MENU = new FrmMenu();

                MENU.Show();

                this.Hide();
            }
        }
    }
}
