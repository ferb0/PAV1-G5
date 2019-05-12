using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmProveedores : Form
    {
        const int MAX_CHAR_VARCHAR = 45;
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            // Cargar Data Grip View
            loadAllProveedores();

            // Ocultar elementos
            this.panel_formulario.Visible = false;
        }

        private void loadAllProveedores()
        {
            Proveedor proveedor = new Proveedor();
            DataTable proveedores = proveedor.buscarTodos();
            cargarProveedores(proveedores);
        }
        private void cargarProveedores(DataTable data)
        {
            this.data_grid_proveedores.DataSource = data;

            // Headers 
            this.data_grid_proveedores.Columns[0].HeaderText = "CUIT";
            this.data_grid_proveedores.Columns[1].HeaderText = "Razon Social";
            this.data_grid_proveedores.Columns[2].HeaderText = "Telefono";
            this.data_grid_proveedores.Columns[3].HeaderText = "Email";
            // Auto size
            this.data_grid_proveedores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.data_grid_proveedores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.data_grid_proveedores.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.data_grid_proveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void data_grid_proveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_proveedores.Enabled = false; 
            // Mostrar Formulario de edicion
            this.txtCuit.Text = this.data_grid_proveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtRazonSocial.Text = this.data_grid_proveedores.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txtTelefono.Text = this.data_grid_proveedores.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txtEmail.Text = this.data_grid_proveedores.Rows[e.RowIndex].Cells[3].Value.ToString();

            // Ocultar Data Grip View
            this.data_grid_proveedores.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Proveedor";
            this.txtCuit.Enabled = false;
            this.panel_formulario.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            // Validaciones
            if(this.txtCuit.Text == "")
            {
                MessageBox.Show("El cuit no puede estar vacío");
                this.txtCuit.Focus();
                return;
            }

            if(this.txtCuit.Text.Length > 11)
            {
                MessageBox.Show("El cuit no es un cuit valido");
                this.txtCuit.Focus();
                return;
            }

            if(this.txtRazonSocial.Text == "")
            {
                MessageBox.Show("La razón social no puede estar vacía");
                this.txtRazonSocial.Focus();
                return;
            }

            if(this.txtRazonSocial.Text.Length > MAX_CHAR_VARCHAR)
            {
                MessageBox.Show("La razon social es demasiado larga");
                this.txtRazonSocial.Focus();
                return;
            }

            if(!(this.txtTelefono.Text == "(   )   -") && this.txtTelefono.MaskFull)
            {
                proveedor.telefono = this.txtTelefono.Text;
            } else if(!(this.txtTelefono.Text == "(   )   -") && !this.txtTelefono.MaskFull)
            {
                MessageBox.Show("El telefono está incompleto");
                this.txtTelefono.Focus();
                return;
            } else
            {
                proveedor.telefono = "";
            }

            if(this.txtEmail.Text.Length > MAX_CHAR_VARCHAR)
            {
                MessageBox.Show("El email es demasiado largo");
                this.txtEmail.Focus();
                return;
            }

            if(this.txtEmail.Text != "" && !emailIsValid(txtEmail.Text))
            {
                MessageBox.Show("El email ingresado no es un email valido");
                this.txtEmail.Focus();
                return;
            }

            // Creamos el proveedor
            proveedor.razon_social = this.txtRazonSocial.Text;
            proveedor.email = this.txtEmail.Text;

            // Validar que otro proveedor no tenga el mismo dni
            long cuit = (Int64.TryParse(this.txtCuit.Text, out cuit) ? cuit : 0);
            if(cuit == 0)
            {
                MessageBox.Show("El cuit no corresponde a un numero entero válido");
                txtCuit.Focus();
                return;
            }

            proveedor.cuit = cuit;

            if (lb_subtitle.Text == "Editar Proveedor")
            {
                proveedor.modificarProveedor();

                MessageBox.Show("Proveedor editado exitosamente");
            }
            else if (lb_subtitle.Text == "Crear Proveedor")
            {
                if(proveedor.buscarProveedorPorCuit(cuit))
                {
                    MessageBox.Show("Ya existe un proveedor con ese cuit");
                    txtCuit.Focus();
                    return;
                }
                proveedor.agregarProveedor();

                MessageBox.Show("Proveedor creado exitosamente");
            }
            else
            {
                MessageBox.Show("Error inesperado (Codigo 404:Not Found)");
            }

            showMain();
        }

        private void CmdBuscar_Click(object sender, EventArgs e)
        {
            // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
            Proveedor proveedor = new Proveedor();
            DataTable dt = proveedor.consultarProveedor(txtBuscar.Text);
            cargarProveedores(dt);
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            showMain();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            this.lb_subtitle.Text = "Crear Proveedor";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_proveedores.Enabled = false;
            // Ocultar Data Grip View
            this.data_grid_proveedores.Visible = false;

            // Mostrar Formulario de edicion
            this.txtCuit.Enabled = true;
            panel_formulario.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void emptyTextBoxes()
        {
            this.txtCuit.Text = "";
            this.txtRazonSocial.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";
        }

        private void CmdBorrar_Click(object sender, EventArgs e)
        {
            Proveedor proveedor = new Proveedor();
            long cuit = (Int64.TryParse(this.txtCuit.Text, out cuit) ? cuit : 0);
            if (cuit == 0)
            {
                MessageBox.Show("Hubo un error al intentar borrar el proveedor. Causa: No se pudo determinar que proveedor es");
                return;
            }

            proveedor.borrar(cuit);

            MessageBox.Show("Proveedor eliminado exitosamente");
            showMain();
        }

        private void showMain()
        {
            this.data_grid_proveedores.Enabled = true;
            this.data_grid_proveedores.Visible = true;
            emptyTextBoxes();
            panel_formulario.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllProveedores();
        }

        private bool emailIsValid(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }

        private void txtCuit_KeyPress(Object sender, KeyPressEventArgs e) {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten números");
                e.Handled = true;
            }
        }

        private void txtBuscar_KeyPress(Object sender, KeyPressEventArgs e) {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Proveedor proveedor = new Proveedor();
                DataTable dt = proveedor.consultarProveedor(txtBuscar.Text);
                cargarProveedores(dt);
            }
        }
    }
}
