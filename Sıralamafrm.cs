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
    public partial class Sıralamafrm : Form
    {
        public Sıralamafrm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Sıralamafrm_Load(object sender, EventArgs e)
        {

            baglan.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select ad,soyad,tel,okunankitapsayısı from kullanıcı order by okunankitapsayısı desc", baglan);
            adtr.Fill(daset, "kullanıcı");
            dataGridView1.DataSource = daset.Tables["kullanıcı"];
            baglan.Close();
            label2.Text = "";
            label4.Text = "";
            label2.Text = daset.Tables["kullanıcı"].Rows[0]["ad"].ToString();
           label2.Text += daset.Tables["kullanıcı"].Rows[0]["soyad"].ToString();
           // label2.Text += daset.Tables["kullanıcı"].Rows[0]["okunankitapsayısı"].ToString();

            label4.Text = daset.Tables["kullanıcı"].Rows[dataGridView1.Rows.Count - 2]["ad"].ToString();
            label4.Text += daset.Tables["kullanıcı"].Rows[dataGridView1.Rows.Count - 2]["soyad"].ToString();
           // label4.Text += daset.Tables["kullanıcı"].Rows[dataGridView1.Rows.Count - 2]["okunankitapsayısı"].ToString();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            adminform frm = new adminform();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
