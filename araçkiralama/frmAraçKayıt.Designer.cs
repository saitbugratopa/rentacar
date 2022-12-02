namespace araçkiralama
{
    partial class frmAraçKayıt
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
            this.components = new System.ComponentModel.Container();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.markacombo = new System.Windows.Forms.ComboBox();
            this.sericombo = new System.Windows.Forms.ComboBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.Yakitcombo = new System.Windows.Forms.ComboBox();
            this.Ücrettxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnResim = new System.Windows.Forms.Button();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.yilcombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(121, 45);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(191, 22);
            this.Plakatxt.TabIndex = 0;
            this.Plakatxt.TextChanged += new System.EventHandler(this.Plakatxt_TextChanged);
            // 
            // markacombo
            // 
            this.markacombo.FormattingEnabled = true;
            this.markacombo.Items.AddRange(new object[] {
            "Bmw",
            "Fiat",
            "Land Rover",
            "Mercedes Benz",
            "Opel",
            "Renault",
            "Toyota",
            "Vokswagen"});
            this.markacombo.Location = new System.Drawing.Point(121, 85);
            this.markacombo.Name = "markacombo";
            this.markacombo.Size = new System.Drawing.Size(191, 24);
            this.markacombo.TabIndex = 1;
            this.markacombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sericombo
            // 
            this.sericombo.FormattingEnabled = true;
            this.sericombo.Location = new System.Drawing.Point(121, 127);
            this.sericombo.Name = "sericombo";
            this.sericombo.Size = new System.Drawing.Size(191, 24);
            this.sericombo.TabIndex = 2;
            this.sericombo.SelectedIndexChanged += new System.EventHandler(this.sericombo_SelectedIndexChanged);
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(121, 209);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(191, 22);
            this.Renktxt.TabIndex = 4;
            this.Renktxt.TextChanged += new System.EventHandler(this.Renktxt_TextChanged);
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(121, 249);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(191, 22);
            this.Kmtxt.TabIndex = 5;
            this.Kmtxt.TextChanged += new System.EventHandler(this.Kmtxt_TextChanged);
            // 
            // Yakitcombo
            // 
            this.Yakitcombo.FormattingEnabled = true;
            this.Yakitcombo.Items.AddRange(new object[] {
            "Dizel",
            "Benzin"});
            this.Yakitcombo.Location = new System.Drawing.Point(121, 289);
            this.Yakitcombo.Name = "Yakitcombo";
            this.Yakitcombo.Size = new System.Drawing.Size(191, 24);
            this.Yakitcombo.TabIndex = 6;
            this.Yakitcombo.SelectedIndexChanged += new System.EventHandler(this.Yakitcombo_SelectedIndexChanged);
            // 
            // Ücrettxt
            // 
            this.Ücrettxt.Location = new System.Drawing.Point(121, 331);
            this.Ücrettxt.Name = "Ücrettxt";
            this.Ücrettxt.Size = new System.Drawing.Size(191, 22);
            this.Ücrettxt.TabIndex = 7;
            this.Ücrettxt.TextChanged += new System.EventHandler(this.Ücrettxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Plaka:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Marka:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seri:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Model/Yıl:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Renk:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "KM:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Yakıt:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kira Ücreti:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(373, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnResim
            // 
            this.BtnResim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnResim.Location = new System.Drawing.Point(427, 214);
            this.BtnResim.Name = "BtnResim";
            this.BtnResim.Size = new System.Drawing.Size(95, 38);
            this.BtnResim.TabIndex = 17;
            this.BtnResim.Text = "Resim Ekle";
            this.BtnResim.UseVisualStyleBackColor = false;
            this.BtnResim.Click += new System.EventHandler(this.BtnResim_Click);
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKayıt.Location = new System.Drawing.Point(121, 378);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(87, 35);
            this.btnKayıt.TabIndex = 18;
            this.btnKayıt.Text = "Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnİptal.Location = new System.Drawing.Point(214, 378);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(98, 34);
            this.btnİptal.TabIndex = 19;
            this.btnİptal.Text = "Geri";
            this.btnİptal.UseVisualStyleBackColor = false;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(30, 30);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // yilcombo
            // 
            this.yilcombo.FormattingEnabled = true;
            this.yilcombo.Items.AddRange(new object[] {
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010"});
            this.yilcombo.Location = new System.Drawing.Point(121, 167);
            this.yilcombo.Name = "yilcombo";
            this.yilcombo.Size = new System.Drawing.Size(191, 24);
            this.yilcombo.TabIndex = 20;
            this.yilcombo.SelectedIndexChanged += new System.EventHandler(this.yilcombo_SelectedIndexChanged);
            // 
            // frmAraçKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(598, 442);
            this.Controls.Add(this.yilcombo);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.BtnResim);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ücrettxt);
            this.Controls.Add(this.Yakitcombo);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.sericombo);
            this.Controls.Add(this.markacombo);
            this.Controls.Add(this.Plakatxt);
            this.Name = "frmAraçKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kayıt Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.ComboBox markacombo;
        private System.Windows.Forms.ComboBox sericombo;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.ComboBox Yakitcombo;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnResim;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox yilcombo;
    }
}