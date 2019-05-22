using System;
using System.Data;
using System.Windows.Forms;
using MaxiKiosko.Clases;

namespace MaxiKiosko.Formularios
{
    public partial class frmVentaConsulta : Form
    {
        public frmVentaConsulta()
        {
            InitializeComponent();
            cargarVentas();
        }

        private void cargarVentas()
        {
            Venta venta = new Venta();
            DataTable dt = venta.consultarTodos();
            this.dataGridVentas.DataSource = dt;

            // Headers 
            dt.Columns[0].ColumnName = "Nro Ticket";
            dt.Columns[1].ColumnName = "Fecha";
            dt.Columns[2].ColumnName = "Importe Total";
            dt.Columns[3].ColumnName = "Nombre";
            dt.Columns[4].ColumnName = "Apellido";
            dt.Columns[5].ColumnName = "DNI";
            dt.Columns[6].ColumnName = "Forma de Pago";

            // Auto size
            this.dataGridVentas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}