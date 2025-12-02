namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    partial class FrmCambiarClave
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblClaveActual = new System.Windows.Forms.Label();
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.lblNuevaClave = new System.Windows.Forms.Label();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(125, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INICIAR SESIÓN";
            // 
            // lblClaveActual
            // 
            this.lblClaveActual.AutoSize = true;
            this.lblClaveActual.ForeColor = System.Drawing.Color.White;
            this.lblClaveActual.Location = new System.Drawing.Point(45, 90);
            this.lblClaveActual.Name = "lblClaveActual";
            this.lblClaveActual.Size = new System.Drawing.Size(129, 13);
            this.lblClaveActual.TabIndex = 1;
            this.lblClaveActual.Text = "CONTRASEÑA ACTUAL:";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(190, 87);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.PasswordChar = '*';
            this.txtClaveActual.Size = new System.Drawing.Size(180, 20);
            this.txtClaveActual.TabIndex = 2;
            // 
            // lblNuevaClave
            // 
            this.lblNuevaClave.AutoSize = true;
            this.lblNuevaClave.ForeColor = System.Drawing.Color.White;
            this.lblNuevaClave.Location = new System.Drawing.Point(45, 130);
            this.lblNuevaClave.Name = "lblNuevaClave";
            this.lblNuevaClave.Size = new System.Drawing.Size(124, 13);
            this.lblNuevaClave.TabIndex = 3;
            this.lblNuevaClave.Text = "NUEVA CONTRASEÑA:";
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(190, 127);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '*';
            this.txtNuevaClave.Size = new System.Drawing.Size(180, 20);
            this.txtNuevaClave.TabIndex = 4;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.ForeColor = System.Drawing.Color.White;
            this.lblConfirmar.Location = new System.Drawing.Point(45, 170);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(151, 13);
            this.lblConfirmar.TabIndex = 5;
            this.lblConfirmar.Text = "CONFIRMAR CONTRASEÑA:";
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(190, 167);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(180, 20);
            this.txtConfirmar.TabIndex = 6;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(80, 220);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(130, 35);
            this.btnCambiar.TabIndex = 7;
            this.btnCambiar.Text = "CAMBIAR CLAVE";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(240, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 35);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmCambiarClave
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(430, 300);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.lblNuevaClave);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.lblClaveActual);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClaveActual;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label lblNuevaClave;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Label lblConfirmar;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
