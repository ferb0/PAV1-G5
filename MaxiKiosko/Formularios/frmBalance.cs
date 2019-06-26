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
    public partial class frmBalance : Form
    {
        public frmBalance()
        {
            InitializeComponent();

            this.dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            this.dtpFechaDesde.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaHasta.CustomFormat = "dd-MM-yyyy";
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void CmbBuscar_Click(object sender, EventArgs e)
        {
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterDesde", dtpFechaDesde.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterHasta", dtpFechaHasta.Text.ToString()));
            rptVentasPorDia.LocalReport.SetParameters(parms);


            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");
            string hasta = Convert.ToDateTime(dtpFechaHasta.Text).ToString("yyyy-MM-dd");

            Conexion conexion = new Conexion();
            string sql = "SELECT fecha, sum(total) as total " +
                        "FROM(select date_format(fecha_hora, '%Y-%m-%d') as fecha, sum(total) * -1 as total from compra " +
                        "GROUP BY fecha " +
                        "UNION ALL " +
                        "SELECT date_format(fecha_hora, '%Y-%m-%d') as fecha, sum(total) as total from venta " +
                        "GROUP BY fecha) as un " +
                        "WHERE fecha >= '" + desde +"' AND fecha <= '" + hasta + "' " +
                        "GROUP BY fecha";
            //string sql = @"SELECT CONCAT(day(v.fecha_hora), ' - ' , MONTH(v.fecha_hora)) as descriptor, SUM(v.total) - (SELECT SUM(c.total) 
            //    FROM compra as c 
            //    WHERE date(c.fecha_hora) = '" + desde + "') AS total " +
            //" FROM venta as v " +
            //" WHERE date(v.fecha_hora) = '" + desde + "'" +
            //" GROUP BY DATE(v.fecha_hora);";
            DataTable dt = conexion.consulta(sql);
            
            if(dt.Rows.Count > 0)
            {
                this.ventasPorDiaBindingSource.DataSource = conexion.consulta(sql);
                this.rptVentasPorDia.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay resultados");
            }
        }
    }
}
