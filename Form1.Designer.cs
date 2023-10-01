namespace CheckboxApp
{
    partial class Form1
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
            this.cbDorucak = new System.Windows.Forms.CheckBox();
            this.cbRucak = new System.Windows.Forms.CheckBox();
            this.cbVecera = new System.Windows.Forms.CheckBox();
            this.cbSakrij = new System.Windows.Forms.CheckBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.tbNarudzba = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbDorucak
            // 
            this.cbDorucak.AutoSize = true;
            this.cbDorucak.Location = new System.Drawing.Point(32, 42);
            this.cbDorucak.Name = "cbDorucak";
            this.cbDorucak.Size = new System.Drawing.Size(95, 24);
            this.cbDorucak.TabIndex = 0;
            this.cbDorucak.Text = "Dorucak";
            this.cbDorucak.UseVisualStyleBackColor = true;
            this.cbDorucak.CheckedChanged += new System.EventHandler(this.cbDorucak_CheckedChanged);
            // 
            // cbRucak
            // 
            this.cbRucak.AutoSize = true;
            this.cbRucak.Location = new System.Drawing.Point(32, 98);
            this.cbRucak.Name = "cbRucak";
            this.cbRucak.Size = new System.Drawing.Size(81, 24);
            this.cbRucak.TabIndex = 1;
            this.cbRucak.Text = "Rucak";
            this.cbRucak.UseVisualStyleBackColor = true;
            this.cbRucak.CheckedChanged += new System.EventHandler(this.cbRucak_CheckedChanged);
            // 
            // cbVecera
            // 
            this.cbVecera.AutoSize = true;
            this.cbVecera.Location = new System.Drawing.Point(32, 149);
            this.cbVecera.Name = "cbVecera";
            this.cbVecera.Size = new System.Drawing.Size(86, 24);
            this.cbVecera.TabIndex = 2;
            this.cbVecera.Text = "Vecera";
            this.cbVecera.UseVisualStyleBackColor = true;
            // 
            // cbSakrij
            // 
            this.cbSakrij.AutoSize = true;
            this.cbSakrij.Location = new System.Drawing.Point(204, 212);
            this.cbSakrij.Name = "cbSakrij";
            this.cbSakrij.Size = new System.Drawing.Size(147, 24);
            this.cbSakrij.TabIndex = 3;
            this.cbSakrij.Text = "Sakrij Narudžbu";
            this.cbSakrij.UseVisualStyleBackColor = true;
            this.cbSakrij.CheckedChanged += new System.EventHandler(this.cbSakrij_CheckedChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(41, 207);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(110, 29);
            this.btnPosalji.TabIndex = 4;
            this.btnPosalji.Text = "Posalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            this.btnPosalji.Click += new System.EventHandler(this.btnPosalji_Click);
            // 
            // tbNarudzba
            // 
            this.tbNarudzba.Location = new System.Drawing.Point(204, 39);
            this.tbNarudzba.Multiline = true;
            this.tbNarudzba.Name = "tbNarudzba";
            this.tbNarudzba.Size = new System.Drawing.Size(225, 134);
            this.tbNarudzba.TabIndex = 5;
            this.tbNarudzba.Text = "Odabrali ste:";
            this.tbNarudzba.TextChanged += new System.EventHandler(this.tbNarudzba_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 275);
            this.Controls.Add(this.tbNarudzba);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.cbSakrij);
            this.Controls.Add(this.cbVecera);
            this.Controls.Add(this.cbRucak);
            this.Controls.Add(this.cbDorucak);
            this.Name = "Form1";
            this.Text = "Upotreba CheckBox Kontrole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDorucak;
        private System.Windows.Forms.CheckBox cbRucak;
        private System.Windows.Forms.CheckBox cbVecera;
        private System.Windows.Forms.CheckBox cbSakrij;
        private System.Windows.Forms.Button btnPosalji;
        private System.Windows.Forms.TextBox tbNarudzba;
    }
}

