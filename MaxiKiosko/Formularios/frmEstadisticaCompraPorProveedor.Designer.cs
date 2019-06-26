namespace MaxiKiosko.Formularios
{
    partial class frmEstadisticaCompraPorProveedor
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
            this.ventasPorDiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.rptVentasPorDia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbBuscar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lbFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ventasPorDiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ventasPorDiaBindingSource
            // 
            this.ventasPorDiaBindingSource.DataMember = "ventas_por_dia";
            this.ventasPorDiaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptVentasPorDia
            // 
            this.rptVentasPorDia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ventasPorDiaBindingSource;
            this.rptVentasPorDia.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVentasPorDia.LocalReport.ReportEmbeddedResource = "MaxiKiosko.Reportes.estCompraPorDia.rdlc";
            this.rptVentasPorDia.Location = new System.Drawing.Point(9, 51);
            this.rptVentasPorDia.Margin = new System.Windows.Forms.Padding(2);
            this.rptVentasPorDia.Name = "rptVentasPorDia";
            this.rptVentasPorDia.ServerReport.BearerToken = null;
            this.rptVentasPorDia.Size = new System.Drawing.Size(866, 500);
            this.rptVentasPorDia.TabIndex = 0;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmbBuscar.Location = new System.Drawing.Point(487, 6);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(40, 40);
            this.cmbBuscar.TabIndex = 16;
            this.cmbBuscar.UseVisualStyleBackColor = true;
            this.cmbBuscar.Click += new System.EventHandler(this.CmbBuscar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(383, 15);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaHasta.TabIndex = 15;
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.AutoSize = true;
            this.lbFechaHasta.Location = new System.Drawing.Point(343, 20);
            this.lbFechaHasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(38, 13);
            this.lbFechaHasta.TabIndex = 14;
            this.lbFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(242, 15);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaDesde.TabIndex = 13;
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(197, 20);
            this.lbFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(41, 13);
            this.lbFechaDesde.TabIndex = 12;
            this.lbFechaDesde.Text = "Desde:";
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(73, 15);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(120, 21);
            this.cmbUsuario.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Proveedor:";
            // 
            // frmEstadisticaCompraPorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lbFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lbFechaDesde);
            this.Controls.Add(this.rptVentasPorDia);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEstadisticaCompraPorProveedor";
            this.Text = "Estaditica Compra por día - Proveedores";
            this.Load += new System.EventHandler(this.FrmEstadisticaVentaPorDiaPorUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasPorDiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVentasPorDia;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ventasPorDiaBindingSource;
        private System.Windows.Forms.Button cmbBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lbFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
    }
}