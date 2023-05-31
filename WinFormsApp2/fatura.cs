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
    public partial class fatura : Form
    {
        public fatura()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }
        SqlConnection baglan = new SqlConnection("Data Source=.\\MSSQLSERVER01; Initial Catalog=YaAl_Hotel_12;Integrated Security=true");

        private void fatura_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            baglan.Open();
            SqlCommand cmd = new SqlCommand("select * from fatura", baglan);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string a = reader["müstc"].ToString();
            label3.Text= a;
                
                string b = reader["toplam_ücret"].ToString();
                label5.Text = b;
                string c = reader["Komisyon"].ToString();
                label7.Text = c;
                string d = reader["İndirim"].ToString();
                label11.Text = d;
                string w = reader["ödeneneck_ücret"].ToString(); 
                label12.Text = w;
                string f = reader["gün"].ToString();    
                label14.Text = f;

            }
            baglan.Close();
        }
    }
}

