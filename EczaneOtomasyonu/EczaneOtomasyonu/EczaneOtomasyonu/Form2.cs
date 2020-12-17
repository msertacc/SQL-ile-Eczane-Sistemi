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

namespace EczaneOtomasyonu
{
    public partial class Form2 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 stok = new Form4();
            stok.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KategoriForm ktg = new KategoriForm();
            this.Hide();
            ktg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tedarik_Üretici tu = new Tedarik_Üretici();
            this.Hide();
            tu.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
