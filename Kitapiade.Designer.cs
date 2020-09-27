namespace BM102Poje
{
    partial class Kitapiade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitapiade));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iadebarkodtxt = new System.Windows.Forms.TextBox();
            this.iadetcaratxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teslimalbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // iadebarkodtxt
            // 
            this.iadebarkodtxt.Location = new System.Drawing.Point(657, 35);
            this.iadebarkodtxt.Name = "iadebarkodtxt";
            this.iadebarkodtxt.Size = new System.Drawing.Size(105, 20);
            this.iadebarkodtxt.TabIndex = 1;
            this.iadebarkodtxt.TextChanged += new System.EventHandler(this.iadebarkodtxt_TextChanged);
            // 
            // iadetcaratxt
            // 
            this.iadetcaratxt.Location = new System.Drawing.Point(360, 35);
            this.iadetcaratxt.Name = "iadetcaratxt";
            this.iadetcaratxt.Size = new System.Drawing.Size(105, 20);
            this.iadetcaratxt.TabIndex = 2;
            this.iadetcaratxt.TextChanged += new System.EventHandler(this.iadetcaratxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(255, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC\'ye göre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(492, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Barkod no\'ya göre:";
            // 
            // teslimalbtn
            // 
            this.teslimalbtn.BackColor = System.Drawing.Color.Transparent;
            this.teslimalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.teslimalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teslimalbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.teslimalbtn.Location = new System.Drawing.Point(638, 391);
            this.teslimalbtn.Name = "teslimalbtn";
            this.teslimalbtn.Size = new System.Drawing.Size(114, 30);
            this.teslimalbtn.TabIndex = 5;
            this.teslimalbtn.Text = "TESLİM AL";
            this.teslimalbtn.UseVisualStyleBackColor = false;
            this.teslimalbtn.Click += new System.EventHandler(this.teslimalbtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 28);
            this.button3.TabIndex = 33;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Kitapiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(848, 457);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.teslimalbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iadetcaratxt);
            this.Controls.Add(this.iadebarkodtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kitapiade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap İade Formu";
            this.Load += new System.EventHandler(this.Kitapiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox iadebarkodtxt;
        private System.Windows.Forms.TextBox iadetcaratxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button teslimalbtn;
        private System.Windows.Forms.Button button3;
    }
}