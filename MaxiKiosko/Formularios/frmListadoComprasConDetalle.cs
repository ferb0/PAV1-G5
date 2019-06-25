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
    public partial class frmListadoComprasConDetalle : Form
    {
        public frmListadoComprasConDetalle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.compraDetalle' table. You can move, or remove it, as needed.
            //this.compraDetalleTableAdapter.Fill(this.dataSet1.compraDetalle);

            //this.reportViewer1.RefreshReport();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterDesde", dateTimePickerDesde.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterHasta", dateTimePickerHasta.Text.ToString()));
            reportViewer1.LocalReport.SetParameters(parms);

            if (dateTimePickerDesde.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha Desde no puede ser mayor a la fecha actual, por favor elija una nueva fecha");
                dateTimePickerDesde.Focus();
                return;
            }
            else if (dateTimePickerHasta.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha Hasta no puede ser mayor a la fecha actual, por favor elija una nueva fecha");
                dateTimePickerHasta.Focus();
                return;
            }
            Compra compra = new Compra();
            DataTable dt = compra.ConsultarReporte(dateTimePickerDesde.Value, dateTimePickerHasta.Value);
            if (dt.Rows.Count > 0)
            {
                compraDetalleBindingSource.DataSource = dt;
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay resultados");
                reportViewer1.Clear();
            }
        }
    }
}
