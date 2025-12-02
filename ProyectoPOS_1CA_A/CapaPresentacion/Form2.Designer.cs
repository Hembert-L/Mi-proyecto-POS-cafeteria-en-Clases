namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    partial class Form2
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

        private void InitializeComponent()
        {
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblNumFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.txtTipoPago = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFactura
            // 
            this.lblFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFactura.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblFactura.ForeColor = System.Drawing.Color.White;
            this.lblFactura.Location = new System.Drawing.Point(0, 0);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(800, 70);
            this.lblFactura.TabIndex = 0;
            this.lblFactura.Text = "FACTURA DE VENTA";
            this.lblFactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumFactura
            // 
            this.lblNumFactura.AutoSize = true;
            this.lblNumFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNumFactura.Location = new System.Drawing.Point(20, 20);
            this.lblNumFactura.Name = "lblNumFactura";
            this.lblNumFactura.Size = new System.Drawing.Size(111, 19);
            this.lblNumFactura.TabIndex = 9;
            this.lblNumFactura.Text = "Número Factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroFactura.Location = new System.Drawing.Point(150, 18);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(200, 25);
            this.txtNumeroFactura.TabIndex = 8;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFecha.Location = new System.Drawing.Point(400, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(47, 19);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtFecha
            // 
            this.txtFecha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFecha.Location = new System.Drawing.Point(460, 18);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(250, 25);
            this.txtFecha.TabIndex = 6;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCliente.Location = new System.Drawing.Point(20, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 19);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCliente.Location = new System.Drawing.Point(150, 58);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(300, 25);
            this.txtCliente.TabIndex = 4;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTipoPago.Location = new System.Drawing.Point(480, 60);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(92, 19);
            this.lblTipoPago.TabIndex = 3;
            this.lblTipoPago.Text = "Tipo de Pago:";
            // 
            // txtTipoPago
            // 
            this.txtTipoPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTipoPago.Location = new System.Drawing.Point(580, 58);
            this.txtTipoPago.Name = "txtTipoPago";
            this.txtTipoPago.ReadOnly = true;
            this.txtTipoPago.Size = new System.Drawing.Size(200, 25);
            this.txtTipoPago.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 430);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 21);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.LightYellow;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(100, 430);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(150, 29);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(20, 110);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(624, 221);
            this.dgvDetalle.TabIndex = 10;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(180)))));
            this.pnlHeader.Controls.Add(this.lblFactura);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(800, 70);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnImprimir);
            this.pnlBody.Controls.Add(this.txtTotal);
            this.pnlBody.Controls.Add(this.lblTotal);
            this.pnlBody.Controls.Add(this.txtTipoPago);
            this.pnlBody.Controls.Add(this.lblTipoPago);
            this.pnlBody.Controls.Add(this.txtCliente);
            this.pnlBody.Controls.Add(this.lblCliente);
            this.pnlBody.Controls.Add(this.txtFecha);
            this.pnlBody.Controls.Add(this.lblFecha);
            this.pnlBody.Controls.Add(this.txtNumeroFactura);
            this.pnlBody.Controls.Add(this.lblNumFactura);
            this.pnlBody.Controls.Add(this.dgvDetalle);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 70);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBody.Size = new System.Drawing.Size(800, 430);
            this.pnlBody.TabIndex = 0;
            this.pnlBody.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBody_Paint);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(676, 144);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Form2
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblNumFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblTipoPago;
        private System.Windows.Forms.TextBox txtTipoPago;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btnImprimir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
