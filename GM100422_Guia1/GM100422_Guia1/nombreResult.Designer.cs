namespace GM100422_Guia1
{
    partial class nombreResult
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
            this.lblRecibido = new System.Windows.Forms.Label();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecibido
            // 
            this.lblRecibido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecibido.AutoSize = true;
            this.lblRecibido.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRecibido.Location = new System.Drawing.Point(91, 120);
            this.lblRecibido.Name = "lblRecibido";
            this.lblRecibido.Size = new System.Drawing.Size(109, 39);
            this.lblRecibido.TabIndex = 0;
            this.lblRecibido.Text = "label1";
            // 
            // btnRegreso
            // 
            this.btnRegreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegreso.Location = new System.Drawing.Point(281, 288);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(234, 67);
            this.btnRegreso.TabIndex = 1;
            this.btnRegreso.Text = "Regresar";
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // nombreResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.lblRecibido);
            this.Name = "nombreResult";
            this.Text = "nombreResult";
            this.Load += new System.EventHandler(this.nombreResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecibido;
        private System.Windows.Forms.Button btnRegreso;
    }
}