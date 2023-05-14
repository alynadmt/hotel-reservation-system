using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class anaekran : Form
    {
        public anaekran()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void anaekran_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            rezervasyon rez = new rezervasyon();
            rez.TopLevel= false;
            panel3.Controls.Add(rez);
            rez.Show();
            rez.Dock= DockStyle.Fill;
            rez.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            odadakimkalıyor kim = new odadakimkalıyor();
            kim.TopLevel = false;
            panel3.Controls.Add(kim);
            kim.Show();
            kim.Dock = DockStyle.Fill;
            kim.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
