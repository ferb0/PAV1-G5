namespace MaxiKiosko.Formularios
{
    partial class frmProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.data_grid_productos = new System.Windows.Forms.DataGridView();
            this.panel_producto = new System.Windows.Forms.Panel();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_subtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_productos)).BeginInit();
            this.panel_producto.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(18, 55);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(249, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(471, 44);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmdBuscar.TabIndex = 2;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Image = global::MaxiKiosko.Properties.Resources.add_file;
            this.cmdNuevo.Location = new System.Drawing.Point(517, 44);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(40, 40);
            this.cmdNuevo.TabIndex = 3;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevo_Click);
            // 
            // data_grid_productos
            // 
            this.data_grid_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_productos.Location = new System.Drawing.Point(12, 90);
            this.data_grid_productos.Name = "data_grid_productos";
            this.data_grid_productos.ReadOnly = true;
            this.data_grid_productos.RowHeadersVisible = false;
            this.data_grid_productos.Size = new System.Drawing.Size(545, 236);
            this.data_grid_productos.TabIndex = 4;
            this.data_grid_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_productos_CellDoubleClick);
            // 
            // panel_producto
            // 
            this.panel_producto.Controls.Add(this.cmdBorrar);
            this.panel_producto.Controls.Add(this.cmdCancelar);
            this.panel_producto.Controls.Add(this.cmdGuardar);
            this.panel_producto.Controls.Add(this.txtMedida);
            this.panel_producto.Controls.Add(this.label7);
            this.panel_producto.Controls.Add(this.txtStock);
            this.panel_producto.Controls.Add(this.label5);
            this.panel_producto.Controls.Add(this.txtPrecio);
            this.panel_producto.Controls.Add(this.label6);
            this.panel_producto.Controls.Add(this.txtDescripcion);
            this.panel_producto.Controls.Add(this.label4);
            this.panel_producto.Controls.Add(this.txtCodigoProducto);
            this.panel_producto.Controls.Add(this.label3);
            this.panel_producto.Controls.Add(this.lb_subtitle);
            this.panel_producto.Location = new System.Drawing.Point(12, 44);
            this.panel_producto.Name = "panel_producto";
            this.panel_producto.Size = new System.Drawing.Size(545, 282);
            this.panel_producto.TabIndex = 5;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(424, 9);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 17;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(302, 242);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(132, 23);
            this.cmdCancelar.TabIndex = 16;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click_1);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(71, 243);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(126, 23);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(171, 202);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(260, 20);
            this.txtMedida.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Medida";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(171, 162);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(260, 20);
            this.txtStock.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stock";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(171, 124);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(260, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(171, 89);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(171, 51);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(260, 20);
            this.txtCodigoProducto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo Producto";
            // 
            // lb_subtitle
            // 
            this.lb_subtitle.AutoSize = true;
            this.lb_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitle.Location = new System.Drawing.Point(18, 11);
            this.lb_subtitle.Name = "lb_subtitle";
            this.lb_subtitle.Size = new System.Drawing.Size(57, 20);
            this.lb_subtitle.TabIndex = 0;
            this.lb_subtitle.Text = "label2";
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.data_grid_productos);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_producto);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_productos)).EndInit();
            this.panel_producto.ResumeLayout(false);
            this.panel_producto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridView data_grid_productos;
        private System.Windows.Forms.Panel panel_producto;
        private System.Windows.Forms.Label lb_subtitle;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdBorrar;
    }
}