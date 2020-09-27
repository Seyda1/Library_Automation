using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace BM102Poje
{
    public partial class dergifrm : Form
    {
        public dergifrm()
        {
            InitializeComponent();
        }
      
        private void dergifrm_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar2.Maximum = 100;
            progressBar3.Maximum = 100;
            progressBar4.Maximum = 100;
            progressBar5.Maximum = 100;
            progressBar6.Maximum = 100;
            progressBar7.Maximum = 100;
            progressBar8.Maximum = 100;
        }
        private void Wc1_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar1.Value = e.ProgressPercentage;
            label1.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc2_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar2.Value = e.ProgressPercentage;
            label2.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc3_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar3.Value = e.ProgressPercentage;
            label3.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc4_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar7.Value = e.ProgressPercentage;
            label4.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc5_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar6.Value = e.ProgressPercentage;
            label5.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc6_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar4.Value = e.ProgressPercentage;
            label6.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc7_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar5.Value = e.ProgressPercentage;
            label7.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc8_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            progressBar8.Value = e.ProgressPercentage;
            label8.Text = "İndirilen : %" + e.ProgressPercentage;
        }
        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("İndirme İşlemi Tamamlandı");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {    progressBar1.Visible = true;
        label1.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848420/u348852382/docs/d3/b50b57ed0d9c/New_Scientist__April_27_2019.pdf?extra=gEIZcWtGWR_m4DrALUxrUxy_VwDlIoOz8VgIfjpJt30NeiahuAJWLmZnr5yfOo8QrdRV2678tOvvIvFwxjWDkU7XR3x7mdliq_xI4OJMiQOwdET3HZdx9er6GljNFhHO4AtQlg"), "D:/dergi1mb.pdf");
            wc.DownloadProgressChanged += Wc1_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            
        }
      
        private void progressBar2_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
            progressBar3.Visible = true;
            label3.Visible = true;

            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848432/u479697494/docs/d12/491332fd0c73/National_Geographic_History_-_05_2019_-_06_2019.pdf?extra=UoCUhprAtz_ywlDPr3SiRX_A2lIsFxOoEw6Ymm2vBQoP-w_XLj4F5rHlk8X5_3dT7HTflKo2atkbdBpQGuX_ygbwZj-mNQXHKKhpz9ebg3CN-Eu9GdBOLeqXcxSulSDViMyUoQ"), "D:/dergi2mb.pdf");
            wc.DownloadProgressChanged += Wc3_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar7.Visible = true;
            label4.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848332/u479697494/docs/d1/704786f9f6ba/The_Guardian_-_26_04_2019.pdf?extra=A6cYLUzjChXPskOpgUepYLyFYCOM_yZtzMHAU3eSeHG1L4M2RlMUOijHMCSPaGbn0F7-KmNTkmNjGW9m3Tz6_1HZ2gk1iUSMmpe684OHzBCfBY9RZQN5mrppZSyugMw97l9I0Q"), "D:/dergi3mb.pdf");
            wc.DownloadProgressChanged += Wc4_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar6.Visible = true;
            label5.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848332/u479697494/docs/d13/4f1aec5dffb9/Daily_Mail_-_26_04_2019.pdf?extra=mccJYoqoEv3hl-_wt_0h7_J6PMhMObFBe1rdFQffdz_YBMC_F4GBsdJjHC9Nu00Gn5vlsFBkjKVh-X9bOVPhybn3XSGLT6pE_xVgnqyEonfbtk7nsstDOeR6U7UsozyX4dQe7Q"), "D:/dergi4mb.pdf");
            wc.DownloadProgressChanged += Wc5_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar4.Visible = true;
            label6.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848332/u479697494/docs/d14/21297a72f40d/Daily_Mirror_-_26_04_2019.pdf?extra=OKZSnRMxGUrzOxjjB18985xC4BU_dPv4v3LCNDrOLmOw89kFGcGLEy-XokeOvWaBCZOcHXOcEuPM4Y9iQiyM2Tixyu96nPJZNNUi0EXM_wuSXCd4ZlMR3HmE2RpgQTtSwUH5lQ"), "D:/dergi5mb.pdf");
            wc.DownloadProgressChanged += Wc6_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar5.Visible = true;
            label7.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848216/u16929061/docs/d6/2b727125cd0a/int270419.pdf?extra=_YehuNe-dU04IHMIP3SI846KRSrDTTvN-TTU_NEiocbQixgGCMWRdTyBRYgQKET4vC_chdf34qKsn7BbFm7Ex_D_dUdYwSxlxR_MsFXlRhwA5L2npS-jC3PV_6bI9-fk0LF-"), "D:/dergi6mb.pdf");
            wc.DownloadProgressChanged += Wc7_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar8.Visible = true;
            label8.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848028/u348852382/docs/d8/39393b02f1cf/Time_International_Edition__April_29_2019.pdf?extra=u96lWNGInuQG7D6_o43TtmKpAc2qSkE5szWXu-222_vFtMcHS_Ic--kCbYgW0wRDxwwbNlY3T5VGmnVrxDbBJGvH6RRoFXnVhJnSooXO3Gt7MGkXC99zjPzMObgHr-gtgbWeug"), "D:/dergi7mb.pdf");
            wc.DownloadProgressChanged += Wc8_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            progressBar2.Visible = true;
            label2.Visible = true;
            WebClient wc = new WebClient();
            wc.DownloadFileAsync(new Uri("https://psv4.userapi.com/c848136/u348852382/docs/d10/52ac5ae7be2c/The_Demographics_of_Empire-_The_Colonial_Order_and_the_Creation_of_Knowledge.pdf?extra=Btj2ikFH4hS7dQYN3-ciTmF6sKOaMjdhD_QTIFjHeCJF62hW-VcvY8dqyJl4E8oev2pZzN74j4ZFVHuZgBbMWgdkD4wifHnYu3S7XhcB8Cl1lILwe8oazXzGgUMT6M7ee8iZEg"), "D:/dergi8mb.pdf");
            wc.DownloadProgressChanged += Wc2_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcıanasayfafrm kl = new kullanıcıanasayfafrm();
            this.Hide();
            kl.ShowDialog();
        }
    }
}
