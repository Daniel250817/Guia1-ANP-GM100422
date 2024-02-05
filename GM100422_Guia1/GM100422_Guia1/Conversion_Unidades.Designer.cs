namespace GM100422_Guia1
{
    partial class Conversion_Unidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conversion_Unidades));
            this.label1 = new System.Windows.Forms.Label();
            this.cmBop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalcular = new System.Windows.Forms.TextBox();
            this.txtResultadoConv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el valor a transformar";
            // 
            // cmBop
            // 
            this.cmBop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmBop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBop.FormattingEnabled = true;
            this.cmBop.Location = new System.Drawing.Point(302, 192);
            this.cmBop.Name = "cmBop";
            this.cmBop.Size = new System.Drawing.Size(238, 21);
            this.cmBop.TabIndex = 3;
            this.cmBop.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione que tipo de conversión desea realizar";
            // 
            // txtCalcular
            // 
            this.txtCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCalcular.Location = new System.Drawing.Point(123, 300);
            this.txtCalcular.Name = "txtCalcular";
            this.txtCalcular.Size = new System.Drawing.Size(212, 20);
            this.txtCalcular.TabIndex = 4;
            // 
            // txtResultadoConv
            // 
            this.txtResultadoConv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtResultadoConv.Location = new System.Drawing.Point(465, 300);
            this.txtResultadoConv.Multiline = true;
            this.txtResultadoConv.Name = "txtResultadoConv";
            this.txtResultadoConv.Size = new System.Drawing.Size(229, 64);
            this.txtResultadoConv.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(461, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "El resultado de la conversión es";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(365, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(126, 122);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConvertir.Location = new System.Drawing.Point(123, 336);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(212, 28);
            this.btnConvertir.TabIndex = 14;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.Location = new System.Drawing.Point(619, 404);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Conversion_Unidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtResultadoConv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCalcular);
            this.Controls.Add(this.cmBop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conversion_Unidades";
            this.Text = "Conversion_Unidades";
            this.Load += new System.EventHandler(this.Conversion_Unidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmBop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCalcular;
        private System.Windows.Forms.TextBox txtResultadoConv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnVolver;
    }
}