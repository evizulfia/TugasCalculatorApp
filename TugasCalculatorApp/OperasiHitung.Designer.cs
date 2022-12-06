namespace TugasCalculatorApp
{
    partial class OperasiHitung
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
            this.prosesBtn = new System.Windows.Forms.Button();
            this.operasi = new System.Windows.Forms.Label();
            this.nilaiA = new System.Windows.Forms.Label();
            this.nilaiB = new System.Windows.Forms.Label();
            this.formNilaiB = new System.Windows.Forms.TextBox();
            this.formNilaiA = new System.Windows.Forms.TextBox();
            this.operasiDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // prosesBtn
            // 
            this.prosesBtn.Location = new System.Drawing.Point(171, 122);
            this.prosesBtn.Name = "prosesBtn";
            this.prosesBtn.Size = new System.Drawing.Size(82, 24);
            this.prosesBtn.TabIndex = 13;
            this.prosesBtn.Text = "Proses";
            this.prosesBtn.UseVisualStyleBackColor = true;
            this.prosesBtn.Click += new System.EventHandler(this.prosesBtn_Click);
            // 
            // operasi
            // 
            this.operasi.AutoSize = true;
            this.operasi.Location = new System.Drawing.Point(42, 37);
            this.operasi.Name = "operasi";
            this.operasi.Size = new System.Drawing.Size(43, 13);
            this.operasi.TabIndex = 12;
            this.operasi.Text = "Operasi";
            // 
            // nilaiA
            // 
            this.nilaiA.AutoSize = true;
            this.nilaiA.Location = new System.Drawing.Point(42, 64);
            this.nilaiA.Name = "nilaiA";
            this.nilaiA.Size = new System.Drawing.Size(37, 13);
            this.nilaiA.TabIndex = 11;
            this.nilaiA.Text = "Nilai A";
            // 
            // nilaiB
            // 
            this.nilaiB.AutoSize = true;
            this.nilaiB.Location = new System.Drawing.Point(42, 90);
            this.nilaiB.Name = "nilaiB";
            this.nilaiB.Size = new System.Drawing.Size(37, 13);
            this.nilaiB.TabIndex = 10;
            this.nilaiB.Text = "Nilai B";
            // 
            // formNilaiB
            // 
            this.formNilaiB.Location = new System.Drawing.Point(111, 87);
            this.formNilaiB.Name = "formNilaiB";
            this.formNilaiB.Size = new System.Drawing.Size(142, 20);
            this.formNilaiB.TabIndex = 9;
            // 
            // formNilaiA
            // 
            this.formNilaiA.Location = new System.Drawing.Point(111, 61);
            this.formNilaiA.Name = "formNilaiA";
            this.formNilaiA.Size = new System.Drawing.Size(142, 20);
            this.formNilaiA.TabIndex = 8;
            // 
            // operasiDropDown
            // 
            this.operasiDropDown.FormattingEnabled = true;
            this.operasiDropDown.Items.AddRange(new object[] {
            "Penjumlahan",
            "Pengurangan",
            "Pembagian",
            "Perkalian"});
            this.operasiDropDown.Location = new System.Drawing.Point(111, 34);
            this.operasiDropDown.Name = "operasiDropDown";
            this.operasiDropDown.Size = new System.Drawing.Size(142, 21);
            this.operasiDropDown.TabIndex = 7;
            // 
            // OperasiHitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 180);
            this.Controls.Add(this.prosesBtn);
            this.Controls.Add(this.operasi);
            this.Controls.Add(this.nilaiA);
            this.Controls.Add(this.nilaiB);
            this.Controls.Add(this.formNilaiB);
            this.Controls.Add(this.formNilaiA);
            this.Controls.Add(this.operasiDropDown);
            this.Name = "OperasiHitung";
            this.Text = "Operasi Hitung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prosesBtn;
        private System.Windows.Forms.Label operasi;
        private System.Windows.Forms.Label nilaiA;
        private System.Windows.Forms.Label nilaiB;
        private System.Windows.Forms.TextBox formNilaiB;
        private System.Windows.Forms.TextBox formNilaiA;
        private System.Windows.Forms.ComboBox operasiDropDown;
    }
}