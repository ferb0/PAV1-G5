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
            frmVenta frm = new Formularios.frmVenta();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ventasConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentaConsulta frm = new Formularios.frmVentaConsulta();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
