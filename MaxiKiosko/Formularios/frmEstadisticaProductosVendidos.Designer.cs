namespace MaxiKiosko.Formularios
{
    partial class frmEstadisticaProductosVendidos
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
            this.tipoProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.rptTipoProductosVendidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbBuscar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lbFechaHasta = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoProductosBindingSource
            // 
            this.tipoProductosBindingSource.DataMember = "tipo_productos_vendidos";
            this.tipoProductosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptTipoProductosVendidos
            // 
            this.rptTipoProductosVendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tipoProductosBindingSource;
            this.rptTipoProductosVendidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rptTipoProductosVendidos.LocalReport.ReportEmbeddedResource = "MaxiKiosko.Reportes.estProductosVendidos.rdlc";
            this.rptTipoProductosVendidos.Location = new System.Drawing.Point(12, 63);
            this.rptTipoProductosVendidos.Name = "rptTipoProductosVendidos";
            this.rptTipoProductosVendidos.ServerReport.BearerToken = null;
            this.rptTipoProductosVendidos.Size = new System.Drawing.Size(776, 375);
            this.rptTipoProductosVendidos.TabIndex = 0;
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.cmbBuscar.Location = new System.Drawing.Point(424, 7);
            this.cmbBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(53, 49);
            this.cmbBuscar.TabIndex = 16;
            this.cmbBuscar.UseVisualStyleBackColor = true;
            this.cmbBuscar.Click += new System.EventHandler(this.CmbBuscar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(259, 18);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(131, 22);
            this.dtpFechaHasta.TabIndex = 15;
            // 
            // lbFechaHasta
            // 
            this.lbFechaHasta.AutoSize = true;
            this.lbFechaHasta.Location = new System.Drawing.Point(204, 19);
            this.lbFechaHasta.Name = "lbFechaHasta";
            this.lbFechaHasta.Size = new System.Drawing.Size(49, 17);
            this.lbFechaHasta.TabIndex = 14;
            this.lbFechaHasta.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(70, 18);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(128, 22);
            this.dtpFechaDesde.TabIndex = 13;
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.Location = new System.Drawing.Point(10, 19);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(53, 17);
            this.lbFechaDesde.TabIndex = 12;
            this.lbFechaDesde.Text = "Desde:";
            // 
            // frmEstadisticaProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.lbFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Controls.Add(this.lbFechaDesde);
            this.Controls.Add(this.rptTipoProductosVendidos);
            this.Name = "frmEstadisticaProductosVendidos";
            this.Text = "Estadisticas de Producto";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptTipoProductosVendidos;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tipoProductosBindingSource;
        private System.Windows.Forms.Button cmbBuscar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lbFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lbFechaDesde;
    }
}