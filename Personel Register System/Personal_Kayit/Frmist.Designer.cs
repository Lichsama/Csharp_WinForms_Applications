namespace Personal_Kayit
{
    partial class Frmist
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
            this.toplamPer = new System.Windows.Forms.Label();
            this.evliper = new System.Windows.Forms.Label();
            this.bekarper = new System.Windows.Forms.Label();
            this.sehirsay = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toplammaas = new System.Windows.Forms.Label();
            this.ortmaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evli Personel Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bekar Personel Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şehir Sayısı:";
            // 
            // toplamPer
            // 
            this.toplamPer.AutoSize = true;
            this.toplamPer.Location = new System.Drawing.Point(231, 40);
            this.toplamPer.Name = "toplamPer";
            this.toplamPer.Size = new System.Drawing.Size(23, 26);
            this.toplamPer.TabIndex = 4;
            this.toplamPer.Text = "0";
            // 
            // evliper
            // 
            this.evliper.AutoSize = true;
            this.evliper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.evliper.Location = new System.Drawing.Point(231, 78);
            this.evliper.Name = "evliper";
            this.evliper.Size = new System.Drawing.Size(23, 26);
            this.evliper.TabIndex = 5;
            this.evliper.Text = "0";
            // 
            // bekarper
            // 
            this.bekarper.AutoSize = true;
            this.bekarper.Location = new System.Drawing.Point(231, 119);
            this.bekarper.Name = "bekarper";
            this.bekarper.Size = new System.Drawing.Size(23, 26);
            this.bekarper.TabIndex = 6;
            this.bekarper.Text = "0";
            // 
            // sehirsay
            // 
            this.sehirsay.AutoSize = true;
            this.sehirsay.Location = new System.Drawing.Point(231, 153);
            this.sehirsay.Name = "sehirsay";
            this.sehirsay.Size = new System.Drawing.Size(23, 26);
            this.sehirsay.TabIndex = 7;
            this.sehirsay.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 26);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam Maaş:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 26);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ortalama Maaş:";
            // 
            // toplammaas
            // 
            this.toplammaas.AutoSize = true;
            this.toplammaas.Location = new System.Drawing.Point(231, 188);
            this.toplammaas.Name = "toplammaas";
            this.toplammaas.Size = new System.Drawing.Size(23, 26);
            this.toplammaas.TabIndex = 10;
            this.toplammaas.Text = "0";
            this.toplammaas.Click += new System.EventHandler(this.label11_Click);
            // 
            // ortmaas
            // 
            this.ortmaas.AutoSize = true;
            this.ortmaas.Location = new System.Drawing.Point(231, 224);
            this.ortmaas.Name = "ortmaas";
            this.ortmaas.Size = new System.Drawing.Size(23, 26);
            this.ortmaas.TabIndex = 11;
            this.ortmaas.Text = "0";
            // 
            // Frmist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 294);
            this.Controls.Add(this.ortmaas);
            this.Controls.Add(this.toplammaas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sehirsay);
            this.Controls.Add(this.bekarper);
            this.Controls.Add(this.evliper);
            this.Controls.Add(this.toplamPer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Frmist";
            this.Text = "Frmist";
            this.Load += new System.EventHandler(this.Frmist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label toplamPer;
        private System.Windows.Forms.Label evliper;
        private System.Windows.Forms.Label bekarper;
        private System.Windows.Forms.Label sehirsay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label toplammaas;
        private System.Windows.Forms.Label ortmaas;
    }
}