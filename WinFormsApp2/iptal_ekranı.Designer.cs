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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(477, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(543, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "rezervasyonu iptal et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oda Id :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Müşteri TC :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // Oda_txtbox
            // 
            this.Oda_txtbox.Location = new System.Drawing.Point(130, 93);
            this.Oda_txtbox.Name = "Oda_txtbox";
            this.Oda_txtbox.Size = new System.Drawing.Size(125, 27);
            this.Oda_txtbox.TabIndex = 8;
            // 
            // giris_txt
            // 
            this.giris_txt.Location = new System.Drawing.Point(384, 60);
            this.giris_txt.Name = "giris_txt";
            this.giris_txt.Size = new System.Drawing.Size(125, 27);
            this.giris_txt.TabIndex = 9;
            // 
            // girisT_txt
            // 
            this.girisT_txt.AutoSize = true;
            this.girisT_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.girisT_txt.Location = new System.Drawing.Point(286, 60);
            this.girisT_txt.Name = "girisT_txt";
            this.girisT_txt.Size = new System.Drawing.Size(92, 20);
            this.girisT_txt.TabIndex = 10;
            this.girisT_txt.Text = "Giris Tarihi :";
            // 
            // cikisT_txt
            // 
            this.cikisT_txt.AutoSize = true;
            this.cikisT_txt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cikisT_txt.Location = new System.Drawing.Point(286, 96);
            this.cikisT_txt.Name = "cikisT_txt";
            this.cikisT_txt.Size = new System.Drawing.Size(92, 20);
            this.cikisT_txt.TabIndex = 11;
            this.cikisT_txt.Text = "Çıkış Tarihi :";
            // 
            // Cikis_txt
            // 
            this.Cikis_txt.Location = new System.Drawing.Point(384, 93);
            this.Cikis_txt.Name = "Cikis_txt";
            this.Cikis_txt.Size = new System.Drawing.Size(125, 27);
            this.Cikis_txt.TabIndex = 12;
            // 
            // iptalleri_göster
            // 
            this.iptalleri_göster.Location = new System.Drawing.Point(532, 216);
            this.iptalleri_göster.Name = "iptalleri_göster";
            this.iptalleri_göster.Size = new System.Drawing.Size(210, 29);
            this.iptalleri_göster.TabIndex = 13;
            this.iptalleri_göster.Text = "İptal rezervasyonlaı göster";
            this.iptalleri_göster.UseVisualStyleBackColor = true;
            this.iptalleri_göster.Click += new System.EventHandler(this.iptalleri_göster_Click);
            // 
            // iptal_ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 403);
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
    }
}