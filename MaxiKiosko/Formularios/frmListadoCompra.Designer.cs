namespace MaxiKiosko.Formularios
{
    partial class frmListadoCompra
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
            this.compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.rptCompras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.compraTableAdapter = new MaxiKiosko.DataSet.DataSet1TableAdapters.compraTableAdapter();
            this.cmbBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptCompras
            // 
            this.rptCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.compraBindingSource;
            this.rptCompras.LocalReport.DataSources.Add(reportDataSource1);
            this.rptCompras.LocalReport.ReportEmbeddedResource = "MaxiKiosko.Reportes.rptComprasPorProveedor.rdlc";
            this.rptCompras.Location = new System.Drawing.Point(9, 56);
            this.rptCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rptCompras.Name = "rptCompras";
            this.rptCompras.ServerReport.BearerToken = null;
            this.rptCompras.Size = new System.Drawing.Size(871, 495);
            this.rptCompras.TabIndex = 0;
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(10, 20);
            this.lbFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lbFechaDesde.TabIndex = 5;
            this.lbFechaDesde.Text = "Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(55, 20);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.AutoSize = true;
            this.lbFechaHasta.Location = new System.Drawing.Point(155, 20);
            this.lbFechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lbFechaHasta.TabIndex = 7;
            this.lbFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(196, 20);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmbBuscar.Location = new System.Drawing.Point(320, 11);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmbBuscar.TabIndex = 11;
            this.cmbBuscar.UseVisualStyleBackColor = true;
            this.cmbBuscar.Click += new System.EventHandler(this.CmbBuscar_Click);
            // 
            // frmListadoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lbFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lbFechaDesde);
            this.Controls.Add(this.rptCompras);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListadoCompra";
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCompras;
        private DataSet.DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private DataSet.DataSet1TableAdapters.compraTableAdapter compraTableAdapter;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lbFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Button cmbBuscar;
    }
}