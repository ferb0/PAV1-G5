namespace MaxiKiosko.Formularios
{
    partial class frmTipo_producto
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
            this.lblTipo_producto = new System.Windows.Forms.Label();
            this.panel_formulario = new System.Windows.Forms.Panel();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoTipoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_subtitle = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.data_grid_tipo_producto = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_tipo_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTipo_producto
            // 
            this.lblTipo_producto.AutoSize = true;
            this.lblTipo_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo_producto.Location = new System.Drawing.Point(12, 9);
            this.lblTipo_producto.Name = "lblTipo_producto";
            this.lblTipo_producto.Size = new System.Drawing.Size(171, 25);
            this.lblTipo_producto.TabIndex = 1;
            this.lblTipo_producto.Text = "Tipo Productos";
            // 
            // panel_formulario
            // 
            this.panel_formulario.Controls.Add(this.cmdBorrar);
            this.panel_formulario.Controls.Add(this.cmdCancelar);
            this.panel_formulario.Controls.Add(this.cmdGuardar);
            this.panel_formulario.Controls.Add(this.txtDescripcion);
            this.panel_formulario.Controls.Add(this.label4);
            this.panel_formulario.Controls.Add(this.txtCodigoTipoProducto);
            this.panel_formulario.Controls.Add(this.label3);
            this.panel_formulario.Controls.Add(this.lb_subtitle);
            this.panel_formulario.Location = new System.Drawing.Point(14, 85);
            this.panel_formulario.Name = "panel_formulario";
            this.panel_formulario.Size = new System.Drawing.Size(548, 219);
            this.panel_formulario.TabIndex = 6;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(424, 9);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 17;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(302, 170);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(132, 23);
            this.cmdCancelar.TabIndex = 16;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(74, 170);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(126, 23);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 107);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion*";
            // 
            // txtCodigoTipoProducto
            // 
            this.txtCodigoTipoProducto.Location = new System.Drawing.Point(174, 69);
            this.txtCodigoTipoProducto.Name = "txtCodigoTipoProducto";
            this.txtCodigoTipoProducto.Size = new System.Drawing.Size(260, 20);
            this.txtCodigoTipoProducto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo Tipo Producto*";
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
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(353, 53);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmdBuscar.TabIndex = 7;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Image = global::MaxiKiosko.Properties.Resources.add_file;
            this.cmdNuevo.Location = new System.Drawing.Point(399, 53);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(40, 40);
            this.cmdNuevo.TabIndex = 18;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            // 
            // data_grid_tipo_producto
            // 
            this.data_grid_tipo_producto.AllowUserToAddRows = false;
            this.data_grid_tipo_producto.AllowUserToDeleteRows = false;
            this.data_grid_tipo_producto.AllowUserToResizeRows = false;
            this.data_grid_tipo_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_tipo_producto.Location = new System.Drawing.Point(14, 336);
            this.data_grid_tipo_producto.Name = "data_grid_tipo_producto";
            this.data_grid_tipo_producto.ReadOnly = true;
            this.data_grid_tipo_producto.RowHeadersVisible = false;
            this.data_grid_tipo_producto.Size = new System.Drawing.Size(545, 236);
            this.data_grid_tipo_producto.TabIndex = 19;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 59);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(243, 20);
            this.txtBuscar.TabIndex = 19;
            // 
            // frmTipo_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 640);
            this.Controls.Add(this.data_grid_tipo_producto);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.lblTipo_producto);
            this.Controls.Add(this.panel_formulario);
            this.Name = "frmTipo_producto";
            this.Text = "Tipo Producto";
            this.panel_formulario.ResumeLayout(false);
            this.panel_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_tipo_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipo_producto;
        private System.Windows.Forms.Panel panel_formulario;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoTipoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_subtitle;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridView data_grid_tipo_producto;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}