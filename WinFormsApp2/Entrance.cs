using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApp2
{
    public partial class Entrance : Form
    {

        public Entrance()
        {
            InitializeComponent();
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            button1.Parent = pictureBox1;
            button1.BackColor= Color.Transparent;
            button1.Parent= pictureBox1;
            button1.FlatAppearance.BorderColor = Color.LightSteelBlue;
         
            button2.Parent = pictureBox1;
            button2.BackColor = Color.Transparent;
            button2.Parent = pictureBox1;
            button2.FlatAppearance.BorderColor = Color.LightSteelBlue;

            /*  button3.Parent= pictureBox1;
            button3.BackColor = Color.Transparent;
            button3.Parent= pictureBox1;
            button3.FlatAppearance.BorderColor = Color.LightSteelBlue;*/
            datagridviewsetting(dataGridView1);
          
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_12;Integrated Security=true");
        public void odalarıgetir()
        {
            baglan.Open();
            //dataGridView1.Rows.Clear();
          dataGridView1.Columns.Clear();
            SqlCommand cmd = new SqlCommand("exec Oda_Sorgu_2 @odakişi,@odastil,@gtarihi,@ctarihi\r\n", baglan);
            cmd.Parameters.AddWithValue("@odastil", Convert.ToString(odastilcombobox.Text));
            cmd.Parameters.AddWithValue("@odakişi", Convert.ToString(kişisayısıcombobox.Text));
            cmd.Parameters.AddWithValue("@gtarihi",Convert.ToDateTime(gtarihitext.Text));
            cmd.Parameters.AddWithValue("@ctarihi", Convert.ToDateTime(crarihitext.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            button();

            
            baglan.Close();
          

        }
        public void datagridviewsetting(DataGridView datagridview)
        {
            dataGridView1.RowHeadersVisible= false;
            datagridview.BorderStyle= BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            datagridview.DefaultCellStyle.SelectionBackColor= Color.DarkOrange;
            datagridview.DefaultCellStyle.SelectionForeColor= Color.Black;
            datagridview.EnableHeadersVisualStyles= false;
            datagridview.ColumnHeadersBorderStyle= DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



        }
        public void button()
        {

            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            btn1.HeaderText = "Fotoğraf";
            btn1.Text = "Fotoğraf";
            btn1.Name = "Fotoğraf";
            btn1.UseColumnTextForButtonValue = true;
            btn1.DefaultCellStyle.BackColor = Color.Orange;
            btn1.DefaultCellStyle.SelectionBackColor = Color.Blue;

            btn1.Width = 50;

            //Butonu kolon olarak ekliyoruz
            dataGridView1.Columns.Add(btn1);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Entrance_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Denizin eşsiz dinginliğiyle birleşen rahatlık, konfor ve lüks dünyasına bizimle adım atın.\r\n\r\nZarafet ve mükemmelliği bir arada yaşayabileceğiniz, size eşsiz bir liman olacak Cettia Beach Resort'a doyamayacaksınız. Üstün hizmet ayrıcalığımız ve içten misafirperverliğimizle keyifli ve hafızanızdan silinmeyecek bir tatil sizleri bekliyor. \r\n\r\nCettia Beach Resort, Cettia ailesinin en yeni üyesi. Otelimizin konumu itibariyle limana, Marmaris şehir merkezine ve kapalı çarşıya dakikalar içerisinde ulaşım sağlayabilirsiniz. Ayrıca tesisimiz Dalaman Uluslararası Havaalanına 96 km, Marmaris şehir merkezine 3,5 km uzaklıkta olup tüm ulaşım olanaklarına sahiptir.\r\n\r\nOtelimize ait özel iskelede güneşin tadını çıkarırken bünyemizde bulunan restauranttan ve iki adet bardan dilediğiniz gibi faydalanabilir, spa merkezimizde ruhsal ve bedensel arınmanızı tamamlayabilirsiniz.\r\n\r\nTesisimiz 12 ay boyunca samimi, sıcak, modern, dinlendirici atmosferiyle sizlere ev sahipliği yapıyor. Denizin mavisi doğanın yeşiliyle dans ederken kendinizi ödüllendirin ve bu keyfe siz de ortak olun.","Hakkımızda");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void odabulbtn_Click(object sender, EventArgs e)
        {
            odalarıgetir();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string a2;
        public static string b2;
        public static string c2;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Fotoğraf"].Index)
            {
                baglan.Open();

                SqlCommand cmd = new SqlCommand("exec Oda_Sorgu_2 @odakişi,@odastil,@gtarihi,@ctarihi\r\n", baglan);
                cmd.Parameters.AddWithValue("@odastil", Convert.ToString(odastilcombobox.Text));
                cmd.Parameters.AddWithValue("@odakişi", Convert.ToString(kişisayısıcombobox.Text));
                cmd.Parameters.AddWithValue("@gtarihi", Convert.ToDateTime(gtarihitext.Text));
                cmd.Parameters.AddWithValue("@ctarihi", Convert.ToDateTime(crarihitext.Text));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                { 
                    string a = reader["Stil"].ToString();
                    string b = reader["Yatak"].ToString();
                    string c = reader["Kisi_Sayisi"].ToString() ;
                    a2 = a;
                    b2 = b;
                    c2 = c;
                    if (c == "2 Kişilik" || c == "3 Kişilik")
                    {
                        Fotoğraf fm = new Fotoğraf();
                        fm.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Odanın Görseli Bulunmamaktadır...");
                    }
                  
                }
                baglan.Close();
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update rezervasyon set Oda_Id=12 where Giriş_Tarihi='2023-05-12 00:00:00.000'", baglan);
        }
    }
}
