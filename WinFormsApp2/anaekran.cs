using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
