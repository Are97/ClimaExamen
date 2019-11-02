namespace ClimaExamen
{
    partial class Form1
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
            this.bPruebas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.bAceptarLogin = new System.Windows.Forms.Button();
            this.labelCuenta = new System.Windows.Forms.Label();
            this.bRegistrate = new System.Windows.Forms.Button();
            this.tbContraLogin = new System.Windows.Forms.TextBox();
            this.tbCorreoLogin = new System.Windows.Forms.TextBox();
            this.tbCorreoRegistro = new System.Windows.Forms.TextBox();
            this.tbContraRegistro = new System.Windows.Forms.TextBox();
            this.bAceptarRegistro = new System.Windows.Forms.Button();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.bAgregarCiudad = new System.Windows.Forms.Button();
            this.bRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bPruebas
            // 
            this.bPruebas.Location = new System.Drawing.Point(635, 184);
            this.bPruebas.Name = "bPruebas";
            this.bPruebas.Size = new System.Drawing.Size(75, 23);
            this.bPruebas.TabIndex = 0;
            this.bPruebas.Text = "Pruebas";
            this.bPruebas.UseVisualStyleBackColor = true;
            this.bPruebas.Click += new System.EventHandler(this.bPruebas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(584, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Location = new System.Drawing.Point(66, 0);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(34, 13);
            this.labelLogIn.TabIndex = 2;
            this.labelLogIn.Text = "LogIn";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Location = new System.Drawing.Point(12, 64);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 3;
            this.labelCorreo.Text = "Correo";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Location = new System.Drawing.Point(12, 94);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(61, 13);
            this.labelContrasena.TabIndex = 4;
            this.labelContrasena.Text = "Contraseña";
            // 
            // bAceptarLogin
            // 
            this.bAceptarLogin.Location = new System.Drawing.Point(64, 126);
            this.bAceptarLogin.Name = "bAceptarLogin";
            this.bAceptarLogin.Size = new System.Drawing.Size(75, 23);
            this.bAceptarLogin.TabIndex = 5;
            this.bAceptarLogin.Text = "Aceptar";
            this.bAceptarLogin.UseVisualStyleBackColor = true;
            this.bAceptarLogin.Click += new System.EventHandler(this.bAceptarLogin_Click);
            // 
            // labelCuenta
            // 
            this.labelCuenta.AutoSize = true;
            this.labelCuenta.Location = new System.Drawing.Point(0, 161);
            this.labelCuenta.Name = "labelCuenta";
            this.labelCuenta.Size = new System.Drawing.Size(100, 13);
            this.labelCuenta.TabIndex = 6;
            this.labelCuenta.Text = "¿No tienes cuenta?";
            // 
            // bRegistrate
            // 
            this.bRegistrate.Location = new System.Drawing.Point(12, 184);
            this.bRegistrate.Name = "bRegistrate";
            this.bRegistrate.Size = new System.Drawing.Size(75, 23);
            this.bRegistrate.TabIndex = 7;
            this.bRegistrate.Text = "¡Regístrate!";
            this.bRegistrate.UseVisualStyleBackColor = true;
            this.bRegistrate.Click += new System.EventHandler(this.bRegistrate_Click);
            // 
            // tbContraLogin
            // 
            this.tbContraLogin.Location = new System.Drawing.Point(79, 91);
            this.tbContraLogin.Name = "tbContraLogin";
            this.tbContraLogin.Size = new System.Drawing.Size(171, 20);
            this.tbContraLogin.TabIndex = 8;
            // 
            // tbCorreoLogin
            // 
            this.tbCorreoLogin.Location = new System.Drawing.Point(79, 61);
            this.tbCorreoLogin.Name = "tbCorreoLogin";
            this.tbCorreoLogin.Size = new System.Drawing.Size(171, 20);
            this.tbCorreoLogin.TabIndex = 9;
            // 
            // tbCorreoRegistro
            // 
            this.tbCorreoRegistro.Location = new System.Drawing.Point(79, 61);
            this.tbCorreoRegistro.Name = "tbCorreoRegistro";
            this.tbCorreoRegistro.Size = new System.Drawing.Size(171, 20);
            this.tbCorreoRegistro.TabIndex = 10;
            this.tbCorreoRegistro.Visible = false;
            // 
            // tbContraRegistro
            // 
            this.tbContraRegistro.Location = new System.Drawing.Point(79, 91);
            this.tbContraRegistro.Name = "tbContraRegistro";
            this.tbContraRegistro.Size = new System.Drawing.Size(171, 20);
            this.tbContraRegistro.TabIndex = 11;
            this.tbContraRegistro.Visible = false;
            // 
            // bAceptarRegistro
            // 
            this.bAceptarRegistro.Location = new System.Drawing.Point(64, 126);
            this.bAceptarRegistro.Name = "bAceptarRegistro";
            this.bAceptarRegistro.Size = new System.Drawing.Size(75, 23);
            this.bAceptarRegistro.TabIndex = 12;
            this.bAceptarRegistro.Text = "Aceptar";
            this.bAceptarRegistro.UseVisualStyleBackColor = true;
            this.bAceptarRegistro.Visible = false;
            this.bAceptarRegistro.Click += new System.EventHandler(this.bAceptarRegistro_Click);
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(66, 0);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(46, 13);
            this.labelRegistro.TabIndex = 13;
            this.labelRegistro.Text = "Registro";
            this.labelRegistro.Visible = false;
            // 
            // bAgregarCiudad
            // 
            this.bAgregarCiudad.Location = new System.Drawing.Point(455, 12);
            this.bAgregarCiudad.Name = "bAgregarCiudad";
            this.bAgregarCiudad.Size = new System.Drawing.Size(146, 23);
            this.bAgregarCiudad.TabIndex = 14;
            this.bAgregarCiudad.Text = "Agregar Ciudad";
            this.bAgregarCiudad.UseVisualStyleBackColor = true;
            this.bAgregarCiudad.Visible = false;
            this.bAgregarCiudad.Click += new System.EventHandler(this.bAgregarCiudad_Click);
            // 
            // bRegresar
            // 
            this.bRegresar.Location = new System.Drawing.Point(635, 12);
            this.bRegresar.Name = "bRegresar";
            this.bRegresar.Size = new System.Drawing.Size(75, 23);
            this.bRegresar.TabIndex = 15;
            this.bRegresar.Text = "Regresar";
            this.bRegresar.UseVisualStyleBackColor = true;
            this.bRegresar.Visible = false;
            this.bRegresar.Click += new System.EventHandler(this.bRegresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bRegresar);
            this.Controls.Add(this.bAgregarCiudad);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.bAceptarRegistro);
            this.Controls.Add(this.tbContraRegistro);
            this.Controls.Add(this.tbCorreoRegistro);
            this.Controls.Add(this.tbCorreoLogin);
            this.Controls.Add(this.tbContraLogin);
            this.Controls.Add(this.bRegistrate);
            this.Controls.Add(this.labelCuenta);
            this.Controls.Add(this.bAceptarLogin);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelLogIn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bPruebas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPruebas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLogIn;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.Button bAceptarLogin;
        private System.Windows.Forms.Label labelCuenta;
        private System.Windows.Forms.Button bRegistrate;
        private System.Windows.Forms.TextBox tbContraLogin;
        private System.Windows.Forms.TextBox tbCorreoLogin;
        private System.Windows.Forms.TextBox tbCorreoRegistro;
        private System.Windows.Forms.TextBox tbContraRegistro;
        private System.Windows.Forms.Button bAceptarRegistro;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Button bAgregarCiudad;
        private System.Windows.Forms.Button bRegresar;
    }
}

