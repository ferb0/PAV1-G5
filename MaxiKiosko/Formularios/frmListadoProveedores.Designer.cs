namespace MaxiKiosko.Formularios
{
    partial class frmListadoProveedores
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
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.RptViewerProveedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.proveedorTableAdapter = new MaxiKiosko.DataSet.DataSet1TableAdapters.proveedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "proveedor";
            this.proveedorBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(69, 36);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(260, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(363, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(53, 49);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RptViewerProveedores
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.proveedorBindingSource;
            this.RptViewerProveedores.LocalReport.DataSources.Add(reportDataSource1);
            this.RptViewerProveedores.LocalReport.ReportEmbeddedResource = "MaxiKiosko.Reportes.rptProveedores.rdlc";
            this.RptViewerProveedores.Location = new System.Drawing.Point(1, 86);
            this.RptViewerProveedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RptViewerProveedores.Name = "RptViewerProveedores";
            this.RptViewerProveedores.ServerReport.BearerToken = null;
            this.RptViewerProveedores.Size = new System.Drawing.Size(1062, 464);
            this.RptViewerProveedores.TabIndex = 2;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.RptViewerProveedores);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoProveedores";
            this.Text = "Listado de Proveedores";
            this.Load += new System.EventHandler(this.frmListadoProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer RptViewerProveedores;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private DataSet.DataSet1 DataSet1;
        private DataSet.DataSet1TableAdapters.proveedorTableAdapter proveedorTableAdapter;
    }
}