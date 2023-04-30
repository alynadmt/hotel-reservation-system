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
using System.Collections;

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
              
                SqlCommand cmd = new SqlCommand("exec insertprocmüs @ad,@soyad,@telno,@tc,@dtarih,@mail", baglan);
             
                cmd.Parameters.AddWithValue("@ad", ad2textbox.Text);
                cmd.Parameters.AddWithValue("@soyad", soyad2textbox.Text);
                cmd.Parameters.AddWithValue("@telno", telno2textbox.Text);
                cmd.Parameters.AddWithValue("@tc", tc2textbox.Text);
                cmd.Parameters.AddWithValue("@dtarih", Convert.ToDateTime(dateTimePicker1.Text)); 
                cmd.Parameters.AddWithValue("@mail", email2textbox.Text);
           

           
                cmd.ExecuteNonQuery();
                
            }
            catch
            {
                MessageBox.Show("Müşteri Bilgilerinde Boş Alan Bırakmayınız");
            }
            //try
           // {

                // SqlCommand cmd2 = new SqlCommand("exec insertprocrez @tc,@odano,@gtarih,@ctarih,500", baglan);

              
                   SqlCommand cmd2 = new SqlCommand("exec commission_calculate @tc,@odano,@gtarih,@ctarih", baglan);
                      cmd2.CommandType = CommandType.StoredProcedure;

            SqlCommand cmd3 = new SqlCommand("exec fullness_update @odano", baglan);
              //  SqlCommand cmd4 = new SqlCommand(" declare @s3 int \r\nselect @s3=StilID from Odalar where OdaId=@odano\r\nselect Stil from Oda_Stil where StilID=@s3 \r\nselect KSayiID from Oda_Stil where StilID=@s3");
            //    SqlCommand cmd4 = new SqlCommand("exec commission_calculate @odano",baglan);
                 
                //cmd3.Parameters.AddWithValue("@komisyon", Convert.ToInt64(komisyontextBox.Text));
              //  cmd4.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));
            
                cmd2.Parameters.AddWithValue("@tc", tc2textbox.Text);
                cmd2.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));
                cmd2.Parameters.AddWithValue("@gtarih", Convert.ToDateTime(dateTimePicker2.Text));
                cmd2.Parameters.AddWithValue("@ctarih", Convert.ToDateTime(dateTimePicker3.Text));
                cmd3.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));

                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
               // cmd4.ExecuteNonQuery();

                MessageBox.Show("Rezervasyon Başarılı");
           // }
           /* catch
            {
                MessageBox.Show("Oda Bilgileri Kısmında Boş Alan Bırakmayınız ");
            }             /* catch(Exception ex) 
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
