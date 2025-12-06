namespace ProyectoPOS_1CA_A
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuSuperior = new System.Windows.Forms.MenuStrip();
            this.gestiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoríaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCategoríasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoMasVendidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saliirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarClaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCorteCaja = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentaRapida = new System.Windows.Forms.Button();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.logoPOS = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.menuSuperior.SuspendLayout();
            this.panelIzquierdo.SuspendLayout();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPOS)).BeginInit();
            this.SuspendLayout();
            // 
            // menuSuperior
            // 
            this.menuSuperior.BackColor = System.Drawing.Color.LightGray;
            this.menuSuperior.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.saliirToolStripMenuItem,
            this.cambiarClaveToolStripMenuItem});
            this.menuSuperior.Location = new System.Drawing.Point(0, 0);
            this.menuSuperior.Name = "menuSuperior";
            this.menuSuperior.Size = new System.Drawing.Size(784, 27);
            this.menuSuperior.TabIndex = 0;
            this.menuSuperior.Text = "menuStrip1";
            // 
            // gestiónToolStripMenuItem
            // 
            this.gestiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.categoríasToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestiónToolStripMenuItem.Name = "gestiónToolStripMenuItem";
            this.gestiónToolStripMenuItem.Size = new System.Drawing.Size(68, 23);
            this.gestiónToolStripMenuItem.Text = "Gestión";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductoToolStripMenuItem,
            this.verProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // agregarProductoToolStripMenuItem
            // 
            this.agregarProductoToolStripMenuItem.Name = "agregarProductoToolStripMenuItem";
            this.agregarProductoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.agregarProductoToolStripMenuItem.Text = "Agregar Producto";
            // 
            // verProductosToolStripMenuItem
            // 
            this.verProductosToolStripMenuItem.Name = "verProductosToolStripMenuItem";
            this.verProductosToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.verProductosToolStripMenuItem.Text = "Ver Productos";
            // 
            // categoríasToolStripMenuItem
            // 
            this.categoríasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCategoríaToolStripMenuItem,
            this.verCategoríasToolStripMenuItem});
            this.categoríasToolStripMenuItem.Name = "categoríasToolStripMenuItem";
            this.categoríasToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.categoríasToolStripMenuItem.Text = "Categorías";
            // 
            // agregarCategoríaToolStripMenuItem
            // 
            this.agregarCategoríaToolStripMenuItem.Name = "agregarCategoríaToolStripMenuItem";
            this.agregarCategoríaToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.agregarCategoríaToolStripMenuItem.Text = "Agregar Categoría";
            // 
            // verCategoríasToolStripMenuItem
            // 
            this.verCategoríasToolStripMenuItem.Name = "verCategoríasToolStripMenuItem";
            this.verCategoríasToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.verCategoríasToolStripMenuItem.Text = "Ver Categorías";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.verClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente";
            // 
            // verClientesToolStripMenuItem
            // 
            this.verClientesToolStripMenuItem.Name = "verClientesToolStripMenuItem";
            this.verClientesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.verClientesToolStripMenuItem.Text = "Ver Clientes";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVentaToolStripMenuItem,
            this.historialDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(62, 23);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // registrarVentaToolStripMenuItem
            // 
            this.registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            this.registrarVentaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.registrarVentaToolStripMenuItem.Text = "Registrar Venta";
            // 
            // historialDeVentasToolStripMenuItem
            // 
            this.historialDeVentasToolStripMenuItem.Name = "historialDeVentasToolStripMenuItem";
            this.historialDeVentasToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.historialDeVentasToolStripMenuItem.Text = "Historial de Ventas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDiarioToolStripMenuItem,
            this.productoMasVendidoToolStripMenuItem,
            this.cierreDeCajaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDiarioToolStripMenuItem
            // 
            this.reporteDiarioToolStripMenuItem.Name = "reporteDiarioToolStripMenuItem";
            this.reporteDiarioToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.reporteDiarioToolStripMenuItem.Text = "Reporte Diario";
            // 
            // productoMasVendidoToolStripMenuItem
            // 
            this.productoMasVendidoToolStripMenuItem.Name = "productoMasVendidoToolStripMenuItem";
            this.productoMasVendidoToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.productoMasVendidoToolStripMenuItem.Text = "Producto mas vendido";
            // 
            // cierreDeCajaToolStripMenuItem
            // 
            this.cierreDeCajaToolStripMenuItem.Name = "cierreDeCajaToolStripMenuItem";
            this.cierreDeCajaToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.cierreDeCajaToolStripMenuItem.Text = "Cierre de Caja";
            // 
            // saliirToolStripMenuItem
            // 
            this.saliirToolStripMenuItem.Name = "saliirToolStripMenuItem";
            this.saliirToolStripMenuItem.Size = new System.Drawing.Size(49, 23);
            this.saliirToolStripMenuItem.Text = "Saliir";
            // 
            // cambiarClaveToolStripMenuItem
            // 
            this.cambiarClaveToolStripMenuItem.Name = "cambiarClaveToolStripMenuItem";
            this.cambiarClaveToolStripMenuItem.Size = new System.Drawing.Size(109, 23);
            this.cambiarClaveToolStripMenuItem.Text = "Cambiar Clave";
            this.cambiarClaveToolStripMenuItem.Click += new System.EventHandler(this.cambiarClaveToolStripMenuItem_Click);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.SaddleBrown;
            this.panelIzquierdo.Controls.Add(this.btnReportes);
            this.panelIzquierdo.Controls.Add(this.btnUsuario);
            this.panelIzquierdo.Controls.Add(this.btnSalir);
            this.panelIzquierdo.Controls.Add(this.btnCorteCaja);
            this.panelIzquierdo.Controls.Add(this.btnInventario);
            this.panelIzquierdo.Controls.Add(this.btnClientes);
            this.panelIzquierdo.Controls.Add(this.btnProductos);
            this.panelIzquierdo.Controls.Add(this.btnVentaRapida);
            this.panelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierdo.Location = new System.Drawing.Point(0, 27);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(200, 534);
            this.panelIzquierdo.TabIndex = 1;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Bisque;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Location = new System.Drawing.Point(10, 323);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(180, 42);
            this.btnUsuario.TabIndex = 6;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Bisque;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(10, 440);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Cerrar sesión";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCorteCaja
            // 
            this.btnCorteCaja.BackColor = System.Drawing.Color.Bisque;
            this.btnCorteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCorteCaja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCorteCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCorteCaja.Image")));
            this.btnCorteCaja.Location = new System.Drawing.Point(10, 262);
            this.btnCorteCaja.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnCorteCaja.Name = "btnCorteCaja";
            this.btnCorteCaja.Size = new System.Drawing.Size(180, 41);
            this.btnCorteCaja.TabIndex = 4;
            this.btnCorteCaja.Text = "Corte de Caja";
            this.btnCorteCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorteCaja.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.Bisque;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.Location = new System.Drawing.Point(10, 201);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(180, 41);
            this.btnInventario.TabIndex = 3;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Bisque;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(10, 139);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(180, 42);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Bisque;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(12, 76);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(180, 43);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVentaRapida
            // 
            this.btnVentaRapida.BackColor = System.Drawing.Color.Bisque;
            this.btnVentaRapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentaRapida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentaRapida.Image = ((System.Drawing.Image)(resources.GetObject("btnVentaRapida.Image")));
            this.btnVentaRapida.Location = new System.Drawing.Point(12, 14);
            this.btnVentaRapida.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnVentaRapida.Name = "btnVentaRapida";
            this.btnVentaRapida.Size = new System.Drawing.Size(180, 42);
            this.btnVentaRapida.TabIndex = 0;
            this.btnVentaRapida.Text = "Venta Rápida";
            this.btnVentaRapida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentaRapida.UseVisualStyleBackColor = false;
            this.btnVentaRapida.Click += new System.EventHandler(this.btnVentaRapida_Click);
            // 
            // panelCentral
            // 
            this.panelCentral.Controls.Add(this.lblUsuario);
            this.panelCentral.Controls.Add(this.logoPOS);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Location = new System.Drawing.Point(200, 27);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(584, 534);
            this.panelCentral.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(426, 14);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "label1";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // logoPOS
            // 
            this.logoPOS.Image = global::ProyectoPOS_1CA_A.Properties.Resources.Gemini_Generated_Image_u3u1r0u3u1r0u3u1;
            this.logoPOS.Location = new System.Drawing.Point(17, 46);
            this.logoPOS.Name = "logoPOS";
            this.logoPOS.Size = new System.Drawing.Size(555, 383);
            this.logoPOS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPOS.TabIndex = 0;
            this.logoPOS.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Bisque;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Location = new System.Drawing.Point(10, 378);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(180, 42);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "REPORTES";
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelIzquierdo);
            this.Controls.Add(this.menuSuperior);
            this.MainMenuStrip = this.menuSuperior;
            this.MaximizeBox = false;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema POS Cafeteria Dulce Aroma";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuSuperior.ResumeLayout(false);
            this.menuSuperior.PerformLayout();
            this.panelIzquierdo.ResumeLayout(false);
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSuperior;
        private System.Windows.Forms.ToolStripMenuItem gestiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoríaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCategoríasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoMasVendidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saliirToolStripMenuItem;
        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.Button btnVentaRapida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCorteCaja;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.PictureBox logoPOS;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem cambiarClaveToolStripMenuItem;
        private System.Windows.Forms.Button btnReportes;
    }
}

