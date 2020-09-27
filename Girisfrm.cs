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
    public partial class Klncgrsfrm : Form
    {
        public Klncgrsfrm()
        {
            InitializeComponent();
        }

        private void Klncgrsfrm_Load(object sender, EventArgs e)
        {
            sfrtxtbx.UseSystemPasswordChar = true;
        }
        kullanici_girissınıf sinif = new kullanici_girissınıf();
        private void grsbtn_Click(object sender, EventArgs e)
        {
            sinif.bilgilerimigörüntele(klncadtxtbx,sfrtxtbx);
            sinif.kullanici(klncadtxtbx,sfrtxtbx);
        }

        private void linksfrlbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            şifremiunuttumfrm unut = new şifremiunuttumfrm();
            this.Hide();
            unut.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 unut = new Form1();
            this.Hide();
            unut.ShowDialog();
        }
    }
}
