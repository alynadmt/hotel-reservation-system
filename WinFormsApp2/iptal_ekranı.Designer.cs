namespace WinFormsApp2
{
    partial class iptal_ekranı
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Oda_txtbox = new System.Windows.Forms.TextBox();
            this.giris_txt = new System.Windows.Forms.TextBox();
            this.girisT_txt = new System.Windows.Forms.Label();
            this.cikisT_txt = new System.Windows.Forms.Label();
            this.Cikis_txt = new System.Windows.Forms.TextBox();
            this.iptalleri_göster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Rez_txtbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 220);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(596, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(679, 84);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "rezervasyonu iptal et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oda Id :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(40, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Müşteri TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 299);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 6;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 75);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 31);
            this.textBox1.TabIndex = 7;
            // 
            // Oda_txtbox
            // 
            this.Oda_txtbox.Location = new System.Drawing.Point(162, 116);
            this.Oda_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Oda_txtbox.Name = "Oda_txtbox";
            this.Oda_txtbox.Size = new System.Drawing.Size(155, 31);
            this.Oda_txtbox.TabIndex = 8;
            this.Oda_txtbox.TextChanged += new System.EventHandler(this.Oda_txtbox_TextChanged);
            // 
            // giris_txt
            // 
            this.giris_txt.Location = new System.Drawing.Point(480, 75);
            this.giris_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.giris_txt.Name = "giris_txt";
            this.giris_txt.Size = new System.Drawing.Size(155, 31);
            this.giris_txt.TabIndex = 9;
            // 
            // girisT_txt
            // 
            this.girisT_txt.AutoSize = true;
            this.girisT_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisT_txt.Location = new System.Drawing.Point(358, 75);
            this.girisT_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.girisT_txt.Name = "girisT_txt";
            this.girisT_txt.Size = new System.Drawing.Size(112, 25);
            this.girisT_txt.TabIndex = 10;
            this.girisT_txt.Text = "Giris Tarihi :";
            // 
            // cikisT_txt
            // 
            this.cikisT_txt.AutoSize = true;
            this.cikisT_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cikisT_txt.Location = new System.Drawing.Point(358, 120);
            this.cikisT_txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cikisT_txt.Name = "cikisT_txt";
            this.cikisT_txt.Size = new System.Drawing.Size(113, 25);
            this.cikisT_txt.TabIndex = 11;
            this.cikisT_txt.Text = "Çıkış Tarihi :";
            // 
            // Cikis_txt
            // 
            this.Cikis_txt.Location = new System.Drawing.Point(480, 116);
            this.Cikis_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cikis_txt.Name = "Cikis_txt";
            this.Cikis_txt.Size = new System.Drawing.Size(155, 31);
            this.Cikis_txt.TabIndex = 12;
            // 
            // iptalleri_göster
            // 
            this.iptalleri_göster.Location = new System.Drawing.Point(665, 270);
            this.iptalleri_göster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iptalleri_göster.Name = "iptalleri_göster";
            this.iptalleri_göster.Size = new System.Drawing.Size(262, 36);
            this.iptalleri_göster.TabIndex = 13;
            this.iptalleri_göster.Text = "İptal rezervasyonlaı göster";
            this.iptalleri_göster.UseVisualStyleBackColor = true;
            this.iptalleri_göster.Click += new System.EventHandler(this.iptalleri_göster_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(734, 149);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Rez_txtbox
            // 
            this.Rez_txtbox.Location = new System.Drawing.Point(162, 158);
            this.Rez_txtbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rez_txtbox.Name = "Rez_txtbox";
            this.Rez_txtbox.Size = new System.Drawing.Size(155, 31);
            this.Rez_txtbox.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // iptal_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(980, 504);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rez_txtbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iptalleri_göster);
            this.Controls.Add(this.Cikis_txt);
            this.Controls.Add(this.cikisT_txt);
            this.Controls.Add(this.girisT_txt);
            this.Controls.Add(this.giris_txt);
            this.Controls.Add(this.Oda_txtbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "iptal_ekranı";
            this.Text = "iptal_ekranı";
            this.Load += new System.EventHandler(this.iptal_ekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox Oda_txtbox;
        private TextBox giris_txt;
        private Label girisT_txt;
        private Label cikisT_txt;
        private TextBox Cikis_txt;
        private Button iptalleri_göster;
        private Button button2;
        private TextBox Rez_txtbox;
        private Button button3;
    }
}