namespace MaxiKiosko.Formularios
{
    partial class frmListadoVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MaxiKiosko.DataSet.DataSet1();
            this.spRptVentasTableAdapter = new MaxiKiosko.DataSet.DataSet1TableAdapters.spRptVentasTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.dataSet1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MaxiKiosko.Reportes.rptVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 104);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(812, 418);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataMember = "spRptVentas";
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spRptVentasTableAdapter
            // 
            this.spRptVentasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dateTimePickerHasta);
            this.groupBox1.Controls.Add(this.lblFechaHasta);
            this.groupBox1.Controls.Add(this.dateTimePickerDesde);
            this.groupBox1.Controls.Add(this.lblFechaDesde);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rango de Fechas";
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(219, 38);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDesde.Location = new System.Drawing.Point(296, 33);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(78, 20);
            this.dateTimePickerDesde.TabIndex = 1;
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(414, 38);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 0;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerHasta.Location = new System.Drawing.Point(488, 32);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(78, 20);
            this.dateTimePickerHasta.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::MaxiKiosko.Properties.Resources.search;
            this.btnBuscar.Location = new System.Drawing.Point(598, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(40, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListadoVentas";
            this.Text = "Listado de Ventas";
            this.Load += new System.EventHandler(this.frmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet.DataSet1 dataSet1;
        private DataSet.DataSet1TableAdapters.spRptVentasTableAdapter spRptVentasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Button btnBuscar;
    }
}