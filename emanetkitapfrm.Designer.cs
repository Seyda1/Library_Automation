namespace BM102Poje
{
    partial class emanetkitapfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emanetkitapfrm));
            this.btnEmanetKitapVerme = new System.Windows.Forms.Button();
            this.btnEmanetKitapListele = new System.Windows.Forms.Button();
            this.anasayfabtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmanetKitapVerme
            // 
            this.btnEmanetKitapVerme.BackColor = System.Drawing.Color.Transparent;
            this.btnEmanetKitapVerme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmanetKitapVerme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetKitapVerme.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmanetKitapVerme.Location = new System.Drawing.Point(139, 35);
            this.btnEmanetKitapVerme.Name = "btnEmanetKitapVerme";
            this.btnEmanetKitapVerme.Size = new System.Drawing.Size(198, 29);
            this.btnEmanetKitapVerme.TabIndex = 0;
            this.btnEmanetKitapVerme.Text = "Emanet Kitap Verme";
            this.btnEmanetKitapVerme.UseVisualStyleBackColor = false;
            this.btnEmanetKitapVerme.Click += new System.EventHandler(this.btnEmanetKitapVerme_Click);
            // 
            // btnEmanetKitapListele
            // 
            this.btnEmanetKitapListele.BackColor = System.Drawing.Color.Transparent;
            this.btnEmanetKitapListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmanetKitapListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEmanetKitapListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEmanetKitapListele.Location = new System.Drawing.Point(139, 84);
            this.btnEmanetKitapListele.Name = "btnEmanetKitapListele";
            this.btnEmanetKitapListele.Size = new System.Drawing.Size(199, 26);
            this.btnEmanetKitapListele.TabIndex = 1;
            this.btnEmanetKitapListele.Text = "Emanet Kitap Listele";
            this.btnEmanetKitapListele.UseVisualStyleBackColor = false;
            this.btnEmanetKitapListele.Click += new System.EventHandler(this.btnEmanetKitapListele_Click);
            // 
            // anasayfabtn
            // 
            this.anasayfabtn.BackColor = System.Drawing.Color.Transparent;
            this.anasayfabtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anasayfabtn.BackgroundImage")));
            this.anasayfabtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anasayfabtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anasayfabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfabtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anasayfabtn.Location = new System.Drawing.Point(14, 9);
            this.anasayfabtn.Name = "anasayfabtn";
            this.anasayfabtn.Size = new System.Drawing.Size(27, 23);
            this.anasayfabtn.TabIndex = 2;
            this.anasayfabtn.UseVisualStyleBackColor = false;
            this.anasayfabtn.Click += new System.EventHandler(this.anasayfabtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(139, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Emanet Kitap İade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // emanetkitapfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(471, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.anasayfabtn);
            this.Controls.Add(this.btnEmanetKitapListele);
            this.Controls.Add(this.btnEmanetKitapVerme);
            this.Name = "emanetkitapfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet Kitap Formu";
            this.Load += new System.EventHandler(this.emanetkitapfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmanetKitapVerme;
        private System.Windows.Forms.Button btnEmanetKitapListele;
        private System.Windows.Forms.Button anasayfabtn;
        private System.Windows.Forms.Button button1;
    }
}