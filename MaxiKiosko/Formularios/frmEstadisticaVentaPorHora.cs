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
using MaxiKiosko.Clases;



namespace MaxiKiosko.Formularios
{
    public partial class frmEstadisticaVentaPorHora : Form
    {
        public frmEstadisticaVentaPorHora()
        {
            InitializeComponent();
            this.dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            this.dtpFechaDesde.CustomFormat = "dd-MM-yyyy";
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void CmbBuscar_Click(object sender, EventArgs e)
        {
            ReportParameter pfecha = new ReportParameter("rptParameterFecha",dtpFechaDesde.Text.ToString());
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterUsuario", Global.username));
            rptTipoProductosVendidos.LocalReport.SetParameters(parms);
            rptTipoProductosVendidos.LocalReport.SetParameters(pfecha);
            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");

            Conexion conexion = new Conexion();
            string sql = @"SELECT HOUR(v.fecha_hora) as fecha, count(*) as total
                            FROM venta AS v
                            WHERE DATE(v.fecha_hora) = '"+ desde + "'" +
                            "GROUP BY HOUR(v.fecha_hora);";

            DataTable dt = conexion.consulta(sql);

            if(dt.Rows.Count > 0)
            {
                this.tipoProductosBindingSource.DataSource = conexion.consulta(sql);
                this.rptTipoProductosVendidos.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay resultados");
            }
        }
    }
}
