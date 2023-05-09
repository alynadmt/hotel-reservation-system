using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_4;Integrated Security=true");
        public void odalarıgetir()
        {
            baglan.Open();
           
            SqlCommand cmd = new SqlCommand("exec Oda_sorgu @odakişi,@odastil,@gtarihi,10,2023,09", baglan);
            cmd.Parameters.AddWithValue("@odastil", Convert.ToString(odastilcombobox.Text));
            cmd.Parameters.AddWithValue("@odakişi", Convert.ToString(kişisayısıcombobox.Text));
            cmd.Parameters.AddWithValue("@gtarihi",Convert.ToDateTime(gtarihitext.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
          
    

            baglan.Close();

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
    }
}
