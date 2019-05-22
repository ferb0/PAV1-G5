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
    public partial class frmProveedoresBusqueda : Form
    {
        public string _CUIT = "";
        public string _razon_social = "";
        public frmProveedoresBusqueda()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Proveedor proveedor = new Proveedor();
            DataTable dt = proveedor.consultarProveedor(txtBuscar.Text);
            cargarProveedores(dt);
        }

        private void cargarProveedores(DataTable dt)
        {
            this.dataGrid_Proveedores.DataSource = dt;

            // Headers 
            this.dataGrid_Proveedores.Columns[0].HeaderText = "CUIT";
            this.dataGrid_Proveedores.Columns[1].HeaderText = "Razón Social";
            this.dataGrid_Proveedores.Columns[2].Visible = false;
            this.dataGrid_Proveedores.Columns[3].Visible = false;
            // Auto size
            this.dataGrid_Proveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGrid_Proveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGrid_Proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this._CUIT = this.dataGrid_Proveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            this._razon_social = this.dataGrid_Proveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Close();
        }

        private void txtBuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Proveedor proveedor = new Proveedor();
                DataTable dt = proveedor.consultarProveedor(txtBuscar.Text);
                cargarProveedores(dt);
            }
        }
    }
}
