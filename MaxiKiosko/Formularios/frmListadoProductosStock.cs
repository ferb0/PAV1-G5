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
using Microsoft.Reporting.WinForms;

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
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterUsuario", Global.username));
            rptViewerProductoStock.LocalReport.SetParameters(parms);

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
