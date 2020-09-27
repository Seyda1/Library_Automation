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
    public partial class emanetkitaplistelemefrm : Form
    {
        public emanetkitaplistelemefrm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-QMSN7VK\\SQLEXPRESS;Initial Catalog=Üyeler;Integrated Security=True");
       

        private void emanetkitaplistelemefrm_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int kıyaslama1 = 0;
            DateTime simdi1 = DateTime.Now;
            SqlCommand komut1 = new SqlCommand("select *from EmanetKitaplar", baglanti);
            baglanti.Open();
            SqlDataReader oku1 = komut1.ExecuteReader();
            
            while (oku1.Read())
            {
                kıyaslama1 = simdi1.CompareTo(Convert.ToDateTime(oku1["iadetarihi"]));
              

            } baglanti.Close(); 
            filtrelecmbx.SelectedIndex = 0;
          
            
        }
       

        private void filtrelecmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
             listView1.Items.Clear();
            int kıyaslama = 0;
            DateTime simdi = DateTime.Now; 
            SqlCommand komut = new SqlCommand("select *from EmanetKitaplar", baglanti);
           baglanti.Open();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {

                kıyaslama = simdi.CompareTo(Convert.ToDateTime(oku["iadetarihi"]));


                if (filtrelecmbx.SelectedIndex==0)
                {
                    
                    ListViewItem item2 = new ListViewItem();
                        item2.Text = oku["tc"].ToString();
                        item2.SubItems.Add(oku["ad"].ToString());
                        item2.SubItems.Add(oku["soyad"].ToString());
                       
                        item2.SubItems.Add(oku["barkodno"].ToString());
                        item2.SubItems.Add(oku["kitapadı"].ToString());
                       
                        item2.SubItems.Add(oku["kitapsayısı"].ToString());
                        item2.SubItems.Add(oku["teslimtarihi"].ToString());
                        item2.SubItems.Add(oku["iadetarihi"].ToString());
                        listView1.Items.Add(item2);
                    
                }
                else if ( filtrelecmbx.SelectedIndex== 1)
                {
                       if (kıyaslama > 0)
                    {
                        ListViewItem item3 = new ListViewItem();
                        item3.Text = oku["tc"].ToString();
                        item3.SubItems.Add(oku["ad"].ToString());
                        item3.SubItems.Add(oku["soyad"].ToString());
                      
                        item3.SubItems.Add(oku["barkodno"].ToString());
                        item3.SubItems.Add(oku["kitapadı"].ToString());
                      
                        item3.SubItems.Add(oku["kitapsayısı"].ToString());
                        item3.SubItems.Add(oku["teslimtarihi"].ToString());
                        item3.SubItems.Add(oku["iadetarihi"].ToString());
                        listView1.Items.Add(item3);
                    }
                    


                }
                else if ( filtrelecmbx.SelectedIndex== 2)
                {
                   if (kıyaslama <= 0)
                    {
                        ListViewItem item4 = new ListViewItem();
                        item4.Text = oku["tc"].ToString();
                        item4.SubItems.Add(oku["ad"].ToString());
                        item4.SubItems.Add(oku["soyad"].ToString());
                      
                        item4.SubItems.Add(oku["barkodno"].ToString());
                        item4.SubItems.Add(oku["kitapadı"].ToString());
                      
                        item4.SubItems.Add(oku["kitapsayısı"].ToString());
                        item4.SubItems.Add(oku["teslimtarihi"].ToString());
                        item4.SubItems.Add(oku["iadetarihi"].ToString());
                        listView1.Items.Add(item4);

                    }

                }

            }
            baglanti.Close();
          
            
             }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            emanetkitapfrm emanet = new emanetkitapfrm();
            this.Hide();
            emanet.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

           
            



              
                      
                       
                      
                       
              

                
       
   