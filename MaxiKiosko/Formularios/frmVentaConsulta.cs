﻿using System;
using System.Data;
using System.Windows.Forms;
namespace MaxiKiosko.Formularios
{
    public partial class frmVentaConsulta : Form
    {
        public frmClienteBusqueda()
        {
            InitializeComponent();
	    cargarVentas();
        }

        private void cargarVentas()
        {
	    Venta venta = new Venta();
	    //DataTable dt = venta.consultarTodos();
	    //TODO descomentar est alinea cuando este el metodo
            this.dataGridVentas.DataSource = dt;

            // Headers 
            this.dataGridVentas.Columns[0].HeaderText = "Apellido";
            this.dataGridVentas.Columns[1].HeaderText = "Nombre";
            this.dataGridVentas.Columns[2].HeaderText = "Documento";
            this.dataGridVentas.Columns[3].HeaderText = "A";
            this.dataGridVentas.Columns[4].HeaderText = "B";
            this.dataGridVentas.Columns[5].HeaderText = "C";
	    //TODO agregar de acuerdo a la cantidad de columnas de la consulta
            // Auto size
            this.dataGridVentas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridVentas.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
	    //TODO agregar de acuerdo a la cantidad de columnas de la consulta
        }
    }
}
