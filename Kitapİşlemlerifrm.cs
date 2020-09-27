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
    public partial class Kitapİşlemlerifrm : Form
    {
        public Kitapİşlemlerifrm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        private void verigöster(string veri)
        {
            SqlDataAdapter adtr = new SqlDataAdapter(veri, baglan);
            DataSet daset = new DataSet();
            adtr.Fill(daset);
            dataGridView1.DataSource = daset.Tables[0];
        }


        private void btngöster_Click(object sender, EventArgs e)
        {
            verigöster("select barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok from kitaplar ");

        }
        bool durum;
        void tekrar()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *from kitaplar where barkod=@barkod", baglan);
            komut.Parameters.AddWithValue("@barkod", txtkbarkod.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglan.Close();
        }
        private void Kitapİşlemlerifrm_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataSet daset = new DataSet();
           // daset.Tables["kitaplar"].Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok from kitaplar where ad like '" + txtAramakadı.Text + "%'", baglan);
            adtr.Fill(daset, "kitaplar");
            dataGridView1.DataSource = daset.Tables["kitaplar"];
            baglan.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkekle_Click(object sender, EventArgs e)
        {
            if (txtkbarkod.Text != "")
            {
                tekrar();
                if (durum == true)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("insert into kitaplar (barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok,kayıttarihi,kişisayısı,puan,ortalama) values (@barkod,@ad,@yazar,@yayınevi,@basımyılı,@sayfa,@tür,@stok,@kayıttarihi,@kişisayısı,@puan,@ortalama)", baglan);

                    komut.Parameters.AddWithValue("@barkod", txtkbarkod.Text);
                    komut.Parameters.AddWithValue("@ad", txtkadı.Text);
                    komut.Parameters.AddWithValue("@yazar", txtkyazarı.Text);
                    komut.Parameters.AddWithValue("@yayınevi", txtkyayınevi.Text);
                    komut.Parameters.AddWithValue("@basımyılı", txtkbasımyılı.Text);
                    komut.Parameters.AddWithValue("@sayfa", txtksayfa.Text);
                    komut.Parameters.AddWithValue("@tür", comboBoxtür.Text);
                    komut.Parameters.AddWithValue("@stok", txtkstok.Text);
                    komut.Parameters.AddWithValue("@kayıttarihi", DateTime.Now.ToShortDateString());
                    komut.Parameters.AddWithValue("@kişisayısı", kisisystxt.Text);
                    komut.Parameters.AddWithValue("@puan", puantxt.Text);
                    komut.Parameters.AddWithValue("@ortalama", ortalamatxt.Text);

                    komut.ExecuteNonQuery();
                    verigöster("select barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok from kitaplar");
                    MessageBox.Show("Kitap Kaydedildi");
                }
                else
                {
                    MessageBox.Show("Bu kayıt zaten var");
                }
                baglan.Close();
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                        item.Text = "";
                }
                txtkadı.Focus();
            
                
            }
             else
	                {
                        MessageBox.Show("Barkod alanı boş bırakılamaz!!");
	                }
        }

        private void btnKitapsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from kitaplar where ad=@ad",baglan);
            komut.Parameters.AddWithValue("@ad", txtkadı.Text);
            komut.ExecuteNonQuery();
            verigöster("select barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok from kitaplar");
            baglan.Close();
            MessageBox.Show("Kitap Silindi");
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                    item.Text = "";
            }

        }

        private void btnKitapAra_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok from kitaplar where ad like '%" + txtkadı.Text + "%'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilialan = dataGridView1.SelectedCells[0].RowIndex;
           // string ID = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string barkod = dataGridView1.Rows[secilialan].Cells[0].Value.ToString();
            string ad = dataGridView1.Rows[secilialan].Cells[1].Value.ToString();
            string yazar = dataGridView1.Rows[secilialan].Cells[2].Value.ToString();
            string yayınevi= dataGridView1.Rows[secilialan].Cells[3].Value.ToString();
            string basımyılı = dataGridView1.Rows[secilialan].Cells[4].Value.ToString();
            string sayfa = dataGridView1.Rows[secilialan].Cells[5].Value.ToString();
            string tür= dataGridView1.Rows[secilialan].Cells[6].Value.ToString();
            string stok = dataGridView1.Rows[secilialan].Cells[7].Value.ToString();

           // txtid.Text = ID;
            txtkbarkod.Text = barkod;
            txtkadı.Text = ad;
            txtkyazarı.Text=yazar;
            txtkyayınevi.Text = yayınevi;
            txtkbasımyılı.Text = basımyılı;
            txtksayfa.Text = sayfa;
            txtkstok.Text = stok;
            comboBoxtür.Text = tür;
           // txtAramakadı.Text = ad;

        }

        private void btnKitapGüncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update kitaplar set barkod='"+txtkbarkod.Text+"',  ad='"+txtkadı.Text+"',yazar='"+txtkyazarı.Text+"',yayınevi='"+txtkyayınevi.Text+"',basımyılı='"+txtkbasımyılı.Text+"',sayfa='"+txtksayfa.Text+"',tür='"+comboBoxtür.Text+"' where barkod='"+txtkbarkod.Text+"'",baglan);
            komut.ExecuteNonQuery();
            verigöster("select barkod,ad,yazar,yayınevi,basımyılı,sayfa,tür,stok from kitaplar");
            baglan.Close();
                

        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            adminform dön = new adminform();
            this.Hide();
            dön.ShowDialog();
        }
    }
}
