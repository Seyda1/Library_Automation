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
    public partial class emanetkitapfrm : Form
    {
        public emanetkitapfrm()
        {
            InitializeComponent();
        }

        private void btnEmanetKitapVerme_Click(object sender, EventArgs e)
        {
            emanetkitapvermefrn emanetver = new emanetkitapvermefrn();
            emanetver.ShowDialog();
            this.Hide();

        }

        private void anasayfabtn_Click(object sender, EventArgs e)
        {
            adminform dön = new adminform();
            this.Hide();
            dön.ShowDialog();
        }

        private void emanetkitapfrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitapiade iade = new Kitapiade();
            this.Hide();
            iade.ShowDialog();
        }

        private void btnEmanetKitapListele_Click(object sender, EventArgs e)
        {
            emanetkitaplistelemefrm liste = new emanetkitaplistelemefrm();
            this.Hide();
            liste.ShowDialog();
        }
    }
}
