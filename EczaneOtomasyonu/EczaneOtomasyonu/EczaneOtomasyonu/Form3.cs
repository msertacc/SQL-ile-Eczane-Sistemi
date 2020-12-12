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
        SqlDataAdapter komut;
        DataTable table = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
            komut = new SqlDataAdapter("select Urun.UrunBarkod,Urun.UrunAd,Urun.UrunFiyat,TedarikFirma.TedarikFirmaAd,UreticiSirket.UreticiSirketAd from Urun inner join TedarikFirma on Urun.TedarikFirmaID = TedarikFirma.TedarikFirmaID inner join UreticiSirket on Urun.UreticiSirketID = UreticiSirket.UreticiSirketID", conn);

            komut.Fill(table);
            dataGridView1.DataSource = table;

            SqlCommand sqlCmdTedarik = new SqlCommand("select *from TedarikFirma", conn);
            SqlCommand sqlCmdUretici = new SqlCommand("select *from UreticiSirket", conn); 
            conn.Open();

            SqlDataReader sqlReader = sqlCmdTedarik.ExecuteReader();
            SqlDataReader sqlRe = sqlCmdUretici.ExecuteReader();
            while (sqlReader.Read())
            {
                comboBox1.Items.Add(sqlReader["TedarikFirmaAd"].ToString());
                
            }
            while (sqlRe.Read())
            {
                comboUretici.Items.Add(sqlRe["UreticiSirketAd"].ToString());
            }
            sqlReader.Close();


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
                /*SqlCommand uTedarikConvert = new SqlCommand("SELECT TedarikFirmaID FROM TedarikFirma WHERE TedarikFirmaAd = @uTedarik");
                SqlDataReader sqlU = uTedarikConvert.ExecuteReader();
                */

                insertCommand.CommandText = "insert into Urun(UrunBarkod,UrunAd,UrunFiyat,TedarikFirmaID,UreticiSirketID) values (@uBarkod,@uAd,@uFiyat,@uTedarik,@uUretici)";
                insertCommand.Parameters.Add("@uBarkod", uBarkod);
                insertCommand.Parameters.Add("@uAd", uAd);
                insertCommand.Parameters.Add("@uFiyat", uFiyat);
                insertCommand.Parameters.Add("@uTedarik", uTedarik);
                insertCommand.Parameters.Add("@uUretici", uUretici);
                
                insertCommand.ExecuteNonQuery();

                

            }
            

            txtAd.Text = "";
            txtBarkod.Text = "";
            txtFiyat.Text = "";
            comboBox1.Text = "";
            comboUretici.Text = "";
            dataGridView1.Refresh();
        }

    }
}
