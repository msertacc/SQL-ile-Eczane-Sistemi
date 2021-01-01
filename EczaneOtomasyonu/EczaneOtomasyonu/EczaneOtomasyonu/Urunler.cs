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
    public partial class Urunler : Form
    {
        SqlConnection conn;
        string value1,value2,value3,value4,value5,value6;
        SqlDataAdapter komut;

        private void Yenile()
        {
            table.Clear();
            komut = new SqlDataAdapter("select Urun.UrunBarkod,Urun.UrunAd,Urun.UrunFiyat,TedarikFirma.TedarikFirmaAd,UreticiSirket.UreticiSirketAd, UrunKategori.UrunKategoriAd, Urun.UrunTur from Urun inner join TedarikFirma on Urun.TedarikFirmaID = TedarikFirma.TedarikFirmaID inner join UreticiSirket on Urun.UreticiSirketID = UreticiSirket.UreticiSirketID inner join UrunKategori on Urun.UrunKategoriID = UrunKategori.UrunKategoriID", conn);
            komut.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

		private void Form3_Load(object sender, EventArgs e)
		{
			conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
			Yenile();

			label8.Visible = false;
			cinsiyetCombo.Visible = false;
			ynCombo.Visible = false;
			renktxtBox.Visible = false;
			digertxt.Visible = false;
			txtBarkod.Enabled = false;

			SqlCommand sqlCmdTedarik = new SqlCommand("select *from TedarikFirma", conn);
			SqlCommand sqlCmdUretici = new SqlCommand("select *from UreticiSirket", conn);
			SqlCommand sqlCmdKtg = new SqlCommand("select *from UrunKategori", conn);
			conn.Open();

			SqlDataReader sqlTedarik = sqlCmdTedarik.ExecuteReader();
			SqlDataReader sqlUretici = sqlCmdUretici.ExecuteReader();
			SqlDataReader sqlKtg = sqlCmdKtg.ExecuteReader();
			while (sqlTedarik.Read())
			{
				comboBox1.Items.Add(sqlTedarik["TedarikFirmaAd"].ToString());

			}
			while (sqlUretici.Read())
			{
				comboUretici.Items.Add(sqlUretici["UreticiSirketAd"].ToString());
			}
			while (sqlKtg.Read())
			{
				comboKtg.Items.Add(sqlKtg["UrunKategoriAd"].ToString());
			}
			button1.Enabled = false;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                txtBarkod.Enabled = false;
                button2.Enabled = true;
                button1.Enabled = false;
            }
            else
            {
                txtBarkod.Enabled = true;
                button2.Enabled = false;
                button1.Enabled = true;
            }            
        }

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlCommand insertCommand = conn.CreateCommand())
				{
					dynamic uAd = txtAd.Text;
					dynamic uBarkod = txtBarkod.Text;
					dynamic uFiyat = txtFiyat.Text;
					dynamic uTedarik = comboBox1.Text;
					dynamic uUretici = comboUretici.Text;
					dynamic uKtg = comboKtg.Text;
					dynamic uTur = radioButton1.Text;
					dynamic uRecete = ynCombo.Text;
					dynamic uRenk = renktxtBox.Text;
					dynamic uCinsiyet = cinsiyetCombo.Text;
					dynamic uDiger = digertxt.Text;

					if (radioButton1.Checked)
					{
						uTur = radioButton1.Text;
					}
					else if (radioButton2.Checked)
					{
						uTur = radioButton2.Text;
					}
					else if (radioButton3.Checked)
					{
						uTur = radioButton3.Text;
					}
					else if (radioButton4.Checked)
					{
						uTur = radioButton4.Text;
					}

					if (uTur == radioButton4.Text)
					{
						insertCommand.CommandText = "insert into Urun(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID,UrunTur) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg),@uDiger)";
						insertCommand.Parameters.Add("@uBarkod", uBarkod);
						insertCommand.Parameters.Add("@uAd", uAd);
						insertCommand.Parameters.Add("@uFiyat", uFiyat);
						insertCommand.Parameters.Add("@uTedarik", uTedarik);
						insertCommand.Parameters.Add("@uUretici", uUretici);
						insertCommand.Parameters.Add("@uKtg", uKtg);
						insertCommand.Parameters.Add("@uDiger", uDiger);
						insertCommand.ExecuteNonQuery();
					}
					else
					{
						insertCommand.CommandText = "insert into Urun(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID,UrunTur) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg),@uTur)";
						insertCommand.Parameters.Add("@uBarkod", uBarkod);
						insertCommand.Parameters.Add("@uAd", uAd);
						insertCommand.Parameters.Add("@uFiyat", uFiyat);
						insertCommand.Parameters.Add("@uTedarik", uTedarik);
						insertCommand.Parameters.Add("@uUretici", uUretici);
						insertCommand.Parameters.Add("@uKtg", uKtg);
						insertCommand.Parameters.Add("@uTur", uDiger);
						insertCommand.ExecuteNonQuery();

						if (uTur == radioButton1.Text)
						{
							using (SqlCommand insert2Command = conn.CreateCommand())
							{
								if (ynCombo.Text.ToString() == "Evet")
								{
									insert2Command.CommandText = "insert into Ilac(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID,ReceteZorunlu) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg),1)";
								}
								else
								{
									insert2Command.CommandText = "insert into Ilac(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID,ReceteZorunlu) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg),0)";
								}
								insert2Command.Parameters.Add("@uBarkod", uBarkod);
								insert2Command.Parameters.Add("@uAd", uAd);
								insert2Command.Parameters.Add("@uFiyat", uFiyat);
								insert2Command.Parameters.Add("@uTedarik", uTedarik);
								insert2Command.Parameters.Add("@uUretici", uUretici);
								insert2Command.Parameters.Add("@uKtg", uKtg);
								insert2Command.ExecuteNonQuery();
							}
						}
						if (uTur == radioButton3.Text)
						{
							using (SqlCommand insert2Command = conn.CreateCommand())
							{

								insert2Command.CommandText = "insert into KozmetikUrun(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID,Renk) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg),@uRenk)";

								insert2Command.Parameters.Add("@uBarkod", uBarkod);
								insert2Command.Parameters.Add("@uAd", uAd);
								insert2Command.Parameters.Add("@uFiyat", uFiyat);
								insert2Command.Parameters.Add("@uTedarik", uTedarik);
								insert2Command.Parameters.Add("@uUretici", uUretici);
								insert2Command.Parameters.Add("@uKtg", uKtg);
								insert2Command.Parameters.Add("@uRenk", uRenk);
								insert2Command.ExecuteNonQuery();
							}
						}
						if (uTur == radioButton2.Text)
						{
							using (SqlCommand insert2Command = conn.CreateCommand())
							{

								insert2Command.CommandText = "insert into BakimUrun(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID,Cinsiyet) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg),@uCinsiyet)";

								insert2Command.Parameters.Add("@uBarkod", uBarkod);
								insert2Command.Parameters.Add("@uAd", uAd);
								insert2Command.Parameters.Add("@uFiyat", uFiyat);
								insert2Command.Parameters.Add("@uTedarik", uTedarik);
								insert2Command.Parameters.Add("@uUretici", uUretici);
								insert2Command.Parameters.Add("@uKtg", uKtg);
								insert2Command.Parameters.Add("@uCinsiyet", uCinsiyet);
								insert2Command.ExecuteNonQuery();
							}
						}
					}
				}
				txtAd.Text = "";
				txtBarkod.Text = "";
				txtFiyat.Text = "";
				comboBox1.Text = "";
				comboUretici.Text = "";
				comboKtg.Text = "";
				label8.Visible = false;
				cinsiyetCombo.Visible = false;
				ynCombo.Visible = false;
				renktxtBox.Visible = false;
				digertxt.Visible = false;

				Yenile();
			}
			catch
			{
				MessageBox.Show("Hatalı işlem yapıldı.");
			}

		}

		private void button2_Click(object sender, EventArgs e)
        {
            using (SqlCommand updateCommand = conn.CreateCommand())
            {
                dynamic uAd = txtAd.Text;
                dynamic uBarkod = txtBarkod.Text;
                dynamic uFiyat = txtFiyat.Text;
                dynamic uTedarik = comboBox1.Text;
                dynamic uUretici = comboUretici.Text;
                dynamic uKtg = comboKtg.Text;

				try
				{
					updateCommand.CommandText = "update Urun set UrunAd=@uAd, UrunFiyat=@uFiyat, TedarikFirmaID=(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik), UreticiSirketID=(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici), UrunKategoriID=(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg) where UrunBarkod=@uBarkod";
					updateCommand.Parameters.Add("@uBarkod", uBarkod);
					updateCommand.Parameters.Add("@uAd", uAd);
					updateCommand.Parameters.Add("@uFiyat", uFiyat);
					updateCommand.Parameters.Add("@uTedarik", uTedarik);
					updateCommand.Parameters.Add("@uUretici", uUretici);
					updateCommand.Parameters.Add("@uKtg", uKtg);

					updateCommand.ExecuteNonQuery();

					using(SqlCommand update2Command = conn.CreateCommand())
					{
						updateCommand.CommandText = "update Ilac set UrunAd=@uAd, UrunFiyat=@uFiyat, TedarikFirmaID=(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik), UreticiSirketID=(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici), UrunKategoriID=(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg) where UrunBarkod=@uBarkod";
						updateCommand.Parameters.Add("@uBarkod", uBarkod);
						updateCommand.Parameters.Add("@uAd", uAd);
						updateCommand.Parameters.Add("@uFiyat", uFiyat);
						updateCommand.Parameters.Add("@uTedarik", uTedarik);
						updateCommand.Parameters.Add("@uUretici", uUretici);
						updateCommand.Parameters.Add("@uKtg", uKtg);
						updateCommand.ExecuteNonQuery();
					}
					using (SqlCommand update3Command = conn.CreateCommand())
					{
						updateCommand.CommandText = "update KozmetikUrun set UrunAd=@uAd, UrunFiyat=@uFiyat, TedarikFirmaID=(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik), UreticiSirketID=(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici), UrunKategoriID=(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg) where UrunBarkod=@uBarkod";
						updateCommand.Parameters.Add("@uBarkod", uBarkod);
						updateCommand.Parameters.Add("@uAd", uAd);
						updateCommand.Parameters.Add("@uFiyat", uFiyat);
						updateCommand.Parameters.Add("@uTedarik", uTedarik);
						updateCommand.Parameters.Add("@uUretici", uUretici);
						updateCommand.Parameters.Add("@uKtg", uKtg);
						updateCommand.ExecuteNonQuery();
					}
					using (SqlCommand update4Command = conn.CreateCommand())
					{
						updateCommand.CommandText = "update BakimUrun set UrunAd=@uAd, UrunFiyat=@uFiyat, TedarikFirmaID=(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik), UreticiSirketID=(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici), UrunKategoriID=(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg) where UrunBarkod=@uBarkod";
						updateCommand.Parameters.Add("@uBarkod", uBarkod);
						updateCommand.Parameters.Add("@uAd", uAd);
						updateCommand.Parameters.Add("@uFiyat", uFiyat);
						updateCommand.Parameters.Add("@uTedarik", uTedarik);
						updateCommand.Parameters.Add("@uUretici", uUretici);
						updateCommand.Parameters.Add("@uKtg", uKtg);
						updateCommand.ExecuteNonQuery();
					}
					Yenile();
				}
				catch
				{
					MessageBox.Show("Hatalı işlem uygulandı.");
				}
            }     
        }

        private void button3_Click(object sender, EventArgs e)
        {
			try
			{
				using (SqlCommand deleteCommand = conn.CreateCommand())
				{
					dynamic uAd = txtAd.Text;
					dynamic uBarkod = txtBarkod.Text;
					dynamic uFiyat = txtFiyat.Text;
					dynamic uTedarik = comboBox1.Text;
					dynamic uUretici = comboUretici.Text;
					dynamic uKtg = comboKtg.Text;

					using (SqlCommand delete2Command = conn.CreateCommand())
					{
						delete2Command.CommandText = "delete from Ilac where UrunBarkod = @uBarkod";
						delete2Command.Parameters.Add("@uBarkod", uBarkod);
						delete2Command.ExecuteNonQuery();
					}
					using (SqlCommand delete3Command = conn.CreateCommand())
					{
						delete3Command.CommandText = "delete from KozmetikUrun where UrunBarkod = @uBarkod";
						delete3Command.Parameters.Add("@uBarkod", uBarkod);
						delete3Command.ExecuteNonQuery();
					}
					using (SqlCommand delete4Command = conn.CreateCommand())
					{
						delete4Command.CommandText = "delete from BakimUrun where UrunBarkod = @uBarkod";
						delete4Command.Parameters.Add("@uBarkod", uBarkod);
						delete4Command.ExecuteNonQuery();
					}
					deleteCommand.CommandText = "delete from Urun where UrunBarkod = @uBarkod";
					deleteCommand.Parameters.Add("@uBarkod", uBarkod);
					deleteCommand.ExecuteNonQuery();
				}
				Yenile();
			}
			catch
			{
				MessageBox.Show("Hatalı işlem yapıldı.");
			}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StokIslemleri frm = new StokIslemleri();
            frm.Show();
            this.Hide();
        }

		private void button5_Click(object sender, EventArgs e)
		{
			Menuler menu = new Menuler();
			menu.Show();
			this.Hide();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			label8.Visible = true;
			label8.Text = "Reçete Zorunlu?";
			cinsiyetCombo.Visible = false;
			ynCombo.Visible = true;
			renktxtBox.Visible = false;
			digertxt.Visible = false;
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label8.Visible = true;
			label8.Text = "Cinsiyet giriniz:";
			cinsiyetCombo.Visible = true;
			ynCombo.Visible = false;
			renktxtBox.Visible = false;
			digertxt.Visible = false;
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			label8.Visible = true;
			label8.Text = "Renk Giriniz:";
			cinsiyetCombo.Visible = false;
			ynCombo.Visible = false;
			renktxtBox.Visible = true;
			digertxt.Visible = false;
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			label8.Visible = false;
			label8.Text = "Giriniz: ";
			cinsiyetCombo.Visible = false;
			ynCombo.Visible = false;
			renktxtBox.Visible = false;
			digertxt.Visible = true;
		}

		DataTable table = new DataTable();

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
                value2 = row.Cells[1].Value.ToString();
                value3 = row.Cells[2].Value.ToString();
                value4 = row.Cells[3].Value.ToString();
                value5 = row.Cells[4].Value.ToString();
                value6 = row.Cells[5].Value.ToString();
            }
            txtBarkod.Text = value1;
            txtAd.Text = value2;
            txtFiyat.Text = value3;
            comboBox1.Text = value4;
            comboUretici.Text = value5;
            comboKtg.Text = value6;
        }

        public Urunler()
        {
            InitializeComponent();
        }
    }
}
