using System;
using System.Data;
using System.Globalization;
using System.Net.Mail;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmClientes : Form
    {
        private static int MAX_CHAR_VARCHAR = 100;
        public frmClientes()
        {
            InitializeComponent();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Cargar Data Grip View
            loadAllClientes();

            // Ocultar elementos
            this.panel_formulario.Visible = false;
        }

        private void loadAllClientes()
        {
            Cliente cliente = new Cliente();
            DataTable clientes = cliente.buscarTodos();
            cargarClientes(clientes);
        }
        private void cargarClientes(DataTable data)
        {
            this.data_grip_clientes.DataSource = data;

            // Headers 
            this.data_grip_clientes.Columns[0].HeaderText = "Apellido";
            this.data_grip_clientes.Columns[1].HeaderText = "Nombre";
            this.data_grip_clientes.Columns[2].HeaderText = "Documento";
            this.data_grip_clientes.Columns[3].HeaderText = "Telefono";
            this.data_grip_clientes.Columns[4].HeaderText = "Email";

        }

        private void data_grip_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grip_clientes.Enabled = false; 
            // Mostrar Formulario de edicion
            this.txtApellido.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtNombre.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txtDocumento.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txtTelefono.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.txtEmail.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[4].Value.ToString();

            // Ocultar Data Grip View
            this.data_grip_clientes.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Cliente";
            this.txtDocumento.Enabled = false;
            this.panel_formulario.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if(this.txtDocumento.Text == "")
            {
                MessageBox.Show("El dni no puede estar vacío");
                this.txtDocumento.Focus();
                return;
            }

            if(this.txtDocumento.Text.Length > 8)
            {
                MessageBox.Show("El dni no es un dni valido");
                this.txtDocumento.Focus();
                return;
            }

            if(this.txtNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío");
                this.txtNombre.Focus();
                return;
            }

            if(this.txtNombre.Text.Length > MAX_CHAR_VARCHAR)
            {
                MessageBox.Show("El nombre es demasiado largo");
                this.txtNombre.Focus();
                return;
            }

            if(this.txtApellido.Text == "")
            {
                MessageBox.Show("El apellido no puede estar vacío");
                this.txtApellido.Focus();
                return;
            }

            if(this.txtApellido.Text.Length > MAX_CHAR_VARCHAR)
            {
                MessageBox.Show("El apellido es demasiado largo");
                this.txtApellido.Focus();
                return;
            }

            if(this.txtTelefono.Text.Length > 13)
            {
                MessageBox.Show("El telefono es demasiado largo");
                this.txtTelefono.Focus();
                return;
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

            // Creamos la cuenta corriente
            Cuenta_corriente cuentaCorriente = new Cuenta_corriente();
            if(this.txtLimiteCredito.Text != "")
            {
                float limiteCredito = (Single.TryParse(this.txtLimiteCredito.Text, out limiteCredito) ? limiteCredito : 0);
                if(limiteCredito == 0)
                {
                    MessageBox.Show("El limite de crédito no es un número válido");
                    this.txtLimiteCredito.Focus();
                    return;
                }
                cuentaCorriente.limite_credito = limiteCredito;
            }
            cuentaCorriente.agregarCuenta_corriente();

            int lastInsertedIdCC = cuentaCorriente.lastInsertedId();

            if(lastInsertedIdCC == -1)
            {
                MessageBox.Show("Ocurrio un error al intentar crear el cliente. Motivo: Error al vincular cuenta corriente");
                return;
            }

            // Creamos el cliente
            Cliente cliente = new Cliente();
            cliente.nombre = this.txtNombre.Text;
            cliente.apellido = this.txtApellido.Text;
            cliente.telefono = this.txtTelefono.Text;
            cliente.email = this.txtEmail.Text;
            cliente.id_cuenta_corriente = lastInsertedIdCC;

            // Validar que otro cliente no tenga el mismo dni
            int dni = (Int32.TryParse(this.txtDocumento.Text, out dni) ? dni : 0);
            if(dni == 0)
            {
                MessageBox.Show("El dni no corresponde a un numero entero válido");
                txtDocumento.Focus();
                return;
            }

            if(cliente.buscarClientePorDNI(dni))
            {
                MessageBox.Show("Ya existe un cliente con ese documento");
                txtDocumento.Focus();
                return;
            }

            cliente.dni = dni;

            if (lb_subtitle.Text == "Editar Cliente")
            {
                cliente.modificarCliente();

                MessageBox.Show("Cliente editado exitosamente");
            }
            else if (lb_subtitle.Text == "Crear Cliente")
            {
                cliente.agregarCliente();

                MessageBox.Show("Cliente creado exitosamente");
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
            Cliente cliente = new Cliente();
            DataTable dt = cliente.consultarCliente(txtBuscar.Text);
            cargarClientes(dt);
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            showMain();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            this.lb_subtitle.Text = "Crear Cliente";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grip_clientes.Enabled = false;
            // Ocultar Data Grip View
            this.data_grip_clientes.Visible = false;

            // Mostrar Formulario de edicion
            this.txtDocumento.Enabled = true;
            panel_formulario.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void emptyTextBoxes()
        {
            this.txtDocumento.Text = "";
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";
        }

        private void CmdBorrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int dni = (Int32.TryParse(this.txtDocumento.Text, out dni) ? dni : 0);
            if (dni == 0)
            {
                MessageBox.Show("Hubo un error al intentar borrar el cliente. Causa: No se pudo determinar que cliente es");
                return;
            }

            cliente.borrar(dni);

            MessageBox.Show("Cliente eliminado exitosamente");
            showMain();
        }

        private void showMain()
        {
            this.data_grip_clientes.Enabled = true;
            this.data_grip_clientes.Visible = true;
            emptyTextBoxes();
            panel_formulario.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllClientes();
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
    }
}
