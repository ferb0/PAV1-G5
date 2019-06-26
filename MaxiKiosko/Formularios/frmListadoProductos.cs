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
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.dataSet1.producto);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterUsuario", Global.username));
            RptViewerProductos.LocalReport.SetParameters(parms);

            Producto producto = new Producto();
            DataTable dt = producto.consultarProducto(txtBuscar.Text);
            productoBindingSource.DataSource = dt;
            RptViewerProductos.RefreshReport();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
