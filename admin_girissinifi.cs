using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM102Poje
{
    class admin_girissinifi
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        adminform yeni = new adminform();
        public SqlDataReader adminyol(TextBox kullaniciad, TextBox şifre)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from admin where admin_ad ='" + kullaniciad.Text + "'and admin_şifre='" + şifre.Text + "'";
            read = komut.ExecuteReader();
            if (read.Read() == true)
            {
                
                yeni.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("bilgileirniz kontrol edin");

            }
            baglanti.Close();
            return read;
        }
    }
}
