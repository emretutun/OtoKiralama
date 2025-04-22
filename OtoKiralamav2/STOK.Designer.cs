
namespace OtoKiralamav2
{
    partial class STOK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STOK));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtodeme = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtod = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkalan = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1341, 156);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.DoubleClick += new System.EventHandler(this.dataGridView2_DoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(7, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "STOK EKLE";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(207, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 69);
            this.button2.TabIndex = 9;
            this.button2.Text = "STOK SİL";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtodeme);
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1353, 222);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(1128, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOPLAM ÖDENEN";
            // 
            // txtodeme
            // 
            this.txtodeme.Location = new System.Drawing.Point(1247, 180);
            this.txtodeme.Name = "txtodeme";
            this.txtodeme.Size = new System.Drawing.Size(100, 20);
            this.txtodeme.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtod);
            this.groupBox2.Controls.Add(this.dataGridView3);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1353, 248);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FİRMA";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(1125, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TOPLAM ÖDENEN";
            // 
            // txtod
            // 
            this.txtod.Location = new System.Drawing.Point(1244, 222);
            this.txtod.Name = "txtod";
            this.txtod.Size = new System.Drawing.Size(100, 20);
            this.txtod.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 18);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(1341, 186);
            this.dataGridView3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1225, 551);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "KALAN BORÇ";
            // 
            // txtkalan
            // 
            this.txtkalan.BackColor = System.Drawing.Color.Black;
            this.txtkalan.ForeColor = System.Drawing.Color.Green;
            this.txtkalan.Location = new System.Drawing.Point(1229, 578);
            this.txtkalan.Name = "txtkalan";
            this.txtkalan.Size = new System.Drawing.Size(127, 20);
            this.txtkalan.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1332, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // STOK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1368, 610);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkalan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "STOK";
            this.Text = "STOK";
            this.Load += new System.EventHandler(this.STOK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtodeme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtod;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkalan;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}