using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source =.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_12; Integrated Security=TRUE ");
        public Form1()
        {
            InitializeComponent();
            label3.Parent = pictureBox2;
            label3.BackColor = Color.Transparent;
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
            SqlCommand command = new SqlCommand("Select *from login", connection);
            SqlDataReader reader = command.ExecuteReader();
             
            anaekran form2 = new anaekran();
            İdare_İşlem_Ekran form3 = new İdare_İşlem_Ekran();
            Form1 form1 = new Form1();



            while (reader.Read())
            {
                string a = reader["Kullanıcı_Adı"].ToString().Trim();
                string b = reader["Sifre"].ToString().Trim();
                string c = txt_ad.Text;
                string d = txt_sifre.Text;
             
                char idare = Convert.ToChar((( reader["Kullanıcı_Adı"].ToString().Trim().Substring(0,1))));
                char i = 'i';
                if (c == "" && d == "")
                {
                    MessageBox.Show("Lütfen Kullanıcı adı ve Şifre giriniz ");
                    break;
                }
               else if (c == a && d == "")
                {
                    MessageBox.Show("Lütfen  Şifre giriniz");
                    break;

                }
              else  if (d == b && c == "")
                {
                    MessageBox.Show("Lütfen  Kullanıcı Adı  giriniz");
                       break;
                }
                else
                {
                    if ((c == a && c != "") && ((d == b && d != "")) && (idare != i))
                    {
                      //  MessageBox.Show("Basariyla giris yaptiniz", "Program");

                        connection.Close();
                        connection.Open();
                       /* SqlCommand kom = new SqlCommand("insert Login_Processes values(@Kullanıcı_adı,GETDATE())", connection);
                        kom.Parameters.AddWithValue("@Kullanıcı_adı", txt_ad.Text);*/
                       // kom.ExecuteNonQuery();

                        form2.Show();  // form2 göster diyoruz
                        this.Hide();   // bu yani form1 gizle diyoruz
                        break;


                    }
                  /*  else if ((c == a && c != "") && ((d == b && d != "")) && (idare == i))
                    {
                        MessageBox.Show("Basariyla giris yaptiniz", "Program");

                        form3.Show();  // form2 göster diyoruz
                        this.Hide();   // bu yani form1 gizle diyoruz
                        break;


                    }*/

                 else   if ((c != a && c != "") && ((d == b && d != "")))
                    {
                        MessageBox.Show("Kullanıcı adı veya şifrenizi kontrol ediniz...", "Program");

                        break;
                      
                    }
                else    if ((c == a && c != "") && ((d != b && d != "")))
                    {
                        MessageBox.Show("Kullanıcı adı veya şifrenizi kontrol ediniz...", "Program");
                        break;
                    }
                 /*   else if ((c != a && c != "") && ((d != b && d != "")))
                    {
                        MessageBox.Show("Kullanıcı adı veya şifrenizi kontrol ediniz...3", "Program");
                        
                    }*/

                }
           
            
            }
           connection.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /* if(isThere)
         {
             MessageBox.Show("Basariyla giris yaptiniz", "Program");
             form2.Show();  // form2 göster diyoruz
             this.Hide();   // bu yani form1 gizle diyoruz

         }
         else
         {
             MessageBox.Show("Giris yapamadiniz ", "program");
         }
        */
    }
    }
