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
using Microsoft.Reporting.WinForms;

namespace MaxiKiosko.Formularios
{
    public partial class frmEstadisticaVentaPorDiaPorCliente : Form
    {
        public frmEstadisticaVentaPorDiaPorCliente()
        {
            InitializeComponent();
            this.dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            this.dtpFechaDesde.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaHasta.CustomFormat = "dd-MM-yyyy";
        }

        private void CmbBuscar_Click(object sender, EventArgs e)
        {
            rptVentasPorDia.LocalReport.DataSources.Clear();
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterDesde", dtpFechaDesde.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterHasta", dtpFechaHasta.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterCliente", cmbUsuario.Text));
            rptVentasPorDia.LocalReport.SetParameters(parms);

            if (Convert.ToDateTime(dtpFechaHasta.Text) < Convert.ToDateTime(dtpFechaDesde.Text))
            {
                MessageBox.Show("La fecha hasta no puede ser mayor a la fecha desde");
            }

            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");
            string hasta = Convert.ToDateTime(dtpFechaHasta.Text).ToString("yyyy-MM-dd");

            Conexion conexion = new Conexion();
            string sql = @"SELECT tb.fecha as fecha, count(tb.fecha) as total
                            FROM
                            (SELECT CONCAT(day(fecha_hora), ' - ' , MONTH(fecha_hora)) as fecha
                            FROM venta
                            WHERE DATE(fecha_hora) BETWEEN '" + desde + "' AND '" + hasta + "' AND dni = " + cmbUsuario.SelectedValue +
                            " ) as tb " +
                            "GROUP BY tb.fecha;";

            DataTable dt = conexion.consulta(sql);

            if(dt.Rows.Count > 0)
            {
                System.Data.DataSet ds = conexion.obtenerComoDataSet(sql);
                ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
                rptVentasPorDia.LocalReport.DataSources.Add(datasource);
                //rptVentasPorDia.LocalReport.DataSources.Clear();
                this.ventasPorDiaBindingSource.DataSource = conexion.consulta(sql);
                this.rptVentasPorDia.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay resultados");
                rptVentasPorDia.Clear();
            }
        }

        private void FrmEstadisticaVentaPorDiaPorUsuario_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = new Cliente().buscarTodosConNombreCompleto();
            cmbUsuario.ValueMember = "dni";
            cmbUsuario.DisplayMember = "nombrecompleto";
        }
    }
}
