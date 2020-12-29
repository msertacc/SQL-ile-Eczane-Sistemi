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
namespace EczaneOtomasyonu
{
    public partial class Login : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtPass.Text;
            conn = new SqlConnection(@"Data Source =.; Initial Catalog = EczaneSistemi; Integrated Security = True");
            cmd = new SqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "select *from Kullanici where KullaniciAd='" + txtUserName.Text + "'AND KullaniciSifre='" + txtPass.Text + "'";
           
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Menuler frm2 = new Menuler();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("azazaz");
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
