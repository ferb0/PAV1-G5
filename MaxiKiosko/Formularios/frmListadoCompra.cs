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
    public partial class frmListadoCompra : Form
    {
        public frmListadoCompra()
        {
            InitializeComponent();
            this.dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            this.dtpFechaDesde.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaHasta.CustomFormat = "dd-MM-yyyy";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.compraTableAdapter.Fill(this.DataSet1.compra);
        }

        private void CmbBuscar_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            string sql = @"SELECT c.id_compra, c.fecha_hora, p.cuit, p.razon_social, u.nombre_usuario, c.numero_comprobante, c.total
                           FROM compra c 
                           INNER JOIN usuario u ON u.id_usuario = c.id_usuario
                           INNER JOIN proveedor p ON p.cuit = c.proveedor_cuit
                           WHERE true";
            
            if(Convert.ToDateTime(dtpFechaHasta.Text) < Convert.ToDateTime(dtpFechaDesde.Text))
            {
                MessageBox.Show("La fecha hasta no puede ser mayor a la fecha desde");
            }

            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");
            string hasta = Convert.ToDateTime(dtpFechaHasta.Text).ToString("yyyy-MM-dd");

            sql += " AND DATE(c.fecha_hora) BETWEEN '" + desde + "' AND '" + hasta + "'";
            DataTable dt = conexion.consulta(sql);
            if(dt.Rows.Count > 0)
            {
                this.compraBindingSource.DataSource = conexion.consulta(sql);
                rptCompras.RefreshReport();
            }
            else
            {
                MessageBox.Show("No hay resultados");
                rptCompras.Clear();
            }
        }
    }
}
