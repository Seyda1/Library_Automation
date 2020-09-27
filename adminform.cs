using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM102Poje
{
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uyeislemfrm uyeislem = new Uyeislemfrm();
            this.Hide();
            uyeislem.ShowDialog();
        }

        private void uyeekle_btn_Click(object sender, EventArgs e)
        {
            uyeeklefrm uyeekle = new uyeeklefrm();
            uyeekle.ShowDialog();
            this.Hide();
        }

        private void kitapislem_btn_Click(object sender, EventArgs e)
        {
            Kitapİşlemlerifrm kitap = new Kitapİşlemlerifrm();
            kitap.ShowDialog();
            this.Hide();
        }

        private void emanetkitap_islbtn_Click(object sender, EventArgs e)
        {
            emanetkitapfrm emanetkitap = new emanetkitapfrm();
              this.Hide(); 
            emanetkitap.ShowDialog();
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Sıralamafrm sıra = new Sıralamafrm();
            this.Hide();
            sıra.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grafiklerfrm grafik = new Grafiklerfrm();
            this.Hide();
            grafik.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 grafik = new Form1();
            this.Hide();
            grafik.ShowDialog();

        }

        private void admincksbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
