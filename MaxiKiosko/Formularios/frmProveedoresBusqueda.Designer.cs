namespace MaxiKiosko.Formularios
{
    partial class frmProveedoresBusqueda
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
            this.dataGrid_Proveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Proveedores";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(97, 72);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(268, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress_1);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmdBuscar.Location = new System.Drawing.Point(391, 52);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmdBuscar.TabIndex = 3;
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // dataGrid_Proveedores
            // 
            this.dataGrid_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Proveedores.Location = new System.Drawing.Point(13, 130);
            this.dataGrid_Proveedores.Name = "dataGrid_Proveedores";
            this.dataGrid_Proveedores.ReadOnly = true;
            this.dataGrid_Proveedores.Size = new System.Drawing.Size(553, 203);
            this.dataGrid_Proveedores.TabIndex = 4;
            this.dataGrid_Proveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Proveedores_CellDoubleClick);
            // 
            // frmBusquedaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 345);
            this.Controls.Add(this.dataGrid_Proveedores);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "frmBusquedaProveedores";
            this.Text = "Busqueda de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Proveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridView dataGrid_Proveedores;
    }
}