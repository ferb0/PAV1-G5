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
    public partial class frmClientes : Form
    {
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
            this.data_grip_clientes.Columns[0].Visible = false;
            this.data_grip_clientes.Columns[1].HeaderText = "Apellido";
            this.data_grip_clientes.Columns[2].HeaderText = "Nombre";
            this.data_grip_clientes.Columns[3].HeaderText = "Telefono";
            this.data_grip_clientes.Columns[4].HeaderText = "Email";

        }

        private void data_grip_clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grip_clientes.Enabled = false;

            // Mostrar Formulario de edicion
            this.txtIDCliente.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtApellido.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.txtNombre.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.txtTelefono.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.txtEmail.Text = this.data_grip_clientes.Rows[e.RowIndex].Cells[4].Value.ToString();

            // Ocultar Data Grip View
            this.data_grip_clientes.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Cliente";
            this.panel_formulario.Visible = true;
            this.cmdBorrar.Visible = true;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            // Creamos el cliente
            Cliente cliente = new Cliente();
            cliente.nombre = this.txtNombre.Text; 
            cliente.apellido = this.txtApellido.Text; 
            cliente.telefono = this.txtTelefono.Text; 
            cliente.email = this.txtEmail.Text;

            if (lb_subtitle.Text == "Editar Cliente")
            {
                int idCliente = (Int32.TryParse(this.txtIDCliente.Text, out idCliente) ? idCliente : 0);
                if (idCliente == 0)
                {
                    MessageBox.Show("Hubo un error al intentar editar el cliente. Causa: No se pudo determinar que cliente es");
                    return;
                }
                cliente.idCliente = idCliente;
                cliente.modificarCliente();

                MessageBox.Show("Cliente editado exitosamente");
            } else if(lb_subtitle.Text == "Crear Cliente")
            {
                cliente.agregarCliente();

                MessageBox.Show("Cliente creado exitosamente");
            } else
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
            panel_formulario.Visible = true;
            cmdBorrar.Visible = false;
            // Buttons
            this.cmdNuevo.Visible = false;
            this.txtBuscar.Visible = false;
            this.cmdBuscar.Visible = false;
        }

        private void emptyTextBoxes()
        {
            this.txtIDCliente.Text = "";
            this.txtApellido.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.txtEmail.Text = "";
        }

        private void CmdBorrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int idCliente = (Int32.TryParse(this.txtIDCliente.Text, out idCliente) ? idCliente : 0);
            if (idCliente == 0)
            {
                MessageBox.Show("Hubo un error al intentar editar el cliente. Causa: No se pudo determinar que cliente es");
                return;
            }

            cliente.borrar(idCliente);

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
    }
}
