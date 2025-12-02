namespace ProyectoPOS_1CA_A.CapaPresentacion
{
    partial class FrmUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(160, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(279, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(30, 60);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(520, 160);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(30, 230);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(40, 20);
            this.txtId.TabIndex = 2;
            this.txtId.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(30, 275);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(100, 272);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Location = new System.Drawing.Point(30, 315);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(44, 13);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "CLAVE:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(100, 312);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(150, 20);
            this.txtClave.TabIndex = 6;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.ForeColor = System.Drawing.Color.White;
            this.lblRol.Location = new System.Drawing.Point(290, 275);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(32, 13);
            this.lblRol.TabIndex = 7;
            this.lblRol.Text = "ROL:";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.Location = new System.Drawing.Point(340, 272);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(150, 21);
            this.cmbRol.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(290, 315);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "ESTADO:";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.ForeColor = System.Drawing.Color.White;
            this.chkEstado.Location = new System.Drawing.Point(350, 314);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(65, 17);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.Text = "ACTIVO";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(83, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(183, 360);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 35);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(283, 360);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(383, 360);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(90, 35);
            this.btnRefrescar.TabIndex = 15;
            this.btnRefrescar.Text = "REFRESCAR";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // FrmUsuarios
            // 
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(580, 420);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE USUARIOS";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;
    }
}
