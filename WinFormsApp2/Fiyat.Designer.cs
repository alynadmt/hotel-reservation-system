﻿namespace WinFormsApp2
{
    partial class Fiyat
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
            this.ücret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ücret
            // 
            this.ücret.Location = new System.Drawing.Point(68, 107);
            this.ücret.Name = "ücret";
            this.ücret.Size = new System.Drawing.Size(409, 31);
            this.ücret.TabIndex = 0;
            this.ücret.TextChanged += new System.EventHandler(this.ücret_TextChanged);
            // 
            // Fiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ücret);
            this.Name = "Fiyat";
            this.Text = "Fiyat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ücret;
    }
}