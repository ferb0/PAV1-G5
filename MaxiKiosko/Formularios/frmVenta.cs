using MaxiKiosko.Clases;
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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            txtCliente.AutoCompleteCustomSource = GetAutoSourceCollectionFromTable(cliente.buscarTodosTypeahead());
            DataTable productos = new DataTable();
            productos.Columns.Add("Codigo Producto");
            productos.Columns.Add("Descripcion").ReadOnly = true;
            productos.Columns.Add("Precio").ReadOnly = true;
            productos.Columns.Add("Cantidad");
            datagrid_venta.DataSource = productos;
        }

        private AutoCompleteStringCollection GetAutoSourceCollectionFromTable(DataTable table)
        {
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in table.Rows)
            {
                autoSourceCollection.Add(row[0].ToString());
            }

            return autoSourceCollection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            Cliente cliente = new Cliente();
            int dni = int.Parse(txtCliente.Text.ToString().Split('-')[1].Trim());
            venta.idCliente = dni;
            venta.guardarVenta();
        }
    }
}
