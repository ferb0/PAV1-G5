using System;
using System.Data;
using System.Windows.Forms;
namespace MaxiKiosko.Formularios
{
    public partial class frmProductoBusqueda : Form
    {
        public string _codigo = "";
        public frmProductoBusqueda()
        {
            InitializeComponent();
        }
        private void txtBuscar_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Producto producto = new Producto();
                DataTable dt = producto.consultarProducto(txtBuscar.Text);
                cargarProductos(dt);
            }
        }

        private void cmdBuscar_Click(Object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Producto producto = new Producto();
            DataTable dt = producto.consultarProducto(txtBuscar.Text);
            cargarProductos(dt);
        }

        private void cargarProductos(DataTable dt)
        {
            this.dataGridProductos.DataSource = dt;

            // Headers 
            this.dataGridProductos.Columns[0].HeaderText = "Codigo";
            this.dataGridProductos.Columns[1].HeaderText = "Tipo";
            this.dataGridProductos.Columns[2].HeaderText = "Descripcion";
            this.dataGridProductos.Columns[3].HeaderText = "Precio";
            this.dataGridProductos.Columns[4].HeaderText = "Stock";
            // Auto size
            this.dataGridProductos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridProductos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridProductos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridProductos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridProductos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void dataGridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._codigo = this.dataGridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }
    }
}
