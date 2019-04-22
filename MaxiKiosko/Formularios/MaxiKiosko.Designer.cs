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
            this.panel_clientenuevo = new System.Windows.Forms.Panel();
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
            this.panel_clienteconsultar = new System.Windows.Forms.Panel();
            this.label_consultarcliente = new System.Windows.Forms.Label();
            this.textBox_consultarcliente = new System.Windows.Forms.TextBox();
            this.button_consultarcliente = new System.Windows.Forms.Button();
            this.label_consultarclientedescripcion = new System.Windows.Forms.Label();
            this.listBox_consultacliente = new System.Windows.Forms.ListBox();
            this.panel_clienteconsultado = new System.Windows.Forms.Panel();
            this.button_clienteconsultadoeliminar = new System.Windows.Forms.Button();
            this.button_clienteconsultadomodificar = new System.Windows.Forms.Button();
            this.textBox_clienteconsultadoemail = new System.Windows.Forms.TextBox();
            this.textBox_clienteconsultadotelefono = new System.Windows.Forms.TextBox();
            this.textBox_clienteconsultadonombre = new System.Windows.Forms.TextBox();
            this.textBox_clienteconsultadoapellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_clienteconsultadocancelar = new System.Windows.Forms.Button();
            this.menuMaxiKiosko.SuspendLayout();
            this.panel_clientenuevo.SuspendLayout();
            this.panel_clienteconsultar.SuspendLayout();
            this.panel_clienteconsultado.SuspendLayout();
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
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
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
            this.label_maxikiosko.Location = new System.Drawing.Point(0, 0);
            this.label_maxikiosko.Name = "label_maxikiosko";
            this.label_maxikiosko.Size = new System.Drawing.Size(513, 447);
            this.label_maxikiosko.TabIndex = 1;
            this.label_maxikiosko.Text = "MaxiKiosko Felix";
            this.label_maxikiosko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_clientenuevo
            // 
            this.panel_clientenuevo.Controls.Add(this.button_clientecancelar);
            this.panel_clientenuevo.Controls.Add(this.button_clienteguardar);
            this.panel_clientenuevo.Controls.Add(this.textBox_emailcliente);
            this.panel_clientenuevo.Controls.Add(this.textBox_telefonocliente);
            this.panel_clientenuevo.Controls.Add(this.textBox_nombrecliente);
            this.panel_clientenuevo.Controls.Add(this.textBox_apellidocliente);
            this.panel_clientenuevo.Controls.Add(this.label_emailcliente);
            this.panel_clientenuevo.Controls.Add(this.label_telefonocliente);
            this.panel_clientenuevo.Controls.Add(this.label_nombrecliente);
            this.panel_clientenuevo.Controls.Add(this.label_apellidocliente);
            this.panel_clientenuevo.Controls.Add(this.label_nuevocliente);
            this.panel_clientenuevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clientenuevo.Location = new System.Drawing.Point(0, 24);
            this.panel_clientenuevo.Name = "panel_clientenuevo";
            this.panel_clientenuevo.Size = new System.Drawing.Size(513, 423);
            this.panel_clientenuevo.TabIndex = 2;
            this.panel_clientenuevo.Visible = false;
            // 
            // button_clientecancelar
            // 
            this.button_clientecancelar.Location = new System.Drawing.Point(225, 247);
            this.button_clientecancelar.Name = "button_clientecancelar";
            this.button_clientecancelar.Size = new System.Drawing.Size(75, 23);
            this.button_clientecancelar.TabIndex = 14;
            this.button_clientecancelar.Text = "Cancelar";
            this.button_clientecancelar.UseVisualStyleBackColor = true;
            this.button_clientecancelar.Click += new System.EventHandler(this.button_clientecancelar_Click);
            // 
            // button_clienteguardar
            // 
            this.button_clienteguardar.Location = new System.Drawing.Point(128, 247);
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
            // panel_clienteconsultar
            // 
            this.panel_clienteconsultar.Controls.Add(this.listBox_consultacliente);
            this.panel_clienteconsultar.Controls.Add(this.label_consultarclientedescripcion);
            this.panel_clienteconsultar.Controls.Add(this.button_consultarcliente);
            this.panel_clienteconsultar.Controls.Add(this.textBox_consultarcliente);
            this.panel_clienteconsultar.Controls.Add(this.label_consultarcliente);
            this.panel_clienteconsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clienteconsultar.Location = new System.Drawing.Point(0, 24);
            this.panel_clienteconsultar.Name = "panel_clienteconsultar";
            this.panel_clienteconsultar.Size = new System.Drawing.Size(513, 423);
            this.panel_clienteconsultar.TabIndex = 15;
            this.panel_clienteconsultar.Visible = false;
            // 
            // label_consultarcliente
            // 
            this.label_consultarcliente.AutoSize = true;
            this.label_consultarcliente.Location = new System.Drawing.Point(3, 404);
            this.label_consultarcliente.Name = "label_consultarcliente";
            this.label_consultarcliente.Size = new System.Drawing.Size(86, 13);
            this.label_consultarcliente.TabIndex = 0;
            this.label_consultarcliente.Text = "Consultar Cliente";
            // 
            // textBox_consultarcliente
            // 
            this.textBox_consultarcliente.Location = new System.Drawing.Point(98, 115);
            this.textBox_consultarcliente.Name = "textBox_consultarcliente";
            this.textBox_consultarcliente.Size = new System.Drawing.Size(197, 20);
            this.textBox_consultarcliente.TabIndex = 1;
            // 
            // button_consultarcliente
            // 
            this.button_consultarcliente.Location = new System.Drawing.Point(301, 115);
            this.button_consultarcliente.Name = "button_consultarcliente";
            this.button_consultarcliente.Size = new System.Drawing.Size(75, 23);
            this.button_consultarcliente.TabIndex = 2;
            this.button_consultarcliente.Text = "Consultar";
            this.button_consultarcliente.UseVisualStyleBackColor = true;
            this.button_consultarcliente.Click += new System.EventHandler(this.button_consultarcliente_Click);
            // 
            // label_consultarclientedescripcion
            // 
            this.label_consultarclientedescripcion.AutoSize = true;
            this.label_consultarclientedescripcion.Location = new System.Drawing.Point(95, 84);
            this.label_consultarclientedescripcion.Name = "label_consultarclientedescripcion";
            this.label_consultarclientedescripcion.Size = new System.Drawing.Size(281, 13);
            this.label_consultarclientedescripcion.TabIndex = 3;
            this.label_consultarclientedescripcion.Text = "Ingrese dato a buscar (Nombre, Apellido, Email, Telefono).";
            // 
            // listBox_consultacliente
            // 
            this.listBox_consultacliente.FormattingEnabled = true;
            this.listBox_consultacliente.Location = new System.Drawing.Point(98, 175);
            this.listBox_consultacliente.Name = "listBox_consultacliente";
            this.listBox_consultacliente.Size = new System.Drawing.Size(197, 147);
            this.listBox_consultacliente.TabIndex = 4;
            this.listBox_consultacliente.SelectedIndexChanged += new System.EventHandler(this.listBox_consultacliente_SelectedIndexChanged);
            // 
            // panel_clienteconsultado
            // 
            this.panel_clienteconsultado.Controls.Add(this.button_clienteconsultadocancelar);
            this.panel_clienteconsultado.Controls.Add(this.button_clienteconsultadoeliminar);
            this.panel_clienteconsultado.Controls.Add(this.button_clienteconsultadomodificar);
            this.panel_clienteconsultado.Controls.Add(this.textBox_clienteconsultadoemail);
            this.panel_clienteconsultado.Controls.Add(this.textBox_clienteconsultadotelefono);
            this.panel_clienteconsultado.Controls.Add(this.textBox_clienteconsultadonombre);
            this.panel_clienteconsultado.Controls.Add(this.textBox_clienteconsultadoapellido);
            this.panel_clienteconsultado.Controls.Add(this.label1);
            this.panel_clienteconsultado.Controls.Add(this.label2);
            this.panel_clienteconsultado.Controls.Add(this.label3);
            this.panel_clienteconsultado.Controls.Add(this.label4);
            this.panel_clienteconsultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_clienteconsultado.Location = new System.Drawing.Point(0, 24);
            this.panel_clienteconsultado.Name = "panel_clienteconsultado";
            this.panel_clienteconsultado.Size = new System.Drawing.Size(513, 423);
            this.panel_clienteconsultado.TabIndex = 5;
            this.panel_clienteconsultado.Visible = false;
            // 
            // button_clienteconsultadoeliminar
            // 
            this.button_clienteconsultadoeliminar.Location = new System.Drawing.Point(220, 247);
            this.button_clienteconsultadoeliminar.Name = "button_clienteconsultadoeliminar";
            this.button_clienteconsultadoeliminar.Size = new System.Drawing.Size(75, 23);
            this.button_clienteconsultadoeliminar.TabIndex = 24;
            this.button_clienteconsultadoeliminar.Text = "Eliminar";
            this.button_clienteconsultadoeliminar.UseVisualStyleBackColor = true;
            // 
            // button_clienteconsultadomodificar
            // 
            this.button_clienteconsultadomodificar.Location = new System.Drawing.Point(128, 247);
            this.button_clienteconsultadomodificar.Name = "button_clienteconsultadomodificar";
            this.button_clienteconsultadomodificar.Size = new System.Drawing.Size(75, 23);
            this.button_clienteconsultadomodificar.TabIndex = 23;
            this.button_clienteconsultadomodificar.Text = "Modificar";
            this.button_clienteconsultadomodificar.UseVisualStyleBackColor = true;
            // 
            // textBox_clienteconsultadoemail
            // 
            this.textBox_clienteconsultadoemail.Location = new System.Drawing.Point(200, 212);
            this.textBox_clienteconsultadoemail.Name = "textBox_clienteconsultadoemail";
            this.textBox_clienteconsultadoemail.Size = new System.Drawing.Size(100, 20);
            this.textBox_clienteconsultadoemail.TabIndex = 22;
            // 
            // textBox_clienteconsultadotelefono
            // 
            this.textBox_clienteconsultadotelefono.Location = new System.Drawing.Point(200, 172);
            this.textBox_clienteconsultadotelefono.Name = "textBox_clienteconsultadotelefono";
            this.textBox_clienteconsultadotelefono.Size = new System.Drawing.Size(100, 20);
            this.textBox_clienteconsultadotelefono.TabIndex = 21;
            // 
            // textBox_clienteconsultadonombre
            // 
            this.textBox_clienteconsultadonombre.Location = new System.Drawing.Point(200, 135);
            this.textBox_clienteconsultadonombre.Name = "textBox_clienteconsultadonombre";
            this.textBox_clienteconsultadonombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_clienteconsultadonombre.TabIndex = 20;
            // 
            // textBox_clienteconsultadoapellido
            // 
            this.textBox_clienteconsultadoapellido.Location = new System.Drawing.Point(200, 97);
            this.textBox_clienteconsultadoapellido.Name = "textBox_clienteconsultadoapellido";
            this.textBox_clienteconsultadoapellido.Size = new System.Drawing.Size(100, 20);
            this.textBox_clienteconsultadoapellido.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellido";
            // 
            // button_clienteconsultadocancelar
            // 
            this.button_clienteconsultadocancelar.Location = new System.Drawing.Point(317, 247);
            this.button_clienteconsultadocancelar.Name = "button_clienteconsultadocancelar";
            this.button_clienteconsultadocancelar.Size = new System.Drawing.Size(75, 23);
            this.button_clienteconsultadocancelar.TabIndex = 25;
            this.button_clienteconsultadocancelar.Text = "Cancelar";
            this.button_clienteconsultadocancelar.UseVisualStyleBackColor = true;
            this.button_clienteconsultadocancelar.Click += new System.EventHandler(this.button_clienteconsultadocancelar_Click);
            // 
            // MaxiKiosko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 447);
            this.Controls.Add(this.panel_clienteconsultar);
            this.Controls.Add(this.panel_clienteconsultado);
            this.Controls.Add(this.panel_clientenuevo);
            this.Controls.Add(this.menuMaxiKiosko);
            this.Controls.Add(this.label_maxikiosko);
            this.MainMenuStrip = this.menuMaxiKiosko;
            this.Name = "MaxiKiosko";
            this.Text = "MaxiKiosco Felix";
            this.Load += new System.EventHandler(this.MaxiKiosko_Load);
            this.menuMaxiKiosko.ResumeLayout(false);
            this.menuMaxiKiosko.PerformLayout();
            this.panel_clientenuevo.ResumeLayout(false);
            this.panel_clientenuevo.PerformLayout();
            this.panel_clienteconsultar.ResumeLayout(false);
            this.panel_clienteconsultar.PerformLayout();
            this.panel_clienteconsultado.ResumeLayout(false);
            this.panel_clienteconsultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMaxiKiosko;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Label label_maxikiosko;
        private System.Windows.Forms.Panel panel_clientenuevo;
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
        private System.Windows.Forms.Panel panel_clienteconsultar;
        private System.Windows.Forms.Label label_consultarcliente;
        private System.Windows.Forms.Label label_consultarclientedescripcion;
        private System.Windows.Forms.Button button_consultarcliente;
        private System.Windows.Forms.TextBox textBox_consultarcliente;
        private System.Windows.Forms.ListBox listBox_consultacliente;
        private System.Windows.Forms.Panel panel_clienteconsultado;
        private System.Windows.Forms.Button button_clienteconsultadoeliminar;
        private System.Windows.Forms.Button button_clienteconsultadomodificar;
        private System.Windows.Forms.TextBox textBox_clienteconsultadoemail;
        private System.Windows.Forms.TextBox textBox_clienteconsultadotelefono;
        private System.Windows.Forms.TextBox textBox_clienteconsultadonombre;
        private System.Windows.Forms.TextBox textBox_clienteconsultadoapellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_clienteconsultadocancelar;
    }
}

