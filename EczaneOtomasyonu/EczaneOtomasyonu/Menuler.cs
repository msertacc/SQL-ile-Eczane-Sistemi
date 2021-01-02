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
    public partial class Menuler : Form
    {
        public Menuler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Urunler form3 = new Urunler();
            form3.Show();
            this.Hide();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Tedarik_Üretici tu = new Tedarik_Üretici();
			this.Hide();
			tu.Show();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			SatisAlisIade sai = new SatisAlisIade();
			sai.Show();
			this.Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			KategoriForm ktg = new KategoriForm();
			this.Hide();
			ktg.Show();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Personel prs = new Personel();
			this.Hide();
			prs.Show();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			StokIslemleri stok = new StokIslemleri();
			stok.Show();
			this.Hide();
		}

        private void button8_Click(object sender, EventArgs e)
        {
            Musteriler mst = new Musteriler();
            this.Hide();
            mst.Show();
        }

		private void button9_Click(object sender, EventArgs e)
		{
			Raporlama rpr = new Raporlama();
			this.Hide();
			rpr.Show();
		}
	}
}
