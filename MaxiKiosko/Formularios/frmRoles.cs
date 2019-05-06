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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }
        private void loadAllRoles()
        {
            Rol rol = new Rol();
            DataTable roles = rol.mostrarTodos();
            cargarRoles(roles);
        }
        private void cargarRoles(DataTable data)
        {
            this.dg_roles.DataSource = data;

            // Headers 
            this.dg_roles.Columns[0].Visible = false;
            this.dg_roles.Columns[1].HeaderText = "Nombre";
            this.dg_roles.Columns[2].HeaderText = "Descripción";
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            loadAllRoles();

            // Ocultar elementos
            this.panel_formulario.Visible = false;
        }

        private void dg_roles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.dg_roles.Enabled = false;
            // Mostrar Formulario de edicion
            if (dg_roles.CurrentRow.Index != -1)
            {
                //id_rol = int.Parse(dgUsuarios.CurrentRow.Cells[0].Value.ToString());
                this.txtNombre.Text = dg_roles.CurrentRow.Cells[1].Value.ToString();
                this.txtDescripcion.Text = dg_roles.CurrentRow.Cells[2].Value.ToString();
            }
            // Ocultar Data Grip View
            this.dg_roles.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lblSubtitulo.Text = "Editar Rol";
            this.panel_formulario.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Creamos el rol
            Rol rol = new Rol();
            rol.nombre_rol = this.txtNombre.Text;
            rol.descripcion_rol = this.txtDescripcion.Text;

            if (lblSubtitulo.Text == "Editar Rol")
            {
                rol.id_rol = int.Parse(dg_roles.CurrentRow.Cells[0].Value.ToString());
                rol.actualizar_Rol();
                MessageBox.Show("El usuario se actualizo exitosamente");
            }
            else if (lblSubtitulo.Text == "Crear Rol")
            {
                rol.guardar_rol();
                MessageBox.Show("El usuario se guardo exitosamente");
            }
            else
            {
                MessageBox.Show("Error inesperado (Codigo 404:Not Found)");
            }

            showMain();

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {
            this.lblSubtitulo.Text = "Crear Rol";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.dg_roles.Enabled = false;
            // Ocultar Data Grip View
            this.dg_roles.Visible = false;

            // Mostrar Formulario de edicion
            panel_formulario.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        void limpiarTexto()
        {
            this.txtNombre.Text = this.txtDescripcion.Text = "";
        }

        private void showMain()
        {
            this.dg_roles.Enabled = true;
            this.dg_roles.Visible = true;
            limpiarTexto();
            panel_formulario.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllRoles();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            rol.id_rol = int.Parse(dg_roles.CurrentRow.Cells[0].Value.ToString());
            rol.borrar_rol();
            MessageBox.Show("El usuario se borró exitosamente");
            showMain();            
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Rol rol = new Rol();
            DataTable tabla_rol = rol.buscar_rol(txtBuscar.Text.ToString());
            cargarRoles(tabla_rol);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            showMain();
        }
    }
}
