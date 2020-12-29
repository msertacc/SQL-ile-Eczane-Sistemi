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
    public partial class Personel : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter komut1;
        DataTable table = new DataTable();

        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            komut1 = new SqlDataAdapter("select Personel.PersonelID as PersonelNo, Personel.KullaniciAd,Personel.PersonelAd,Personel.PersonelSoyad,Personel.PersonelTelefon,Personel.PersonelAdres,PersonelKategori.PersonelKategoriAd from Personel inner join PersonelKategori on Personel.PersonelKategoriID = PersonelKategori.PersonelKategoriID",conn);
            komut1.Fill(table);
            dataGridView1.DataSource = table;

        }
    }
}
