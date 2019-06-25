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
    public partial class frmListadoComprasPorProveedor : Form
    {
        public frmListadoComprasPorProveedor()
        {
            InitializeComponent();
            this.dtpFechaDesde.Format = DateTimePickerFormat.Custom;
            this.dtpFechaHasta.Format = DateTimePickerFormat.Custom;
            this.dtpFechaDesde.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaHasta.CustomFormat = "dd-MM-yyyy";
            Proveedor proveedor = new Proveedor();
            DataTable dt = proveedor.buscarTodos();
            cmbProveedor.DataSource = dt;
            cmbProveedor.DisplayMember = "razon_social";
            cmbProveedor.ValueMember = "cuit";
            cmbProveedor.SelectedIndex = -1;
        }

        private void FrmListadoComprasPorProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.compra' Puede moverla o quitarla según sea necesario.
            this.compraTableAdapter.Fill(this.dataSet1.compra);
        }

        private void CmbBuscar_Click(object sender, EventArgs e)
        {
            ReportParameterCollection parms = new ReportParameterCollection();
            parms.Add(new ReportParameter("rptParameterDesde", dtpFechaDesde.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterHasta", dtpFechaHasta.Text.ToString()));
            parms.Add(new ReportParameter("rptParameterProveedor", cmbProveedor.Text));
            rptCompras.LocalReport.SetParameters(parms);

            if (Convert.ToDateTime(dtpFechaHasta.Text) < Convert.ToDateTime(dtpFechaDesde.Text))
            {
                MessageBox.Show("La fecha hasta no puede ser mayor a la fecha desde");
            }

            string desde = Convert.ToDateTime(dtpFechaDesde.Text).ToString("yyyy-MM-dd");
            string hasta = Convert.ToDateTime(dtpFechaHasta.Text).ToString("yyyy-MM-dd");

            Conexion conexion = new Conexion();
            string sql = @"SELECT c.id_compra, c.fecha_hora, p.cuit, p.razon_social, u.nombre_usuario, c.numero_comprobante, c.total
                           FROM compra c 
                           INNER JOIN usuario u ON u.id_usuario = c.id_usuario
                           INNER JOIN proveedor p ON p.cuit = c.proveedor_cuit
                           WHERE DATE(fecha_hora) BETWEEN '" + desde + "' AND '" + hasta + "'";
            
            if(cmbProveedor.SelectedIndex != -1)
            {
                sql += " AND p.cuit = " + cmbProveedor.SelectedValue;
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
            else
            {
                MessageBox.Show("Por favor, Elija un Proveedor");
                rptCompras.Clear();
                cmbProveedor.Focus();
                return;
            }
        }
    }
}
