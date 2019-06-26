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
    public partial class frmListadoVentas : Form
    {
        public frmListadoVentas()
        {
            InitializeComponent();
        }
        
        private void frmListadoVentas_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            dateTimePickerDesde.Value = new DateTime(now.Year, now.Month, 1);
            dateTimePickerHasta.Value = now.AddTicks(-1);
            // TODO: This line of code loads data into the 'dataSet1.spRptVentas' table. You can move, or remove it, as needed.
            this.spRptVentasTableAdapter.Fill(this.dataSet1.spRptVentas);

            //this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //DateTime now = DateTime.Now;
            if (dateTimePickerDesde.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha Desde no puede ser mayor a la fecha actual, por favor elija una nueva fecha");
                dateTimePickerDesde.Focus();
                return;
            }
            else if(dateTimePickerHasta.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("La fecha Hasta no puede ser mayor a la fecha actual, por favor elija una nueva fecha");
                dateTimePickerHasta.Focus();
                return;
            }
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterDesde", dateTimePickerDesde.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterHasta", dateTimePickerHasta.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterUsuario", Global.username));

            reportViewer1.LocalReport.SetParameters(parms);

            Venta venta = new Venta();
            DataTable dt = venta.ConsultarReporte(dateTimePickerDesde.Value, dateTimePickerHasta.Value);
            if (dt.Rows.Count > 0)
            {
                dataSet1BindingSource.DataSource = dt;
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay resultados");
            }




        }
    }
}
