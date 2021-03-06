﻿using MaxiKiosko.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmVenta : Form
    {
        List<DetalleVenta> detalles = new System.Collections.Generic.List<DetalleVenta>();
        public frmVenta()
        {
            InitializeComponent();
            // Colocamos la fecha en txtFecha
	    fillFormaPago();
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Subtotal");
            datagrid_venta.DataSource = dt;

            // Auto size
            this.datagrid_venta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.datagrid_venta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.datagrid_venta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.datagrid_venta.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.datagrid_venta.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            //int dni = int.Parse(txtCliente.Text.ToString().Split('-')[1].Trim());
            //venta.idCliente = dni;
            venta.guardarVenta();
        }

        private void datagrid_venta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Producto producto = new Producto();
            producto.buscarPorCodigo();
        }

        private void cmdBuscarCliente_Click(object sender, EventArgs e)
        {
            frmClienteBusqueda frm = new Formularios.frmClienteBusqueda();
            frm.ShowDialog();
            txtClienteDni.Text = frm._dni;
            txtClienteNombreYApellido.Text = frm._nombreYApellido;
            frm.Dispose();
        }

        private void cmdBuscarProducto_Click(object sender, EventArgs e)
        {
            frmProductoBusqueda frm = new Formularios.frmProductoBusqueda();
            frm.ShowDialog();
            txtProductoCodigo.Text = frm._codigo;
            frm.Dispose();
        }

        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtProductoCodigo.Text.Trim().Equals(""))
            {
                MessageBox.Show("El codigo del producto no puede estar vacio");
                return;
            }

            if(txtProductoCantidad.Text.Trim().Equals(""))
            {
                MessageBox.Show("La cantidad no puede estar vacia");
                return;
            }

            // Buscamos el producto
            Producto producto = new Producto();
            try
            {
                producto.id_producto = Int64.Parse(txtProductoCodigo.Text);
                producto.buscarPorCodigoUnico();
            }
            catch (Exception)
            {
                MessageBox.Show("Error no se pudo encontrar el producto");
                return;
            }

            if(!producto.hayStock(int.Parse(txtProductoCantidad.Text)))
            {
                MessageBox.Show("No hay suficiente stock");
                return;
            }

            DetalleVenta detalle = new DetalleVenta();
            detalle.idProducto = producto.id_producto;
            detalle.precioHistorico = producto.precio;
            try
            {
                detalle.cantidad = int.Parse(txtProductoCantidad.Text);
            } catch (Exception)
            {
                MessageBox.Show("Error la cantidad no es un numero valido");
                return;
            }

            if(!validarNuevoProducto(detalle))
            {
                MessageBox.Show("El producto que intenta agregar ya fue ingresado");
                return;
            }

            DataTable data = (DataTable) datagrid_venta.DataSource;
            DataRow newRow = data.NewRow();
            newRow[0] = detalle.idProducto;
            newRow[1] = producto.descripcion;
            newRow[2] = detalle.precioHistorico;
            newRow[3] = detalle.cantidad;
            newRow[4] = detalle.precioHistorico * detalle.cantidad;
            data.Rows.Add(newRow);
            data.AcceptChanges();

            detalles.Add(detalle);

            calcularTotal();

            txtProductoCodigo.Text = "";
            txtProductoCantidad.Text = "";
        }

        private Boolean validarNuevoProducto(DetalleVenta detalle)
        {
            foreach(var d in detalles)
            {
                if(d.idProducto == detalle.idProducto)
                {
                    return false;
                }
            }

            return true;
        }

        private void calcularTotal()
        {
            if(detalles.Count > 0)
            {
                decimal total = 0;
                foreach (var d in detalles)
                {
                    total += d.precioHistorico * d.cantidad;
                }
                lbTotal.Text = "Total: $" + total;
                lbTotal.Visible = true;
            }
            else
            {
                lbTotal.Visible = false;
            }
        }

        private void datagrid_venta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagrid_venta.Rows[e.RowIndex].Cells[0].Value == null)
            {
                MessageBox.Show("No selecciono un producto valido");
                return;
            }

            long codigoProducto = long.Parse(this.datagrid_venta.Rows[e.RowIndex].Cells[0].Value.ToString());

            DetalleVenta detalle = null;
            foreach (var d in detalles)
            {
                if(d.idProducto == codigoProducto)
                {
                    detalle = d;
                }
            }

            if(detalle != null)
            {
                detalles.Remove(detalle);
            }

            calcularTotal();

            DataTable dt = (DataTable)datagrid_venta.DataSource;
            dt.Rows.Remove(dt.Rows[e.RowIndex]);
            dt.AcceptChanges();
        }

        private void txtProductoCantidad_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txtProductoCodigo_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.detalle = detalles;
            venta.fecha = DateTime.Now;
	        venta.formaPago = (int)this.cmbFormaPago.SelectedValue;
            if(txtClienteDni.Text != "")
            {
                venta.idCliente = int.Parse(txtClienteDni.Text);
            }
            else
            {
                venta.idCliente = 0;
            }

            decimal total = 0;
            foreach(var d in detalles)
            {
                total += d.precioHistorico * d.cantidad;
            }
            venta.total = total;

            try
            {
                venta.guardarVenta();
                MessageBox.Show("Venta guardada exitosamente");
                this.Close();
            } catch(Exception)
            {
                MessageBox.Show("Hubo un error al intentar guardar venta");
            }
        }

	private void fillFormaPago()
       	{
		Forma_pago formaPago = new Forma_pago();
		DataTable dt = formaPago.buscarTodos();
		this.cmbFormaPago.DataSource = dt;
		this.cmbFormaPago.DisplayMember = "descripcion";
		this.cmbFormaPago.ValueMember = "id_forma_pago";
	}
    }
}
