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
    public partial class frmUsuario_ : Form
    {
        public frmUsuario_()
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
        private void cmdGuardar_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {

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
            cboRol.DataSource = dt;
            cboRol.ValueMember = "id_rol";
            cboRol.DisplayMember = "nombre";
        }

        private void dg_usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.dg_usuarios.Enabled = false;
            // Mostrar Formulario de edicion
            if (dg_usuarios.CurrentRow.Index != -1)
            {
                //id_rol = int.Parse(dgUsuarios.CurrentRow.Cells[0].Value.ToString());
                this.txtNombreUsuario.Text = dg_usuarios.CurrentRow.Cells[1].Value.ToString();
                this.txtApellido.Text = dg_usuarios.CurrentRow.Cells[2].Value.ToString();
                this.txtNombre.Text = dg_usuarios.CurrentRow.Cells[3].Value.ToString();
                this.txtPassword.Text = Crypto.Decrypt(dg_usuarios.CurrentRow.Cells[4].Value.ToString());
                cargar_combo_roles();
                this.cboRol.SelectedIndex = Convert.ToInt32(dg_usuarios.CurrentRow.Cells[0].Value.ToString());
                               
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
    }
    
}
