namespace BM102Poje
{
    partial class yöneticibilgignclfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yöneticibilgignclfrm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ysfrtxtbx = new System.Windows.Forms.TextBox();
            this.yklncadtxtbx = new System.Windows.Forms.TextBox();
            this.yntcsfrgnclbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // ysfrtxtbx
            // 
            this.ysfrtxtbx.Location = new System.Drawing.Point(108, 89);
            this.ysfrtxtbx.MaxLength = 10;
            this.ysfrtxtbx.Name = "ysfrtxtbx";
            this.ysfrtxtbx.PasswordChar = '*';
            this.ysfrtxtbx.Size = new System.Drawing.Size(150, 20);
            this.ysfrtxtbx.TabIndex = 10;
            // 
            // yklncadtxtbx
            // 
            this.yklncadtxtbx.Location = new System.Drawing.Point(108, 53);
            this.yklncadtxtbx.MaxLength = 15;
            this.yklncadtxtbx.Name = "yklncadtxtbx";
            this.yklncadtxtbx.Size = new System.Drawing.Size(150, 20);
            this.yklncadtxtbx.TabIndex = 9;
            // 
            // yntcsfrgnclbtn
            // 
            this.yntcsfrgnclbtn.BackColor = System.Drawing.Color.Transparent;
            this.yntcsfrgnclbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yntcsfrgnclbtn.Location = new System.Drawing.Point(169, 133);
            this.yntcsfrgnclbtn.Name = "yntcsfrgnclbtn";
            this.yntcsfrgnclbtn.Size = new System.Drawing.Size(89, 23);
            this.yntcsfrgnclbtn.TabIndex = 13;
            this.yntcsfrgnclbtn.Text = "GÜNCELLE";
            this.yntcsfrgnclbtn.UseVisualStyleBackColor = false;
            this.yntcsfrgnclbtn.Click += new System.EventHandler(this.yntcsfrgnclbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 14;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yöneticibilgignclfrm
            // 
            this.AcceptButton = this.yntcsfrgnclbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yntcsfrgnclbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ysfrtxtbx);
            this.Controls.Add(this.yklncadtxtbx);
            this.Name = "yöneticibilgignclfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Bilgi Güncelleme Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ysfrtxtbx;
        private System.Windows.Forms.TextBox yklncadtxtbx;
        private System.Windows.Forms.Button yntcsfrgnclbtn;
        private System.Windows.Forms.Button button1;
    }
}