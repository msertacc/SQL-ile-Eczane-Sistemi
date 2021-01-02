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
    public partial class Musteriler : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter komut1;
        DataTable table = new DataTable();

        public Musteriler()
        {
            InitializeComponent();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            komut1 = new SqlDataAdapter("select Musteri.MusteriKimlik, Musteri.MusteriAd, Musteri.MusteriSoyad, Musteri.MusteriTelefon, Musteri.MusteriAdres from Musteri", conn);
            komut1.Fill(table);
            dataGridView1.DataSource = table;
        }

		private void button1_Click(object sender, EventArgs e)
		{
			string ara = textBox1.Text.ToString();
			int rowIndex = -1;
			try
			{
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					if (row.Cells[1].Value.ToString().Equals(ara))
					{
						rowIndex = row.Index;
						break;
					}
				}
				dataGridView1.Rows[rowIndex].Selected = true;
			}
			catch
			{
				MessageBox.Show("Hatalı İşlem Yapıldı.");
			}		
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Menuler menu = new Menuler();
			menu.Show();
			this.Hide();
		}
	}
}
