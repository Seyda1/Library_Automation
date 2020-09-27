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
    public partial class Kitapiade : Form
    {
        public Kitapiade()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        DataSet daset = new DataSet();
        private void EmanetListele()
        {
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglan);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglan.Close();
        }

        private void Kitapiade_Load(object sender, EventArgs e)
        {
            EmanetListele();
        }

        private void iadetcaratxt_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where tc like '%" + iadetcaratxt.Text + "%'", baglan);
            adtr.Fill(daset, "EmanetKitaplar");
            baglan.Close();
            if (iadetcaratxt.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void iadebarkodtxt_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where barkodno like '%" + iadebarkodtxt.Text + "%'", baglan);
            adtr.Fill(daset, "EmanetKitaplar");
            baglan.Close();
            if (iadebarkodtxt.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }

        private void teslimalbtn_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where tc=@tc and barkodno=@barkodno", baglan);
            komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update kitaplar set stok=stok+'" + dataGridView1.CurrentRow.Cells["kitapsayısı"].Value.ToString() + "' where barkod=@barkodno", baglan);//Datagridde emanetkitaplar tablosundaki kitapsayısı
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kitap(lar) iade edildi");

            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            emanetkitapfrm kl = new emanetkitapfrm();
            this.Hide();
            kl.ShowDialog();
        }
    }
}