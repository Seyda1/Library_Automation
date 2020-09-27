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
    public partial class şifremiunuttumfrm : Form
    {
        public şifremiunuttumfrm()
        {
            InitializeComponent();
        }
        kullanici_girissınıf sfr = new kullanici_girissınıf();
        private void yenişifre_btn_Click(object sender, EventArgs e)
        {
            if (uyeadtxtbx.Text != "" && uyesoyadtxtbx.Text != "" && uyetctxtbx.Text != "" && uyepostatxtbx.Text != "" && uyesifretxtbx.Text != "" && uyetel_txtbx.Text != "" && uyesifretkr_txtbx.Text != "")
            {
                sfr.sifre(uyeadtxtbx, uyesoyadtxtbx, uyetctxtbx, uyetel_txtbx, uyepostatxtbx, uyesifretxtbx, uyesifretkr_txtbx);
               
            }
            else
            {
                MessageBox.Show("Kutular boş bırakılamaz!!");
            }
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Klncgrsfrm kl = new Klncgrsfrm();
            this.Hide();
            kl.ShowDialog();
        }
    }
}
