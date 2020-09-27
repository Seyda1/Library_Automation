namespace BM102Poje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.yntcgrsbtn = new System.Windows.Forms.Button();
            this.klncgrsbtn = new System.Windows.Forms.Button();
            this.lblsoz = new System.Windows.Forms.Label();
            this.admincksbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yntcgrsbtn
            // 
            this.yntcgrsbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.yntcgrsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yntcgrsbtn.Location = new System.Drawing.Point(378, 86);
            this.yntcgrsbtn.Name = "yntcgrsbtn";
            this.yntcgrsbtn.Size = new System.Drawing.Size(165, 31);
            this.yntcgrsbtn.TabIndex = 0;
            this.yntcgrsbtn.Text = "Yönetici Girişi";
            this.yntcgrsbtn.UseVisualStyleBackColor = false;
            this.yntcgrsbtn.Click += new System.EventHandler(this.yntcgrsbtn_Click);
            // 
            // klncgrsbtn
            // 
            this.klncgrsbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.klncgrsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.klncgrsbtn.Location = new System.Drawing.Point(378, 143);
            this.klncgrsbtn.Name = "klncgrsbtn";
            this.klncgrsbtn.Size = new System.Drawing.Size(165, 31);
            this.klncgrsbtn.TabIndex = 1;
            this.klncgrsbtn.Text = "Kullanıcı Girişi";
            this.klncgrsbtn.UseVisualStyleBackColor = false;
            this.klncgrsbtn.Click += new System.EventHandler(this.klncgrsbtn_Click);
            // 
            // lblsoz
            // 
            this.lblsoz.AutoSize = true;
            this.lblsoz.BackColor = System.Drawing.Color.Transparent;
            this.lblsoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsoz.Location = new System.Drawing.Point(24, 260);
            this.lblsoz.Name = "lblsoz";
            this.lblsoz.Size = new System.Drawing.Size(70, 25);
            this.lblsoz.TabIndex = 2;
            this.lblsoz.Text = "label1";
            this.lblsoz.Click += new System.EventHandler(this.lblsoz_Click);
            // 
            // admincksbtn
            // 
            this.admincksbtn.BackColor = System.Drawing.Color.Transparent;
            this.admincksbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admincksbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.admincksbtn.ForeColor = System.Drawing.Color.White;
            this.admincksbtn.Location = new System.Drawing.Point(825, 343);
            this.admincksbtn.Name = "admincksbtn";
            this.admincksbtn.Size = new System.Drawing.Size(57, 22);
            this.admincksbtn.TabIndex = 34;
            this.admincksbtn.Text = "ÇIKIŞ";
            this.admincksbtn.UseVisualStyleBackColor = false;
            this.admincksbtn.Click += new System.EventHandler(this.admincksbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 215);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(894, 368);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.admincksbtn);
            this.Controls.Add(this.lblsoz);
            this.Controls.Add(this.klncgrsbtn);
            this.Controls.Add(this.yntcgrsbtn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphanem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yntcgrsbtn;
        private System.Windows.Forms.Button klncgrsbtn;
        private System.Windows.Forms.Label lblsoz;
        private System.Windows.Forms.Button admincksbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

