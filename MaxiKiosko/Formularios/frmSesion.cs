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
using MaxiKiosko.Clases;

namespace MaxiKiosko.Formularios
{
    public partial class frmSesion : Form
    {
        int _id = 0;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string usuario
        {
            get { return this.txt_usuario.Text; }
            set { this.txt_usuario.Text = value; }
        }
        public string contraseña
        {
            get { return this.txt_contraseña.Text; }
            set { this.txt_contraseña.Text = value; }

        }
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

            //            if ( this.txt_usuario.Text == "usuario" && this.txt_contraseña.Text == "usuario" )
            //            {
            //                this.Close();
            //            }
            Usuario validar_usuario = new Usuario();
            DataTable tabla = new DataTable();
            tabla = validar_usuario.autenticacion(this.txt_usuario.Text.Trim(), Crypto.Encrypt(this.txt_contraseña.Text.ToString().Trim()));
            if (tabla.Rows.Count == 1)
            {
                //this._id = int.Parse(tabla.Rows[0][0].ToString());
                //this.Close();
                Usuario usuario = new Usuario();
                DataTable tablau = new DataTable();
                tablau = usuario.mostrarUsuarioLogueado(this.txt_usuario.Text.Trim());
                if (tabla.Rows.Count == 1)
                {
                    Global.userID= int.Parse(tablau.Rows[0][0].ToString());
                    Global.username = tablau.Rows[0][1].ToString();
                    Global.rolID = int.Parse(tablau.Rows[0][2].ToString());
                    Global.rol_name= tablau.Rows[0][3].ToString();
                }
                frmMaxiKiosko MK = new frmMaxiKiosko();
                MK._id_usuario = int.Parse(tabla.Rows[0][0].ToString());
                MK._nombre_usuario = tabla.Rows[0][1].ToString();
                MK._rol = tabla.Rows[0][5].ToString();

                //MessageBox.Show(Global.username);

                this.Hide();
                MK.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Password inválido","Acceso al Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Sesion_Load(object sender, EventArgs e)
        {
            this.txt_usuario.Focus();
            this.txt_contraseña.UseSystemPasswordChar = true;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_contraseña.Focus();
            }
        }

        private void txt_contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ingresar.PerformClick();
            }
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                this.txt_contraseña.UseSystemPasswordChar = false;
            }
            else
            {
                this.txt_contraseña.UseSystemPasswordChar = true;
            }
        }
    }
}
