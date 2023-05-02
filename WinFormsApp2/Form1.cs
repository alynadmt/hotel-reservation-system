using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source =LAPTOP-S74S2GFL; Initial Catalog=YaAl_Hotel_3; Integrated Security=TRUE ");
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_giris_MouseHover(object sender, EventArgs e)
        {
            btn_giris.BackColor = Color.Teal;
        }
        
        private void btn_giris_MouseLeave(object sender, EventArgs e)
        {
            btn_giris.BackColor = Color.Turquoise;
                }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        bool isThere;
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullanıcı_adı = txt_ad.Text;
            string sıfre = txt_sifre.Text;
            
            connection.Open();
            SqlCommand command = new SqlCommand("Select *from kayıt_ekranı", connection);
            SqlDataReader reader = command.ExecuteReader();
             
            anaekran form2 = new anaekran();



            while (reader.Read())
            {
                string a = reader["kullanıcı_adı"].ToString();
                string b = reader["sifre"].ToString();
                string c = txt_ad.Text;
                string d = txt_sifre.Text;

                if (c == a && d == b
)
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }

            }
            
            if(isThere)
            {
                MessageBox.Show("Basariyla giris yaptiniz", "Program");
                form2.Show();  // form2 göster diyoruz
                this.Hide();   // bu yani form1 gizle diyoruz

            }
            else
            {
                MessageBox.Show("Giris yapamadiniz ", "program");
            }
           
        }
    }
}