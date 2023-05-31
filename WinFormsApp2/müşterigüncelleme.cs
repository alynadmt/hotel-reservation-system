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
    public partial class müşterigüncelleme : Form
    {
        public müşterigüncelleme()
        {
            InitializeComponent();
            tümmüşterilerigetir();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_12;Integrated Security=true");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        void tümmüşterilerigetir()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select * from müşteriler", baglan);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;



            baglan.Close();
        }
       void Müşteribul()
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select* from müşteriler where Müs_Tc = @tc\r\n", baglan);
            cmd.Parameters.AddWithValue("@tc", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;



            baglan.Close();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Müşteribul();
        }
     
       
        private void müşterigüncelleme_Load(object sender, EventArgs e)
        {
          
        }
        private void button2_Click(object sender, EventArgs e)
        {

            baglan.Open();
            SqlCommand cmd = new SqlCommand("exec update_müsteri @ad,@soyad,@tc,@tel,@mail,@dtarihi \r\n", baglan);
            cmd.Parameters.AddWithValue("@ad", ad2textbox.Text);
            cmd.Parameters.AddWithValue("@soyad", soyad2textbox.Text);
            cmd.Parameters.AddWithValue("@tc", tc2textbox.Text);
            cmd.Parameters.AddWithValue("@tel", telno2textbox.Text);
            cmd.Parameters.AddWithValue("@dtarihi",Convert.ToDateTime(dtext.Text));
            cmd.Parameters.AddWithValue("@mail", email2textbox.Text);
            
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Bilgiler Güncellendi");
            tümmüşterilerigetir();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ad2textbox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            soyad2textbox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tc2textbox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            telno2textbox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dtext.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            email2textbox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

    }
}
