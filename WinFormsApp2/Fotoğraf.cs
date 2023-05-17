using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Fotoğraf : Form
    {
       public static int resim_sıra= 1;
        public static int resim_sıra2 = 5;
        string a = Entrance.a2;
        string b = Entrance.b2;
        string c = Entrance.c2;

        public Fotoğraf()
        {
            InitializeComponent();
          
          
            if (a == "Normal Oda"  && c=="2 Kişilik")
            {
              
                pictureBox1.Image = Image.FromFile(resim_sıra+".jpg");

            }
         if (a=="Normal Oda"  && c == "3 Kişilik")
            {
               
                pictureBox1.Image = Image.FromFile(resim_sıra2+".jpg");

            }
          

        }
        private void Fotoğraf_Load(object sender, EventArgs e)
        {
   

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == "2 Kişilik")
            {
                resim_sıra--;
                if (resim_sıra < 1)
                { MessageBox.Show("fotoğraf bitmiştir");
                    
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(resim_sıra+".jpg");

                }
            }if(c=="2 Kişilik")
            {
               
                resim_sıra2--;
                if (resim_sıra < 5)

                { MessageBox.Show("fotoğraf bitmiştir2"); }
                else
                {
                    pictureBox1.Image = Image.FromFile(resim_sıra2 + ".jpg");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {if (c=="2 Kişilik")
            {

                resim_sıra++;

                if (resim_sıra >4)
                {
                    MessageBox.Show("fotoğraf bitmiştir");
                    
                }
                else
                {

                    pictureBox1.Image = Image.FromFile(resim_sıra+".jpg");

                }
            }if(c=="3 Kişilik")
            {
                resim_sıra2++;
               
                if (resim_sıra2 > 8)
                {
                    MessageBox.Show("fotoğraf bitmiştir2");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(resim_sıra2+ ".jpg");

                }

            }
        
        }
    }
}
