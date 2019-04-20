namespace MaxiKiosko
{
    partial class MaxiKiosko
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMaxiKiosko = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_maxikiosko = new System.Windows.Forms.Label();
            this.panel_clientes = new System.Windows.Forms.Panel();
            this.button_clientecancelar = new System.Windows.Forms.Button();
            this.button_clienteguardar = new System.Windows.Forms.Button();
            this.textBox_emailcliente = new System.Windows.Forms.TextBox();
            this.textBox_telefonocliente = new System.Windows.Forms.TextBox();
            this.textBox_nombrecliente = new System.Windows.Forms.TextBox();
            this.textBox_apellidocliente = new System.Windows.Forms.TextBox();
            this.label_emailcliente = new System.Windows.Forms.Label();
            this.label_telefonocliente = new System.Windows.Forms.Label();
            this.label_nombrecliente = new System.Windows.Forms.Label();
            this.label_apellidocliente = new System.Windows.Forms.Label();
            this.label_nuevocliente = new System.Windows.Forms.Label();
            this.menuMaxiKiosko.SuspendLayout();
            this.panel_clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMaxiKiosko
            // 
            this.menuMaxiKiosko.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuMaxiKiosko.Location = new System.Drawing.Point(0, 0);
            this.menuMaxiKiosko.Name = "menuMaxiKiosko";
            this.menuMaxiKiosko.Size = new System.Drawing.Size(513, 24);
            this.menuMaxiKiosko.TabIndex = 0;
            this.menuMaxiKiosko.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // label_maxikiosko
            // 
            this.label_maxikiosko.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_maxikiosko.Location = new System.Drawing.Point(0, 24);
            this.label_maxikiosko.Name = "label_maxikiosko";
            this.label_maxikiosko.Size = new System.Drawing.Size(513, 423);
            this.label_maxikiosko.TabIndex = 1;
            this.label_maxikiosko.Text = "MaxiKiosko Felix";
            this.label_maxikiosko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_clientes
            // 
            this.panel_clientes.Controls.Add(this.button_clientecancelar);
            this.panel_clientes.Controls.Add(this.button_clienteguardar);
            this.panel_clientes.Controls.Add(this.textBox_emailcliente);
            this.panel_clientes.Controls.Add(this.textBox_telefonocliente);
            this.panel_clientes.Controls.Add(this.textBox_nombrecliente);
            this.panel_clientes.Controls.Add(this.textBox_apellidocliente);
            this.panel_clientes.Controls.Add(this.label_emailcliente);
            this.panel_clientes.Controls.Add(this.label_telefonocliente);
            this.panel_clientes.Controls.Add(this.label_nombrecliente);
            this.panel_clientes.Controls.Add(this.label_apellidocliente);
            this.panel_clientes.Controls.Add(this.label_nuevocliente);
            this.panel_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clientes.Location = new System.Drawing.Point(0, 24);
            this.panel_clientes.Name = "panel_clientes";
            this.panel_clientes.Size = new System.Drawing.Size(513, 423);
            this.panel_clientes.TabIndex = 2;
            this.panel_clientes.Visible = false;
            // 
            // button_clientecancelar
            // 
            this.button_clientecancelar.Location = new System.Drawing.Point(264, 302);
            this.button_clientecancelar.Name = "button_clientecancelar";
            this.button_clientecancelar.Size = new System.Drawing.Size(75, 23);
            this.button_clientecancelar.TabIndex = 14;
            this.button_clientecancelar.Text = "Cancelar";
            this.button_clientecancelar.UseVisualStyleBackColor = true;
            this.button_clientecancelar.Click += new System.EventHandler(this.button_clientecancelar_Click);
            // 
            // button_clienteguardar
            // 
            this.button_clienteguardar.Location = new System.Drawing.Point(157, 302);
            this.button_clienteguardar.Name = "button_clienteguardar";
            this.button_clienteguardar.Size = new System.Drawing.Size(75, 23);
            this.button_clienteguardar.TabIndex = 13;
            this.button_clienteguardar.Text = "Guardar";
            this.button_clienteguardar.UseVisualStyleBackColor = true;
            this.button_clienteguardar.Click += new System.EventHandler(this.button_clienteguardar_Click);
            // 
            // textBox_emailcliente
            // 
            this.textBox_emailcliente.Location = new System.Drawing.Point(200, 215);
            this.textBox_emailcliente.Name = "textBox_emailcliente";
            this.textBox_emailcliente.Size = new System.Drawing.Size(100, 20);
            this.textBox_emailcliente.TabIndex = 11;
            // 
            // textBox_telefonocliente
            // 
            this.textBox_telefonocliente.Location = new System.Drawing.Point(200, 175);
            this.textBox_telefonocliente.Name = "textBox_telefonocliente";
            this.textBox_telefonocliente.Size = new System.Drawing.Size(100, 20);
            this.textBox_telefonocliente.TabIndex = 10;
            // 
            // textBox_nombrecliente
            // 
            this.textBox_nombrecliente.Location = new System.Drawing.Point(200, 138);
            this.textBox_nombrecliente.Name = "textBox_nombrecliente";
            this.textBox_nombrecliente.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombrecliente.TabIndex = 9;
            // 
            // textBox_apellidocliente
            // 
            this.textBox_apellidocliente.Location = new System.Drawing.Point(200, 100);
            this.textBox_apellidocliente.Name = "textBox_apellidocliente";
            this.textBox_apellidocliente.Size = new System.Drawing.Size(100, 20);
            this.textBox_apellidocliente.TabIndex = 8;
            // 
            // label_emailcliente
            // 
            this.label_emailcliente.AutoSize = true;
            this.label_emailcliente.Location = new System.Drawing.Point(138, 222);
            this.label_emailcliente.Name = "label_emailcliente";
            this.label_emailcliente.Size = new System.Drawing.Size(36, 13);
            this.label_emailcliente.TabIndex = 5;
            this.label_emailcliente.Text = "E-Mail";
            // 
            // label_telefonocliente
            // 
            this.label_telefonocliente.AutoSize = true;
            this.label_telefonocliente.Location = new System.Drawing.Point(125, 178);
            this.label_telefonocliente.Name = "label_telefonocliente";
            this.label_telefonocliente.Size = new System.Drawing.Size(49, 13);
            this.label_telefonocliente.TabIndex = 4;
            this.label_telefonocliente.Text = "Teléfono";
            // 
            // label_nombrecliente
            // 
            this.label_nombrecliente.AutoSize = true;
            this.label_nombrecliente.Location = new System.Drawing.Point(130, 138);
            this.label_nombrecliente.Name = "label_nombrecliente";
            this.label_nombrecliente.Size = new System.Drawing.Size(44, 13);
            this.label_nombrecliente.TabIndex = 3;
            this.label_nombrecliente.Text = "Nombre";
            // 
            // label_apellidocliente
            // 
            this.label_apellidocliente.AutoSize = true;
            this.label_apellidocliente.Location = new System.Drawing.Point(130, 100);
            this.label_apellidocliente.Name = "label_apellidocliente";
            this.label_apellidocliente.Size = new System.Drawing.Size(44, 13);
            this.label_apellidocliente.TabIndex = 2;
            this.label_apellidocliente.Text = "Apellido";
            // 
            // label_nuevocliente
            // 
            this.label_nuevocliente.AutoSize = true;
            this.label_nuevocliente.Location = new System.Drawing.Point(12, 404);
            this.label_nuevocliente.Name = "label_nuevocliente";
            this.label_nuevocliente.Size = new System.Drawing.Size(74, 13);
            this.label_nuevocliente.TabIndex = 0;
            this.label_nuevocliente.Text = "Nuevo Cliente";
            // 
            // MaxiKiosko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 447);
            this.Controls.Add(this.panel_clientes);
            this.Controls.Add(this.label_maxikiosko);
            this.Controls.Add(this.menuMaxiKiosko);
            this.MainMenuStrip = this.menuMaxiKiosko;
            this.Name = "MaxiKiosko";
            this.Text = "MaxiKiosco Felix";
            this.Load += new System.EventHandler(this.MaxiKiosko_Load);
            this.menuMaxiKiosko.ResumeLayout(false);
            this.menuMaxiKiosko.PerformLayout();
            this.panel_clientes.ResumeLayout(false);
            this.panel_clientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMaxiKiosko;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Label label_maxikiosko;
        private System.Windows.Forms.Panel panel_clientes;
        private System.Windows.Forms.Label label_nuevocliente;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_emailcliente;
        private System.Windows.Forms.TextBox textBox_telefonocliente;
        private System.Windows.Forms.TextBox textBox_nombrecliente;
        private System.Windows.Forms.TextBox textBox_apellidocliente;
        private System.Windows.Forms.Label label_emailcliente;
        private System.Windows.Forms.Label label_telefonocliente;
        private System.Windows.Forms.Label label_nombrecliente;
        private System.Windows.Forms.Label label_apellidocliente;
        private System.Windows.Forms.Button button_clientecancelar;
        private System.Windows.Forms.Button button_clienteguardar;
    }
}

