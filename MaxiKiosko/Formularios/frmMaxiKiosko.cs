using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxiKiosko.Formularios;

namespace MaxiKiosko
{
    public partial class frmMaxiKiosko : Form
    {
        public int _id_usuario = 0;
        public string _nombre_usuario = "";
        public string _rol = "";
        public frmMaxiKiosko()
        {
            InitializeComponent();
        }

        private void MaxiKiosko_Load(object sender, EventArgs e)
        {
            // Sesion frm_sesion = new Sesion();
            // frm_sesion.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TipoProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipo_producto frm = new Formularios.frmTipo_producto();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void FormaDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormaPago frm = new Formularios.frmFormaPago();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto frm = new Formularios.frmProducto();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new Formularios.frmProveedores();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientes frm = new Formularios.frmClientes();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void aBMToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmRoles frm = new Formularios.frmRoles();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void aBMToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmUsuario frm = new Formularios.frmUsuario();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta frm = new Formularios.frmVenta(_id_usuario);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ventasConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaConsulta frm = new Formularios.frmVentaConsulta();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ingresoDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras frm = new Formularios.frmCompras(_id_usuario);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void comprasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompraConsulta frm = new Formularios.frmCompraConsulta();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void informeDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProductos frm = new Formularios.frmListadoProductos();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void productosConStockFaltanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProductosStock frm = new Formularios.frmListadoProductosStock();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoCliente frm = new Formularios.frmListadoCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoUsuarios frm = new Formularios.frmListadoUsuarios();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void InformeDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoCompra frm = new Formularios.frmListadoCompra();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void InformeDeComprasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoComprasPorProveedor frm = new Formularios.frmListadoComprasPorProveedor();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaVentasPorDíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaVentaPorDia frm = new Formularios.frmEstadisticaVentaPorDia();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaVentasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaVentaPorDiaPorUsuario frm = new Formularios.frmEstadisticaVentaPorDiaPorUsuario();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaVentasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaVentaPorDiaPorCliente frm = new Formularios.frmEstadisticaVentaPorDiaPorCliente();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void informeDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoVentas frm = new frmListadoVentas();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoProveedores frm = new frmListadoProveedores();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaTipoDeProductosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaTipoProductosVendidos frm = new Formularios.frmEstadisticaTipoProductosVendidos();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaProductosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaProductosVendidos frm = new Formularios.frmEstadisticaProductosVendidos();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaVentasPorHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaVentaPorHora frm = new Formularios.frmEstadisticaVentaPorHora();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void EstadisticaCompraPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaCompraPorProveedor frm = new Formularios.frmEstadisticaCompraPorProveedor();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void BalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBalance frm = new Formularios.frmBalance();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
