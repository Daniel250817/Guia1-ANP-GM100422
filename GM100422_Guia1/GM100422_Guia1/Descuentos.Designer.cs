namespace GM100422_Guia1
{
    partial class Descuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Descuentos));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbMontoDes = new System.Windows.Forms.Label();
            this.txtMontoDesc = new System.Windows.Forms.TextBox();
            this.lbSalarioN = new System.Windows.Forms.Label();
            this.txtSalNeto = new System.Windows.Forms.TextBox();
            this.lbSalarioB = new System.Windows.Forms.Label();
            this.txtSalarioB = new System.Windows.Forms.TextBox();
            this.rbtnGerente = new System.Windows.Forms.RadioButton();
            this.lbApelli = new System.Windows.Forms.Label();
            this.txtApelli = new System.Windows.Forms.TextBox();
            this.rbtnSubgerente = new System.Windows.Forms.RadioButton();
            this.rbtnSecretaria = new System.Windows.Forms.RadioButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Location = new System.Drawing.Point(212, 53);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(364, 37);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Calcula Tus Descuentos";
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(148, 156);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 20);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(219, 156);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lbMontoDes
            // 
            this.lbMontoDes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbMontoDes.AutoSize = true;
            this.lbMontoDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontoDes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMontoDes.Location = new System.Drawing.Point(148, 276);
            this.lbMontoDes.Name = "lbMontoDes";
            this.lbMontoDes.Size = new System.Drawing.Size(136, 20);
            this.lbMontoDes.TabIndex = 11;
            this.lbMontoDes.Text = "Monto Descuento";
            // 
            // txtMontoDesc
            // 
            this.txtMontoDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMontoDesc.Location = new System.Drawing.Point(292, 276);
            this.txtMontoDesc.Name = "txtMontoDesc";
            this.txtMontoDesc.Size = new System.Drawing.Size(100, 20);
            this.txtMontoDesc.TabIndex = 10;
            this.txtMontoDesc.TextChanged += new System.EventHandler(this.txtMontoDesc_TextChanged);
            // 
            // lbSalarioN
            // 
            this.lbSalarioN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSalarioN.AutoSize = true;
            this.lbSalarioN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSalarioN.Location = new System.Drawing.Point(148, 326);
            this.lbSalarioN.Name = "lbSalarioN";
            this.lbSalarioN.Size = new System.Drawing.Size(96, 20);
            this.lbSalarioN.TabIndex = 13;
            this.lbSalarioN.Text = "Salario Neto";
            // 
            // txtSalNeto
            // 
            this.txtSalNeto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalNeto.Location = new System.Drawing.Point(292, 326);
            this.txtSalNeto.Name = "txtSalNeto";
            this.txtSalNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSalNeto.TabIndex = 12;
            this.txtSalNeto.TextChanged += new System.EventHandler(this.txtSalNeto_TextChanged);
            // 
            // lbSalarioB
            // 
            this.lbSalarioB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSalarioB.AutoSize = true;
            this.lbSalarioB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSalarioB.Location = new System.Drawing.Point(148, 219);
            this.lbSalarioB.Name = "lbSalarioB";
            this.lbSalarioB.Size = new System.Drawing.Size(101, 20);
            this.lbSalarioB.TabIndex = 15;
            this.lbSalarioB.Text = "Salario Bruto";
            // 
            // txtSalarioB
            // 
            this.txtSalarioB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalarioB.Location = new System.Drawing.Point(292, 219);
            this.txtSalarioB.Name = "txtSalarioB";
            this.txtSalarioB.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioB.TabIndex = 14;
            this.txtSalarioB.TextChanged += new System.EventHandler(this.txtSalarioB_TextChanged);
            // 
            // rbtnGerente
            // 
            this.rbtnGerente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnGerente.AutoSize = true;
            this.rbtnGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnGerente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnGerente.Location = new System.Drawing.Point(474, 219);
            this.rbtnGerente.Name = "rbtnGerente";
            this.rbtnGerente.Size = new System.Drawing.Size(86, 24);
            this.rbtnGerente.TabIndex = 16;
            this.rbtnGerente.TabStop = true;
            this.rbtnGerente.Text = "Gerente";
            this.rbtnGerente.UseVisualStyleBackColor = true;
            this.rbtnGerente.CheckedChanged += new System.EventHandler(this.rbtnGerente_CheckedChanged);
            // 
            // lbApelli
            // 
            this.lbApelli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbApelli.AutoSize = true;
            this.lbApelli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApelli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbApelli.Location = new System.Drawing.Point(461, 156);
            this.lbApelli.Name = "lbApelli";
            this.lbApelli.Size = new System.Drawing.Size(73, 20);
            this.lbApelli.TabIndex = 18;
            this.lbApelli.Text = "Apellidos";
            this.lbApelli.Click += new System.EventHandler(this.lbApelli_Click);
            // 
            // txtApelli
            // 
            this.txtApelli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApelli.Location = new System.Drawing.Point(540, 158);
            this.txtApelli.Name = "txtApelli";
            this.txtApelli.Size = new System.Drawing.Size(171, 20);
            this.txtApelli.TabIndex = 17;
            this.txtApelli.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // rbtnSubgerente
            // 
            this.rbtnSubgerente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnSubgerente.AutoSize = true;
            this.rbtnSubgerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSubgerente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnSubgerente.Location = new System.Drawing.Point(474, 276);
            this.rbtnSubgerente.Name = "rbtnSubgerente";
            this.rbtnSubgerente.Size = new System.Drawing.Size(111, 24);
            this.rbtnSubgerente.TabIndex = 19;
            this.rbtnSubgerente.TabStop = true;
            this.rbtnSubgerente.Text = "Subgerente";
            this.rbtnSubgerente.UseVisualStyleBackColor = true;
            this.rbtnSubgerente.CheckedChanged += new System.EventHandler(this.rbtnSubgerente_CheckedChanged);
            // 
            // rbtnSecretaria
            // 
            this.rbtnSecretaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtnSecretaria.AutoSize = true;
            this.rbtnSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSecretaria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnSecretaria.Location = new System.Drawing.Point(474, 326);
            this.rbtnSecretaria.Name = "rbtnSecretaria";
            this.rbtnSecretaria.Size = new System.Drawing.Size(100, 24);
            this.rbtnSecretaria.TabIndex = 20;
            this.rbtnSecretaria.TabStop = true;
            this.rbtnSecretaria.Text = "Secretaria";
            this.rbtnSecretaria.UseVisualStyleBackColor = true;
            this.rbtnSecretaria.CheckedChanged += new System.EventHandler(this.rbtnSecretaria_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(582, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 129);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCalcular.Location = new System.Drawing.Point(292, 377);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 31);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResetear.Location = new System.Drawing.Point(446, 377);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(139, 31);
            this.btnResetear.TabIndex = 23;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVolver.Location = new System.Drawing.Point(681, 398);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 24;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.rbtnSecretaria);
            this.Controls.Add(this.rbtnSubgerente);
            this.Controls.Add(this.lbApelli);
            this.Controls.Add(this.txtApelli);
            this.Controls.Add(this.rbtnGerente);
            this.Controls.Add(this.lbSalarioB);
            this.Controls.Add(this.txtSalarioB);
            this.Controls.Add(this.lbSalarioN);
            this.Controls.Add(this.txtSalNeto);
            this.Controls.Add(this.lbMontoDes);
            this.Controls.Add(this.txtMontoDesc);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Descuentos";
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.Descuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbMontoDes;
        private System.Windows.Forms.TextBox txtMontoDesc;
        private System.Windows.Forms.Label lbSalarioN;
        private System.Windows.Forms.TextBox txtSalNeto;
        private System.Windows.Forms.Label lbSalarioB;
        private System.Windows.Forms.TextBox txtSalarioB;
        private System.Windows.Forms.RadioButton rbtnGerente;
        private System.Windows.Forms.Label lbApelli;
        private System.Windows.Forms.TextBox txtApelli;
        private System.Windows.Forms.RadioButton rbtnSubgerente;
        private System.Windows.Forms.RadioButton rbtnSecretaria;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnVolver;
    }
}