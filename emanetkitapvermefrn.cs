using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BM102Poje
{
    public partial class emanetkitapvermefrn : Form
    {
        public emanetkitapvermefrn()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        DataSet daset = new DataSet();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kullanıcı where tc like'%" + texttcara.Text + "%'", baglanti);

            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                //üye tablosundan alınacak bilgiler
                textad.Text = read["ad"].ToString();
                textsoyad.Text = read["soyad"].ToString();

                texttelefon.Text = read["tel"].ToString();


            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayısı) from EmanetKitaplar where tc='" + texttcara.Text + "'", baglanti);
            labelkayıtlıkitapsayısı.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();
            //kayıtlı kitap sayısı ve sepetteki kıtap sayısı bilgilerinin temizlenmesi için
            if (texttcara.Text == "")
            {
                foreach (Control item in groupuyebilgileri.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";

                    }

                }
                labelkayıtlıkitapsayısı.Text = "";
            }
        }
        private void SepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Sepet", baglanti);
            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
           
            baglanti.Close();
        }

        private void kitapsayısı()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayısı) from Sepet", baglanti);
            labelkitapsayısı.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
       
        private void buttonekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
                SqlCommand komut = new SqlCommand("insert into Sepet(barkodno,kitapadı,yazarı,yayınevi,sayfasayısı,kitapsayısı,tesimtarihi,iadetarihi) values(@barkodno,@kitapadı,@yazarı,@yayınevi,@sayfasayısı,@kitapsayısı,@teslimtarihi,@iadetarihi)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", textbarkodno.Text);
                komut.Parameters.AddWithValue("@kitapadı", textkitapadı.Text);
               komut.Parameters.AddWithValue("@yazarı", textyazarı.Text);
               komut.Parameters.AddWithValue("@yayınevi", textyayınevi.Text);
                komut.Parameters.AddWithValue("@sayfasayısı", textsayfasayısı.Text);
                komut.Parameters.AddWithValue("@kitapsayısı", int.Parse(textkitapsayısı.Text));
                komut.Parameters.AddWithValue("@teslimtarihi", dateteslimtarihi.Text);
                komut.Parameters.AddWithValue("@iadetarihi", dateiadetarihi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kitap(lar) sepete eklendi.", "Ekleme işlemi");
                daset.Tables["Sepet"].Clear();
                SepetListele();
                labelkitapsayısı.Text = "";
                kitapsayısı();
                //foreach (Control item in groupkitapbilgileri.Controls)
                //{
                //    if (item is TextBox)
                //    {
                //        if (item != textkitapsayısı)
                //            item.Text = "";
                //    }
                //}
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labeltelefon_Click(object sender, EventArgs e)
        {

        }

        private void labeladsoyad_Click(object sender, EventArgs e)
        {

        }

        private void labeltcara_Click(object sender, EventArgs e)
        {

        }

        private void buttonteslimet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand kmt3 = new SqlCommand("select stok from kitaplar where barkod='" + textbarkodno.Text.Trim() + "'", baglanti);
            string stkdrm = kmt3.ExecuteScalar().ToString();
            
           
           
            
            baglanti.Close();
            if (Convert.ToInt32(stkdrm) - int.Parse(textkitapsayısı.Text) > 0)
            {
                if (labelkitapsayısı.Text != "")
                {
                    if (labelkayıtlıkitapsayısı.Text == "" && int.Parse(labelkitapsayısı.Text) <= 3 || labelkayıtlıkitapsayısı.Text != "" && int.Parse(labelkayıtlıkitapsayısı.Text) + int.Parse(labelkitapsayısı.Text) <= 3)
                    {
                        if (texttcara.Text != "" && textad.Text != "" && textsoyad.Text != "" && texttelefon.Text != "")
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {
                                baglanti.Open();
                                SqlCommand komut = new SqlCommand("insert into EmanetKitaplar(tc,ad,soyad,tel,barkodno,kitapadı,yazarı,yayınevi,sayfasayısı,kitapsayısı,teslimtarihi,iadetarihi) values(@tc,@ad,@soyad,@tel,@barkodno,@kitapadı,@yazarı,@yayınevi,@sayfasayısı,@kitapsayısı,@teslimtarihi,@iadetarihi)", baglanti);
                                komut.Parameters.AddWithValue("@tc", texttcara.Text);
                                komut.Parameters.AddWithValue("@ad", textad.Text);
                                komut.Parameters.AddWithValue("@soyad", textsoyad.Text);
                                komut.Parameters.AddWithValue("@tel", texttelefon.Text);
                                komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                                komut.Parameters.AddWithValue("kitapadı", dataGridView1.Rows[i].Cells["kitapadı"].Value.ToString());
                                komut.Parameters.AddWithValue("yazarı", dataGridView1.Rows[i].Cells["yazarı"].Value.ToString());
                                komut.Parameters.AddWithValue("yayınevi", dataGridView1.Rows[i].Cells["yayınevi"].Value.ToString());
                                komut.Parameters.AddWithValue("sayfasayısı", dataGridView1.Rows[i].Cells["sayfasayısı"].Value.ToString());
                                komut.Parameters.AddWithValue("kitapsayısı", int.Parse(dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString()));
                                komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["tesimtarihi"].Value.ToString());
                                komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());
                                komut.ExecuteNonQuery();
                                SqlCommand komut2 = new SqlCommand("update kullanıcı set okunankitapsayısı=okunankitapsayısı+'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString()) + "' where tc='" + texttcara.Text + "' ", baglanti);
                                komut2.ExecuteNonQuery();
                                SqlCommand komut3 = new SqlCommand("update kitaplar set stok=stok-'" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayısı"].Value.ToString()) + "' where barkod='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                                komut3.ExecuteNonQuery();

                                baglanti.Close();
                            }


                            baglanti.Open();
                            SqlCommand komut4 = new SqlCommand("delete from Sepet", baglanti);
                            komut4.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Kitap(lar) emanet edildi. ");
                            daset.Tables["Sepet"].Clear();
                            SepetListele();
                            texttcara.Text = "";
                            labelkitapsayısı.Text = "";
                            kitapsayısı();
                            labelkayıtlıkitapsayısı.Text = "";
                            //komut satırları
                        }
                        else
                        {
                            MessageBox.Show("Önce üye ismi seçmeniz gerekir!!!", "Uyarı");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Emanet kitap sayısı üçten fazla olamaz!!!", "Uyarı");
                    }
                }
                //label eğer boşsa
                else
                {
                    MessageBox.Show("Önce sepete kitap eklenmelidir!!!", "Uyarı");
                }
           }
           else
	         {
               MessageBox.Show("Stokta aradığınız kitap bulunmamaktadır");
	         }
          
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonsil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kayıt silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand("delete from Sepet where barkodno='"+dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+"' ", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi yapıldı", "Silme işlemi");
                daset.Tables["Sepet"].Clear();
                SepetListele();
                labelkitapsayısı.Text = "";
                kitapsayısı();
            }
        }

        private void emanetkitapvermefrn_Load(object sender, EventArgs e)
        {
            
            SepetListele();
            kitapsayısı();
        }

        private void textbarkodno_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
             SqlCommand komut = new SqlCommand("select *from kitaplar where barkod like '%"+textbarkodno.Text+"%'",baglanti);
             SqlDataReader read= komut.ExecuteReader();
                while(read.Read())
                 {
                   textkitapadı.Text=read["ad"].ToString();
                   textyazarı.Text=read["yazar"].ToString();
                   textyayınevi.Text=read["yayınevi"].ToString();
                   textsayfasayısı.Text=read["sayfa"].ToString();
                  }
               baglanti.Close();
                if(textbarkodno.Text=="")
                 {
                     foreach(Control item in groupkitapbilgileri.Controls)
                      {
                         
                         if(item is TextBox)
                         {
                          if(item!=textkitapsayısı)
                             {
                                 item.Text="";
                             }
                          }
                      }
                 }
         }

        private void öncekisayfabtn_Click(object sender, EventArgs e)
        {
            emanetkitapfrm önceki = new emanetkitapfrm();
            this.Hide();
            önceki.ShowDialog();
        }
    }
}
    