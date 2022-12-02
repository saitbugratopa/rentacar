namespace araçkiralama
{
    partial class frmSözleşme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTcAra = new System.Windows.Forms.Label();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtE_Yer = new System.Windows.Forms.TextBox();
            this.txtE_Tarih = new System.Windows.Forms.TextBox();
            this.txtEhliyetno = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblE_Yer = new System.Windows.Forms.Label();
            this.lblE_Tarih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dateGiriş = new System.Windows.Forms.DateTimePicker();
            this.dateÇıkış = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiraŞekli = new System.Windows.Forms.ComboBox();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAraçTeslim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTcAra);
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.txtE_Yer);
            this.groupBox1.Controls.Add(this.txtE_Tarih);
            this.groupBox1.Controls.Add(this.txtEhliyetno);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblE_Yer);
            this.groupBox1.Controls.Add(this.lblE_Tarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // btnTcAra
            // 
            this.btnTcAra.AutoSize = true;
            this.btnTcAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTcAra.Location = new System.Drawing.Point(60, 21);
            this.btnTcAra.Name = "btnTcAra";
            this.btnTcAra.Size = new System.Drawing.Size(68, 20);
            this.btnTcAra.TabIndex = 13;
            this.btnTcAra.Text = "TC Ara";
            this.btnTcAra.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcAra.Location = new System.Drawing.Point(134, 21);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(100, 22);
            this.txtTcAra.TabIndex = 12;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txtE_Yer
            // 
            this.txtE_Yer.Location = new System.Drawing.Point(134, 192);
            this.txtE_Yer.Name = "txtE_Yer";
            this.txtE_Yer.Size = new System.Drawing.Size(100, 22);
            this.txtE_Yer.TabIndex = 11;
            // 
            // txtE_Tarih
            // 
            this.txtE_Tarih.Location = new System.Drawing.Point(134, 164);
            this.txtE_Tarih.Name = "txtE_Tarih";
            this.txtE_Tarih.Size = new System.Drawing.Size(100, 22);
            this.txtE_Tarih.TabIndex = 10;
            // 
            // txtEhliyetno
            // 
            this.txtEhliyetno.Location = new System.Drawing.Point(134, 136);
            this.txtEhliyetno.Name = "txtEhliyetno";
            this.txtEhliyetno.Size = new System.Drawing.Size(100, 22);
            this.txtEhliyetno.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(134, 108);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(134, 79);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(134, 51);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(100, 22);
            this.txtTc.TabIndex = 6;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // lblE_Yer
            // 
            this.lblE_Yer.AutoSize = true;
            this.lblE_Yer.Location = new System.Drawing.Point(22, 197);
            this.lblE_Yer.Name = "lblE_Yer";
            this.lblE_Yer.Size = new System.Drawing.Size(105, 17);
            this.lblE_Yer.TabIndex = 5;
            this.lblE_Yer.Text = "E. Verildiği Yer:";
            // 
            // lblE_Tarih
            // 
            this.lblE_Tarih.AutoSize = true;
            this.lblE_Tarih.Location = new System.Drawing.Point(22, 169);
            this.lblE_Tarih.Name = "lblE_Tarih";
            this.lblE_Tarih.Size = new System.Drawing.Size(94, 17);
            this.lblE_Tarih.TabIndex = 4;
            this.lblE_Tarih.Text = "Ehliyet Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ehliyet No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.dateGiriş);
            this.groupBox2.Controls.Add(this.dateÇıkış);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGün);
            this.groupBox2.Controls.Add(this.txtKiraÜcreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtYil);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiraŞekli);
            this.groupBox2.Controls.Add(this.comboAraçlar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(366, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 284);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(611, 21);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 199);
            this.btnHesapla.TabIndex = 25;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(436, 222);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(155, 45);
            this.btnTemizle.TabIndex = 24;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(196, 222);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(86, 45);
            this.btnGüncelle.TabIndex = 23;
            this.btnGüncelle.Text = "Sözleşme Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dateGiriş
            // 
            this.dateGiriş.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGiriş.Location = new System.Drawing.Point(436, 115);
            this.dateGiriş.Name = "dateGiriş";
            this.dateGiriş.Size = new System.Drawing.Size(155, 22);
            this.dateGiriş.TabIndex = 21;
            this.dateGiriş.ValueChanged += new System.EventHandler(this.a);
            // 
            // dateÇıkış
            // 
            this.dateÇıkış.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateÇıkış.Location = new System.Drawing.Point(436, 87);
            this.dateÇıkış.Name = "dateÇıkış";
            this.dateÇıkış.Size = new System.Drawing.Size(155, 22);
            this.dateÇıkış.TabIndex = 20;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(113, 222);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(77, 43);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Sözleşme Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(436, 174);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(155, 22);
            this.txtTutar.TabIndex = 19;
            // 
            // txtGün
            // 
            this.txtGün.Location = new System.Drawing.Point(436, 143);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(155, 22);
            this.txtGün.TabIndex = 18;
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.Location = new System.Drawing.Point(436, 54);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(155, 22);
            this.txtKiraÜcreti.TabIndex = 17;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(113, 169);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(169, 22);
            this.txtRenk.TabIndex = 16;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(113, 133);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(169, 22);
            this.txtYil.TabIndex = 15;
            // 
            // txtSeri
            // 
            this.txtSeri.Location = new System.Drawing.Point(113, 100);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(169, 22);
            this.txtSeri.TabIndex = 14;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(113, 66);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(169, 22);
            this.txtMarka.TabIndex = 13;
            // 
            // comboKiraŞekli
            // 
            this.comboKiraŞekli.FormattingEnabled = true;
            this.comboKiraŞekli.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık"});
            this.comboKiraŞekli.Location = new System.Drawing.Point(436, 21);
            this.comboKiraŞekli.Name = "comboKiraŞekli";
            this.comboKiraŞekli.Size = new System.Drawing.Size(155, 24);
            this.comboKiraŞekli.TabIndex = 12;
            this.comboKiraŞekli.SelectedIndexChanged += new System.EventHandler(this.comboKiraŞekli_SelectedIndexChanged);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Location = new System.Drawing.Point(113, 29);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(169, 24);
            this.comboAraçlar.TabIndex = 11;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(309, 87);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 10;
            this.label17.Text = "Giriş Tarihi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(309, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "Çıkış Tarihi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Tutar";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(319, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Gün";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(319, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Kira Ücreti";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(319, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Kira Şekli";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Renk";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Yıl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Seri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Marka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1002, 243);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(776, 581);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(100, 22);
            this.txtEkstra.TabIndex = 13;
            this.txtEkstra.TextChanged += new System.EventHandler(this.txtEkstra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Borç Durumu:";
            // 
            // btnAraçTeslim
            // 
            this.btnAraçTeslim.Location = new System.Drawing.Point(903, 571);
            this.btnAraçTeslim.Name = "btnAraçTeslim";
            this.btnAraçTeslim.Size = new System.Drawing.Size(155, 32);
            this.btnAraçTeslim.TabIndex = 25;
            this.btnAraçTeslim.Text = "Araç Teslim";
            this.btnAraçTeslim.UseVisualStyleBackColor = true;
            this.btnAraçTeslim.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1130, 606);
            this.Controls.Add(this.btnAraçTeslim);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSözleşme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtE_Yer;
        private System.Windows.Forms.TextBox txtE_Tarih;
        private System.Windows.Forms.TextBox txtEhliyetno;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblE_Yer;
        private System.Windows.Forms.Label lblE_Tarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.DateTimePicker dateGiriş;
        private System.Windows.Forms.DateTimePicker dateÇıkış;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtGün;
        private System.Windows.Forms.TextBox txtKiraÜcreti;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSeri;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ComboBox comboKiraŞekli;
        private System.Windows.Forms.ComboBox comboAraçlar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label btnTcAra;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.TextBox txtEkstra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAraçTeslim;
    }
}