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
    public partial class frmListadoProductosStock : Form
    {
        public frmListadoProductosStock()
        {
            InitializeComponent();
        }

        private void frmListadoProductosStock_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.dataSet1.producto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                Producto producto = new Producto();
                DataTable dt = producto.consultarProductoStock(txtBuscar.Text);
                productoBindingSource.DataSource = dt;
                rptViewerProductoStock.RefreshReport();
            }

        }
    }
}
