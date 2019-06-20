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
    public partial class frmListadoCliente : Form
    {
        public frmListadoCliente()
        {
            InitializeComponent();
        }

        private void frmListadoCliente_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.dataSet1.cliente);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            DataTable dt = cl.consultarCliente(txtBuscar.Text);
            clienteBindingSource.DataSource = dt;
            rptViewerClientes.RefreshReport();
        }
    }
}
