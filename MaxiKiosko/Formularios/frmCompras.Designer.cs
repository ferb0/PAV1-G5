namespace MaxiKiosko.Formularios
{
    partial class frmCompras
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.groupBoxProveedores = new System.Windows.Forms.GroupBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdBuscarProveedor = new System.Windows.Forms.Button();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.groupBoxProducto = new System.Windows.Forms.GroupBox();
            this.cmdBuscarProducto = new System.Windows.Forms.Button();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dataGrid_compra = new System.Windows.Forms.DataGridView();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.groupBoxProveedores.SuspendLayout();
            this.groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(662, 18);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFecha.Size = new System.Drawing.Size(126, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha y hora del Sistema";
            // 
            // groupBoxProveedores
            // 
            this.groupBoxProveedores.Controls.Add(this.txtRazonSocial);
            this.groupBoxProveedores.Controls.Add(this.label3);
            this.groupBoxProveedores.Controls.Add(this.label2);
            this.groupBoxProveedores.Controls.Add(this.txtComprobante);
            this.groupBoxProveedores.Controls.Add(this.txtCUIT);
            this.groupBoxProveedores.Controls.Add(this.label6);
            this.groupBoxProveedores.Controls.Add(this.cmdBuscarProveedor);
            this.groupBoxProveedores.Controls.Add(this.lblCUIT);
            this.groupBoxProveedores.Location = new System.Drawing.Point(12, 25);
            this.groupBoxProveedores.Name = "groupBoxProveedores";
            this.groupBoxProveedores.Size = new System.Drawing.Size(562, 138);
            this.groupBoxProveedores.TabIndex = 1;
            this.groupBoxProveedores.TabStop = false;
            this.groupBoxProveedores.Text = "Proveedores";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(279, 57);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(162, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Razón Social";
            this.label3.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(279, 96);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtComprobante.TabIndex = 2;
            this.txtComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtComprobante_KeyPress);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(82, 57);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtCUIT.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nro de Comprobante";
            // 
            // cmdBuscarProveedor
            // 
            this.cmdBuscarProveedor.Location = new System.Drawing.Point(37, 19);
            this.cmdBuscarProveedor.Name = "cmdBuscarProveedor";
            this.cmdBuscarProveedor.Size = new System.Drawing.Size(102, 23);
            this.cmdBuscarProveedor.TabIndex = 0;
            this.cmdBuscarProveedor.Text = "Buscar Proveedor";
            this.cmdBuscarProveedor.UseVisualStyleBackColor = true;
            this.cmdBuscarProveedor.Click += new System.EventHandler(this.cmdBuscarProveedor_Click);
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(31, 57);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 1;
            this.lblCUIT.Text = "CUIT";
            // 
            // groupBoxProducto
            // 
            this.groupBoxProducto.Controls.Add(this.cmdBuscarProducto);
            this.groupBoxProducto.Controls.Add(this.cmdAgregarProducto);
            this.groupBoxProducto.Controls.Add(this.txtIVA);
            this.groupBoxProducto.Controls.Add(this.label5);
            this.groupBoxProducto.Controls.Add(this.txtPrecioCompra);
            this.groupBoxProducto.Controls.Add(this.label1);
            this.groupBoxProducto.Controls.Add(this.txtCantidad);
            this.groupBoxProducto.Controls.Add(this.label4);
            this.groupBoxProducto.Controls.Add(this.txtCodigo);
            this.groupBoxProducto.Controls.Add(this.lblCodigo);
            this.groupBoxProducto.Location = new System.Drawing.Point(12, 179);
            this.groupBoxProducto.Name = "groupBoxProducto";
            this.groupBoxProducto.Size = new System.Drawing.Size(562, 114);
            this.groupBoxProducto.TabIndex = 2;
            this.groupBoxProducto.TabStop = false;
            this.groupBoxProducto.Text = "Agregar Productos";
            // 
            // cmdBuscarProducto
            // 
            this.cmdBuscarProducto.Location = new System.Drawing.Point(29, 62);
            this.cmdBuscarProducto.Name = "cmdBuscarProducto";
            this.cmdBuscarProducto.Size = new System.Drawing.Size(100, 23);
            this.cmdBuscarProducto.TabIndex = 3;
            this.cmdBuscarProducto.Text = "Buscar Producto";
            this.cmdBuscarProducto.UseVisualStyleBackColor = true;
            this.cmdBuscarProducto.Click += new System.EventHandler(this.cmdBuscarProducto_Click);
            // 
            // cmdAgregarProducto
            // 
            this.cmdAgregarProducto.Location = new System.Drawing.Point(409, 17);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(116, 23);
            this.cmdAgregarProducto.TabIndex = 2;
            this.cmdAgregarProducto.Text = "Agregar Producto";
            this.cmdAgregarProducto.UseVisualStyleBackColor = true;
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(308, 68);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(60, 20);
            this.txtIVA.TabIndex = 1;
            this.txtIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIVA_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Porcentaje IVA";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(308, 42);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(60, 20);
            this.txtPrecioCompra.TabIndex = 1;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio de Compra";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(308, 16);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // dataGrid_compra
            // 
            this.dataGrid_compra.AllowUserToAddRows = false;
            this.dataGrid_compra.AllowUserToDeleteRows = false;
            this.dataGrid_compra.AllowUserToResizeColumns = false;
            this.dataGrid_compra.AllowUserToResizeRows = false;
            this.dataGrid_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_compra.Location = new System.Drawing.Point(12, 299);
            this.dataGrid_compra.Name = "dataGrid_compra";
            this.dataGrid_compra.ReadOnly = true;
            this.dataGrid_compra.Size = new System.Drawing.Size(562, 150);
            this.dataGrid_compra.TabIndex = 3;
            this.dataGrid_compra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_compra_CellDoubleClick);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(434, 9);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(126, 13);
            this.lblFechaHora.TabIndex = 4;
            this.lblFechaHora.Text = "Fecha y hora del Sistema";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(422, 464);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(157, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: $ 4500.15";
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(178, 467);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(75, 23);
            this.cmdGuardar.TabIndex = 6;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(294, 465);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdCancelar.TabIndex = 6;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 514);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.dataGrid_compra);
            this.Controls.Add(this.groupBoxProducto);
            this.Controls.Add(this.groupBoxProveedores);
            this.Controls.Add(this.lblFecha);
            this.Name = "frmCompras";
            this.Text = "frmCompras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.groupBoxProveedores.ResumeLayout(false);
            this.groupBoxProveedores.PerformLayout();
            this.groupBoxProducto.ResumeLayout(false);
            this.groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_compra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox groupBoxProveedores;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdBuscarProveedor;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.Button cmdBuscarProducto;
        private System.Windows.Forms.DataGridView dataGrid_compra;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.Label label6;
    }
}