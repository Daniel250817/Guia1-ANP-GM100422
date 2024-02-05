namespace GM100422_Guia1
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.cmbop = new System.Windows.Forms.ComboBox();
            this.listadvance = new System.Windows.Forms.ListBox();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnum1.Location = new System.Drawing.Point(398, 82);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            this.txtnum1.TextChanged += new System.EventHandler(this.txtnum1_TextChanged);
            // 
            // txtnum2
            // 
            this.txtnum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnum2.Location = new System.Drawing.Point(398, 165);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 1;
            this.txtnum2.TextChanged += new System.EventHandler(this.txtnum2_TextChanged);
            // 
            // cmbop
            // 
            this.cmbop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbop.FormattingEnabled = true;
            this.cmbop.Location = new System.Drawing.Point(623, 119);
            this.cmbop.Name = "cmbop";
            this.cmbop.Size = new System.Drawing.Size(121, 21);
            this.cmbop.TabIndex = 2;
            this.cmbop.SelectedIndexChanged += new System.EventHandler(this.cmbop_SelectedIndexChanged);
            // 
            // listadvance
            // 
            this.listadvance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listadvance.FormattingEnabled = true;
            this.listadvance.Location = new System.Drawing.Point(622, 207);
            this.listadvance.Name = "listadvance";
            this.listadvance.Size = new System.Drawing.Size(120, 95);
            this.listadvance.TabIndex = 3;
            // 
            // rbtn1
            // 
            this.rbtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn1.AutoSize = true;
            this.rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn1.Location = new System.Drawing.Point(623, 76);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(83, 24);
            this.rbtn1.TabIndex = 4;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Básicas";
            this.rbtn1.UseVisualStyleBackColor = true;
            this.rbtn1.CheckedChanged += new System.EventHandler(this.rbtn1_CheckedChanged);
            // 
            // rbtn2
            // 
            this.rbtn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn2.Location = new System.Drawing.Point(622, 164);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(106, 24);
            this.rbtn2.TabIndex = 5;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Avanzadas";
            this.rbtn2.UseVisualStyleBackColor = true;
            this.rbtn2.CheckedChanged += new System.EventHandler(this.rbtn2_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalcular.Location = new System.Drawing.Point(316, 273);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(182, 67);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Resultado";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbNum1
            // 
            this.lbNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum1.AutoSize = true;
            this.lbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNum1.Location = new System.Drawing.Point(297, 80);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(74, 20);
            this.lbNum1.TabIndex = 7;
            this.lbNum1.Text = "Número1";
            // 
            // lbNum2
            // 
            this.lbNum2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNum2.AutoSize = true;
            this.lbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNum2.Location = new System.Drawing.Point(297, 165);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(78, 20);
            this.lbNum2.TabIndex = 8;
            this.lbNum2.Text = "Número 2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(252, 228);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(645, 404);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.lbNum1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.listadvance);
            this.Controls.Add(this.cmbop);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.ComboBox cmbop;
        private System.Windows.Forms.ListBox listadvance;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnVolver;
    }
}