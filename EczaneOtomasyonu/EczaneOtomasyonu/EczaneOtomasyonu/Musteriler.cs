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
    }
}
