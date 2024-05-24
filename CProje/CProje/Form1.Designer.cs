namespace CProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.bttngiris = new System.Windows.Forms.Button();
            this.Şifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpboxkullanicigirisi = new System.Windows.Forms.GroupBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpboxkullanicigirisi.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 7;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(263, 193);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(188, 30);
            this.txtsifre.TabIndex = 3;
            // 
            // bttngiris
            // 
            this.bttngiris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttngiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttngiris.Location = new System.Drawing.Point(215, 277);
            this.bttngiris.Name = "bttngiris";
            this.bttngiris.Size = new System.Drawing.Size(157, 39);
            this.bttngiris.TabIndex = 4;
            this.bttngiris.Text = "Giriş Yap";
            this.bttngiris.UseVisualStyleBackColor = false;
            this.bttngiris.Click += new System.EventHandler(this.bttngiris_Click);
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.Location = new System.Drawing.Point(161, 196);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(70, 25);
            this.Şifre.TabIndex = 1;
            this.Şifre.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // grpboxkullanicigirisi
            // 
            this.grpboxkullanicigirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpboxkullanicigirisi.Controls.Add(this.label1);
            this.grpboxkullanicigirisi.Controls.Add(this.Şifre);
            this.grpboxkullanicigirisi.Controls.Add(this.bttngiris);
            this.grpboxkullanicigirisi.Controls.Add(this.txtkullaniciadi);
            this.grpboxkullanicigirisi.Controls.Add(this.txtsifre);
            this.grpboxkullanicigirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxkullanicigirisi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpboxkullanicigirisi.Location = new System.Drawing.Point(142, 154);
            this.grpboxkullanicigirisi.Name = "grpboxkullanicigirisi";
            this.grpboxkullanicigirisi.Size = new System.Drawing.Size(603, 384);
            this.grpboxkullanicigirisi.TabIndex = 6;
            this.grpboxkullanicigirisi.TabStop = false;
            this.grpboxkullanicigirisi.Text = "Demirbaş Takip Sistemi Kullanıcı Girişi";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(263, 92);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(188, 30);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(193, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başkent Üniversitesi Bilgisayar Demirbaş Takip Sistemi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 100);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(883, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpboxkullanicigirisi);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bilgisayar Demirbaş Takip Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxkullanicigirisi.ResumeLayout(false);
            this.grpboxkullanicigirisi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button bttngiris;
        private System.Windows.Forms.Label Şifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpboxkullanicigirisi;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

