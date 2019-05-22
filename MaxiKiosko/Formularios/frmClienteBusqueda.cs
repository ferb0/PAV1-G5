using System;
using System.Data;
using System.Windows.Forms;
namespace MaxiKiosko.Formularios
{
    public partial class frmClienteBusqueda : Form
    {
        public string _dni = "";
        public string _nombreYApellido = "";
        public frmClienteBusqueda()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Cliente cliente = new Cliente();
                DataTable dt = cliente.consultarCliente(txtBuscar.Text);
                cargarClientes(dt);
            }
        }

        private void cmdBuscar_Click(Object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Cliente cliente = new Cliente();
            DataTable dt = cliente.consultarCliente(txtBuscar.Text);
            cargarClientes(dt);
        }

        private void cargarClientes(DataTable dt)
        {
            this.dataGridClientes.DataSource = dt;

            // Headers 
            this.dataGridClientes.Columns[0].HeaderText = "Apellido";
            this.dataGridClientes.Columns[1].HeaderText = "Nombre";
            this.dataGridClientes.Columns[2].HeaderText = "Documento";
            this.dataGridClientes.Columns[3].Visible = false;
            this.dataGridClientes.Columns[4].Visible = false;
            this.dataGridClientes.Columns[5].Visible = false;
            // Auto size
            this.dataGridClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridClientes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridClientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._dni = this.dataGridClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            string nombre = this.dataGridClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            string apellido = this.dataGridClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            this._nombreYApellido = apellido + ", " + nombre;
            this.Close();
        }
    }
}