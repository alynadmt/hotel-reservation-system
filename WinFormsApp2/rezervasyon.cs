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
           /* label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;*/

        }
        SqlConnection baglan = new SqlConnection("Data Source=.; Initial Catalog=YaAl_Hotel_7;Integrated Security=true");
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
            
        { baglan.Open();
            /*  SqlCommand cmd3 = new SqlCommand("select DolulukId from Odalar where OdaId=@odano", baglan);
             cmd3.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));
             SqlDataReader reader = cmd3.ExecuteReader();
             while (reader.Read())
             {
                 string a = reader["DolulukId"].ToString();
                 int a2 = (int)Convert.ToInt64(a);
                 int b = 1;
                 if (a2 == b)
                 {
                     MessageBox.Show("Oda Bu Tarihler Arası Doludur");
                     break;
                 }
                 else
                 {
                     baglan.Close();
                     baglan.Open();
                         SqlCommand cmd = new SqlCommand("exec make_reservation_2 '3567890908',21,'2023-09-10','2023-09-15','Meryem','Gürbüz','05467090090','1992-11-12','fghjkjhgfgh'\r\n", baglan);

                         cmd.Parameters.AddWithValue("@ad", ad2textbox.Text);
                         cmd.Parameters.AddWithValue("@soyad", soyad2textbox.Text);
                         cmd.Parameters.AddWithValue("@telno", telno2textbox.Text);
                         cmd.Parameters.AddWithValue("@tc", tc2textbox.Text);
                         cmd.Parameters.AddWithValue("@dtarih", Convert.ToDateTime(dateTimePicker1.Text));
                         cmd.Parameters.AddWithValue("@mail", email2textbox.Text);



                       cmd.ExecuteNonQuery();



                     SqlCommand cmd2 = new SqlCommand("exec insertprocrez @tc,@odano,@gtarih,@ctarih", baglan);


                     cmd2.Parameters.AddWithValue("@tc", tc2textbox.Text);
                     cmd2.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));
                     cmd2.Parameters.AddWithValue("@gtarih", Convert.ToDateTime(dateTimePicker2.Text));
                     cmd2.Parameters.AddWithValue("@ctarih", Convert.ToDateTime(dateTimePicker3.Text));

                     cmd2.ExecuteNonQuery();


                     MessageBox.Show("Rezervasyon Başarılı");
                     break;
                 }
             }*/
            SqlCommand cmd2 = new SqlCommand("select Giriş_Tarihi from rezervasyon where Müc_Tc=@tc", baglan);
            cmd2.Parameters.AddWithValue("@tc", tc2textbox.Text);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string a = reader["Giriş_Tarihi"].ToString();
                string d = Convert.ToString(dateTimePicker2.Text);
               int sonuc = String.Compare(d, a);
                if (sonuc ==-1)
                {
                    MessageBox.Show("Aynı kişi Giriş tarihi aynı olan bir rezervasyon yapamaz...");
                    break;
                }

            else
                {
                    baglan.Close();
                    baglan.Open();
                      SqlCommand cmd = new SqlCommand("exec make_reservation_2 @tc,@odano,@gtarih,@ctarih,@ad,@soyad,@telno,@dtarih,@mail", baglan);
                      cmd.Parameters.AddWithValue("@ad", ad2textbox.Text);
                      cmd.Parameters.AddWithValue("@soyad", soyad2textbox.Text);
                      cmd.Parameters.AddWithValue("@telno", telno2textbox.Text);
                      cmd.Parameters.AddWithValue("@tc", tc2textbox.Text);
                      cmd.Parameters.AddWithValue("@dtarih", Convert.ToDateTime(dateTimePicker1.Text));
                      cmd.Parameters.AddWithValue("@mail", email2textbox.Text);
                      cmd.Parameters.AddWithValue("@odano", Convert.ToInt64(odanotextBox.Text));
                      cmd.Parameters.AddWithValue("@gtarih", Convert.ToDateTime(dateTimePicker2.Text));
                      cmd.Parameters.AddWithValue("@ctarih", Convert.ToDateTime(dateTimePicker3.Text));



                      cmd.ExecuteNonQuery();
                      MessageBox.Show("rezerveee");
                      fatura ftr = new fatura();
                    ftr.Show();
                    break;
                }
            }

             
           
            baglan.Close();


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

        private void ücret_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            iptal_ekranı slm = new iptal_ekranı();  
            slm.Show();
            this.Hide();

        }
    }
}
