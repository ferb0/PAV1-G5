﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // Cargar Data Grip View
            loadAllProducto();

            // Ocultar elementos
            this.panel_producto.Visible = false;
            this.txtBuscar.Focus();
        }

        private void loadAllProducto()
        {
            Producto producto = new Producto();
            DataTable productos = producto.buscarTodos();
            cargarProducto(productos);
        }
        private void cargarProducto(DataTable data)
        {
            this.data_grid_productos.DataSource = data;

            // Headers 
            this.data_grid_productos.Columns[0].HeaderText = "Codigo";
            this.data_grid_productos.Columns[1].HeaderText = "Tipo";
            this.data_grid_productos.Columns[2].HeaderText = "Descripcion";
            this.data_grid_productos.Columns[3].HeaderText = "Precio";
            this.data_grid_productos.Columns[4].HeaderText = "Stock";
            // Auto size
            this.data_grid_productos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.data_grid_productos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.data_grid_productos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.data_grid_productos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.data_grid_productos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void data_grid_productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_productos.Enabled = false;
            // Mostrar Formulario de edicion
            if(data_grid_productos.Rows[e.RowIndex].Cells[0].Value == null)
            {
                MessageBox.Show("No selecciono un producto valido");
                return;
            }
            this.txtCodigoProducto.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txtPrecio.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.txtStock.Text = this.data_grid_productos.Rows[e.RowIndex].Cells[4].Value.ToString();

            fillProductTypes();
            cmbTipoProducto.SelectedIndex = cmbTipoProducto.FindStringExact(this.data_grid_productos.Rows[e.RowIndex].Cells[1].Value.ToString());

            // Ocultar Data Grip View
            this.data_grid_productos.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Producto";
            this.panel_producto.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            // Creamos el producto 
            Producto producto = new Producto();
            if(txtCodigoProducto.Text == "")
            {
                MessageBox.Show("El código del producto no puede estar vacío");
                txtCodigoProducto.Focus();
                return;
            }

            if(txtDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion del producto no puede estar vacía");
                txtDescripcion.Focus();
                return;
            }

            if(txtPrecio.Text == "")
            {
                MessageBox.Show("El precio del producto no puede estar vacío");
                txtPrecio.Focus();
                return;
            }

            try
            {
                producto.id_producto = long.Parse(this.txtCodigoProducto.Text);
            } catch(Exception)
            {
                MessageBox.Show("El código del producto debe ser un número válido");
                txtCodigoProducto.Focus();
                return;
            }

            if(cmbTipoProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un tipo de producto");
                return;
            }

            producto.descripcion = this.txtDescripcion.Text;
            producto.tipo_producto = (int)cmbTipoProducto.SelectedValue;


            if (txtPrecio.Text.Contains(","))
            {
                txtPrecio.Text.Replace(",", ".");
            }
            try
            {
                var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
                clone.NumberFormat.NumberDecimalSeparator = ",";
                clone.NumberFormat.NumberGroupSeparator = ".";
                producto.precio = decimal.Parse(this.txtPrecio.Text, clone);
            } catch (Exception)
            {
                MessageBox.Show("El precio no posee un formato correcto");
                txtPrecio.Focus();
                return;
            }

            if(txtStock.Text != "")
            {
                try
                {
                    producto.stock = int.Parse(this.txtStock.Text);
                } catch (Exception)
                {
                    MessageBox.Show("El stock debe ser un numero entero válido");
                    txtStock.Focus();
                    return;
                }
            }

            if (lb_subtitle.Text == "Editar Producto")
            {
                long idProducto = (Int64.TryParse(this.txtCodigoProducto.Text, out idProducto) ? idProducto : 0);
                if (idProducto == 0)
                {
                    MessageBox.Show("Hubo un error al intentar editar el producto. Causa: No se pudo determinar que producto es");
                    return;
                }
                producto.id_producto = idProducto;
                producto.modificarProducto();

                MessageBox.Show("Producto editado exitosamente");
            }
            else if (lb_subtitle.Text == "Crear Producto")
            {
                producto.agregarProducto();

                MessageBox.Show("Producto creado exitosamente");
            }
            else
                MessageBox.Show("Error inesperado (Codigo 404:Not Found)");

            showMain();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Producto producto = new Producto();
            DataTable dt = producto.consultarProducto(txtBuscar.Text);
            cargarProducto(dt);
            this.txtBuscar.Focus();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            this.lb_subtitle.Text = "Crear Producto";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_productos.Enabled = false;
            // Ocultar Data Grip View
            this.data_grid_productos.Visible = false;

            // Mostrar Formulario de edicion
            panel_producto.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
            fillProductTypes();
        }

        private void fillProductTypes()
        {
            Tipo_producto tipo = new Tipo_producto();
            DataTable tiposProducto = tipo.buscarTodos();

            this.cmbTipoProducto.Text = "Seleccione";
            this.cmbTipoProducto.DataSource = tiposProducto;
            this.cmbTipoProducto.DisplayMember = "descripcion";
            this.cmbTipoProducto.ValueMember = "id_tipo_producto";
        }

        private void showMain()
        {
            this.data_grid_productos.Enabled = true;
            this.data_grid_productos.Visible = true;
            emptyTextBoxes();
            panel_producto.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllProducto();
        }

        private void emptyTextBoxes()
        {
            this.txtCodigoProducto.Text = "";
            this.txtDescripcion.Text = "";
            this.txtPrecio.Text = "";
            this.txtStock.Text = "";
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            long idProducto = (Int64.TryParse(this.txtCodigoProducto.Text, out idProducto) ? idProducto : 0);
            if (idProducto == 0)
            {
                MessageBox.Show("Hubo un error al intentar borrar el producto. Causa: No se pudo determinar que producto es");
                return;
            }

            producto.borrarProducto(idProducto);

            MessageBox.Show("Producto eliminado exitosamente");
            showMain();
        }

        private void cmdCancelar_Click_1(object sender, EventArgs e)
        {
            showMain();
            this.txtBuscar.Focus();
        }

        private void txtBuscar_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Producto producto = new Producto();
                DataTable dt = producto.consultarProducto(txtBuscar.Text);
                cargarProducto(dt);
            }
        }

        private void txtCodigoProducto_KeyPress(Object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(Object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(Object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') &&
                (e.KeyChar != ','))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }

            // Aceptar solo un . o una ,
            if((e.KeyChar  == '.') &&
                (((sender as TextBox).Text.IndexOf('.') > -1) ||
                ((sender as TextBox).Text.IndexOf(',') > -1)))
            {
                MessageBox.Show("Solo se permite un solo (.) o (,)");
                e.Handled = true;
            }
            
            if((e.KeyChar  == ',') &&
                (((sender as TextBox).Text.IndexOf('.') > -1) ||
                ((sender as TextBox).Text.IndexOf(',') > -1)))
            {
                MessageBox.Show("Solo se permite un solo (.) o (,)");
                e.Handled = true;
            }
        }
    }
}
