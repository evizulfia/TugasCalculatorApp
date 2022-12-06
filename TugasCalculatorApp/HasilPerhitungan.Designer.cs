namespace TugasCalculatorApp
{
    partial class HasilPerhitungan
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
            this.hitungBtn = new System.Windows.Forms.Button();
            this.hasilBox = new System.Windows.Forms.GroupBox();
            this.listHasil = new System.Windows.Forms.ListBox();
            this.hasilBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hitungBtn
            // 
            this.hitungBtn.Location = new System.Drawing.Point(12, 311);
            this.hitungBtn.Name = "hitungBtn";
            this.hitungBtn.Size = new System.Drawing.Size(451, 22);
            this.hitungBtn.TabIndex = 3;
            this.hitungBtn.Text = "Hitung";
            this.hitungBtn.UseVisualStyleBackColor = true;
            this.hitungBtn.Click += new System.EventHandler(this.hitungBtn_Click);
            // 
            // hasilBox
            // 
            this.hasilBox.Controls.Add(this.listHasil);
            this.hasilBox.Location = new System.Drawing.Point(12, 12);
            this.hasilBox.Name = "hasilBox";
            this.hasilBox.Size = new System.Drawing.Size(451, 293);
            this.hasilBox.TabIndex = 2;
            this.hasilBox.TabStop = false;
            this.hasilBox.Text = "[ Hasil ]";
            // 
            // listHasil
            // 
            this.listHasil.FormattingEnabled = true;
            this.listHasil.Location = new System.Drawing.Point(6, 19);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(434, 264);
            this.listHasil.TabIndex = 0;
            // 
            // HasilPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 343);
            this.Controls.Add(this.hitungBtn);
            this.Controls.Add(this.hasilBox);
            this.Name = "HasilPerhitungan";
            this.Text = "Hasil Perhitungan";
            this.hasilBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hitungBtn;
        private System.Windows.Forms.GroupBox hasilBox;
        private System.Windows.Forms.ListBox listHasil;
    }
}

