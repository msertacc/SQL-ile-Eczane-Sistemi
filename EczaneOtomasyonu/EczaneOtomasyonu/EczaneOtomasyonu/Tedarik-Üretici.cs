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
    public partial class Tedarik_Üretici : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter komut1;
        SqlDataAdapter komut2;
        DataTable table1 = new DataTable(); // Uretici
        DataTable table2 = new DataTable(); // Tedarik
        DataTable table3 = new DataTable();
        DataTable table4 = new DataTable();

        public Tedarik_Üretici()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            table3.Clear();
            table1.Clear();
            table2.Clear();
            komut1 = new SqlDataAdapter("select YetkiliAd, YetkiliSoyad, YetkiliTel,TedarikFirmaID, YetkiliID as YetkiliNo from TedarikFirmaYetkili", conn);
            komut1.Fill(table4);
            dataGridView1.DataSource = table4;

            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            table4.Clear();
            table1.Clear();
            table2.Clear();
            komut1 = new SqlDataAdapter("select YetkiliAd, YetkiliSoyad, YetkiliTel,UreticiSirketID, YetkiliID as YetkiliNo from UreticiFirmaYetkili", conn);
            komut1.Fill(table3);
            dataGridView1.DataSource = table3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            table3.Clear();
            table4.Clear();
            table2.Clear();
            komut1 = new SqlDataAdapter("select UreticiSirketAd, UreticiSirketAdres, UreticiSirketTelefon from UreticiSirket", conn);
            komut1.Fill(table1);
            dataGridView1.DataSource = table1;
        }

        private void Tedarik_Üretici_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {               
                table1.Clear();
                table4.Clear();
                table3.Clear();
                komut2 = new SqlDataAdapter("select TedarikFirmaAd, TedarikFirmaAdres, TedarikFirmaTelefon from TedarikFirma", conn);
                komut2.Fill(table2);
                dataGridView1.DataSource = table2;               
                 
        }

		private void button5_Click(object sender, EventArgs e)
		{
			Menuler menu = new Menuler();
			menu.Show();
			this.Hide();
		}
	}
}
