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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        private void yntcgrsbtn_Click(object sender, EventArgs e)
        {
            Yntcgrsfrm yongir = new Yntcgrsfrm();
            this.Hide();
            yongir.ShowDialog();
        }

        private void klncgrsbtn_Click(object sender, EventArgs e)
        {
            Klncgrsfrm gir = new Klncgrsfrm();
            this.Hide();
            gir.ShowDialog();
        }

        private void lblsoz_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             baglanti.Open();
                SqlCommand komut = new SqlCommand("select *from sözlerim order by NEWID()", baglanti);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {

                    lblsoz.Text = (oku["söz"].ToString());
                }
                baglanti.Close();
        }

        private void admincksbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
