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
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario__Load(object sender, EventArgs e)
        {
            loadAllUsuarios();
            this.panel_formulario.Visible = false;
        }
        private void loadAllUsuarios()
        {
            Usuario usuario = new Usuario();
            DataTable usuarios = usuario.mostrarTodosUsuarios();
            cargarUsuarios(usuarios);
        }

        private void cargarUsuarios(DataTable data)
        {
            this.dg_usuarios.DataSource = data;

            // Headers 
            this.dg_usuarios.Columns[0].Visible = false;    //id_usuario
            this.dg_usuarios.Columns[1].HeaderText = "Nombre de Usuario";
            this.dg_usuarios.Columns[2].HeaderText = "Apellido";
            this.dg_usuarios.Columns[3].HeaderText = "Nombre";
            this.dg_usuarios.Columns[4].Visible = false;    //Password
            this.dg_usuarios.Columns[5].HeaderText = "Rol";
 

        }

        private void showMain()
        {
            this.dg_usuarios.Enabled = true;
            this.dg_usuarios.Visible = true;
            limpiarTexto();
            panel_formulario.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllUsuarios();
        }

        void limpiarTexto()
        {
            this.txtNombre.Text = this.txtNombreUsuario.Text = this.txtApellido.Text = this.txtPassword.Text = this.txtBuscar.Text = "";
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Creamos el usuario
            Usuario usuario = new Usuario();
            usuario.nombre_usuario = this.txtNombreUsuario.Text;
            usuario.nombre = this.txtNombre.Text;
            usuario.apellido = this.txtApellido.Text;
            usuario.password= Crypto.Encrypt(this.txtPassword.Text.ToString().Trim());
            usuario.rol = int.Parse(this.cboRol.SelectedValue.ToString());
            //string _rol_ = this.cboRol.SelectedValue.ToString();
            //MessageBox.Show(_rol_);
            
            if (lblSubtitulo.Text == "Editar Usuario")
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

                if (this.txtPassword.Text == "")
                {
                    MessageBox.Show("El Password está vacio.");
                    this.txtPassword.Focus();
                    return;
                }
                //rol.id_rol = int.Parse(dg_roles.CurrentRow.Cells[0].Value.ToString());
                usuario.id_usuario = int.Parse(dg_usuarios.CurrentRow.Cells[0].Value.ToString());
                usuario.actualizar_usuario();
                MessageBox.Show("El usuario se actualizo exitosamente");
            }
            else if (lblSubtitulo.Text == "Crear Usuario")
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

                if (this.txtPassword.Text == "")
                {
                    MessageBox.Show("El Password está vacio.");
                    this.txtPassword.Focus();
                    return;
                }
                //    rol.guardar_rol();
                usuario.guardar_usuario();
                MessageBox.Show("El usuario se guardo exitosamente");
            }
            else
            {
                MessageBox.Show("Error inesperado (Codigo 404:Not Found)");
            }

            showMain();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            showMain();
        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            this.lblSubtitulo.Text = "Crear Usuario";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.dg_usuarios.Enabled = false;
            // Ocultar Data Grip View
            this.dg_usuarios.Visible = false;

            // Mostrar Formulario de edicion
            panel_formulario.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;

            cargar_combo_roles();
        }

        public void cargar_combo_roles()
        {
            Rol rol = new Rol();
            DataTable dt = new DataTable();
            dt = rol.mostrarTodos();
            cboRol.ValueMember = "id_rol";
            cboRol.DisplayMember = "nombre";
            cboRol.DataSource = dt;
        }

        private void dg_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.dg_usuarios.Enabled = false;
            // Mostrar Formulario de edicion
            if (dg_usuarios.CurrentRow.Index != -1)
            {
                this.txtNombreUsuario.Text = dg_usuarios.CurrentRow.Cells[1].Value.ToString();
                this.txtApellido.Text = dg_usuarios.CurrentRow.Cells[2].Value.ToString();
                this.txtNombre.Text = dg_usuarios.CurrentRow.Cells[3].Value.ToString();
                this.txtPassword.Text = Crypto.Decrypt(dg_usuarios.CurrentRow.Cells[4].Value.ToString());
                cargar_combo_roles();
                //this.cboRol.Text = dg_usuarios.CurrentRow.Cells[5].Value.ToString();
                this.cboRol.SelectedIndex = this.cboRol.FindStringExact(dg_usuarios.CurrentRow.Cells[5].Value.ToString());
             
            }
            // Ocultar Data Grip View
            this.dg_usuarios.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lblSubtitulo.Text = "Editar Usuario";
            this.panel_formulario.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            DataTable tabla_usuario = usuario.buscarUsuario(txtBuscar.Text.ToString());
            cargarUsuarios(tabla_usuario);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.id_usuario = int.Parse(dg_usuarios.CurrentRow.Cells[0].Value.ToString());
            usuario.borrar_usuario();
            MessageBox.Show("El usuario se borró exitosamente");
            showMain();
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
    
}
