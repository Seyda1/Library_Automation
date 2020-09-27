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
    public partial class kitapdegerlendirme : Form
    {
        public kitapdegerlendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
               
                secilenktp_lbl.Text = listView1.SelectedItems[0].SubItems[1].Text;
            
            }
            groupBox1.Visible = true;

        }

        private void kitapdegerlendirme_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
             SqlCommand komut = new SqlCommand("select *from kitaplar", baglanti);
           baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            { 
            
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["barkod"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["yazar"].ToString());
                ekle.SubItems.Add(oku["ortalama"].ToString());
                listView1.Items.Add(ekle);
            
            }
            baglanti.Close();
        }

        private void Puanlabtn_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            if (radioButton1.Checked)
            {
                SqlCommand komut2 = new SqlCommand("update kitaplar set puan=puan+'"+radioButton1.Text+"'where ad='"+secilenktp_lbl.Text+"'",baglanti);
                
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update kitaplar set kişisayısı=kişisayısı+1 where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("update kitaplar set ortalama=puan/kişisayısı where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut4.ExecuteNonQuery();
            }
            else if (radioButton2.Checked)
            {
                SqlCommand komut2 = new SqlCommand("update kitaplar set puan=puan+'" + radioButton2.Text + "'where ad='" + secilenktp_lbl.Text + "'", baglanti);

                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update kitaplar set kişisayısı=kişisayısı+1 where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("update kitaplar set ortalama=puan/kişisayısı where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut4.ExecuteNonQuery();
            }
            else if (radioButton3.Checked)
            {
                SqlCommand komut2 = new SqlCommand("update kitaplar set puan=puan+'" + radioButton3.Text + "'where ad='" + secilenktp_lbl.Text + "'", baglanti);

                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update kitaplar set kişisayısı=kişisayısı+1 where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("update kitaplar set ortalama=puan/kişisayısı where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut4.ExecuteNonQuery();
            }
            else if (radioButton4.Checked)
            {
                SqlCommand komut2 = new SqlCommand("update kitaplar set puan=puan+'" + radioButton4.Text + "'where ad='" + secilenktp_lbl.Text + "'", baglanti);

                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update kitaplar set kişisayısı=kişisayısı+1 where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("update kitaplar set ortalama=puan/kişisayısı where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut4.ExecuteNonQuery();
            }
            else if (radioButton5.Checked)
            {
                SqlCommand komut2 = new SqlCommand("update kitaplar set puan=puan+'" + radioButton5.Text + "'where ad='" + secilenktp_lbl.Text + "'", baglanti);

                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update kitaplar set kişisayısı=kişisayısı+1 where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut3.ExecuteNonQuery();
                SqlCommand komut4 = new SqlCommand("update kitaplar set ortalama=puan/kişisayısı where ad='" + secilenktp_lbl.Text + "'", baglanti);
                komut4.ExecuteNonQuery();
            }
            MessageBox.Show("Puanladığınız için teşekkürler!");
            baglanti.Close();

        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            kullanıcıanasayfafrm ac = new kullanıcıanasayfafrm();
            this.Hide();
            ac.ShowDialog();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
