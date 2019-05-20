namespace MaxiKiosko.Formularios
{
    partial class frmFormaPago
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
            this.lblForma_pago = new System.Windows.Forms.Label();
            this.panel_formulario = new System.Windows.Forms.Panel();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_subtitle = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            this.data_grid_forma_pago = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtIdFormaPago = new System.Windows.Forms.TextBox();
            this.panel_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_forma_pago)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForma_pago
            // 
            this.lblForma_pago.AutoSize = true;
            this.lblForma_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForma_pago.Location = new System.Drawing.Point(12, 9);
            this.lblForma_pago.Name = "lblForma_pago";
            this.lblForma_pago.Size = new System.Drawing.Size(184, 25);
            this.lblForma_pago.TabIndex = 1;
            this.lblForma_pago.Text = "Formas de Pago";
            // 
            // panel_formulario
            // 
            this.panel_formulario.Controls.Add(this.cmdBorrar);
            this.panel_formulario.Controls.Add(this.cmdCancelar);
            this.panel_formulario.Controls.Add(this.cmdGuardar);
            this.panel_formulario.Controls.Add(this.txtDescripcion);
            this.panel_formulario.Controls.Add(this.label4);
            this.panel_formulario.Controls.Add(this.lb_subtitle);
            this.panel_formulario.Location = new System.Drawing.Point(14, 48);
            this.panel_formulario.Name = "panel_formulario";
            this.panel_formulario.Size = new System.Drawing.Size(548, 154);
            this.panel_formulario.TabIndex = 6;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(459, 6);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(75, 23);
            this.cmdBorrar.TabIndex = 17;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.CmdBorrar_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(321, 128);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(132, 23);
            this.cmdCancelar.TabIndex = 16;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(75, 128);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(126, 23);
            this.cmdGuardar.TabIndex = 15;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(174, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion*";
            // 
            // lb_subtitle
            // 
            this.lb_subtitle.AutoSize = true;
            this.lb_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitle.Location = new System.Drawing.Point(12, 9);
            this.lb_subtitle.Name = "lb_subtitle";
            this.lb_subtitle.Size = new System.Drawing.Size(57, 20);
            this.lb_subtitle.TabIndex = 0;
            this.lb_subtitle.Text = "label2";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(473, 48);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmdBuscar.TabIndex = 7;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Image = global::MaxiKiosko.Properties.Resources.add_file;
            this.cmdNuevo.Location = new System.Drawing.Point(519, 48);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(40, 40);
            this.cmdNuevo.TabIndex = 18;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevo_Click);
            // 
            // data_grid_forma_pago
            // 
            this.data_grid_forma_pago.AllowUserToAddRows = false;
            this.data_grid_forma_pago.AllowUserToDeleteRows = false;
            this.data_grid_forma_pago.AllowUserToResizeRows = false;
            this.data_grid_forma_pago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_forma_pago.Location = new System.Drawing.Point(14, 94);
            this.data_grid_forma_pago.Name = "data_grid_forma_pago";
            this.data_grid_forma_pago.ReadOnly = true;
            this.data_grid_forma_pago.RowHeadersVisible = false;
            this.data_grid_forma_pago.Size = new System.Drawing.Size(545, 169);
            this.data_grid_forma_pago.TabIndex = 19;
            this.data_grid_forma_pago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_forma_pago_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 58);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 20);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // txtIdFormaPago
            // 
            this.txtIdFormaPago.Location = new System.Drawing.Point(462, 12);
            this.txtIdFormaPago.Name = "txtIdFormaPago";
            this.txtIdFormaPago.Size = new System.Drawing.Size(100, 20);
            this.txtIdFormaPago.TabIndex = 20;
            this.txtIdFormaPago.Visible = false;
            // 
            // frmFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 278);
            this.Controls.Add(this.txtIdFormaPago);
            this.Controls.Add(this.lblForma_pago);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panel_formulario);
            this.Controls.Add(this.data_grid_forma_pago);
            this.Name = "frmFormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pago";
            this.Load += new System.EventHandler(this.FrmFormaPago_Load);
            this.panel_formulario.ResumeLayout(false);
            this.panel_formulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_forma_pago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForma_pago;
        private System.Windows.Forms.Panel panel_formulario;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_subtitle;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.DataGridView data_grid_forma_pago;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtIdFormaPago;
    }
}