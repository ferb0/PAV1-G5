namespace MaxiKiosko.Formularios
{
    partial class frmListadoUsuarios
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.rptListadoUsuario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.usuarioTableAdapter = new MaxiKiosko.DataSet.DataSet1TableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptListadoUsuario
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usuarioBindingSource;
            this.rptListadoUsuario.LocalReport.DataSources.Add(reportDataSource1);
            this.rptListadoUsuario.LocalReport.ReportEmbeddedResource = "MaxiKiosko.Reportes.rptUsuario.rdlc";
            this.rptListadoUsuario.Location = new System.Drawing.Point(12, 101);
            this.rptListadoUsuario.Name = "rptListadoUsuario";
            this.rptListadoUsuario.ServerReport.BearerToken = null;
            this.rptListadoUsuario.Size = new System.Drawing.Size(776, 337);
            this.rptListadoUsuario.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(196, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(232, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rptListadoUsuario);
            this.Name = "frmListadoUsuarios";
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.frmListadoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptListadoUsuario;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private DataSet.DataSet1TableAdapters.usuarioTableAdapter usuarioTableAdapter;
    }
}