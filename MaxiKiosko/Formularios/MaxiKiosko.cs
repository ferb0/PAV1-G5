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
            panel_productoconsultado.Visible = false;
            panel_productoconsultar.Visible = false;
            panel_productonuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
            panel_clientenuevo.Visible = true;
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_productoconsultado.Visible = false;
            panel_productoconsultar.Visible = false;
            panel_productonuevo.Visible = false;
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = true;
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_productoconsultado.Visible = false;
            panel_productoconsultar.Visible = false;
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
            panel_clienteconsultado.Visible = false;
            panel_productonuevo.Visible = true;
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_productoconsultado.Visible = false;
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
            panel_clienteconsultado.Visible = false;
            panel_productonuevo.Visible = false;
            panel_productoconsultar.Visible = true;
        }

        private void button_productoconsultadocancelar_Click(object sender, EventArgs e)
        {
            panel_clientenuevo.Visible = false;
            panel_clienteconsultar.Visible = false;
            panel_clienteconsultado.Visible = false;
            panel_productonuevo.Visible = false;
            panel_productoconsultar.Visible = false;
            panel_productoconsultado.Visible = false;
        }

        private void button_productoconsultar_Click(object sender, EventArgs e)
        {
            if (this.textBox_productoconsultar.Text == "")
            {
                MessageBox.Show("No ha ingresado ningún dato.");
                this.textBox_productoconsultar.Focus();
            }

            // Hacer consulta en base da datos formato datos y mostar en listbox.
        }

        private void listBox_productoconsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
