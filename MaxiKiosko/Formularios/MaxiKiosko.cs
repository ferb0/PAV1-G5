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
            panel_clientes.Visible = true;
        }
    }
}
