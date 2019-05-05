using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxiKiosko.Clases;

namespace MaxiKiosko.Formularios
{
    public partial class frmUsuario : Form
    {
        //int id_usuario = 0

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreUsuario.Text == "")
            {
                MessageBox.Show("El usuario está vacio.");
                this.txtNombreUsuario.Focus();
                return;
            }

            if (this.txtApellido.Text == "")
            {
                MessageBox.Show("El Apellido está vacio.");
                this.txtApellido.Focus();
                return;
            }

            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("El Nombre está vacio.");
                this.txtNombre.Focus();
                return;
            }

            if (this.txtRol.Text == "")
            {
                MessageBox.Show("El Rol está vacio.");
                this.txtRol.Focus();
                return;
            }

            if (this.txtPassword.Text == "")
            {
                MessageBox.Show("El Password está vacio.");
                this.txtPassword.Focus();
                return;
            }
            Usuario NuevoUsuario = new Usuario();
            NuevoUsuario.nombre_usuario = this.txtNombreUsuario.Text;
            NuevoUsuario.apellido = this.txtApellido.Text;
            NuevoUsuario.nombre = this.txtNombre.Text;
            NuevoUsuario.rol = this.txtRol.Text;
            NuevoUsuario.password = Crypto.Encrypt(this.txtPassword.Text.ToString().Trim());

            NuevoUsuario.guardar_usuario();
            MessageBox.Show("El usuario se guardo exitosamente");
            cargarGrilla();
            limpiarTexto();
        }

        private void frmABMCUsuarios_Load(object sender, EventArgs e)
        {
            limpiarTexto();
            cargarGrilla();
            btnBorrar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        void cargarGrilla()
        {
            Usuario tUsuario = new Usuario();
            DataTable tablaUsuario = new DataTable();
            tablaUsuario = tUsuario.mostrarTodosUsuarios();
            dgUsuarios.DataSource = tablaUsuario;
            dgUsuarios.Columns[0].Visible = false; //ocultar columna id_usuario
            dgUsuarios.Columns[4].Visible = false; //ocultar columna passwords
        }

       void limpiarTexto()
        {
            this.txtNombreUsuario.Text = this.txtApellido.Text = this.txtNombre.Text = this.txtRol.Text = this.txtPassword.Text = "";
        }

        private void dgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgUsuarios.CurrentRow.Index != -1)
            {
                //id_usuario = int.Parse(dgUsuarios.CurrentRow.Cells[0].Value.ToString());
                this.txtNombreUsuario.Text = dgUsuarios.CurrentRow.Cells[1].Value.ToString();
                this.txtApellido.Text = dgUsuarios.CurrentRow.Cells[2].Value.ToString();
                this.txtNombre.Text = dgUsuarios.CurrentRow.Cells[3].Value.ToString();
                this.txtRol.Text = dgUsuarios.CurrentRow.Cells[5].Value.ToString();
                this.txtPassword.Text = Crypto.Decrypt(dgUsuarios.CurrentRow.Cells[4].Value.ToString());
                btnActualizar.Enabled = true;
                btnBorrar.Enabled = true;
                btnGuardar.Enabled = false;

            }

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTexto();
            this.txtNombreUsuario.Focus();
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (this.txtNombreUsuario.Text == "")
            {
                MessageBox.Show("El usuario está vacio.");
                this.txtNombreUsuario.Focus();
                return;
            }

            if (this.txtApellido.Text == "")
            {
                MessageBox.Show("El Apellido está vacio.");
                this.txtApellido.Focus();
                return;
            }

            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("El Nombre está vacio.");
                this.txtNombre.Focus();
                return;
            }

            if (this.txtRol.Text == "")
            {
                MessageBox.Show("El Rol está vacio.");
                this.txtRol.Focus();
                return;
            }

            if (this.txtPassword.Text == "")
            {
                MessageBox.Show("El Password está vacio.");
                this.txtPassword.Focus();
                return;
            }

            Usuario actualizarUsuario = new Usuario();
            actualizarUsuario.id_usuario = int.Parse(dgUsuarios.CurrentRow.Cells[0].Value.ToString());
            actualizarUsuario.nombre_usuario = this.txtNombreUsuario.Text;
            actualizarUsuario.apellido = this.txtApellido.Text;
            actualizarUsuario.nombre = this.txtNombre.Text;
            actualizarUsuario.rol = this.txtRol.Text;
            actualizarUsuario.password = Crypto.Encrypt(this.txtPassword.Text.ToString().Trim());

            actualizarUsuario.actualizar_usuario();
            MessageBox.Show("El usuario se actualizo exitosamente");
            cargarGrilla();
            limpiarTexto();
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Usuario borrarUsuario = new Usuario();
            borrarUsuario.id_usuario = int.Parse(dgUsuarios.CurrentRow.Cells[0].Value.ToString());

            borrarUsuario.borrar_usuario();
            cargarGrilla();
            limpiarTexto();
            MessageBox.Show("El usuario se borró exitosamente");
            btnActualizar.Enabled = false;
            btnBorrar.Enabled = false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario tUsuario = new Usuario();
            DataTable tablaUsuario = new DataTable();
            tablaUsuario = tUsuario.buscarUsuario(this.txtBuscar.Text.ToString());
            dgUsuarios.DataSource = tablaUsuario;
            dgUsuarios.Columns[0].Visible = false; //ocultar columna id_usuario
            dgUsuarios.Columns[4].Visible = false; //ocultar columna passwords
            txtBuscar.Text = "";
        }

        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtApellido.Focus();
            }
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRol.Focus();
            }
        }

        private void txtRol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGuardar.Focus();
            }
        }
    }
}
