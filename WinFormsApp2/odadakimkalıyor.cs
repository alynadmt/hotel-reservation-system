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
    public partial class odadakimkalıyor : Form
    {
        public odadakimkalıyor()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            datagridviewsetting(dataGridView2);
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_4;Integrated Security=true");
        public void Müşgetir()
        {
            baglan.Open();

            SqlCommand cmd = new SqlCommand("exec odadakimkalıyor2 @odano,@gtarihi,@ctarihi\r\n", baglan);
            cmd.Parameters.AddWithValue("@odano", Convert.ToInt64(odatext.Text));
            cmd.Parameters.AddWithValue("@gtarihi", Convert.ToDateTime(gtext.Text));
            cmd.Parameters.AddWithValue("@ctarihi", Convert.ToDateTime(ctext.Text));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
          


            baglan.Close();

        }
        public void datagridviewsetting(DataGridView datagridview)
        {
            dataGridView2.RowHeadersVisible = false;
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
        private void odadakimkalıyor_Load(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand cmd2 = new SqlCommand("exec odadakimkalıyor @odano,@gtarihi,@ctarihi", baglan);
            cmd2.Parameters.AddWithValue("@odano",Convert.ToInt64(odatext.Text));
            cmd2.Parameters.AddWithValue("@gtarihi",Convert.ToDateTime(gtext.Text));
            cmd2.Parameters.AddWithValue("@ctarihi",Convert.ToDateTime(ctext.Text));

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string a = reader["Kisi_Sayisi"].ToString();
                kişisayısılab.Text = a;

                string b = reader["Yatak"].ToString();
                Yatakmod.Text = b;
                string c = reader["Stil"].ToString();
                stilab.Text = c;
              
            }
            baglan.Close();
            Müşgetir();

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}