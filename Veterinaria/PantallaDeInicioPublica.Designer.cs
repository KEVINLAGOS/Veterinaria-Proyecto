
namespace Veterinaria
{
    partial class InicioUsuarioDueño
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbServicio = new System.Windows.Forms.TabPage();
            this.tbCita = new System.Windows.Forms.TabPage();
            this.tbProducts = new System.Windows.Forms.TabPage();
            this.tbAcercade = new System.Windows.Forms.TabPage();
            this.btnRegistarCita = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(193)))), ((int)(((byte)(129)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCerrarSesion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(686, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veterinaria";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(606, 19);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 28);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbServicio);
            this.tabControl1.Controls.Add(this.tbCita);
            this.tabControl1.Controls.Add(this.tbProducts);
            this.tabControl1.Controls.Add(this.tbAcercade);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 322);
            this.tabControl1.TabIndex = 6;
            // 
            // tbServicio
            // 
            this.tbServicio.Location = new System.Drawing.Point(4, 22);
            this.tbServicio.Name = "tbServicio";
            this.tbServicio.Padding = new System.Windows.Forms.Padding(3);
            this.tbServicio.Size = new System.Drawing.Size(654, 296);
            this.tbServicio.TabIndex = 0;
            this.tbServicio.Text = "Servicio";
            this.tbServicio.UseVisualStyleBackColor = true;
            // 
            // tbCita
            // 
            this.tbCita.Controls.Add(this.btnRegistarCita);
            this.tbCita.Location = new System.Drawing.Point(4, 22);
            this.tbCita.Name = "tbCita";
            this.tbCita.Padding = new System.Windows.Forms.Padding(3);
            this.tbCita.Size = new System.Drawing.Size(654, 296);
            this.tbCita.TabIndex = 1;
            this.tbCita.Text = "Cita";
            this.tbCita.UseVisualStyleBackColor = true;
            // 
            // tbProducts
            // 
            this.tbProducts.Location = new System.Drawing.Point(4, 22);
            this.tbProducts.Name = "tbProducts";
            this.tbProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbProducts.Size = new System.Drawing.Size(654, 296);
            this.tbProducts.TabIndex = 2;
            this.tbProducts.Text = "Productos";
            this.tbProducts.UseVisualStyleBackColor = true;
            // 
            // tbAcercade
            // 
            this.tbAcercade.Location = new System.Drawing.Point(4, 22);
            this.tbAcercade.Name = "tbAcercade";
            this.tbAcercade.Size = new System.Drawing.Size(654, 296);
            this.tbAcercade.TabIndex = 3;
            this.tbAcercade.Text = "Acerca de Nosotros";
            this.tbAcercade.UseVisualStyleBackColor = true;
            // 
            // btnRegistarCita
            // 
            this.btnRegistarCita.Location = new System.Drawing.Point(573, 267);
            this.btnRegistarCita.Name = "btnRegistarCita";
            this.btnRegistarCita.Size = new System.Drawing.Size(75, 23);
            this.btnRegistarCita.TabIndex = 0;
            this.btnRegistarCita.Text = "Registrar";
            this.btnRegistarCita.UseVisualStyleBackColor = true;
            this.btnRegistarCita.Click += new System.EventHandler(this.btnRegistarCita_Click);
            // 
            // InicioUsuarioDueño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(686, 405);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InicioUsuarioDueño";
            this.Text = "Inicio Publico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbCita.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbServicio;
        private System.Windows.Forms.TabPage tbCita;
        private System.Windows.Forms.TabPage tbProducts;
        private System.Windows.Forms.TabPage tbAcercade;
        private System.Windows.Forms.Button btnRegistarCita;
    }
}