namespace BM102Poje
{
    partial class Klncgrsfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Klncgrsfrm));
            this.klncadtxtbx = new System.Windows.Forms.TextBox();
            this.sfrtxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grsbtn = new System.Windows.Forms.Button();
            this.linksfrlbl = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // klncadtxtbx
            // 
            this.klncadtxtbx.Location = new System.Drawing.Point(111, 81);
            this.klncadtxtbx.MaxLength = 11;
            this.klncadtxtbx.Name = "klncadtxtbx";
            this.klncadtxtbx.Size = new System.Drawing.Size(150, 20);
            this.klncadtxtbx.TabIndex = 0;
            // 
            // sfrtxtbx
            // 
            this.sfrtxtbx.Location = new System.Drawing.Point(111, 142);
            this.sfrtxtbx.MaxLength = 10;
            this.sfrtxtbx.Name = "sfrtxtbx";
            this.sfrtxtbx.Size = new System.Drawing.Size(150, 20);
            this.sfrtxtbx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tc Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(61, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre:";
            // 
            // grsbtn
            // 
            this.grsbtn.BackColor = System.Drawing.Color.Transparent;
            this.grsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grsbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grsbtn.Location = new System.Drawing.Point(140, 191);
            this.grsbtn.Name = "grsbtn";
            this.grsbtn.Size = new System.Drawing.Size(90, 30);
            this.grsbtn.TabIndex = 4;
            this.grsbtn.Text = "GİRİŞ";
            this.grsbtn.UseVisualStyleBackColor = false;
            this.grsbtn.Click += new System.EventHandler(this.grsbtn_Click);
            // 
            // linksfrlbl
            // 
            this.linksfrlbl.AutoSize = true;
            this.linksfrlbl.BackColor = System.Drawing.Color.Transparent;
            this.linksfrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linksfrlbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linksfrlbl.Location = new System.Drawing.Point(134, 173);
            this.linksfrlbl.Name = "linksfrlbl";
            this.linksfrlbl.Size = new System.Drawing.Size(96, 15);
            this.linksfrlbl.TabIndex = 5;
            this.linksfrlbl.TabStop = true;
            this.linksfrlbl.Text = "Şifremi Unuttum";
            this.linksfrlbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksfrlbl_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 25);
            this.button1.TabIndex = 16;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Klncgrsfrm
            // 
            this.AcceptButton = this.grsbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(356, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linksfrlbl);
            this.Controls.Add(this.grsbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sfrtxtbx);
            this.Controls.Add(this.klncadtxtbx);
            this.Name = "Klncgrsfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Giriş Formu";
            this.Load += new System.EventHandler(this.Klncgrsfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox klncadtxtbx;
        private System.Windows.Forms.TextBox sfrtxtbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button grsbtn;
        private System.Windows.Forms.LinkLabel linksfrlbl;
        private System.Windows.Forms.Button button1;
    }
}