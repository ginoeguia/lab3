namespace Laborato03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConectar = new Button();
            Servidor = new Label();
            txtServidor = new TextBox();
            Usuario = new Label();
            txtUsuario = new TextBox();
            BaseDatos = new Label();
            txtBaseDatos = new TextBox();
            Contraseña = new Label();
            txtContraseña = new TextBox();
            chkAutenticacion = new CheckBox();
            btnEstado = new Button();
            btnDesconectar = new Button();
            btnPersonas = new Button();
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(142, 259);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click_1;
            // 
            // Servidor
            // 
            Servidor.AutoSize = true;
            Servidor.Location = new Point(65, 59);
            Servidor.Name = "Servidor";
            Servidor.Size = new Size(50, 15);
            Servidor.TabIndex = 1;
            Servidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(65, 87);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(189, 23);
            txtServidor.TabIndex = 2;
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Enabled = false;
            Usuario.Location = new Point(296, 59);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(47, 15);
            Usuario.TabIndex = 3;
            Usuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(296, 87);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(188, 23);
            txtUsuario.TabIndex = 4;
            // 
            // BaseDatos
            // 
            BaseDatos.AutoSize = true;
            BaseDatos.Location = new Point(65, 133);
            BaseDatos.Name = "BaseDatos";
            BaseDatos.Size = new Size(79, 15);
            BaseDatos.TabIndex = 5;
            BaseDatos.Text = "Base de datos";
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(65, 162);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(189, 23);
            txtBaseDatos.TabIndex = 6;
            // 
            // Contraseña
            // 
            Contraseña.AutoSize = true;
            Contraseña.Location = new Point(296, 133);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(67, 15);
            Contraseña.TabIndex = 7;
            Contraseña.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(295, 162);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(189, 23);
            txtContraseña.TabIndex = 8;
            // 
            // chkAutenticacion
            // 
            chkAutenticacion.AutoSize = true;
            chkAutenticacion.Location = new Point(64, 213);
            chkAutenticacion.Name = "chkAutenticacion";
            chkAutenticacion.Size = new Size(153, 19);
            chkAutenticacion.TabIndex = 9;
            chkAutenticacion.Text = "Autenticación Integrada";
            chkAutenticacion.UseVisualStyleBackColor = true;
            chkAutenticacion.CheckedChanged += chkAutenticacion_CheckedChanged;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(240, 259);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(75, 23);
            btnEstado.TabIndex = 10;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Enabled = false;
            btnDesconectar.Location = new Point(331, 259);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(89, 23);
            btnDesconectar.TabIndex = 11;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnPersonas
            // 
            btnPersonas.Location = new Point(240, 302);
            btnPersonas.Name = "btnPersonas";
            btnPersonas.Size = new Size(75, 23);
            btnPersonas.TabIndex = 12;
            btnPersonas.Text = "Personas";
            btnPersonas.UseVisualStyleBackColor = true;
            btnPersonas.Click += btnPersonas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 358);
            Controls.Add(btnPersonas);
            Controls.Add(btnDesconectar);
            Controls.Add(btnEstado);
            Controls.Add(chkAutenticacion);
            Controls.Add(txtContraseña);
            Controls.Add(Contraseña);
            Controls.Add(txtBaseDatos);
            Controls.Add(BaseDatos);
            Controls.Add(txtUsuario);
            Controls.Add(Usuario);
            Controls.Add(txtServidor);
            Controls.Add(Servidor);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Label Servidor;
        private TextBox txtServidor;
        private Label Usuario;
        private TextBox txtUsuario;
        private Label BaseDatos;
        private TextBox txtBaseDatos;
        private Label Contraseña;
        private TextBox txtContraseña;
        private CheckBox chkAutenticacion;
        private Button btnEstado;
        private Button btnDesconectar;
        private Button btnPersonas;
    }
}