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
    public partial class uyeeklefrm : Form
    {
        
        public uyeeklefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeiptal_btn_Click(object sender, EventArgs e)
        {
            adminform gr = new adminform();
            this.Hide();
            gr.ShowDialog();
        }
        public void temizle()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";

                }
            }
        }
        bool durum;
        
        void kayıtkontrol()
        {
            baglanti.Open();
            SqlCommand komut =new SqlCommand("select *from kullanıcı where tc='"+uyetctxtbx.Text+"'",baglanti);
            SqlDataReader read=komut.ExecuteReader();
            if(read.Read())
            {
            durum=false;
            }
            else
            {
            durum=true;
            }
            
            baglanti.Close();
        }
       
        private void uyeekle_btn_Click(object sender, EventArgs e)
        {




            
              if (uyeadtxtbx.Text != "" &&uyesoyadtxtbx.Text != "" && uyetctxtbx.Text != "" && uyetel_txtbx.Text != "" && uyesifretxtbx.Text != "" && uyepostatxtbx.Text != "")
            {
                if (uyesifretkr_txtbx.Text == uyesifretxtbx.Text)
                {
                    kayıtkontrol();
                    if (durum == true)
                    {
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("Insert Into kullanıcı(ad,soyad,tc,tel,e_posta,okunankitapsayısı,şifre,şifre_tekrar)values(@ad,@soyad,@tc,@tel,@e_posta,@okunankitapsayısı,@şifre,@şifre_tekrar)", baglanti);

                        komut.Parameters.AddWithValue("@ad", uyeadtxtbx.Text);
                        komut.Parameters.AddWithValue("@soyad", uyesoyadtxtbx.Text);
                        komut.Parameters.AddWithValue("@tc", uyetctxtbx.Text);
                        komut.Parameters.AddWithValue("@tel", uyetel_txtbx.Text);
                        komut.Parameters.AddWithValue("@e_posta", uyepostatxtbx.Text);
                        komut.Parameters.AddWithValue("@okunankitapsayısı",okunankitaps_txt.Text);
                        komut.Parameters.AddWithValue("@şifre", uyesifretxtbx.Text);
                        komut.Parameters.AddWithValue("@şifre_tekrar", uyesifretkr_txtbx.Text);
                        komut.ExecuteNonQuery();
                        
                        baglanti.Close();
                        MessageBox.Show("Üye kaydı başarılı!");
                        temizle();
                    }
                    else
                    {
                        MessageBox.Show("Bu TC numarasına sahip başka kullanıcı bulunmakta!");
                    }
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor");
                }
             }
           else
                {
               MessageBox.Show("Boş Kutu bırakılamaz");
                }
                
               
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void uyesifretxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
         
                        
	
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminform geri = new adminform(); 
            this.Hide();
            geri.ShowDialog();
           
        }

        private void uyeeklefrm_Load(object sender, EventArgs e)
        {
           
        }

        private void uyeadtxtbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                uyesoyadtxtbx.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
