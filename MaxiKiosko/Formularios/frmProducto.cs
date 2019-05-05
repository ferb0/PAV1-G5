using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // Cargar Data Grip View
            loadAllProducto();

            // Ocultar elementos
            this.panel_producto.Visible = false;
        }

        private void loadAllProducto()
        {
            Producto producto = new Producto();
            DataTable productos = producto.buscarTodos();
            cargarProducto(productos);
        }
        private void cargarProducto(DataTable data)
        {
            this.data_grid_productos.DataSource = data;

            // Headers 
            this.data_grid_productos.Columns[0].HeaderText = "Codigo";
            this.data_grid_productos.Columns[1].HeaderText = "Descripcion";
            this.data_grid_productos.Columns[2].HeaderText = "Precio";
            this.data_grid_productos.Columns[3].HeaderText = "Stock";
            this.data_grid_productos.Columns[4].HeaderText = "Medida";
        }

        private void data_grid_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_productos.Enabled = false;
            // Mostrar Formulario de edicion
            if(data_grid_productos.Rows[e.RowIndex].Cells[0].Value == null)
            {
                MessageBox.Show("No selecciono un producto valido");
                return;
            }
            this.txtCodigoProducto.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txtPrecio.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txtStock.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.txtMedida.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[4].Value.ToString();

            // Ocultar Data Grip View
            this.data_grid_productos.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Producto";
            this.panel_producto.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Creamos el producto 
            Producto producto = new Producto();
            producto.id_producto = int.Parse(this.txtCodigoProducto.Text);
            producto.descripcion = this.txtDescripcion.Text;
            producto.precio = int.Parse(this.txtPrecio.Text);
            producto.stock = int.Parse(this.txtStock.Text);
            producto.tipo_medida = this.txtMedida.Text;

            if (lb_subtitle.Text == "Editar Producto")
            {
                int idProducto = int.Parse(this.txtCodigoProducto.Text);
                if (idProducto == 0)
                {
                    MessageBox.Show("Hubo un error al intentar editar el producto. Causa: No se pudo determinar que producto es");
                    return;
                }
                producto.id_producto = idProducto;
                producto.modificarProducto();

                MessageBox.Show("Producto editado exitosamente");
            }
            else if (lb_subtitle.Text == "Crear Producto")
            {
                producto.agregarProducto();

                MessageBox.Show("Producto creado exitosamente");
            }
            else
                MessageBox.Show("Error inesperado (Codigo 404:Not Found)");

            showMain();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Producto producto = new Producto();
            DataTable dt = producto.consultarProducto(txtBuscar.Text);
            cargarProducto(dt);
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            this.lb_subtitle.Text = "Crear Producto";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_productos.Enabled = false;
            // Ocultar Data Grip View
            this.data_grid_productos.Visible = false;

            // Mostrar Formulario de edicion
            panel_producto.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void showMain()
        {
            this.data_grid_productos.Enabled = true;
            this.data_grid_productos.Visible = true;
            emptyTextBoxes();
            panel_producto.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllProducto();
        }

        private void emptyTextBoxes()
        {
            this.txtCodigoProducto.Text = "";
            this.txtDescripcion.Text = "";
            this.txtPrecio.Text = "";
            this.txtStock.Text = "";
            this.txtMedida.Text = "";
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            int idProducto = (Int32.TryParse(this.txtCodigoProducto.Text, out idProducto) ? idProducto : 0);
            if (idProducto == 0)
            {
                MessageBox.Show("Hubo un error al intentar borrar el producto. Causa: No se pudo determinar que producto es");
                return;
            }

            producto.borrarProducto(idProducto);

            MessageBox.Show("Producto eliminado exitosamente");
            showMain();
        }

        private void cmdCancelar_Click_1(object sender, EventArgs e)
        {
            showMain();
        }
    }
}
