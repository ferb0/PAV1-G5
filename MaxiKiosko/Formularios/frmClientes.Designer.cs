namespace MaxiKiosko.Formularios
{
    partial class frmClientes
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
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.data_grip_clientes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel_formulario = new System.Windows.Forms.Panel();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lb_subtitle = new System.Windows.Forms.Label();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.cmdNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grip_clientes)).BeginInit();
            this.panel_formulario.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(50, 224);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(126, 23);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Teléfono de contacto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "email";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Enabled = false;
            this.txtIDCliente.Location = new System.Drawing.Point(182, 224);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(111, 20);
            this.txtIDCliente.TabIndex = 1;
            this.txtIDCliente.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(144, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(269, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 94);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(269, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(144, 120);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(269, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Location = new System.Drawing.Point(281, 223);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(132, 23);
            this.cmdCancelar.TabIndex = 13;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // data_grip_clientes
            // 
            this.data_grip_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grip_clientes.Location = new System.Drawing.Point(12, 91);
            this.data_grip_clientes.Name = "data_grip_clientes";
            this.data_grip_clientes.ReadOnly = true;
            this.data_grip_clientes.RowHeadersVisible = false;
            this.data_grip_clientes.Size = new System.Drawing.Size(430, 236);
            this.data_grip_clientes.TabIndex = 15;
            this.data_grip_clientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grip_clientes_CellDoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(249, 20);
            this.txtBuscar.TabIndex = 18;
            // 
            // panel_formulario
            // 
            this.panel_formulario.Controls.Add(this.cmdBorrar);
            this.panel_formulario.Controls.Add(this.txtBuscar);
            this.panel_formulario.Controls.Add(this.lb_subtitle);
            this.panel_formulario.Controls.Add(this.txtApellido);
            this.panel_formulario.Controls.Add(this.txtNombre);
            this.panel_formulario.Controls.Add(this.txtTelefono);
            this.panel_formulario.Controls.Add(this.label6);
            this.panel_formulario.Controls.Add(this.label5);
            this.panel_formulario.Controls.Add(this.label4);
            this.panel_formulario.Controls.Add(this.txtEmail);
            this.panel_formulario.Controls.Add(this.label3);
            this.panel_formulario.Controls.Add(this.cmdCancelar);
            this.panel_formulario.Controls.Add(this.cmdGuardar);
            this.panel_formulario.Controls.Add(this.txtIDCliente);
            this.panel_formulario.Location = new System.Drawing.Point(12, 42);
            this.panel_formulario.Name = "panel_formulario";
            this.panel_formulario.Size = new System.Drawing.Size(430, 285);
            this.panel_formulario.TabIndex = 20;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(281, 13);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(132, 23);
            this.cmdBorrar.TabIndex = 18;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.CmdBorrar_Click);
            // 
            // lb_subtitle
            // 
            this.lb_subtitle.AutoSize = true;
            this.lb_subtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtitle.Location = new System.Drawing.Point(12, 11);
            this.lb_subtitle.Name = "lb_subtitle";
            this.lb_subtitle.Size = new System.Drawing.Size(57, 20);
            this.lb_subtitle.TabIndex = 17;
            this.lb_subtitle.Text = "label2";
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(352, 44);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmdBuscar.TabIndex = 19;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.CmdBuscar_Click);
            // 
            // cmdNuevo
            // 
            this.cmdNuevo.Image = global::MaxiKiosko.Properties.Resources.add_file;
            this.cmdNuevo.Location = new System.Drawing.Point(398, 44);
            this.cmdNuevo.Name = "cmdNuevo";
            this.cmdNuevo.Size = new System.Drawing.Size(40, 40);
            this.cmdNuevo.TabIndex = 10;
            this.cmdNuevo.UseVisualStyleBackColor = true;
            this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevo_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 337);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdNuevo);
            this.Controls.Add(this.panel_formulario);
            this.Controls.Add(this.data_grip_clientes);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grip_clientes)).EndInit();
            this.panel_formulario.ResumeLayout(false);
            this.panel_formulario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdNuevo;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.DataGridView data_grip_clientes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.Panel panel_formulario;
        private System.Windows.Forms.Label lb_subtitle;
        private System.Windows.Forms.Button cmdBorrar;
    }
}