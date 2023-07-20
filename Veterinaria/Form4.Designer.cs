namespace Veterinaria
{
    partial class LoginMedicos
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
            this.btnInicioSesionMedico = new System.Windows.Forms.Button();
            this.txtContraseñaMedico = new System.Windows.Forms.TextBox();
            this.txtUsuarioMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistroMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInicioSesionMedico
            // 
            this.btnInicioSesionMedico.Location = new System.Drawing.Point(364, 183);
            this.btnInicioSesionMedico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnInicioSesionMedico.Name = "btnInicioSesionMedico";
            this.btnInicioSesionMedico.Size = new System.Drawing.Size(166, 60);
            this.btnInicioSesionMedico.TabIndex = 13;
            this.btnInicioSesionMedico.Text = "iniciar sesion";
            this.btnInicioSesionMedico.UseVisualStyleBackColor = true;
            this.btnInicioSesionMedico.Click += new System.EventHandler(this.btnInicioSesionMedico_Click);
            // 
            // txtContraseñaMedico
            // 
            this.txtContraseñaMedico.Location = new System.Drawing.Point(260, 115);
            this.txtContraseñaMedico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtContraseñaMedico.Name = "txtContraseñaMedico";
            this.txtContraseñaMedico.PasswordChar = '*';
            this.txtContraseñaMedico.Size = new System.Drawing.Size(380, 31);
            this.txtContraseñaMedico.TabIndex = 12;
            // 
            // txtUsuarioMedico
            // 
            this.txtUsuarioMedico.Location = new System.Drawing.Point(260, 60);
            this.txtUsuarioMedico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsuarioMedico.Name = "txtUsuarioMedico";
            this.txtUsuarioMedico.Size = new System.Drawing.Size(380, 31);
            this.txtUsuarioMedico.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 271);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "¿Eres un médico nuevo?.Registrate";
            // 
            // btnRegistroMedico
            // 
            this.btnRegistroMedico.Location = new System.Drawing.Point(364, 340);
            this.btnRegistroMedico.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRegistroMedico.Name = "btnRegistroMedico";
            this.btnRegistroMedico.Size = new System.Drawing.Size(166, 58);
            this.btnRegistroMedico.TabIndex = 15;
            this.btnRegistroMedico.Text = "Registrarme";
            this.btnRegistroMedico.UseVisualStyleBackColor = true;
            this.btnRegistroMedico.Click += new System.EventHandler(this.btnRegistroMedico_Click);
            // 
            // LoginMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 504);
            this.Controls.Add(this.btnRegistroMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicioSesionMedico);
            this.Controls.Add(this.txtContraseñaMedico);
            this.Controls.Add(this.txtUsuarioMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LoginMedicos";
            this.Text = "Inicio de sesion para medicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicioSesionMedico;
        private System.Windows.Forms.TextBox txtContraseñaMedico;
        private System.Windows.Forms.TextBox txtUsuarioMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroMedico;
    }
}