namespace Veterinaria
{
    partial class ClaveParaMedicos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnContinuarClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la clave proporcionada por su supervisor para continuar";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(72, 58);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(205, 20);
            this.txtClave.TabIndex = 1;
            // 
            // btnContinuarClave
            // 
            this.btnContinuarClave.Location = new System.Drawing.Point(226, 107);
            this.btnContinuarClave.Name = "btnContinuarClave";
            this.btnContinuarClave.Size = new System.Drawing.Size(93, 25);
            this.btnContinuarClave.TabIndex = 2;
            this.btnContinuarClave.Text = "continuar";
            this.btnContinuarClave.UseVisualStyleBackColor = true;
            this.btnContinuarClave.Click += new System.EventHandler(this.btnContinuarClave_Click);
            // 
            // ClaveParaMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(363, 159);
            this.Controls.Add(this.btnContinuarClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label1);
            this.Name = "ClaveParaMedicos";
            this.Text = "Confirmación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnContinuarClave;
    }
}