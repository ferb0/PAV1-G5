using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaxiKiosko.Formularios;

namespace MaxiKiosko
{
    public partial class MaxiKiosko : Form
    {
        public MaxiKiosko()
        {
            InitializeComponent();
        }

        private void MaxiKiosko_Load(object sender, EventArgs e)
        {
            // Sesion frm_sesion = new Sesion();
            // frm_sesion.ShowDialog();
            
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_clienteconsultar.Visible = false;
            panel_clientenuevo.Visible = true;
        }

        private void button_clienteguardar_Click(object sender, EventArgs e)
        {
            if ( this.textBox_apellidocliente.Text == "" )
            {
                MessageBox.Show("Apellido no ingresado.");
                this.textBox_apellidocliente.Focus();
                return;
            }

            if (this.textBox_nombrecliente.Text == "")
            {
                MessageBox.Show("Nombre no ingresado.");
                this.textBox_nombrecliente.Focus();
                return;
            }

            if (this.textBox_telefonocliente.Text == "")
            {
                MessageBox.Show("Teléfono no ingresado.");
                this.textBox_telefonocliente.Focus();
                return;
            }

            Conexion nueva_conexion = new Conexion();
            nueva_conexion.abrirConexion();

            Cliente nuevo_cliente = new Cliente(this.textBox_apellidocliente.Text, this.textBox_nombrecliente.Text, this.textBox_telefonocliente.Text, this.textBox_emailcliente.Text);

            if ( nuevo_cliente.agregarCliente(nueva_conexion) > 0 )
            {
                MessageBox.Show("Cliente guardado.");
            }

            nueva_conexion.cerrarConexion();

            this.textBox_apellidocliente.Clear();
            this.textBox_nombrecliente.Clear();
            this.textBox_telefonocliente.Clear();
            this.textBox_emailcliente.Clear();
        }

        private void button_clientecancelar_Click(object sender, EventArgs e)
        {
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = true;
        }

        private void button_consultarcliente_Click(object sender, EventArgs e)
        {
            if ( this.textBox_consultarcliente.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún dato.");
                this.textBox_consultarcliente.Focus();
            }

            // Hacer consulta en base da datos formato datos y mostar en listbox.

        }

        private void listBox_consultacliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
            panel_clienteconsultado.Visible = true;
        }

        private void button_clienteconsultadocancelar_Click(object sender, EventArgs e)
        {
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
            panel_clienteconsultado.Visible = false;
        }
    }
}
