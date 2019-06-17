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
    public partial class frmListadoProductos : Form
    {
        public frmListadoProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSet1.producto);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSet1.producto);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.producto' Puede moverla o quitarla según sea necesario.
            

            this.RptViewerProductos.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            DataTable dt = producto.consultarProducto(txtBuscar.Text);
            productoBindingSource.DataSource = dt;
            RptViewerProductos.RefreshReport();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
