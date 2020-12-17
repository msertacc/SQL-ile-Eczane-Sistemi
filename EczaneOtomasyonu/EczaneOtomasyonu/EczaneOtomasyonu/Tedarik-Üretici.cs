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
    public partial class Tedarik_Üretici : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=EczaneSistemi;Integrated Security=True;MultipleActiveResultSets=true");
        SqlDataAdapter komut1;
        SqlDataAdapter komut2;
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();

        string value1,value2,value3;
        
        public Tedarik_Üretici()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                value1 = row.Cells[0].Value.ToString();
                value2 = row.Cells[1].Value.ToString();
                value3 = row.Cells[2].Value.ToString();
   
                

            }
            txtAd.Text = value1;
            txtAdres.Text = value2;
            txtTel.Text = value3;
        }

        private void Tedarik_Üretici_Load(object sender, EventArgs e)
        {

            conn.Open();
            txtAdres.Enabled = true;
            txtTel.Enabled = true;
            txtYAd.Enabled = false;
            txtYGorev.Enabled = false;
            txtYSoyad.Enabled = false;
            txtYTel.Enabled = false;
        }

        private void chcMod_CheckedChanged(object sender, EventArgs e)
        {
            if (chcMod.Checked)
            {
                txtAdres.Enabled = false;
                txtTel.Enabled = false;
                txtYAd.Enabled = true;
                txtYGorev.Enabled = true;
                txtYSoyad.Enabled = true;
                txtYTel.Enabled = true;

            }
            else
            {
                txtAdres.Enabled = true;
                txtTel.Enabled = true;
                txtYAd.Enabled = false;
                txtYGorev.Enabled = false;
                txtYSoyad.Enabled = false;
                txtYTel.Enabled = false;

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                
                table1.Clear();
                komut2 = new SqlDataAdapter("select TedarikFirmaAd, TedarikFirmaAdres, TedarikFirmaTelefon,YetkiliID as YetkiliNo from TedarikFirma", conn);
                komut2.Fill(table1);
                dataGridView1.DataSource = table1;
                
                
               
            }
            else
            {
                
                table2.Clear();
                komut1 = new SqlDataAdapter("select UreticiSirketAd, UreticiSirketAdres, UreticiSirketTelefon,YetkiliID as YetkiliNo from UreticiSirket", conn);
                komut1.Fill(table2);
                dataGridView1.DataSource = table2;
                


            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                dynamic uAd;
                dynamic uAdres;
                dynamic uTel;
                dynamic yAd;
                dynamic ySoad;
                dynamic yTel;
                dynamic yGorev;
                dynamic yNo;



                if (radioButton2.Checked)
                {
                    if (chcMod.Checked)
                    {

                        using (SqlCommand addCommandY = conn.CreateCommand())
                        {
                            uAd = txtAd.Text;
                            yAd = txtYAd.Text;
                            ySoad = txtYSoyad.Text;
                            yTel = txtYTel.Text;
                            yGorev = txtYGorev.Text;
                            yNo = txtYNo.Text;
                            addCommandY.CommandText = "insert into TedarikFirmaYetkili(TedarikFirmaID, YetkiliID, YetkiliAd,YetkiliSoyad,YetkiliTel,Gorev) values((select TedarikFirmaID from TedarikFirma where TedarikFirmaAd = @uAd),@yNo, @yAd,@ySoad,@yTel,@yGorev)";
                            addCommandY.Parameters.Add("@yAd", yAd);
                            addCommandY.Parameters.Add("@ySoad", ySoad);
                            addCommandY.Parameters.Add("@yTel", yTel);
                            addCommandY.Parameters.Add("@yGorev", yGorev);
                            addCommandY.Parameters.Add("@yNo", yNo);
                            addCommandY.Parameters.Add("uAd", uAd);

                            addCommandY.ExecuteNonQuery();
                        }

                    }
                    else
                    {
                        using (SqlCommand addCommandU = conn.CreateCommand())
                        {
                            uAd = txtAd.Text;
                            uAdres = txtAdres.Text;
                            uTel = txtTel.Text;
                            yNo = txtYNo.Text;
                            addCommandU.CommandText = "insert into TedarikFirma(TedarikFirmaAd,TedarikFirmaAdres,TedarikFirmaTelefon,YetkiliID) values(@uAd,@uAdres,@uTel,@yNo)";
                            addCommandU.Parameters.Add("@uAd", uAd);
                            addCommandU.Parameters.Add("@uAdres", uAdres);
                            addCommandU.Parameters.Add("@uTel", uTel);
                            addCommandU.Parameters.Add("@yNo", yNo);

                            addCommandU.ExecuteNonQuery();
                        }
                    }


                }
                else
                {
                    if (chcMod.Checked)
                    {

                        using (SqlCommand addCommandY = conn.CreateCommand())
                        {
                            uAd = txtAd.Text;
                            yAd = txtYAd.Text;
                            ySoad = txtYSoyad.Text;
                            yTel = txtYTel.Text;
                            yGorev = txtYGorev.Text;
                            yNo = txtYNo.Text;
                            addCommandY.CommandText = "insert into UreticiFirmaYetkili(UreticiSirketID, YetkiliID, YetkiliAd,YetkiliSoyad,YetkiliTel,Gorev) values((select UreticiSirketID from UreticiSirket where UreticiSirketAd = @uAd),@yNo, @yAd,@ySoad,@yTel,@yGorev)";
                            addCommandY.Parameters.Add("@yAd", yAd);
                            addCommandY.Parameters.Add("@ySoad", ySoad);
                            addCommandY.Parameters.Add("@yTel", yTel);
                            addCommandY.Parameters.Add("@yGorev", yGorev);
                            addCommandY.Parameters.Add("@yNo", yNo);
                            addCommandY.Parameters.Add("uAd", uAd);

                            addCommandY.ExecuteNonQuery();
                        }

                    }
                    else
                    {
                        using (SqlCommand addCommandU = conn.CreateCommand())
                        {
                            uAd = txtAd.Text;
                            uAdres = txtAdres.Text;
                            uTel = txtTel.Text;
                            yNo = txtYNo.Text;
                            addCommandU.CommandText = "insert into UreticiSirket(UreticiSirketAd,UreticiSirketAdres,UreticiSirketTelefon,YetkiliID) values(@uAd,@uAdres,@uTel,@yNo)";
                            addCommandU.Parameters.Add("@uAd", uAd);
                            addCommandU.Parameters.Add("@uAdres", uAdres);
                            addCommandU.Parameters.Add("@uTel", uTel);
                            addCommandU.Parameters.Add("@yNo", yNo);

                            addCommandU.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Hatalı giriş yapıldı");
            }

       
    
            
        }
    }
}
