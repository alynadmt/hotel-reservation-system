using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class hangiodadakonakladı : Form
    {
        public hangiodadakonakladı()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            datagridviewsetting(dataGridView1);
            tümodalarıgetir();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_8;Integrated Security=true");
        void odalarıgetir()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("exec Hangiodadakonakladım @tc", baglan);
            cmd.Parameters.AddWithValue("@tc", textBox1.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;



            baglan.Close();
        }
        void tümodalarıgetir()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("select* from odalar_view", baglan);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            


            baglan.Close();
        }
            public void datagridviewsetting(DataGridView datagridview)
        {
            dataGridView1.RowHeadersVisible = false;
            datagridview.BorderStyle = BorderStyle.None;
            datagridview.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            datagridview.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            datagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            datagridview.EnableHeadersVisualStyles = false;
            datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            datagridview.ColumnHeadersDefaultCellStyle.BackColor = Color.Orange;
            datagridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            datagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



        }
        private void hangiodadakonakladı_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            odalarıgetir();
            baglan.Open();
            SqlCommand cmd = new SqlCommand("\r\nselect * from müşteriler where Müs_Tc=@tc", baglan);
            cmd.Parameters.AddWithValue("@tc", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string a = reader["Müs_Ad"].ToString();
                adlbl.Text = a;

                string b = reader["Müs_Soyad"].ToString();
                soylbl.Text = b;
                string c = reader["Müs_TelNo"].ToString();
                tellbl.Text = c;
                string d = reader["Müs_Tc"].ToString();
                tclbl.Text = d;
                string w = reader["Müs_DTarihi"].ToString();
                dogumlbl.Text = w;
                string f = reader["Müs_Mail"].ToString();
                maillbl.Text = f;

            }
            baglan.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
