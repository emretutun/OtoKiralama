
namespace OtoKiralamav2
{
    partial class Firma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firma));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtadres = new System.Windows.Forms.TextBox();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.txtfaks = new System.Windows.Forms.TextBox();
            this.txtyetkili = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtödenen = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 347);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firma Adı Giriniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1341, 207);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.txtadres);
            this.groupBox1.Controls.Add(this.txttelefon);
            this.groupBox1.Controls.Add(this.txtmail);
            this.groupBox1.Controls.Add(this.txtfaks);
            this.groupBox1.Controls.Add(this.txtyetkili);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(806, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 287);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Firma Bilgilerini Giriniz";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtadres
            // 
            this.txtadres.Location = new System.Drawing.Point(81, 231);
            this.txtadres.Multiline = true;
            this.txtadres.Name = "txtadres";
            this.txtadres.Size = new System.Drawing.Size(171, 50);
            this.txtadres.TabIndex = 15;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(81, 189);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(171, 24);
            this.txttelefon.TabIndex = 12;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(81, 147);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(171, 24);
            this.txtmail.TabIndex = 11;
            // 
            // txtfaks
            // 
            this.txtfaks.Location = new System.Drawing.Point(81, 105);
            this.txtfaks.Name = "txtfaks";
            this.txtfaks.Size = new System.Drawing.Size(171, 24);
            this.txtfaks.TabIndex = 10;
            // 
            // txtyetkili
            // 
            this.txtyetkili.Location = new System.Drawing.Point(81, 63);
            this.txtyetkili.Name = "txtyetkili";
            this.txtyetkili.Size = new System.Drawing.Size(171, 24);
            this.txtyetkili.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(81, 21);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(171, 24);
            this.txtad.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(29, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Adres";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(18, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telefon";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Eposta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(34, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Faks";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yetkili";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Ad";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(765, 287);
            this.dataGridView2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(454, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "ile";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(482, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(22, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 18);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tarihleri arasında Alınan Ürünler :";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(1135, 586);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Toplam Ödenen";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtödenen
            // 
            this.txtödenen.Location = new System.Drawing.Point(1256, 586);
            this.txtödenen.Name = "txtödenen";
            this.txtödenen.Size = new System.Drawing.Size(100, 20);
            this.txtödenen.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1218, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 97);
            this.button3.TabIndex = 23;
            this.button3.Text = "Güncelle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1218, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 97);
            this.button1.TabIndex = 21;
            this.button1.Text = "Firma Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(688, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "ARA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1334, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1368, 610);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtödenen);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Firma";
            this.Text = "Firma";
            this.Load += new System.EventHandler(this.Firma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtadres;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.TextBox txtfaks;
        private System.Windows.Forms.TextBox txtyetkili;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtödenen;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}