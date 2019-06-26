namespace MaxiKiosko.Formularios
{
    partial class frmListadoComprasPorProveedor
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
            this.dataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.rptCompras = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.cmbBuscar = new System.Windows.Forms.Button();
            this.compraTableAdapter = new MaxiKiosko.DataSet.DataSet1TableAdapters.compraTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // compraBindingSource
            // 
            this.compraBindingSource.DataMember = "compra";
            this.compraBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.rptCompras.Location = new System.Drawing.Point(9, 51);
            this.rptCompras.Margin = new System.Windows.Forms.Padding(2);
            this.rptCompras.Name = "rptCompras";
            this.rptCompras.ServerReport.BearerToken = null;
            this.rptCompras.Size = new System.Drawing.Size(866, 500);
            this.rptCompras.TabIndex = 0;
            // 
            // lbProveedor
            // 
            this.lbProveedor.AutoSize = true;
            this.lbProveedor.Location = new System.Drawing.Point(9, 19);
            this.lbProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProveedor.Name = "lbProveedor";
            this.lbProveedor.Size = new System.Drawing.Size(59, 13);
            this.lbProveedor.TabIndex = 6;
            this.lbProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(72, 16);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(132, 21);
            this.cmbProveedor.TabIndex = 5;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmbBuscar.Location = new System.Drawing.Point(496, 8);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmbBuscar.TabIndex = 12;
            this.cmbBuscar.UseVisualStyleBackColor = true;
            this.cmbBuscar.Click += new System.EventHandler(this.CmbBuscar_Click);
            // 
            // compraTableAdapter
            // 
            this.compraTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(261, 16);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaDesde.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(404, 16);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(86, 20);
            this.dtpFechaHasta.TabIndex = 14;
            // 
            // frmListadoComprasPorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.lbProveedor);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.rptCompras);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListadoComprasPorProveedor";
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.FrmListadoComprasPorProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptCompras;
        private System.Windows.Forms.Label lbProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Button cmbBuscar;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource compraBindingSource;
        private DataSet.DataSet1TableAdapters.compraTableAdapter compraTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
    }
}