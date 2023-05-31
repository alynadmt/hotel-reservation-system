namespace WinFormsApp2
{
    partial class mevcut_gelecek_rezSorgu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mevcut_gelecek_rezSorgu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Gelecek_Rez_btn = new System.Windows.Forms.Button();
            this.Mevcut_rez_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Gelecek_Rez_btn
            // 
            this.Gelecek_Rez_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Gelecek_Rez_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Gelecek_Rez_btn.Location = new System.Drawing.Point(252, 434);
            this.Gelecek_Rez_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gelecek_Rez_btn.Name = "Gelecek_Rez_btn";
            this.Gelecek_Rez_btn.Size = new System.Drawing.Size(256, 68);
            this.Gelecek_Rez_btn.TabIndex = 1;
            this.Gelecek_Rez_btn.Text = "Yaklaşan Rezervasyonlar";
            this.Gelecek_Rez_btn.UseVisualStyleBackColor = false;
            this.Gelecek_Rez_btn.Click += new System.EventHandler(this.Gelecek_Rez_btn_Click);
            // 
            // Mevcut_rez_btn
            // 
            this.Mevcut_rez_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Mevcut_rez_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mevcut_rez_btn.Location = new System.Drawing.Point(609, 434);
            this.Mevcut_rez_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Mevcut_rez_btn.Name = "Mevcut_rez_btn";
            this.Mevcut_rez_btn.Size = new System.Drawing.Size(230, 68);
            this.Mevcut_rez_btn.TabIndex = 2;
            this.Mevcut_rez_btn.Text = "Mevcut Rezervasyonlar";
            this.Mevcut_rez_btn.UseVisualStyleBackColor = false;
            this.Mevcut_rez_btn.Click += new System.EventHandler(this.Mevcut_rez_btn_Click);
            // 
            // mevcut_gelecek_rezSorgu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1111, 602);
            this.Controls.Add(this.Mevcut_rez_btn);
            this.Controls.Add(this.Gelecek_Rez_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mevcut_gelecek_rezSorgu";
            this.Text = "mevcut_gelecek_rezSorgu";
            this.Load += new System.EventHandler(this.mevcut_gelecek_rezSorgu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button Gelecek_Rez_btn;
        private Button Mevcut_rez_btn;
    }
}