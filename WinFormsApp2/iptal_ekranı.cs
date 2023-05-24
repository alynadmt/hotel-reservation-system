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
    public partial class iptal_ekranı : Form
    {
        public iptal_ekranı()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //SqlConnection baglan2 = new SqlConnection("Data Source=.; Initial Catalog= YaAl_Hotel_9;Integrated Security=true");
        // SqlConnection conn = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog= YaAl_Hotel_10;Integrated Security=true");
      //SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_10;Integrated Security=true");
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_10;Integrated Security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("delete from rezervasyon where Oda_Id=@Odano and Giriş_Tarihi = @giristarihi and Çıkış_Tarihi=@Çıkış_tarihi", baglan);

            cmd.Parameters.AddWithValue("@Odano",Convert.ToInt64(Oda_txtbox.Text));
            string a = " 00:00:00.000";
            string b = giris_txt.Text;
            string c = b+a;

            string k = " 00:00:00.000"; 
            string l = Cikis_txt.Text;
            string m = l+k;
            cmd.Parameters.AddWithValue("@giristarihi",Convert.ToDateTime(c));
            cmd.Parameters.AddWithValue("@Çıkış_tarihi",Convert.ToDateTime(m));

            cmd.ExecuteNonQuery();
           // baglan.Close();
            // cmd.Parameters.AddWithValue("@telno", telno2textbox.Text);
            MessageBox.Show("selammm");
           baglan.Close();





        }

        private void iptalleri_göster_Click(object sender, EventArgs e)
        {
             
        }
      //  SqlConnection baglanti();
        private void iptal_ekranı_Load(object sender, EventArgs e)
        {

        }

        private void Oda_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

          /**  SqlConnection baglan = new SqlConnection("Data Source=.; Initial Catalog=YaAl_Hotel_7;Integrated Security=true");
            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from rezervasyon where Rez_Id=@Rez_Id ", baglan);

            sil.Parameters.AddWithValue("Rez_Id", Rez_txtbox.Text);
            
            MessageBox.Show("veri silindi");


            sil.ExecuteNonQuery();
            baglan.Close();
          **/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update rezervasyon set Oda_Id=12 where Giriş_Tarihi='2023-05-12 00:00:00.000'", baglan);

        }
    }
}
