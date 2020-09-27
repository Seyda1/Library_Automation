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
    public partial class kullanıcıanasayfafrm : Form
    {
        public kullanıcıanasayfafrm()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        private void kullanıcıanasayfafrm_Load(object sender, EventArgs e)
        {
            tc.Text = kullanici_girissınıf.tcno.ToString();
            adlbl.Text = kullanici_girissınıf.ad.ToString();
            soyadlbl.Text = kullanici_girissınıf.soyad.ToString();
            telbl.Text = kullanici_girissınıf.tel.ToString();
            postalbl.Text = kullanici_girissınıf.e_posta.ToString();
            okunanktplbl.Text = kullanici_girissınıf.okunankitapsayısı.ToString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            int kıyaslama = 0;
            DateTime simdi = DateTime.Now; 
            SqlCommand komut = new SqlCommand("select *from EmanetKitaplar where tc='"+tc.Text+"'", baglanti);
          
            SqlDataReader oku = komut.ExecuteReader();

            if(oku.Read())
            {

                kıyaslama = simdi.CompareTo(Convert.ToDateTime(oku["iadetarihi"]));
                if (kıyaslama > 0)
                {
                    MessageBox.Show("Gecikmiş kitabınız bulunmakta!!");
                
                }
                else
                {
                    MessageBox.Show("Gecikmiş kitabınız yok!!");
                }
            }
            else
            {
                MessageBox.Show("Hiç Mesajınız Yok");
            }
            baglanti.Close();
           
        }

        private void onlinekitapbtn_Click(object sender, EventArgs e)
        {
            dergifrm dergi = new dergifrm();
            this.Hide();
            dergi.ShowDialog();
        }

        private void ktpdegerlendirme_btn_Click(object sender, EventArgs e)
        {
            kitapdegerlendirme ktp = new kitapdegerlendirme();
            this.Hide();
            ktp.ShowDialog();
        }

        private void admincksbtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
