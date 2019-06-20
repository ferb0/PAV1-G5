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
    public partial class frmBalance : Form
    {
        public frmBalance()
        {
            InitializeComponent();
            this.dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            this.dtpFechaDesde.CustomFormat = "dd-MM-yyyy";
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void CmbBuscar_Click(object sender, EventArgs e)
        {
            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");

            Conexion conexion = new Conexion();
            string sql = @"SELECT CONCAT(day(v.fecha_hora), ' - ' , MONTH(v.fecha_hora)) as descriptor, SUM(v.total) - (SELECT SUM(c.total) 
                FROM compra as c 
                WHERE date(c.fecha_hora) = '" + desde + "') AS total " +
            " FROM venta as v " +
            " WHERE date(v.fecha_hora) = '" + desde + "'" +
            " GROUP BY DATE(v.fecha_hora);";
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
