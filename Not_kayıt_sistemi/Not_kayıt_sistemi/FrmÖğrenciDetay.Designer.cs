namespace Not_kayıt_sistemi
{
    partial class FrmÖğrenciDetay
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblsınav1 = new System.Windows.Forms.Label();
            this.lblsınav2 = new System.Windows.Forms.Label();
            this.lblsınav3 = new System.Windows.Forms.Label();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.lblnumara = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblortalama = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numara:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sınav 2:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sınav 3:";
            // 
            // lblsınav1
            // 
            this.lblsınav1.AutoSize = true;
            this.lblsınav1.Location = new System.Drawing.Point(142, 152);
            this.lblsınav1.Name = "lblsınav1";
            this.lblsınav1.Size = new System.Drawing.Size(40, 27);
            this.lblsınav1.TabIndex = 5;
            this.lblsınav1.Text = "00";
            // 
            // lblsınav2
            // 
            this.lblsınav2.AutoSize = true;
            this.lblsınav2.Location = new System.Drawing.Point(142, 203);
            this.lblsınav2.Name = "lblsınav2";
            this.lblsınav2.Size = new System.Drawing.Size(40, 27);
            this.lblsınav2.TabIndex = 6;
            this.lblsınav2.Text = "00";
            // 
            // lblsınav3
            // 
            this.lblsınav3.AutoSize = true;
            this.lblsınav3.Location = new System.Drawing.Point(142, 258);
            this.lblsınav3.Name = "lblsınav3";
            this.lblsınav3.Size = new System.Drawing.Size(40, 27);
            this.lblsınav3.TabIndex = 7;
            this.lblsınav3.Text = "00";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(172, 21);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(57, 27);
            this.lbladsoyad.TabIndex = 8;
            this.lbladsoyad.Text = "Null";
            // 
            // lblnumara
            // 
            this.lblnumara.AutoSize = true;
            this.lblnumara.Location = new System.Drawing.Point(172, 57);
            this.lblnumara.Name = "lblnumara";
            this.lblnumara.Size = new System.Drawing.Size(68, 27);
            this.lblnumara.TabIndex = 9;
            this.lblnumara.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ortalama:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblortalama
            // 
            this.lblortalama.AutoSize = true;
            this.lblortalama.Location = new System.Drawing.Point(142, 312);
            this.lblortalama.Name = "lblortalama";
            this.lblortalama.Size = new System.Drawing.Size(40, 27);
            this.lblortalama.TabIndex = 11;
            this.lblortalama.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 368);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "Durum:";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Location = new System.Drawing.Point(138, 368);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(57, 27);
            this.lbldurum.TabIndex = 13;
            this.lbldurum.Text = "Null";
//            this.lbldurum.Click += new System.EventHandler(this.lbldurum_Click);
            // 
            // FrmÖğrenciDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 440);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblortalama);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblnumara);
            this.Controls.Add(this.lbladsoyad);
            this.Controls.Add(this.lblsınav3);
            this.Controls.Add(this.lblsınav2);
            this.Controls.Add(this.lblsınav1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmÖğrenciDetay";
            this.Text = "Öğrenci Not Kayıt Sistemi";
            this.Load += new System.EventHandler(this.FrmÖğrenciDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsınav1;
        private System.Windows.Forms.Label lblsınav2;
        private System.Windows.Forms.Label lblsınav3;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label lblnumara;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblortalama;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbldurum;
    }
}