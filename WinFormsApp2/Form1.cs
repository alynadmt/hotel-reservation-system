using System.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btn_giris_MouseHover(object sender, EventArgs e)
        {
            btn_giris.BackColor = Color.Teal;
        }
        
        private void btn_giris_MouseLeave(object sender, EventArgs e)
        {
            btn_giris.BackColor = Color.Turquoise;
                }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_sifre.PasswordChar = '*';
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            anaekran form2 = new anaekran();
            form2.Show();  // form2 göster diyoruz
            this.Hide();   // bu yani form1 gizle diyoruz
        }
    }
}