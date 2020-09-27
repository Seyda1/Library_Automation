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
    public partial class yöneticibilgignclfrm : Form
    {
        public yöneticibilgignclfrm()
        {
            InitializeComponent();
        }
        kullanici_girissınıf yeni = new kullanici_girissınıf();
        private void yntcsfrgnclbtn_Click(object sender, EventArgs e)
        {
            yeni.sifregüncelle(yklncadtxtbx,ysfrtxtbx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yntcgrsfrm yn = new Yntcgrsfrm();
            this.Hide();
            yn.ShowDialog();
        }
    }
}
