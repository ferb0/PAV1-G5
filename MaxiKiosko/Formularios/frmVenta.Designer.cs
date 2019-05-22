namespace MaxiKiosko.Formularios
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.datagrid_venta = new System.Windows.Forms.DataGridView();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbFormaPago = new System.Windows.Forms.Label();
	        this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.lbClienteDni = new System.Windows.Forms.Label();
            this.lbClienteObservacion = new System.Windows.Forms.Label();
            this.lbClienteNombreYApellido = new System.Windows.Forms.Label();
            this.txtClienteDni = new System.Windows.Forms.TextBox();
            this.txtClienteNombreYApellido = new System.Windows.Forms.TextBox();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.cmdBuscarCliente = new System.Windows.Forms.Button();
            this.lbProductoCodigo = new System.Windows.Forms.Label();
            this.cmdBuscarProducto = new System.Windows.Forms.Button();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.txtProductoCantidad = new System.Windows.Forms.TextBox();
            this.txtProductoCodigo = new System.Windows.Forms.TextBox();
            this.lbProductoCantidad = new System.Windows.Forms.Label();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(200, 600);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(100, 23);
            this.cmdGuardar.TabIndex = 2;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdAgregarProducto
            // 
            this.cmdAgregarProducto.Location = new System.Drawing.Point(360, 13);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(120, 23);
            this.cmdAgregarProducto.TabIndex = 3;
            this.cmdAgregarProducto.Text = "Agregar Producto";
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // cmdBuscarProducto
            // 
            this.cmdBuscarProducto.Location = new System.Drawing.Point(15, 50);
            this.cmdBuscarProducto.Name = "cmdBuscarProducto";
            this.cmdBuscarProducto.Size = new System.Drawing.Size(120, 23);
            this.cmdBuscarProducto.TabIndex = 4;
            this.cmdBuscarProducto.Text = "Buscar Producto";
            this.cmdBuscarProducto.Click += new System.EventHandler(this.cmdBuscarProducto_Click);
            // 
            // datagrid_venta
            // 
            this.datagrid_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_venta.Location = new System.Drawing.Point(15, 300);
            this.datagrid_venta.AllowUserToAddRows = false;
            this.datagrid_venta.AllowUserToDeleteRows = false;
            this.datagrid_venta.AllowUserToResizeRows = false;
            this.datagrid_venta.Name = "datagrid_venta";
            this.datagrid_venta.Size = new System.Drawing.Size(500, 200);
            this.datagrid_venta.TabIndex = 3;
            this.datagrid_venta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_venta_CellEndEdit);
            this.datagrid_venta.ReadOnly = true;
            this.datagrid_venta.RowHeadersVisible = false;
            this.datagrid_venta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_venta_CellDoubleClick);
            //
            // groupboxCliente
            //
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Location = new System.Drawing.Point(15, 50);
            this.groupBoxCliente.Size = new System.Drawing.Size(500, 110);
            this.groupBoxCliente.Text = "Cliente";
            this.groupBoxCliente.Controls.Add(this.cmdBuscarCliente);
            this.groupBoxCliente.Controls.Add(this.lbClienteNombreYApellido);
            this.groupBoxCliente.Controls.Add(this.txtClienteNombreYApellido);
            this.groupBoxCliente.Controls.Add(this.lbClienteDni);
            this.groupBoxCliente.Controls.Add(this.txtClienteDni);
            this.groupBoxCliente.Controls.Add(this.lbClienteObservacion);
            //
            // groupboxProducto
            //
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Location = new System.Drawing.Point(15, 180);
            this.groupBoxProducto.Size = new System.Drawing.Size(500, 100);
            this.groupBoxProducto.Text = "Agregar Productos";
            this.groupBoxProducto.Controls.Add(this.lbProductoCodigo);
            this.groupBoxProducto.Controls.Add(this.txtProductoCodigo);
            this.groupBoxProducto.Controls.Add(this.lbProductoCantidad);
            this.groupBoxProducto.Controls.Add(this.txtProductoCantidad);
            this.groupBoxProducto.Controls.Add(this.cmdAgregarProducto);
            this.groupBoxProducto.Controls.Add(this.cmdBuscarProducto);
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(380, 15);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(40, 15);
            this.lbFecha.Text = "Fecha y Hora del sistema";
            this.lbFecha.Font = new System.Drawing.Font(this.Font, System.Drawing.FontStyle.Bold);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(360, 515);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Text = "Total: $ 4500.15";
            this.lbTotal.Hide();
            this.lbTotal.Font = new System.Drawing.Font(this.Font.FontFamily, 14, System.Drawing.FontStyle.Bold);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(400, 30);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(40, 15);
            // 
            // cmdBuscarCliente
            // 
            this.cmdBuscarCliente.Location = new System.Drawing.Point(15, 30);
            this.cmdBuscarCliente.Name = "cmdGuardar";
            this.cmdBuscarCliente.Size = new System.Drawing.Size(150, 25);
            this.cmdBuscarCliente.TabIndex = 2;
            this.cmdBuscarCliente.Text = "Buscar Cliente";
            this.cmdBuscarCliente.Click += new System.EventHandler(this.cmdBuscarCliente_Click);
            //TODO agregar lupa a la derecha del boton
            // 
            // lbClienteObservacion
            // 
            this.lbClienteObservacion.AutoSize = true;
            this.lbClienteObservacion.Location = new System.Drawing.Point(190, 30);
            this.lbClienteObservacion.Name = "lbClienteNombreYApellido";
            this.lbClienteObservacion.Size = new System.Drawing.Size(40, 15);
            this.lbClienteObservacion.Text = "* Si no selecciona ningún cliente y \n se tomará por defecto CONSUMIDOR FINAL";
            this.lbClienteObservacion.Font = new System.Drawing.Font(this.Font.FontFamily,8,System.Drawing.FontStyle.Italic);
            // 
            // lbClienteNombreYApellido
            // 
            this.lbClienteNombreYApellido.AutoSize = true;
            this.lbClienteNombreYApellido.Location = new System.Drawing.Point(200, 72);
            this.lbClienteNombreYApellido.Name = "lbClienteNombreYApellido";
            this.lbClienteNombreYApellido.Size = new System.Drawing.Size(40, 15);
            this.lbClienteNombreYApellido.Text = "Nombre:";
            // 
            // lbClienteDni
            // 
            this.lbClienteDni.AutoSize = true;
            this.lbClienteDni.Location = new System.Drawing.Point(15, 72);
            this.lbClienteDni.Name = "lbClienteDni";
            this.lbClienteDni.Size = new System.Drawing.Size(40, 15);
            this.lbClienteDni.Text = "Documento:";
            //
            // txtClienteDni
            //
            this.txtClienteDni.Location = new System.Drawing.Point(80, 70);
            this.txtClienteDni.Name = "txtClienteDni";
            this.txtClienteDni.Size = new System.Drawing.Size(110, 20);
            this.txtClienteDni.Enabled = false;
            //
            // txtClienteNombreYApellido
            //
            this.txtClienteNombreYApellido.Location = new System.Drawing.Point(255, 70);
            this.txtClienteNombreYApellido.Name = "txtClienteNombreYApellido";
            this.txtClienteNombreYApellido.Size = new System.Drawing.Size(220, 20);
            this.txtClienteNombreYApellido.Enabled = false;
            //
            // txtProductoCodigo
            //
            this.txtProductoCodigo.Location = new System.Drawing.Point(65, 15);
            this.txtProductoCodigo.Name = "txtProductoCodigo";
            this.txtProductoCodigo.Size = new System.Drawing.Size(150, 20);
            this.txtProductoCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoCodigo_KeyPress);
            this.txtProductoCodigo.TabIndex = 1;
            // 
            // lbProductoCodigo
            // 
            this.lbProductoCodigo.AutoSize = true;
            this.lbProductoCodigo.Location = new System.Drawing.Point(15, 17);
            this.lbProductoCodigo.Name = "lbProductoCodigo";
            this.lbProductoCodigo.Size = new System.Drawing.Size(40, 15);
            this.lbProductoCodigo.Text = "Codigo:";
            //
            // txtProductoCantidad
            //
            this.txtProductoCantidad.Location = new System.Drawing.Point(290, 15);
            this.txtProductoCantidad.Name = "txtProductoCantidad";
            this.txtProductoCantidad.Size = new System.Drawing.Size(50, 20);
            this.txtProductoCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductoCantidad_KeyPress);
            this.txtProductoCantidad.TabIndex = 2;
            // 
            // lbProductoCantidad
            // 
            this.lbProductoCantidad.AutoSize = true;
            this.lbProductoCantidad.Location = new System.Drawing.Point(230, 17);
            this.lbProductoCantidad.Name = "lbProductoCantidad";
            this.lbProductoCantidad.Size = new System.Drawing.Size(40, 15);
            this.lbProductoCantidad.Text = "Cantidad:";
            // 
            // lbFormaPago
            // 
            this.lbFormaPago.AutoSize = true;
            this.lbFormaPago.Location = new System.Drawing.Point(15, 540);
            this.lbFormaPago.Name = "lbFormaPago";
            this.lbFormaPago.Size = new System.Drawing.Size(40, 15);
            this.lbFormaPago.Text = "Forma de Pago:";
    	    //
    	    // cmbFormaPago
    	    //
    	    this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    	    this.cmbFormaPago.FormattingEnabled = true;
    	    this.cmbFormaPago.Location = new System.Drawing.Point(15, 560);
    	    this.cmbFormaPago.Name = "cmbFormaPago";
    	    this.cmbFormaPago.Size = new System.Drawing.Size(260, 20);
    	    this.cmbFormaPago.TabIndex = 6;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 640);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.datagrid_venta);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.cmdGuardar);
	    this.Controls.Add(this.cmbFormaPago);
	    this.Controls.Add(this.lbFormaPago);
            this.Name = "frmVenta";
            this.Text = "Nueva Venta";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.DataGridView datagrid_venta;
        private System.Windows.Forms.Button cmdBuscarCliente;
        private System.Windows.Forms.Label lbClienteNombreYApellido;
        private System.Windows.Forms.TextBox txtClienteNombreYApellido;
        private System.Windows.Forms.Label lbClienteDni;
        private System.Windows.Forms.TextBox txtClienteDni;
        private System.Windows.Forms.Label lbClienteObservacion;
        private System.Windows.Forms.Button cmdBuscarProducto;
        private System.Windows.Forms.TextBox txtProductoCodigo;
        private System.Windows.Forms.Label lbProductoCodigo;
        private System.Windows.Forms.TextBox txtProductoCantidad;
        private System.Windows.Forms.Label lbProductoCantidad;
        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.Label lbTotal;
	    private System.Windows.Forms.ComboBox cmbFormaPago;
	    private System.Windows.Forms.Label lbFormaPago;
    }
}
