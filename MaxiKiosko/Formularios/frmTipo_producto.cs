using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmTipo_producto : Form
    {
        const int MAX_CHAR_VARCHAR = 45;
        public frmTipo_producto()
        {
            InitializeComponent();
        }
        private void FrmTipo_producto_Load(object sender, EventArgs e)
        {
            // Cargar Data Grip View
            loadAllTipo_producto();

            // Ocultar elementos
            this.panel_formulario.Visible = false;
            this.txtBuscar.Focus();
        }

        private void loadAllTipo_producto()
        {
            Tipo_producto tipo_Producto = new Tipo_producto();
            DataTable tipo_prod = tipo_Producto.buscarTodos();
            cargarTipo_Producto(tipo_prod);
        }

        private void cargarTipo_Producto(DataTable data)
        {
            this.data_grid_tipo_producto.DataSource = data;

            // Headers 
            this.data_grid_tipo_producto.Columns[0].HeaderText = "Codigo";
            this.data_grid_tipo_producto.Columns[1].HeaderText = "Descripcion";
        
            // Auto size
            this.data_grid_tipo_producto.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.data_grid_tipo_producto.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }

        private void data_grid_tipo_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_tipo_producto.Enabled = false;
            // Mostrar Formulario de edicion
            this.txtCodigoTipoProducto.Text = this.data_grid_tipo_producto.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.data_grid_tipo_producto.Rows[e.RowIndex].Cells[1].Value.ToString();
          

            // Ocultar Data Grip View
            this.data_grid_tipo_producto.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Tipo Producto";
            this.txtCodigoTipoProducto.Enabled = false;
            this.panel_formulario.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (this.txtDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede estar vacía");
                this.txtDescripcion.Focus();
                return;
            }

            if (this.txtDescripcion.Text.Length > MAX_CHAR_VARCHAR)
            {
                MessageBox.Show("La descripcion es demasiado larga");
                this.txtDescripcion.Focus();
                return;
            }

            // Creamos el tipo de producto 
            Tipo_producto tipoProducto = new Tipo_producto();
            tipoProducto.descripcion = this.txtDescripcion.Text;

            // Validar que otro tipo de producto no tenga el mismo dni
            

            if (lb_subtitle.Text == "Editar Tipo Producto")
            {
                int id = (Int32.TryParse(this.txtCodigoTipoProducto.Text, out id) ? id : 0);
                if (id == 0)
                {
                    MessageBox.Show("Hubo un error al intentar borrar el Tipo producto. Causa: No se pudo determinar que Tipo de producto es");
                    return;
                }
                tipoProducto.id_tipo_producto = id;
                tipoProducto.modificarTipo_producto();

                MessageBox.Show("Tipo Producto editado exitosamente");
            }
            else if (lb_subtitle.Text == "Crear Tipo Producto")
            {

                tipoProducto.agregarTipo_producto();

                MessageBox.Show("Tipo Producto creado exitosamente");
            }
            else
            {
                MessageBox.Show("Error inesperado (Codigo 404:Not Found)");
            }

            showMain();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Tipo_producto tipoProducto = new Tipo_producto();
            DataTable dt = tipoProducto.consultarTipo_producto(txtBuscar.Text);
            cargarTipo_Producto(dt);
            this.txtBuscar.Focus();
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            showMain();
            this.txtBuscar.Focus();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            this.lb_subtitle.Text = "Crear Tipo Producto";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_tipo_producto.Enabled = false;
            // Ocultar Data Grip View
            this.data_grid_tipo_producto.Visible = false;

            // Mostrar Formulario de edicion
            panel_formulario.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void emptyTextBoxes()
        {
            this.txtDescripcion.Text = "";
            
        }

        private void CmdBorrar_Click(object sender, EventArgs e)
        {
            Tipo_producto tipoProducto = new Tipo_producto();
            int id = (Int32.TryParse(this.txtCodigoTipoProducto.Text, out id) ? id : 0);
            if (id == 0)
            {
                MessageBox.Show("Hubo un error al intentar borrar el Tipo producto. Causa: No se pudo determinar que Tipo de producto es");
                return;
            }

            try
            {
                tipoProducto.borrarTipo_producto(id);
            } catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el tipo de producto debido a que hay productos vinculados al mismo");
                return;
            }

            MessageBox.Show("Tipo producto eliminado exitosamente");
            showMain();
        }

        private void showMain()
        {
            this.data_grid_tipo_producto.Enabled = true;
            this.data_grid_tipo_producto.Visible = true;
            emptyTextBoxes();
            panel_formulario.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllTipo_producto();
        }

        private void txtBuscar_KeyPress(Object sender, KeyPressEventArgs e) {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Tipo_producto tipoProducto = new Tipo_producto();
                DataTable dt = tipoProducto.consultarTipo_producto(txtBuscar.Text);
                cargarTipo_Producto(dt);
            }
        }
    }
}
