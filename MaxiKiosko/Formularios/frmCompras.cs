using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxiKiosko.Clases;

namespace MaxiKiosko.Formularios
{
    public partial class frmCompras : Form
    {

        private decimal numero_total = 0;
        private int _idUsuario = 1;
        List<DetalleCompra> detalles = new System.Collections.Generic.List<DetalleCompra>();
        public frmCompras(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            // Colocamos la fecha en txtFecha
            lblFechaHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Porcentaje IVA");
            dt.Columns.Add("Subtotal");
            dataGrid_compra.DataSource = dt;

            lblTotal.Visible = false;

            // Auto size
            this.dataGrid_compra.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGrid_compra.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGrid_compra.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGrid_compra.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGrid_compra.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGrid_compra.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private AutoCompleteStringCollection GetAutoSourceCollectionFromTable(DataTable table)
        {
            AutoCompleteStringCollection autoSourceCollection = new AutoCompleteStringCollection();

            foreach (DataRow row in table.Rows)
            {
                autoSourceCollection.Add(row[0].ToString());
            }

            return autoSourceCollection;
        }

        private void cmdBuscarProducto_Click(object sender, EventArgs e)
        {
            frmProductoBusqueda frm = new Formularios.frmProductoBusqueda();
            frm.ShowDialog();
            txtCodigo.Text = frm._codigo;
            frm.Dispose();
        }

        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim().Equals(""))
            {
                MessageBox.Show("El codigo del producto no puede estar vacio");
                return;
            }

            if (txtCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("La cantidad no puede estar vacia");
                return;
            }

            // Buscamos el producto
            Producto producto = new Producto();
            try
            {
                producto.id_producto = Int64.Parse(txtCodigo.Text);
                producto.buscarPorCodigoUnico();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo encontrar el producto");
                return;
            }

            DetalleCompra detalle = new DetalleCompra();
            detalle.id_producto = producto.id_producto;
            //detalle.precioHistorico = producto.precio;
            try
            {
                detalle.cantidad = int.Parse(txtCantidad.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error la cantidad no es un numero valido");
                return;
            }

            try
            {
                detalle.costo = decimal.Parse(txtPrecioCompra.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error la cantidad no es un numero valido");
                return;
            }

            try
            {
                detalle.porc_iva = int.Parse(txtIVA.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error la cantidad no es un numero valido");
                return;
            }

            if (!validarNuevoProducto(detalle))
            {
                MessageBox.Show("El producto que intenta agregar ya fue ingresado");
                txtCodigo.Text = "";
                txtCantidad.Text = "";
                txtPrecioCompra.Text = "";
                txtIVA.Text = "";
                return;
            }

            DataTable data = (DataTable)dataGrid_compra.DataSource;
            DataRow newRow = data.NewRow();
            newRow[0] = detalle.id_producto;
            newRow[1] = producto.descripcion;
            newRow[2] = detalle.costo;
            newRow[3] = detalle.cantidad;
            newRow[4] = detalle.porc_iva;
            newRow[5] = detalle.costo * detalle.cantidad;
            data.Rows.Add(newRow);
            data.AcceptChanges();

            detalles.Add(detalle);

            calcularTotal();

            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtPrecioCompra.Text = "";
            txtIVA.Text = "";
        }

        private Boolean validarNuevoProducto(DetalleCompra detalle)
        {
            foreach (var d in detalles)
            {
                if (d.id_producto == detalle.id_producto)
                {
                    return false;
                }
            }

            return true;
        }
        private void calcularTotal()
        {
            if (detalles.Count > 0)
            {
                decimal total = 0;
                foreach (var d in detalles)
                {
                    total += d.costo * d.cantidad;
                }
                lblTotal.Text = "Total: $" + total;
                numero_total = total;
                lblTotal.Visible = true;
            }
            else
            {
                lblTotal.Visible = false;
            }
        }

        private void cmdBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmProveedoresBusqueda frm = new Formularios.frmProveedoresBusqueda();
            frm.ShowDialog();
            txtCUIT.Text = frm._CUIT;
            txtRazonSocial.Text = frm._razon_social;
            frm.Dispose();
        }

        private void dataGrid_compra_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGrid_compra.Rows[e.RowIndex].Cells[0].Value == null)
            {
                MessageBox.Show("No selecciono un producto valido");
                return;
            }

            long codigoProducto = long.Parse(this.dataGrid_compra.Rows[e.RowIndex].Cells[0].Value.ToString());

            DetalleCompra detalle = null;
            foreach (var d in detalles)
            {
                if (d.id_producto == codigoProducto)
                {
                    detalle = d;
                }
            }

            if (detalle != null)
            {
                detalles.Remove(detalle);
            }

            calcularTotal();

            DataTable dt = (DataTable)dataGrid_compra.DataSource;
            dt.Rows.Remove(dt.Rows[e.RowIndex]);
            dt.AcceptChanges();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Compra compra = new Compra();
            //compra.total = Convert.ToDecimal(lblTotal.Text);
            if (txtCUIT.Text == "")
            {
                MessageBox.Show("No se selecciono ningun Proveedor");
                return;
            }
            if(dataGrid_compra.RowCount==0)
            {
                MessageBox.Show("Debe agregar al menos un Producto");
                return;
            }
            if (txtComprobante.Text == "")
            {
                MessageBox.Show("No se ingreso ningun Numero de Comprobante");
                return;
            }
            compra.detalle = detalles;
            compra.fecha_hora = DateTime.Now;
            compra.cuit = long.Parse(txtCUIT.Text.ToString());
            compra.id_usuario = _idUsuario;
            compra.nro_comprobante = long.Parse(txtComprobante.Text.ToString());
            compra.total = numero_total;
            try
            {
                compra.guardarCompra();
                MessageBox.Show("Ingreso de Compra guardada exitosamente");
                this.Close();
            }
                catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar guardar el ingreso de compra");
            }
            

        }

        private void txtComprobante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
