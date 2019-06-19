﻿using System;
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
    public partial class frmListadoProveedores : Form
    {
        public string _CUIT = "";
        public string _razon_social = "";
        public frmListadoProveedores()
        {
            InitializeComponent();
        }

        private void frmListadoProveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.proveedor' table. You can move, or remove it, as needed.
            this.proveedorTableAdapter.Fill(this.DataSet1.proveedor);

            this.RptViewerProveedores.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            DataTable dt = proveedor.consultarProveedor(txtBuscar.Text);
            proveedorBindingSource.DataSource = dt;
            RptViewerProveedores.RefreshReport();
        }
    }
}