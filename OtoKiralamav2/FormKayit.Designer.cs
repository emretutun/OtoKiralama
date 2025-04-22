namespace OtoKiralamav2
{
    partial class FormKayit
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
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.txtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.txtKayitSifreTekrar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.Location = new System.Drawing.Point(101, 188);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(75, 23);
            this.buttonKayitOl.TabIndex = 2;
            this.buttonKayitOl.Text = "Kayıt Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = true;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(101, 44);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKayitKullaniciAdi.TabIndex = 3;
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(101, 92);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.Size = new System.Drawing.Size(100, 20);
            this.txtKayitSifre.TabIndex = 4;
            this.txtKayitSifre.UseSystemPasswordChar = true;
            // 
            // txtKayitSifreTekrar
            // 
            this.txtKayitSifreTekrar.Location = new System.Drawing.Point(101, 141);
            this.txtKayitSifreTekrar.Name = "txtKayitSifreTekrar";
            this.txtKayitSifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.txtKayitSifreTekrar.TabIndex = 5;
            this.txtKayitSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar :";
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKayitSifreTekrar);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.txtKayitKullaniciAdi);
            this.Controls.Add(this.buttonKayitOl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKayit";
            this.Text = "FormKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.TextBox txtKayitKullaniciAdi;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.TextBox txtKayitSifreTekrar;
        private System.Windows.Forms.Label label3;
    }
}