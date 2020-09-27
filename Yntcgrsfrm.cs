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
   
    public partial class Yntcgrsfrm : Form
    {
        public Yntcgrsfrm()
        {
            InitializeComponent();
        }
        admin_girissinifi admin = new admin_girissinifi();
        private void ygrsbtn_Click(object sender, EventArgs e)
        {
            
            admin.adminyol(yklncadtxtbx,ysfrtxtbx);
            
            
        }

        private void Yntcgrsfrm_Load(object sender, EventArgs e)
        {
            ysfrtxtbx.UseSystemPasswordChar = true;
        }

        private void yklncadtxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yöneticibilgignclfrm bilgi = new yöneticibilgignclfrm();
            this.Hide();
            bilgi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 gir = new Form1();
            this.Hide();
            gir.ShowDialog();
        }
    }
}
