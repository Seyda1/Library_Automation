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
    public partial class Uyeislemfrm : Form
    {
        public Uyeislemfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        DataSet daset = new DataSet();
        private void uyelistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ad,soyad,tc,tel,e_posta from kullanıcı",baglanti);
            adtr.Fill(daset, "kullanıcı");
            dataGridView1.DataSource = daset.Tables["kullanıcı"];
            baglanti.Close();


        
        
        }
        private void Uyeislemfrm_Load(object sender, EventArgs e)
        {
            uyelistele();
        }

        private void Uyeislemfrm_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            uyetctxtbx.Text = dataGridView1.CurrentRow.Cells["tc"].Value.ToString();
        }

        private void uyeadtxtbx_TextChanged(object sender, EventArgs e)
        {

        }
       


        private void uyetctxtbx_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select ad,soyad,tc,tel,e_posta from kullanıcı where tc like '" + uyetctxtbx.Text + "%'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                uyeadtxtbx.Text = read["ad"].ToString();
                uyesoyadtxtbx.Text= read["soyad"].ToString();
                   
                uyetel_txtbx.Text = read["tel"].ToString();
                uyepostatxtbx.Text = read["e_posta"].ToString();
               // okunankitapsayısı_txt.Text=read["okunankitapsayısı"].ToString();
               
            }
            baglanti.Close();
        }
       
        private void tcara_txtbx_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["kullanıcı"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ad,soyad,tc,tel,e_posta from kullanıcı where tc like '" + tcara_txtbx.Text + "%'", baglanti);
            adtr.Fill(daset,"kullanıcı");
            dataGridView1.DataSource=daset.Tables["kullanıcı"];
            baglanti.Close();
            
        }

        private void uyeiptal_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uyesil_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kullanıcı where tc=@tc", baglanti);
            komut.Parameters.AddWithValue("@tc",dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("silme işlemi gerçekleşti");
            daset.Tables["kullanıcı"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void uyegüncelle_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update kullanıcı set ad=@ad,soyad=@soyad,tc=@tc,tel=@tel,e_posta=@e_posta where tc=@tc ",baglanti);
            komut.Parameters.AddWithValue("@ad", uyeadtxtbx.Text);
            komut.Parameters.AddWithValue("@soyad",uyesoyadtxtbx.Text);
            komut.Parameters.AddWithValue("@tc",uyetctxtbx.Text);
            komut.Parameters.AddWithValue("@tel", uyetel_txtbx.Text);
            komut.Parameters.AddWithValue("@e_posta",uyepostatxtbx.Text);
          //  komut.Parameters.AddWithValue("@okunankitapsayısı",okunankitapsayısı_txt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["kullanıcı"].Clear();
            uyelistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void anasayfalistbtn_Click(object sender, EventArgs e)
        {
            adminform dn = new adminform();
            this.Hide();
            dn.ShowDialog();
        }
    }
}
