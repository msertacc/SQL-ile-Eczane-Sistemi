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
	public partial class Raporlama : Form
	{
		public Raporlama()
		{
			InitializeComponent();
		}

		SqlConnection conn;
		SqlDataAdapter komut1;
		SqlDataAdapter komut2;
		SqlDataAdapter komut3;
		SqlDataAdapter komut4;

		DataTable tbl1 = new DataTable();
		DataTable tbl2 = new DataTable();
		DataTable tbl3 = new DataTable();
		DataTable tbl4 = new DataTable();

		private void Raporlama_Load(object sender, EventArgs e)
		{
			conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
			conn.Open();
		}

		private void Yenile(DataTable tbl, string kod, DataGridView dgw,dynamic dTime)
		{
			tbl.Clear();
			dTime = dateTimePicker1.Value.ToString();
			SqlDataAdapter komut = new SqlDataAdapter(kod, conn);
			komut.SelectCommand.Parameters.Add("@dTime",dTime);
			komut.Fill(tbl);
			dgw.DataSource = tbl;
			dgw.Refresh();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic dTime = dateTimePicker1.Value.ToString();
				string command = "select count(*) AS SatisSayisi, sum(UrunAdet * UrunFiyat) as KazanilanUcret from IslemUrun inner join Urun on IslemUrun.UrunBarkod = Urun.UrunBarkod where IslemID = 1 and IslemTarih between @dTime and GETDATE()";
				komut1 = new SqlDataAdapter(command, conn);
				komut1.SelectCommand.Parameters.Add("@dTime", dTime);
				komut1.Fill(tbl1);
				dataGridView1.DataSource = tbl1;
				Yenile(tbl1, command, dataGridView1, dTime);
			}
			catch
			{
				MessageBox.Show("Bir hatalı işlem yapıldı..");
			}		
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic dTime = dateTimePicker1.Value.ToString();
				string command = "select IslemUrun.UrunBarkod,Urun.UrunAd,count(1) as SatisAdet,Urun.UrunFiyat* COUNT(*) as ToplamKazanc from IslemUrun inner join Urun on IslemUrun.UrunBarkod = Urun.UrunBarkod where IslemID = 1 and IslemTarih between @dTime and GETDATE() group by IslemUrun.UrunBarkod,Urun.UrunAd,Urun.UrunFiyat having count(1) > 0 order by SatisAdet desc";
				komut2 = new SqlDataAdapter(command, conn);
				komut2.SelectCommand.Parameters.Add("@dTime", dTime);
				komut2.Fill(tbl2);
				dataGridView2.DataSource = tbl2;
				Yenile(tbl2, command, dataGridView2, dTime);
			}
			catch
			{
				MessageBox.Show("Bir hatalı işlem yapıldı..");
			}		
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic dTime = dateTimePicker1.Value.ToString();
				string command = "select IslemUrun.UrunBarkod,Urun.UrunAd,count(1) as AlinanAdet from IslemUrun inner join Urun on IslemUrun.UrunBarkod = Urun.UrunBarkod where IslemID = 2 and IslemTarih between @dTime and GETDATE() group by IslemUrun.UrunBarkod,Urun.UrunAd,Urun.UrunFiyat having count(1)>0 order by AlinanAdet desc";
				komut3 = new SqlDataAdapter(command, conn);
				komut3.SelectCommand.Parameters.Add("@dTime", dTime);
				komut3.Fill(tbl3);
				dataGridView3.DataSource = tbl3;
				Yenile(tbl3, command, dataGridView3, dTime);
			}			
			catch
			{
				MessageBox.Show("Bir hatalı işlem yapıldı..");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				dynamic dTime = dateTimePicker1.Value.ToString();
				string command = "select IslemUrun.PersonelID,Personel.PersonelAd,Personel.PersonelSoyad,count(1) as SatisSayisi from IslemUrun inner join Personel on IslemUrun.PersonelID = Personel.PersonelID where IslemID = 1 and IslemTarih between @dTime and GETDATE() group by IslemUrun.PersonelID,Personel.PersonelAd, Personel.PersonelSoyad having count(1)>0 order by SatisSayisi desc";
				komut4 = new SqlDataAdapter(command, conn);
				komut4.SelectCommand.Parameters.Add("dTime", dTime);
				komut4.Fill(tbl4);
				dataGridView4.DataSource = tbl4;
				Yenile(tbl4, command, dataGridView4, dTime);
			}			
			catch
			{
				MessageBox.Show("Bir hatalı işlem yapıldı..");
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


