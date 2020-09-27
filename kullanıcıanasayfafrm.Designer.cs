namespace BM102Poje
{
    partial class kullanıcıanasayfafrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kullanıcıanasayfafrm));
            this.button1 = new System.Windows.Forms.Button();
            this.onlinekitapbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.okunanktplbl = new System.Windows.Forms.Label();
            this.adlbl = new System.Windows.Forms.Label();
            this.soyadlbl = new System.Windows.Forms.Label();
            this.telbl = new System.Windows.Forms.Label();
            this.postalbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ktpdegerlendirme_btn = new System.Windows.Forms.Button();
            this.admincksbtn = new System.Windows.Forms.Button();
            this.tc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(446, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mesajlar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // onlinekitapbtn
            // 
            this.onlinekitapbtn.BackColor = System.Drawing.Color.Transparent;
            this.onlinekitapbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.onlinekitapbtn.Location = new System.Drawing.Point(446, 134);
            this.onlinekitapbtn.Name = "onlinekitapbtn";
            this.onlinekitapbtn.Size = new System.Drawing.Size(112, 36);
            this.onlinekitapbtn.TabIndex = 2;
            this.onlinekitapbtn.Text = "e-dergi/gazete";
            this.onlinekitapbtn.UseVisualStyleBackColor = false;
            this.onlinekitapbtn.Click += new System.EventHandler(this.onlinekitapbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(0, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Okuduğu Kitap Sayısı:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "e-Posta:";
            // 
            // okunanktplbl
            // 
            this.okunanktplbl.AutoSize = true;
            this.okunanktplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okunanktplbl.Location = new System.Drawing.Point(186, 170);
            this.okunanktplbl.Name = "okunanktplbl";
            this.okunanktplbl.Size = new System.Drawing.Size(14, 17);
            this.okunanktplbl.TabIndex = 6;
            this.okunanktplbl.Text = "-";
            // 
            // adlbl
            // 
            this.adlbl.AutoSize = true;
            this.adlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adlbl.Location = new System.Drawing.Point(186, 34);
            this.adlbl.Name = "adlbl";
            this.adlbl.Size = new System.Drawing.Size(14, 17);
            this.adlbl.TabIndex = 4;
            this.adlbl.Text = "-";
            // 
            // soyadlbl
            // 
            this.soyadlbl.AutoSize = true;
            this.soyadlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyadlbl.Location = new System.Drawing.Point(186, 68);
            this.soyadlbl.Name = "soyadlbl";
            this.soyadlbl.Size = new System.Drawing.Size(14, 17);
            this.soyadlbl.TabIndex = 5;
            this.soyadlbl.Text = "-";
            // 
            // telbl
            // 
            this.telbl.AutoSize = true;
            this.telbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telbl.Location = new System.Drawing.Point(186, 102);
            this.telbl.Name = "telbl";
            this.telbl.Size = new System.Drawing.Size(14, 17);
            this.telbl.TabIndex = 7;
            this.telbl.Text = "-";
            // 
            // postalbl
            // 
            this.postalbl.AutoSize = true;
            this.postalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.postalbl.Location = new System.Drawing.Point(186, 136);
            this.postalbl.Name = "postalbl";
            this.postalbl.Size = new System.Drawing.Size(14, 17);
            this.postalbl.TabIndex = 9;
            this.postalbl.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.postalbl);
            this.groupBox1.Controls.Add(this.telbl);
            this.groupBox1.Controls.Add(this.soyadlbl);
            this.groupBox1.Controls.Add(this.adlbl);
            this.groupBox1.Controls.Add(this.okunanktplbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgilerim";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ktpdegerlendirme_btn
            // 
            this.ktpdegerlendirme_btn.BackColor = System.Drawing.Color.Transparent;
            this.ktpdegerlendirme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ktpdegerlendirme_btn.Location = new System.Drawing.Point(446, 201);
            this.ktpdegerlendirme_btn.Name = "ktpdegerlendirme_btn";
            this.ktpdegerlendirme_btn.Size = new System.Drawing.Size(112, 36);
            this.ktpdegerlendirme_btn.TabIndex = 3;
            this.ktpdegerlendirme_btn.Text = "Kitap Değerlendirme";
            this.ktpdegerlendirme_btn.UseVisualStyleBackColor = false;
            this.ktpdegerlendirme_btn.Click += new System.EventHandler(this.ktpdegerlendirme_btn_Click);
            // 
            // admincksbtn
            // 
            this.admincksbtn.BackColor = System.Drawing.Color.Transparent;
            this.admincksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admincksbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admincksbtn.ForeColor = System.Drawing.Color.Black;
            this.admincksbtn.Location = new System.Drawing.Point(551, 371);
            this.admincksbtn.Name = "admincksbtn";
            this.admincksbtn.Size = new System.Drawing.Size(57, 22);
            this.admincksbtn.TabIndex = 34;
            this.admincksbtn.Text = "ÇIKIŞ";
            this.admincksbtn.UseVisualStyleBackColor = false;
            this.admincksbtn.Click += new System.EventHandler(this.admincksbtn_Click);
            // 
            // tc
            // 
            this.tc.AutoSize = true;
            this.tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc.Location = new System.Drawing.Point(32, 323);
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(32, 17);
            this.tc.TabIndex = 35;
            this.tc.Text = "Ad:";
            this.tc.Visible = false;
            // 
            // kullanıcıanasayfafrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 405);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.admincksbtn);
            this.Controls.Add(this.ktpdegerlendirme_btn);
            this.Controls.Add(this.onlinekitapbtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "kullanıcıanasayfafrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kullanıcıanasayfafrm";
            this.Load += new System.EventHandler(this.kullanıcıanasayfafrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button onlinekitapbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label okunanktplbl;
        private System.Windows.Forms.Label adlbl;
        private System.Windows.Forms.Label soyadlbl;
        private System.Windows.Forms.Label telbl;
        private System.Windows.Forms.Label postalbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ktpdegerlendirme_btn;
        private System.Windows.Forms.Button admincksbtn;
        private System.Windows.Forms.Label tc;
    }
}