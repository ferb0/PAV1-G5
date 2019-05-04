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
            //this.panel_formulario.Visible = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdNuevo_Click(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
