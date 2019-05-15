using System;
using System.Data;
using System.Windows.Forms;

namespace MaxiKiosko.Formularios
{
    public partial class frmFormaPago : Form
    {
        const int MAX_CHAR_VARCHAR = 45;
        public frmFormaPago()
        {
            InitializeComponent();
        }
        private void FrmFormaPago_Load(object sender, EventArgs e)
        {
            // Cargar Data Grip View
            loadAllForma_pago();

            // Ocultar elementos
            this.panel_formulario.Visible = false;
            this.txtBuscar.Focus();
        }

        private void loadAllForma_pago()
        {
            Forma_pago formaPago = new Forma_pago();
            DataTable formasPago = formaPago.buscarTodos();
            cargarFormaPago(formasPago);
        }

        private void cargarFormaPago(DataTable data)
        {
            this.data_grid_forma_pago.DataSource = data;

            // Headers 
            this.data_grid_forma_pago.Columns[0].HeaderText = "Codigo";
            this.data_grid_forma_pago.Columns[1].HeaderText = "Descripcion";
        
            // Auto size
            this.data_grid_forma_pago.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.data_grid_forma_pago.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           
        }

        private void data_grid_forma_pago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_forma_pago.Enabled = false;
            // Mostrar Formulario de edicion
            this.txtIdFormaPago.Text = this.data_grid_forma_pago.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.txtDescripcion.Text = this.data_grid_forma_pago.Rows[e.RowIndex].Cells[1].Value.ToString();
          

            // Ocultar Data Grip View
            this.data_grid_forma_pago.Visible = false;

            // Mostrar Formulario de edicion
            // TextBox
            this.lb_subtitle.Text = "Editar Forma de Pago";
            this.txtIdFormaPago.Enabled = false;
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
            if (this.txtDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede estar vacía");
                this.txtDescripcion.Focus();
                return;
            }

            if (this.txtDescripcion.Text.Length > MAX_CHAR_VARCHAR)
            {
                MessageBox.Show("La descripcion es demasiado larga");
                this.txtDescripcion.Focus();
                return;
            }

            // Creamos el tipo de producto 
            Forma_pago formaPago = new Forma_pago();
            formaPago.descripcion = this.txtDescripcion.Text;

            // Validar que otro tipo de producto no tenga el mismo dni
            

            if (lb_subtitle.Text == "Editar Forma de Pago")
            {
                int id = (Int32.TryParse(this.txtIdFormaPago.Text, out id) ? id : 0);
                if (id == 0)
                {
                    MessageBox.Show("Hubo un error al intentar borrar la Forma de Pago. Causa: No se pudo determinar que Forma de Pago es");
                    return;
                }
                formaPago.id_forma_pago = id;
                formaPago.modificarForma_pago();

                MessageBox.Show("Forma de Pago editado exitosamente");
            }
            else if (lb_subtitle.Text == "Crear Forma de Pago")
            {

                formaPago.agregarForma_pago();

                MessageBox.Show("Forma de Pago creado exitosamente");
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
            Forma_pago formaPago = new Forma_pago();
            DataTable dt = formaPago.consultarForma_pago(txtBuscar.Text);
            cargarFormaPago(dt);
            this.txtBuscar.Focus();
        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            showMain();
            this.txtBuscar.Focus();
        }

        private void CmdNuevo_Click(object sender, EventArgs e)
        {
            this.lb_subtitle.Text = "Crear Forma de Pago";
            // Deshabilitamos la grilla para evitar nuevo doble click
            this.data_grid_forma_pago.Enabled = false;
            // Ocultar Data Grip View
            this.data_grid_forma_pago.Visible = false;

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
            this.txtDescripcion.Text = "";
            
        }

        private void CmdBorrar_Click(object sender, EventArgs e)
        {
            Forma_pago formaPago = new Forma_pago();
            int id = (Int32.TryParse(this.txtIdFormaPago.Text, out id) ? id : 0);
            if (id == 0)
            {
                MessageBox.Show("Hubo un error al intentar borrar la Forma de Pago. Causa: No se pudo determinar que Forma de Pago es");
                return;
            }

            formaPago.borrarForma_pago(id);

            MessageBox.Show("Forma de Pago eliminada exitosamente");
            showMain();
        }

        private void showMain()
        {
            this.data_grid_forma_pago.Enabled = true;
            this.data_grid_forma_pago.Visible = true;
            emptyTextBoxes();
            panel_formulario.Visible = false;
            this.cmdNuevo.Visible = true;
            this.txtBuscar.Visible = true;
            this.cmdBuscar.Visible = true;
            loadAllForma_pago();
        }

        private void txtBuscar_KeyPress(Object sender, KeyPressEventArgs e) {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                // No se valida porque si no hay nada deberia devolver toda la grilla de nuevo
                Forma_pago formaPago = new Forma_pago();
                DataTable dt = formaPago.consultarForma_pago(txtBuscar.Text);
                cargarFormaPago(dt);
            }
        }
    }
}
