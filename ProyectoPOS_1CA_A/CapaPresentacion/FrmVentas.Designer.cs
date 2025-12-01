namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    partial class FrmVentas
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

        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.labelCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.labelTipoPago = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBoxProductos = new System.Windows.Forms.GroupBox();
            this.labelFiltrar = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupBoxDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiarDetalle = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBoxDatos.SuspendLayout();
            this.groupBoxProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBoxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.Location = new System.Drawing.Point(0, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(1200, 60);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "FORMULARIO POS - REGISTRO DE VENTAS";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.labelCliente);
            this.groupBoxDatos.Controls.Add(this.cboCliente);
            this.groupBoxDatos.Controls.Add(this.btnNuevoCliente);
            this.groupBoxDatos.Controls.Add(this.labelTipoPago);
            this.groupBoxDatos.Controls.Add(this.cboTipoPago);
            this.groupBoxDatos.Controls.Add(this.labelFecha);
            this.groupBoxDatos.Controls.Add(this.dtpFecha);
            this.groupBoxDatos.Location = new System.Drawing.Point(20, 70);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(1150, 90);
            this.groupBoxDatos.TabIndex = 1;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "DATOS GENERALES DE LA VENTA";
            // 
            // labelCliente
            // 
            this.labelCliente.Location = new System.Drawing.Point(15, 30);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(59, 23);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "CLIENTE:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Location = new System.Drawing.Point(80, 27);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(250, 21);
            this.cboCliente.TabIndex = 1;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightGreen;
            this.btnNuevoCliente.Location = new System.Drawing.Point(340, 26);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(80, 24);
            this.btnNuevoCliente.TabIndex = 2;
            this.btnNuevoCliente.Text = "NUEVO";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // labelTipoPago
            // 
            this.labelTipoPago.Location = new System.Drawing.Point(450, 30);
            this.labelTipoPago.Name = "labelTipoPago";
            this.labelTipoPago.Size = new System.Drawing.Size(100, 23);
            this.labelTipoPago.TabIndex = 3;
            this.labelTipoPago.Text = "TIPO DE PAGO:";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoPago.Location = new System.Drawing.Point(550, 27);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(150, 21);
            this.cboTipoPago.TabIndex = 4;
            // 
            // labelFecha
            // 
            this.labelFecha.Location = new System.Drawing.Point(727, 27);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(67, 23);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "FECHA:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(800, 27);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 6;
            // 
            // groupBoxProductos
            // 
            this.groupBoxProductos.Controls.Add(this.labelFiltrar);
            this.groupBoxProductos.Controls.Add(this.txtBuscarProducto);
            this.groupBoxProductos.Controls.Add(this.btnBuscarProducto);
            this.groupBoxProductos.Controls.Add(this.dgvProductos);
            this.groupBoxProductos.Controls.Add(this.btnAgregarProducto);
            this.groupBoxProductos.Location = new System.Drawing.Point(20, 170);
            this.groupBoxProductos.Name = "groupBoxProductos";
            this.groupBoxProductos.Size = new System.Drawing.Size(550, 350);
            this.groupBoxProductos.TabIndex = 2;
            this.groupBoxProductos.TabStop = false;
            this.groupBoxProductos.Text = "PRODUCTOS";
            // 
            // labelFiltrar
            // 
            this.labelFiltrar.Location = new System.Drawing.Point(6, 27);
            this.labelFiltrar.Name = "labelFiltrar";
            this.labelFiltrar.Size = new System.Drawing.Size(59, 23);
            this.labelFiltrar.TabIndex = 0;
            this.labelFiltrar.Text = "FILTRAR:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(70, 27);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(250, 20);
            this.txtBuscarProducto.TabIndex = 1;
            this.txtBuscarProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProducto_KeyDown);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscarProducto.Location = new System.Drawing.Point(330, 26);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(80, 24);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "BUSCAR";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.Location = new System.Drawing.Point(15, 60);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(520, 230);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Khaki;
            this.btnAgregarProducto.Location = new System.Drawing.Point(150, 300);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(250, 32);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "AGREGAR PRODUCTO AL CARRITO";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupBoxDetalles
            // 
            this.groupBoxDetalles.Controls.Add(this.dgvDetalles);
            this.groupBoxDetalles.Controls.Add(this.btnQuitar);
            this.groupBoxDetalles.Controls.Add(this.btnLimpiarDetalle);
            this.groupBoxDetalles.Location = new System.Drawing.Point(590, 170);
            this.groupBoxDetalles.Name = "groupBoxDetalles";
            this.groupBoxDetalles.Size = new System.Drawing.Size(580, 350);
            this.groupBoxDetalles.TabIndex = 3;
            this.groupBoxDetalles.TabStop = false;
            this.groupBoxDetalles.Text = "DETALLES DE LA VENTA";
            this.groupBoxDetalles.Enter += new System.EventHandler(this.groupBoxDetalles_Enter);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.Location = new System.Drawing.Point(15, 30);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.Size = new System.Drawing.Size(450, 260);
            this.dgvDetalles.TabIndex = 0;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            this.dgvDetalles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellEndEdit);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuitar.Location = new System.Drawing.Point(480, 60);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(90, 50);
            this.btnQuitar.TabIndex = 1;
            this.btnQuitar.Text = "QUITAR PRODUCTO";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiarDetalle
            // 
            this.btnLimpiarDetalle.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLimpiarDetalle.Location = new System.Drawing.Point(480, 130);
            this.btnLimpiarDetalle.Name = "btnLimpiarDetalle";
            this.btnLimpiarDetalle.Size = new System.Drawing.Size(90, 50);
            this.btnLimpiarDetalle.TabIndex = 2;
            this.btnLimpiarDetalle.Text = "LIMPIAR TODOS";
            this.btnLimpiarDetalle.UseVisualStyleBackColor = false;
            this.btnLimpiarDetalle.Click += new System.EventHandler(this.btnLimpiarDetalle_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotal.Location = new System.Drawing.Point(20, 540);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(139, 23);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "TOTAL A PAGAR:";
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(750, 540);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(150, 45);
            this.btnRegistrarVenta.TabIndex = 6;
            this.btnRegistrarVenta.Text = "REGISTRAR VENTA";
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelar.Location = new System.Drawing.Point(920, 540);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal.Location = new System.Drawing.Point(165, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(187, 30);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$0.00";
            // 
            // FrmVentas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.groupBoxDatos);
            this.Controls.Add(this.groupBoxProductos);
            this.Controls.Add(this.groupBoxDetalles);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.btnCancelar);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE VENTAS DIARIAS";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxProductos.ResumeLayout(false);
            this.groupBoxProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBoxDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label labelTipoPago;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.GroupBox groupBoxProductos;
        private System.Windows.Forms.Label labelFiltrar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBoxDetalles;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiarDetalle;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotal;
    }
}

#region Windows Form Designer generated code

/// <summary>
/// Required method for Designer support - do not modify
/// the contents of this method with the code editor.
/// </summary>
#endregion