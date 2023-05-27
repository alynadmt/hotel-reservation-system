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

        private void hnagiOdalardaKaldıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bilgileriGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            müşterigüncelleme kim = new müşterigüncelleme();
            kim.TopLevel = false;
            panel3.Controls.Add(kim);
            kim.Show();
            kim.Dock = DockStyle.Fill;
            kim.BringToFront();
        }

        private void menuStrip2_ItemClicked_2(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hangiOdadaKonakladıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            hangiodadakonakladı kim = new hangiodadakonakladı();
            kim.TopLevel = false;
            panel3.Controls.Add(kim);
            kim.Show();
            kim.Dock = DockStyle.Fill;
            kim.BringToFront();
        }

        private void menuStrip2_ItemClicked_3(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_4(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bilgileriGüncelleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            müşterigüncelleme kim = new müşterigüncelleme();
            kim.TopLevel = false;
            panel3.Controls.Add(kim);
            kim.Show();
            kim.Dock = DockStyle.Fill;
            kim.BringToFront();
        }

        private void Rez_iptal_btn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            iptal_ekranı rez = new iptal_ekranı();
            rez.TopLevel = false;
            panel3.Controls.Add(rez);
            rez.Show();
            rez.Dock = DockStyle.Fill;
            rez.BringToFront();
        }

        private void Rez_sorgu_btn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            mevcut_gelecek_rezSorgu rez = new mevcut_gelecek_rezSorgu();
            rez.TopLevel = false;
            panel3.Controls.Add(rez);
            rez.Show();
            rez.Dock = DockStyle.Fill;
            rez.BringToFront();
        }
    }
}
