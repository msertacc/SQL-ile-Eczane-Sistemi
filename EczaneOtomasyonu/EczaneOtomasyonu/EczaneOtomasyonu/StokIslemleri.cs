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
    public partial class StokIslemleri : Form
    {
        public StokIslemleri()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter komut;
        string value1, value2;
        DataTable table = new DataTable();
        private void Yenile()
        {
            table.Clear();
            komut = new SqlDataAdapter("select *from Stok", conn);
            komut.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlCommand addCommand = conn.CreateCommand())
            {
                dynamic uAdet = txtAdet.Text;
                dynamic uBarkod = cBoxBarkod.Text;

                addCommand.CommandText = "update Stok set UrunAdet=((select UrunAdet from Stok where UrunBarkod = @uBarkod)+@uAdet), SonGuncelTarih= GETDATE() where UrunBarkod = @uBarkod";
                addCommand.Parameters.Add("@uBarkod", uBarkod);
                addCommand.Parameters.Add("@uAdet", uAdet);
                addCommand.ExecuteNonQuery();
                
            }
            Yenile();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
            Yenile();
            conn.Open();
            SqlCommand barcodes = new SqlCommand("select UrunBarkod from Urun",conn);
            SqlDataReader dReadUrun = barcodes.ExecuteReader();
            while (dReadUrun.Read())
            {
                cBoxBarkod.Items.Add(dReadUrun["UrunBarkod"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(SqlCommand deleteCommand = conn.CreateCommand())
            {
                dynamic uAdet = txtAdet.Text;
                dynamic uBarkod = cBoxBarkod.Text;

                deleteCommand.CommandText = "update Stok set UrunAdet=((select UrunAdet from Stok where UrunBarkod = @uBarkod)-@uAdet), SonGuncelTarih= GETDATE() where UrunBarkod = @uBarkod";
                deleteCommand.Parameters.Add("@uBarkod", uBarkod);
                deleteCommand.Parameters.Add("@uAdet", uAdet);
                deleteCommand.ExecuteNonQuery();                       
            }
            Yenile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlCommand updateCommand = conn.CreateCommand())
            {
                dynamic uAdet = txtAdet.Text;
                dynamic uBarkod = cBoxBarkod.Text;

                updateCommand.CommandText = "update Stok set UrunAdet=@uAdet, SonGuncelTarih= GETDATE() where UrunBarkod = @uBarkod";
                updateCommand.Parameters.Add("@uBarkod", uBarkod);
                updateCommand.Parameters.Add("@uAdet", uAdet);
                updateCommand.ExecuteNonQuery();
                
            }
            Yenile();
        }

		private void button5_Click(object sender, EventArgs e)
		{
			Menuler menu = new Menuler();
			menu.Show();
			this.Hide();
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
                value2 = row.Cells[2].Value.ToString();
                

            }
            cBoxBarkod.Text = value1;
            txtAdet.Text = value2;
        }
    }
}
