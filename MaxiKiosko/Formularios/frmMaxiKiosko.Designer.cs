namespace MaxiKiosko
{
    partial class frmMaxiKiosko
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
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasRealizadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosConStockFaltanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeComprasPorProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaVentasPorDíaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaVentasPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaVentasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formaDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_maxikiosko = new System.Windows.Forms.Label();
            this.listadoDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuMaxiKiosko.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMaxiKiosko
            // 
            this.menuMaxiKiosko.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMaxiKiosko.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.productosToolStripMenuItem1,
            this.informesToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuMaxiKiosko.Location = new System.Drawing.Point(0, 0);
            this.menuMaxiKiosko.Name = "menuMaxiKiosko";
            this.menuMaxiKiosko.Size = new System.Drawing.Size(513, 24);
            this.menuMaxiKiosko.TabIndex = 0;
            this.menuMaxiKiosko.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.ventasConsultaToolStripMenuItem,
            this.clientesToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // ventasConsultaToolStripMenuItem
            // 
            this.ventasConsultaToolStripMenuItem.Name = "ventasConsultaToolStripMenuItem";
            this.ventasConsultaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ventasConsultaToolStripMenuItem.Text = "Ventas Realizadas";
            this.ventasConsultaToolStripMenuItem.Click += new System.EventHandler(this.ventasConsultaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.ClientesToolStripMenuItem1_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeComprasToolStripMenuItem,
            this.comprasRealizadasToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // ingresoDeComprasToolStripMenuItem
            // 
            this.ingresoDeComprasToolStripMenuItem.Name = "ingresoDeComprasToolStripMenuItem";
            this.ingresoDeComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresoDeComprasToolStripMenuItem.Text = "Ingreso de Compras";
            this.ingresoDeComprasToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeComprasToolStripMenuItem_Click);
            // 
            // comprasRealizadasToolStripMenuItem
            // 
            this.comprasRealizadasToolStripMenuItem.Name = "comprasRealizadasToolStripMenuItem";
            this.comprasRealizadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprasRealizadasToolStripMenuItem.Text = "Compras Realizadas";
            this.comprasRealizadasToolStripMenuItem.Click += new System.EventHandler(this.comprasRealizadasToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.ProveedoresToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.tipoProductosToolStripMenuItem});
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem1.Text = "Productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItem_Click);
            // 
            // tipoProductosToolStripMenuItem
            // 
            this.tipoProductosToolStripMenuItem.Name = "tipoProductosToolStripMenuItem";
            this.tipoProductosToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.tipoProductosToolStripMenuItem.Text = "Tipo Productos";
            this.tipoProductosToolStripMenuItem.Click += new System.EventHandler(this.TipoProductosToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeDeVentasToolStripMenuItem,
            this.informeDeComprasToolStripMenuItem,
            this.informeDeProductosToolStripMenuItem,
            this.productosConStockFaltanteToolStripMenuItem,
            this.listadoDeClientesToolStripMenuItem,
            this.listadoDeProveedoresToolStripMenuItem,
            this.listadoDeUsuariosToolStripMenuItem,
            this.informeDeComprasPorProveedorToolStripMenuItem,
            this.consultaDeStockToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.informesToolStripMenuItem.Text = "Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // informeDeVentasToolStripMenuItem
            // 
            this.informeDeVentasToolStripMenuItem.Name = "informeDeVentasToolStripMenuItem";
            this.informeDeVentasToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.informeDeVentasToolStripMenuItem.Text = "Informe de Ventas";
            this.informeDeVentasToolStripMenuItem.Click += new System.EventHandler(this.informeDeVentasToolStripMenuItem_Click);
            // 
            // informeDeComprasToolStripMenuItem
            // 
            this.informeDeComprasToolStripMenuItem.Name = "informeDeComprasToolStripMenuItem";
            this.informeDeComprasToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.informeDeComprasToolStripMenuItem.Text = "Informe de Compras por fechas";
            this.informeDeComprasToolStripMenuItem.Click += new System.EventHandler(this.InformeDeComprasToolStripMenuItem_Click);
            // 
            // informeDeProductosToolStripMenuItem
            // 
            this.informeDeProductosToolStripMenuItem.Name = "informeDeProductosToolStripMenuItem";
            this.informeDeProductosToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.informeDeProductosToolStripMenuItem.Text = "Informe de Productos";
            this.informeDeProductosToolStripMenuItem.Click += new System.EventHandler(this.informeDeProductosToolStripMenuItem_Click);
            // 
            // productosConStockFaltanteToolStripMenuItem
            // 
            this.productosConStockFaltanteToolStripMenuItem.Name = "productosConStockFaltanteToolStripMenuItem";
            this.productosConStockFaltanteToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.productosConStockFaltanteToolStripMenuItem.Text = "Productos con Stock Faltante";
            this.productosConStockFaltanteToolStripMenuItem.Click += new System.EventHandler(this.productosConStockFaltanteToolStripMenuItem_Click);
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            this.listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            this.listadoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeClientesToolStripMenuItem.Text = "Listado de Clientes";
            this.listadoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesToolStripMenuItem_Click);
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Listado de Usuarios";
            this.listadoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeUsuariosToolStripMenuItem_Click);
            // 
            // informeDeComprasPorProveedorToolStripMenuItem
            // 
            this.informeDeComprasPorProveedorToolStripMenuItem.Name = "informeDeComprasPorProveedorToolStripMenuItem";
            this.informeDeComprasPorProveedorToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.informeDeComprasPorProveedorToolStripMenuItem.Text = "Informe de Compras Por Proveedor";
            this.informeDeComprasPorProveedorToolStripMenuItem.Click += new System.EventHandler(this.InformeDeComprasPorProveedorToolStripMenuItem_Click);
            // 
            // consultaDeStockToolStripMenuItem
            // 
            this.consultaDeStockToolStripMenuItem.Name = "consultaDeStockToolStripMenuItem";
            this.consultaDeStockToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.consultaDeStockToolStripMenuItem.Text = "Consulta de Stock";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticaVentasPorDíaToolStripMenuItem,
            this.estadisticaVentasPorUsuarioToolStripMenuItem,
            this.estadisticaVentasPorClienteToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // estadisticaVentasPorDíaToolStripMenuItem
            // 
            this.estadisticaVentasPorDíaToolStripMenuItem.Name = "estadisticaVentasPorDíaToolStripMenuItem";
            this.estadisticaVentasPorDíaToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.estadisticaVentasPorDíaToolStripMenuItem.Text = "Estadistica ventas por día";
            this.estadisticaVentasPorDíaToolStripMenuItem.Click += new System.EventHandler(this.EstadisticaVentasPorDíaToolStripMenuItem_Click);
            // 
            // estadisticaVentasPorUsuarioToolStripMenuItem
            // 
            this.estadisticaVentasPorUsuarioToolStripMenuItem.Name = "estadisticaVentasPorUsuarioToolStripMenuItem";
            this.estadisticaVentasPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.estadisticaVentasPorUsuarioToolStripMenuItem.Text = "Estadistica ventas por usuario";
            this.estadisticaVentasPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.EstadisticaVentasPorUsuarioToolStripMenuItem_Click);
            // 
            // estadisticaVentasPorClienteToolStripMenuItem
            // 
            this.estadisticaVentasPorClienteToolStripMenuItem.Name = "estadisticaVentasPorClienteToolStripMenuItem";
            this.estadisticaVentasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.estadisticaVentasPorClienteToolStripMenuItem.Text = "Estadistica ventas por cliente";
            this.estadisticaVentasPorClienteToolStripMenuItem.Click += new System.EventHandler(this.EstadisticaVentasPorClienteToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formaDePagoToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // formaDePagoToolStripMenuItem
            // 
            this.formaDePagoToolStripMenuItem.Name = "formaDePagoToolStripMenuItem";
            this.formaDePagoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.formaDePagoToolStripMenuItem.Text = "Forma de Pago";
            this.formaDePagoToolStripMenuItem.Click += new System.EventHandler(this.FormaDePagoToolStripMenuItem_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem4});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // aBMToolStripMenuItem4
            // 
            this.aBMToolStripMenuItem4.Name = "aBMToolStripMenuItem4";
            this.aBMToolStripMenuItem4.Size = new System.Drawing.Size(100, 22);
            this.aBMToolStripMenuItem4.Text = "ABM";
            this.aBMToolStripMenuItem4.Click += new System.EventHandler(this.aBMToolStripMenuItem4_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem5});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // aBMToolStripMenuItem5
            // 
            this.aBMToolStripMenuItem5.Name = "aBMToolStripMenuItem5";
            this.aBMToolStripMenuItem5.Size = new System.Drawing.Size(100, 22);
            this.aBMToolStripMenuItem5.Text = "ABM";
            this.aBMToolStripMenuItem5.Click += new System.EventHandler(this.aBMToolStripMenuItem5_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
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
            // listadoDeProveedoresToolStripMenuItem
            // 
            this.listadoDeProveedoresToolStripMenuItem.Name = "listadoDeProveedoresToolStripMenuItem";
            this.listadoDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(261, 22);
            this.listadoDeProveedoresToolStripMenuItem.Text = "Listado de Proveedores";
            this.listadoDeProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeProveedoresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MaxiKiosko.Properties.Resources.MaxikioskoFelixLogo;
            this.pictureBox1.Location = new System.Drawing.Point(130, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmMaxiKiosko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuMaxiKiosko);
            this.Controls.Add(this.label_maxikiosko);
            this.MainMenuStrip = this.menuMaxiKiosko;
            this.Name = "frmMaxiKiosko";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: MaxiKiosco Felix ::.";
            this.Load += new System.EventHandler(this.MaxiKiosko_Load);
            this.menuMaxiKiosko.ResumeLayout(false);
            this.menuMaxiKiosko.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuMaxiKiosko;
    private System.Windows.Forms.Label label_maxikiosko;
    private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ingresoDeComprasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informeDeVentasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informeDeComprasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consultaDeStockToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tipoProductosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem formaDePagoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem ventasConsultaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem comprasRealizadasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informeDeProductosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem productosConStockFaltanteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listadoDeClientesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem informeDeComprasPorProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaVentasPorDíaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaVentasPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaVentasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

