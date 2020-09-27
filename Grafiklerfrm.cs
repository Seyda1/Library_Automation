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
    public partial class Grafiklerfrm : Form
    {
        public Grafiklerfrm()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
        DataSet daset = new DataSet();
        private void Grafiklerfrm_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select ad,soyad,okunankitapsayısı from kullanıcı", baglan);
            SqlDataReader read = komut.ExecuteReader();
           // chart1.ChartAreas[0].AxisX.Maximum = 5;
           // chart1.ChartAreas[0].AxisX.Minimum = 0;
            while (read.Read())
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(read["ad"].ToString(), read["okunankitapsayısı"]);
             
            }
            baglan.Close();
            chart1.Series["Okunan Kitap Sayısı"].Color = Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminform frm = new adminform();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
