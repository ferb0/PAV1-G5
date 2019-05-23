using System;
using System.Data;
using System.Windows.Forms;
using MaxiKiosko.Clases;

namespace MaxiKiosko.Formularios
{
    public partial class frmCompraConsulta : Form
    {
        public frmCompraConsulta()
        {
            InitializeComponent();
            cargarCompras();
        }

        private void cargarCompras()
        {
            Compra compra = new Compra();
            DataTable dt = compra.consultarTodos();
            this.dataGridCompras.DataSource = dt;

            // Headers 
            dt.Columns[0].ColumnName = "Id";
            dt.Columns[1].ColumnName = "Fecha";
            dt.Columns[2].ColumnName = "Proveedor";
            dt.Columns[3].ColumnName = "Nro Comprobante";
            dt.Columns[4].ColumnName = "Total";

            // Auto size
            this.dataGridCompras.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridCompras.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridCompras.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridCompras.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridCompras.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}