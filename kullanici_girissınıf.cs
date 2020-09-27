using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BM102Poje
{
    class kullanici_girissınıf
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
       kullanıcıanasayfafrm yeni=new kullanıcıanasayfafrm();
        
        public SqlDataReader kullanici(TextBox tc, TextBox şifre)
        {
           
           
        baglanti.Open();
            komut=new SqlCommand();
            komut.Connection=baglanti;
            komut.CommandText = "select *from kullanıcı where tc ='" + tc.Text + "'and şifre='" + şifre.Text + "'";
            read=komut.ExecuteReader();
            if(read.Read()==true)
            {
                yeni.ShowDialog();
            }
            else
                {
            MessageBox.Show("bilgileiriniz kontrol edin");
            
                }
        baglanti.Close();
            return read;
        }
       
        public void sifregüncelle(TextBox kullanıcıadı,TextBox sifre)
        {
            
            baglanti.Open();
            komut = new SqlCommand("select *from admin where admin_ad='"+kullanıcıadı.Text+"'",baglanti);
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                baglanti.Close();
                baglanti.Open();
                komut = new SqlCommand("update admin set admin_ad='"+kullanıcıadı.Text+"',admin_şifre='"+sifre.Text+"'",baglanti);
                komut.ExecuteNonQuery();
                 baglanti.Close();
                 MessageBox.Show("güncelleme başarılı");
            
            }
            else
            {
                MessageBox.Show("bilgilerinizi kontrol edin");
            }

           
        
        
        
        }
        public static string ad, soyad, e_posta,tel,tcno;
       public static string okunankitapsayısı;
        
        
        public void bilgilerimigörüntele(TextBox tc, TextBox şifre)
        {
            tcno = tc.Text;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ad,soyad,tel,e_posta,okunankitapsayısı from kullanıcı where tc='" +tc.Text + "' and şifre='" + şifre.Text + "'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
               
                ad = dr[0].ToString();
                soyad = dr[1].ToString();
                tel = dr[2].ToString();
                e_posta = dr[3].ToString();
                okunankitapsayısı = dr[4].ToString();
               

            }
            
            baglanti.Close();
        
        }
       
            
        
        public void  sifre(TextBox ad,TextBox soyad,TextBox tc,TextBox tel,TextBox e_posta,TextBox şifre,TextBox şifre_tekrar)
        {
            if (şifre.Text == şifre_tekrar.Text)
            {
                baglanti.Open();
                komut = new SqlCommand("select *from kullanıcı where tc='" + tc.Text + "'",baglanti);
                read = komut.ExecuteReader();
                if (read.Read() == true)
                {
                    
                        baglanti.Close();
                        baglanti.Open();
                        komut = new SqlCommand("update kullanıcı set ad='"+ad.Text+"',soyad='"+soyad.Text+"',tel='"+tel.Text+"',şifre='"+şifre.Text+"',şifre_tekrar='"+şifre_tekrar.Text+"',e_posta='"+e_posta.Text+"'where tc='"+tc.Text+"'",baglanti);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("işlem başarılı");

                   

                }
                else
                {
                    MessageBox.Show("bilgileriniz kontrol ediniz");
                }
                baglanti.Close();
            }

            else
            {
                MessageBox.Show("şifreler uyuşmuyor");
            }
           
        
        }
    }
}
