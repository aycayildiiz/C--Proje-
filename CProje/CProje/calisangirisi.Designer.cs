namespace CProje
{
    partial class calisangirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calisangirisi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpboxkullanicigirisi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Şifre = new System.Windows.Forms.Label();
            this.bttngiris = new System.Windows.Forms.Button();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpboxkullanicigirisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 108);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(191, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Başkent Üniversitesi Bilgisayar Demirbaş Takip Sistemi";
            // 
            // grpboxkullanicigirisi
            // 
            this.grpboxkullanicigirisi.BackColor = System.Drawing.Color.Silver;
            this.grpboxkullanicigirisi.Controls.Add(this.linkLabel1);
            this.grpboxkullanicigirisi.Controls.Add(this.label1);
            this.grpboxkullanicigirisi.Controls.Add(this.Şifre);
            this.grpboxkullanicigirisi.Controls.Add(this.bttngiris);
            this.grpboxkullanicigirisi.Controls.Add(this.txtkullaniciadi);
            this.grpboxkullanicigirisi.Controls.Add(this.txtsifre);
            this.grpboxkullanicigirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxkullanicigirisi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.grpboxkullanicigirisi.Location = new System.Drawing.Point(161, 116);
            this.grpboxkullanicigirisi.Name = "grpboxkullanicigirisi";
            this.grpboxkullanicigirisi.Size = new System.Drawing.Size(615, 451);
            this.grpboxkullanicigirisi.TabIndex = 9;
            this.grpboxkullanicigirisi.TabStop = false;
            this.grpboxkullanicigirisi.Text = "Personel Giriş Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.Location = new System.Drawing.Point(152, 220);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(63, 25);
            this.Şifre.TabIndex = 1;
            this.Şifre.Text = "Şifre :";
            // 
            // bttngiris
            // 
            this.bttngiris.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttngiris.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bttngiris.Location = new System.Drawing.Point(220, 340);
            this.bttngiris.Name = "bttngiris";
            this.bttngiris.Size = new System.Drawing.Size(157, 39);
            this.bttngiris.TabIndex = 4;
            this.bttngiris.Text = "Giriş Yap";
            this.bttngiris.UseVisualStyleBackColor = false;
            this.bttngiris.Click += new System.EventHandler(this.bttngiris_Click);
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(313, 138);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(188, 30);
            this.txtkullaniciadi.TabIndex = 2;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(313, 235);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.PasswordChar = '*';
            this.txtsifre.Size = new System.Drawing.Size(188, 30);
            this.txtsifre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(230, 395);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Yönetici Girişi";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // calisangirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1000, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpboxkullanicigirisi);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calisangirisi";
            this.Text = "Personel Giriş Ekranı";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpboxkullanicigirisi.ResumeLayout(false);
            this.grpboxkullanicigirisi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpboxkullanicigirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Şifre;
        private System.Windows.Forms.Button bttngiris;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}