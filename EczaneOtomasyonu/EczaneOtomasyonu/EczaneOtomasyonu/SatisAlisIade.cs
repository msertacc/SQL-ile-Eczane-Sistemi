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
	public partial class SatisAlisIade : Form
	{
		public SatisAlisIade()
		{
			InitializeComponent();
		}

		SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
		SqlDataAdapter komut1;
		SqlDataAdapter komut2;
		SqlDataAdapter komut3;
		DataTable table1 = new DataTable();
		DataTable table2 = new DataTable();
		DataTable table3 = new DataTable();

		private void SatisAlisIade_Load(object sender, EventArgs e)
		{
			komut1 = new SqlDataAdapter("select convert(varchar,day(IslemUrun.IslemTarih))+'-'+convert(varchar,month(IslemUrun.IslemTarih))+'-'+convert(varchar,year(IslemUrun.IslemTarih)) as IslemTarihi,Urun.UrunBarkod,Urun.UrunAd,IslemUrun.UrunAdet,Personel.PersonelAd+' '+Personel.PersonelSoyad as PersonelAdSoyad,Urun.UrunFiyat*IslemUrun.UrunAdet as Tutar from IslemUrun inner join Urun on Urun.UrunBarkod = IslemUrun.UrunBarkod inner join Personel on IslemUrun.PersonelID = Personel.PersonelID  where IslemUrun.IslemID = 1",conn);
			komut1.Fill(table1);
			dataGridView1.DataSource = table1;

			komut2 = new SqlDataAdapter("select convert(varchar,day(IslemUrun.IslemTarih))+'-'+convert(varchar,month(IslemUrun.IslemTarih))+'-'+convert(varchar,year(IslemUrun.IslemTarih)) as IslemTarihi,Urun.UrunBarkod,Urun.UrunAd,IslemUrun.UrunAdet,Personel.PersonelAd+' '+Personel.PersonelSoyad as PersonelAdSoyad,Urun.UrunFiyat*IslemUrun.UrunAdet as Tutar from IslemUrun inner join Urun on Urun.UrunBarkod = IslemUrun.UrunBarkod inner join Personel on IslemUrun.PersonelID = Personel.PersonelID  where IslemUrun.IslemID = 2", conn);
			komut2.Fill(table2);
			dataGridView2.DataSource = table2;

			komut3 = new SqlDataAdapter("select convert(varchar,day(IslemUrun.IslemTarih))+'-'+convert(varchar,month(IslemUrun.IslemTarih))+'-'+convert(varchar,year(IslemUrun.IslemTarih)) as IslemTarihi,Urun.UrunBarkod,Urun.UrunAd,IslemUrun.UrunAdet,Personel.PersonelAd+' '+Personel.PersonelSoyad as PersonelAdSoyad,Urun.UrunFiyat*IslemUrun.UrunAdet as Tutar from IslemUrun inner join Urun on Urun.UrunBarkod = IslemUrun.UrunBarkod inner join Personel on IslemUrun.PersonelID = Personel.PersonelID  where IslemUrun.IslemID = 3", conn);
			komut3.Fill(table3);
			dataGridView3.DataSource = table3;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Menuler menu = new Menuler();
			menu.Show();
			this.Hide();
		}
	}
}
