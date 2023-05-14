using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Fotoğraf : Form
    {
        public Fotoğraf()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile("2023-12-04.jpg");
           

        }

        private void Fotoğraf_Load(object sender, EventArgs e)
        {
   

          
        }
    }
}
