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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter komut;
        string value1;

        DataTable table = new DataTable();

        private void KategoriForm_Load(object sender, EventArgs e)
        {
            label2.Text = "Kategori Adı";
            ekleButton.Enabled = true;
            silButton.Enabled = true;
            yAdLabel.Visible = false;
            ktGTbox.Visible = false;
            guncelButton.Enabled = false;
            ktAdTBox.Enabled = true;
            conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
            Yenile();
            conn.Open();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                ekleButton.Enabled = true;
                silButton.Enabled = true;
                guncelButton.Enabled = false;
                label2.Text = "Kategori Adı";
                yAdLabel.Visible = false;
                ktGTbox.Visible = false;
                ktAdTBox.Enabled = true;
            }
            else
            {
                ekleButton.Enabled = false;
                silButton.Enabled = false;
                guncelButton.Enabled = true;
                label2.Text = "Güncellenecek Kategori";
                ktAdTBox.Enabled = false;
                yAdLabel.Visible = true;
                ktGTbox.Visible = true;
                

            }
        }

        private void Yenile()
        {
            table.Clear();
            komut = new SqlDataAdapter("select *from UrunKategori", conn);
            komut.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Refresh();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            using(SqlCommand addCommand = conn.CreateCommand())
            {
                dynamic uKt = ktAdTBox.Text;

                addCommand.CommandText = "insert into UrunKategori(UrunKategoriAd) values(@uKt)";
                addCommand.Parameters.Add("@uKt",uKt);
                addCommand.ExecuteNonQuery();
            }
            Yenile();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[1].Value.ToString();

      

            }
            ktAdTBox.Text = value1;
            
  
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            using(SqlCommand deleteCommand = conn.CreateCommand())
            {
                dynamic @uKt = ktAdTBox.Text;

                deleteCommand.CommandText = "delete from UrunKategori where UrunKategoriAd = @uKt";
                deleteCommand.Parameters.Add("@uKt", uKt);
                deleteCommand.ExecuteNonQuery();
            }
            Yenile();
        }

        private void guncelButton_Click(object sender, EventArgs e)
        {
            using (SqlCommand updateCommand = conn.CreateCommand())
            {
                dynamic @uKt = ktAdTBox.Text;
                dynamic @uKG = ktGTbox.Text;

                updateCommand.CommandText = "update UrunKategori set UrunKategoriAd = @uKG where UrunKategoriAd = @uKt";
                updateCommand.Parameters.Add("@uKt", uKt);
                updateCommand.Parameters.Add("@uKG", uKG);
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
	}
}
