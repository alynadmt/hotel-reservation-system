using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class rezervasyon : Form
    {
        public rezervasyon()
        {
            InitializeComponent();
            
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_2;Integrated Security=true");
        private void goster()
        {
            baglan.Open();
            SqlCommand kom = new SqlCommand("select * from Müsteri", baglan);
            SqlDataReader oku= kom.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Müs_No"].ToString();
                ekle.SubItems.Add(oku["Müs_Ad"].ToString());
                ekle.SubItems.Add(oku["Müs_Soyad"].ToString());
                ekle.SubItems.Add(oku["Müs_TelNo"].ToString());
                ekle.SubItems.Add(oku["Müs_Tc"].ToString());
                ekle.SubItems.Add(oku["Müs_DTarihi"].ToString());
                ekle.SubItems.Add(oku["Müs_Mail"].ToString());

                //listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
       
    private void rezbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("insert into Müsteri(Müs_Ad,Müs_Soyad,Müs_TelNo,Müs_Tc,Müs_DTarihi,Müs_Mail)Values(@ad,@soyad,@telno,@tc,@dtarihi,@mail)", baglan);
            cmd.Parameters.AddWithValue("@ad", ad2textbox.Text);
            cmd.Parameters.AddWithValue("@soyad", soyad2textbox.Text);
            cmd.Parameters.AddWithValue("@telno", telno2textbox.Text);
            cmd.Parameters.AddWithValue("@tc", tc2textbox.Text);
            cmd.Parameters.AddWithValue("@dtarih",dateTimePicker1.Text); //DateTime.Now yerine başka bir değer atayabilirsiniz.
            cmd.Parameters.AddWithValue("@mail", email2textbox.Text);
   
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
    
    private void rezervasyon_Load(object sender, EventArgs e)
        {

        }

        private void rezetbutton_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
               // int a1;
                SqlCommand cmd = new SqlCommand("exec insertprocmüs @ad,@soyad,@telno,@tc,@dtarih,@mail", baglan);
               // SqlCommand cmd2 = new SqlCommand("exec insertprocrez @tc,@odano,@gtarihi,@ctarihi", baglan);
              /*  SqlCommand cmd3 = new SqlCommand("declare @s1 datetime,@s2 datetime  ,@s3 int\r\nselect @s1=Giriş_Tarihi,@s2=Çıkış_Tarihi from rezervasyon where OdId=@odano");
                SqlCommand cmd4 = new SqlCommand("declare ,@s4 int select @s4=dbo.fiyatlandır(@s1,@s2,2)");
                SqlDataReader dr = cmd.ExecuteReader();
                a1= (int)Convert.ToInt64(dr[0]);
                ücret.Text = Convert.ToString(a1);*/
                cmd.Parameters.AddWithValue("@ad", ad2textbox.Text);
                cmd.Parameters.AddWithValue("@soyad", soyad2textbox.Text);
                cmd.Parameters.AddWithValue("@telno", telno2textbox.Text);
                cmd.Parameters.AddWithValue("@tc", tc2textbox.Text);
                cmd.Parameters.AddWithValue("@dtarih", Convert.ToDateTime(dateTimePicker1.Text)); //DateTime.Now yerine başka bir değer atayabilirsiniz.
                cmd.Parameters.AddWithValue("@mail", email2textbox.Text);
             /*   cmd2.Parameters.AddWithValue("@tc", tc2textbox.Text);
                cmd2.Parameters.AddWithValue("@odano", Convert.ToInt32(odanotextBox.Text));
                cmd2.Parameters.AddWithValue("@gtarih", Convert.ToDateTime(dateTimePicker2.Text));
                cmd2.Parameters.AddWithValue("@ctarih", Convert.ToDateTime(dateTimePicker3.Text));*/
               
                //   cmd2.Parameters.AddWithValue("@tc", tc2textbox.Text)
           
                cmd.ExecuteNonQuery();
                //  cmd2.ExecuteNonQuery();
                /* cmd3.ExecuteNonQuery();
                 cmd4.ExecuteNonQuery();*/

                MessageBox.Show("başarılı1");
            }
            catch
            {
                MessageBox.Show("boş alan bırakmayınız müs");
            }
           
                SqlCommand cmd2 = new SqlCommand("exec insertprocrez @tc,@odano,@gtarih,@ctarih,500",baglan);
                cmd2.Parameters.AddWithValue("@tc", tc2textbox.Text);
                cmd2.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));
                cmd2.Parameters.AddWithValue("@gtarih", Convert.ToDateTime(dateTimePicker2.Text));
                cmd2.Parameters.AddWithValue("@ctarih", Convert.ToDateTime(dateTimePicker3.Text));
            cmd2.ExecuteNonQuery();


            MessageBox.Show("başarılı2");
                          /* catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());

            }

            //   MessageBox.Show("Başarılı");
            baglan.Close();*/
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            goster();
        }

        private void komisyontextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
