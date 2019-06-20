using MaxiKiosko.Clases;
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
    public partial class frmListadoUsuarios : Form
    {
        public frmListadoUsuarios()
        {
            InitializeComponent();
        }

        private void frmListadoUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.dataSet1.usuario);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            DataTable dt = usr.buscarUsuario(txtBuscar.Text);
            usuarioBindingSource.DataSource = dt;
            rptListadoUsuario.RefreshReport();
        }
    }
}
