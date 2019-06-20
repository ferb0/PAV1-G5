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
    public partial class frmEstadisticaTipoProductosVendidos : Form
    {
        public frmEstadisticaTipoProductosVendidos()
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
            if(Convert.ToDateTime(dtpFechaHasta.Text) < Convert.ToDateTime(dtpFechaDesde.Text))
            {
                MessageBox.Show("La fecha hasta no puede ser mayor a la fecha desde");
            }

            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");
            string hasta = Convert.ToDateTime(dtpFechaHasta.Text).ToString("yyyy-MM-dd");

            Conexion conexion = new Conexion();
            string sql = @"SELECT tp.descripcion as descriptor, count(*) as dato
                            FROM detalle_venta AS dt
                            LEFT JOIN producto AS pro ON pro.id_producto = dt.id_producto
                            LEFT JOIN tipo_producto AS tp ON tp.id_tipo_producto = pro.tipo_producto
                            LEFT JOIN venta AS v ON v.id_detalle_venta = dt.id_detalle_venta
                            WHERE DATE(fecha_hora) BETWEEN '" + desde + "' AND '" + hasta + "'" +
                            " GROUP BY tp.descripcion";

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
