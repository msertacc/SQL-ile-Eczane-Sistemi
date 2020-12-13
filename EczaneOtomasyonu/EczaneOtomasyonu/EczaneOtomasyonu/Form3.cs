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
    public partial class Form3 : Form
    {
        SqlConnection conn;
        string value1,value2,value3,value4,value5,value6;
        SqlDataAdapter komut;

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

                updateCommand.CommandText = "update Urun set UrunAd=@uAd, UrunFiyat=@uFiyat, TedarikFirmaID=(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik), UreticiSirketID=(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici), UrunKategoriID=(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg) where UrunBarkod=@uBarkod";

                updateCommand.Parameters.Add("@uBarkod", uBarkod);
                updateCommand.Parameters.Add("@uAd", uAd);
                updateCommand.Parameters.Add("@uFiyat", uFiyat);
                updateCommand.Parameters.Add("@uTedarik", uTedarik);
                updateCommand.Parameters.Add("@uUretici", uUretici);
                updateCommand.Parameters.Add("@uKtg", uKtg);

                updateCommand.ExecuteNonQuery();

            }
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

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
            komut = new SqlDataAdapter("select Urun.UrunBarkod,Urun.UrunAd,Urun.UrunFiyat,TedarikFirma.TedarikFirmaAd,UreticiSirket.UreticiSirketAd, UrunKategori.UrunKategoriAd from Urun inner join TedarikFirma on Urun.TedarikFirmaID = TedarikFirma.TedarikFirmaID inner join UreticiSirket on Urun.UreticiSirketID = UreticiSirket.UreticiSirketID inner join UrunKategori on Urun.UrunKategoriID = UrunKategori.UrunKategoriID ", conn);

            komut.Fill(table);
            dataGridView1.DataSource = table;

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

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlCommand insertCommand = conn.CreateCommand())
            {
                dynamic uAd = txtAd.Text;
                dynamic uBarkod = txtBarkod.Text;
                dynamic uFiyat = txtFiyat.Text;
                dynamic uTedarik = comboBox1.Text;
                dynamic uUretici = comboUretici.Text;
                dynamic uKtg = comboKtg.Text;

                try
                {
                insertCommand.CommandText = "insert into Urun(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID,UrunKategoriID) values (@uBarkod,@uAd,@uFiyat,(select TedarikFirma.TedarikFirmaID from TedarikFirma where TedarikFirma.TedarikFirmaAd=@uTedarik) ,(select UreticiSirket.UreticiSirketID from UreticiSirket where UreticiSirket.UreticiSirketAd=@uUretici),(select UrunKategori.UrunKategoriID from UrunKategori where UrunKategori.UrunKategoriAd=@uKtg))";
                insertCommand.Parameters.Add("@uBarkod", uBarkod);
                insertCommand.Parameters.Add("@uAd", uAd);
                insertCommand.Parameters.Add("@uFiyat", uFiyat);
                insertCommand.Parameters.Add("@uTedarik", uTedarik);
                insertCommand.Parameters.Add("@uUretici", uUretici);
                insertCommand.Parameters.Add("@uKtg", uKtg);
                insertCommand.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Kayit Ekleme Başarisiz..");
                }          
            }       
            txtAd.Text = "";
            txtBarkod.Text = "";
            txtFiyat.Text = "";
            comboBox1.Text = "";
            comboUretici.Text = "";
            comboKtg.Text = "";
            dataGridView1.Refresh();
        }



    }
}
