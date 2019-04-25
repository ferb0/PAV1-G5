using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxiKiosko.Formularios;

namespace MaxiKiosko.Formularios
{
    public partial class frmSesion : Form
    {
        public frmSesion()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            if (this.txt_usuario.Text == "")
            {
                MessageBox.Show("El usuario no está cargado.");
                this.txt_usuario.Focus();
                return;
            }

            if (this.txt_contraseña.Text == "")
            {
                MessageBox.Show("La contraseña no está cargada.");
                this.txt_contraseña.Focus();
                return;
            }

            if ( this.txt_usuario.Text == "usuario" && this.txt_contraseña.Text == "usuario" )
            {
                this.Close();
            }

        }

        private void Sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
