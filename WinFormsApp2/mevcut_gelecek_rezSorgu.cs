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
    public partial class mevcut_gelecek_rezSorgu : Form
    {
        public mevcut_gelecek_rezSorgu()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_12;Integrated Security=true");
        private void Gelecek_Rez_btn_MouseHover(object sender, EventArgs e)
        {
            Gelecek_Rez_btn.BackColor = Color.Teal;
        }

        private void Gelecek_Rez_btn_MouseLeave(object sender, EventArgs e)
        {
            Gelecek_Rez_btn.BackColor = Color.Turquoise;
        }
        private void Gelecek_Rez_btn_Click(object sender, EventArgs e)
        {

            con.Open();
            string select = "select Rez_Id , Müc_Tc, Oda_Id, Giriş_Tarihi, Çıkış_Tarihi ,\r\nDatediff (day,getdate(),Giriş_Tarihi) \r\nas Kalan_Gün\r\nfrom rezervasyon \r\nwhere Datediff(day, Giriş_Tarihi,getdate()) <5";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
        SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=YaAl_Hotel_11;Integrated Security=true");
        private void Mevcut_rez_btn_MouseHover(object sender, EventArgs e)
        {
            Mevcut_rez_btn.BackColor = Color.Teal;
        }

        private void Mevcut_rez_btn_MouseLeave(object sender, EventArgs e)
        {
            Mevcut_rez_btn.BackColor = Color.Turquoise;
        }

        private void Mevcut_rez_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string select = "\r\nselect Rez_Id , Müc_Tc, Oda_Id, Giriş_Tarihi, Çıkış_Tarihi ,\r\nDatediff (day,getdate(),Çıkış_Tarihi) \r\nas Çıkışa_kalan_gün_sayısı\r\nfrom rezervasyon \r\nwhere Datediff(day, Giriş_Tarihi,getdate()) >=0 and \r\n Datediff(day,Çıkış_Tarihi,getdate())<10";
            SqlDataAdapter da = new SqlDataAdapter(select, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void geri_btn2_Click(object sender, EventArgs e)
        {

        }

        private void mevcut_gelecek_rezSorgu_Load(object sender, EventArgs e)
        {

        }
    }
}

