using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araçkiralama
{
    public partial class frmSözleşme : Form
    {
        public frmSözleşme()
        {
            InitializeComponent();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        Araç_Kiralama arac = new Araç_Kiralama();
        private void frmSözleşme_Load(object sender, EventArgs e)
        {
            Boş_Araçlar();
            Yenile();
        }

        private void Boş_Araçlar()
        {
            string sorgu2 = "select *from araç where durumu='BOŞ'";
            arac.Boş_Araçlar(comboAraçlar, sorgu2);
        }

        private void Yenile()
        {
            string sorgu3 = "Select *from sözleşme";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2,sorgu3);
        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select*from araç where plaka like '" + comboAraçlar.SelectedItem + "' ";
            arac.CombodanGetir(comboAraçlar, txtMarka, txtSeri,txtYil,txtRenk, sorgu2);
        }

        private void comboKiraŞekli_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sorgu2 = "select*from araç where plaka like '" + comboAraçlar.SelectedItem + "' ";
            arac.ücretHesapla(comboKiraŞekli, txtKiraÜcreti, sorgu2);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            TimeSpan gun = DateTime.Parse(dateGiriş.Text) - DateTime.Parse(dateÇıkış.Text);
            int gun2 = gun.Days;
            txtGün.Text = gun2.ToString();
            txtTutar.Text = (gun2 * int.Parse(txtKiraÜcreti.Text)).ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dateÇıkış.Text = DateTime.Now.ToShortTimeString();
            dateGiriş.Text = DateTime.Now.ToShortTimeString();
            comboKiraŞekli.Text = "";
            txtKiraÜcreti.Text = "";
            txtGün.Text = "";
            txtTutar.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "insert into sözleşme(tc,adsoyad,telefon,ehliyetno,ehliyettarih,ehliyetyer,plaka,marka,seri,yil,renk,kirasekli,kiraucreti,gun,tutar,cikistarih,donustarih) values(@tc,@adsoyad,@telefon,@ehliyetno,@ehliyettarih,@ehliyetyer,@plaka,@marka,@seri,@yil,@renk,@kirasekli,@kiraucreti,@gun,@tutar,@cikistarih,@donustarih)";
            SqlCommand komut2 = new SqlCommand(sorgu2);
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            komut2.Parameters.AddWithValue("@ehliyettarih", txtE_Tarih.Text);
            komut2.Parameters.AddWithValue("@ehliyetyer", txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@cikistarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@donustarih", dateGiriş.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);

            string sorgu3 = "update araç set durumu='DOLU' where plaka= '" + comboAraçlar.Text + "'";
            SqlCommand komut3 = new SqlCommand();
            arac.ekle_sil_guncelle(komut3, sorgu3);
            comboAraçlar.Items.Clear();
            Boş_Araçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("sözleşme eklendi");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string sorgu2 = "update sözleşme set tc=@tc,adsoyad=@adsoyad,telefon=@telefon,ehliyetno=@ehliyetno,ehliyetyer=@ehliyetyer,marka=@marka,seri=@seri,yil=@yil,renk=@renk,kirasekli=@kirasekli,kiraucreti=@kiraucreti,gun=@gun,tutar=@tutar,cikistarih=@cikistarih,donustarih=@donustarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand(sorgu2);
            komut2.Parameters.AddWithValue("@tc", txtTc.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@ehliyetno", txtEhliyetno.Text);
            komut2.Parameters.AddWithValue("@ehliyettarih", txtE_Tarih.Text);
            komut2.Parameters.AddWithValue("@ehliyetyer", txtE_Yer.Text);
            komut2.Parameters.AddWithValue("@plaka", comboAraçlar.Text);
            komut2.Parameters.AddWithValue("@marka", txtMarka.Text);
            komut2.Parameters.AddWithValue("@seri", txtSeri.Text);
            komut2.Parameters.AddWithValue("@yil", txtYil.Text);
            komut2.Parameters.AddWithValue("@renk", txtRenk.Text);
            komut2.Parameters.AddWithValue("@kirasekli", comboKiraŞekli.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(txtKiraÜcreti.Text));
            komut2.Parameters.AddWithValue("@gun", int.Parse(txtGün.Text));
            komut2.Parameters.AddWithValue("@tutar", int.Parse(txtTutar.Text));
            komut2.Parameters.AddWithValue("@cikistarih", dateÇıkış.Text);
            komut2.Parameters.AddWithValue("@donustarih", dateGiriş.Text);
            arac.ekle_sil_guncelle(komut2, sorgu2);

            comboAraçlar.Items.Clear();
            Boş_Araçlar();
            Yenile();
            foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
            comboAraçlar.Text = "";
            Temizle();
            MessageBox.Show("sözleşme güncellendi");
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            if (txtTcAra.Text == "") foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
            string sorgu2 = "select*from müşteri where tc like '" + txtTcAra.Text + "' ";
            arac.TC_Ara(txtTcAra,txtTc, txtAdSoyad, txtTelefon, sorgu2);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTc.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtEhliyetno.Text = satır.Cells[3].Value.ToString();
            txtE_Tarih.Text = satır.Cells[4].Value.ToString();
            txtE_Yer.Text = satır.Cells[5].Value.ToString();
            comboAraçlar.Text = satır.Cells[6].Value.ToString();
            txtMarka.Text = satır.Cells[7].Value.ToString();
            txtSeri.Text = satır.Cells[8].Value.ToString();
            txtYil.Text = satır.Cells[9].Value.ToString();
            txtRenk.Text = satır.Cells[10].Value.ToString();
            comboKiraŞekli.Text = satır.Cells[11].Value.ToString();
            txtKiraÜcreti.Text = satır.Cells[12].Value.ToString();
            txtGün.Text = satır.Cells[13].Value.ToString();
            txtTutar.Text = satır.Cells[14].Value.ToString();
            dateÇıkış.Text = satır.Cells[15].Value.ToString();
            dateGiriş.Text = satır.Cells[16].Value.ToString();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            //Gün farkı hesapla 
            DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime dönüş = DateTime.Parse(satır.Cells["donustarih"].Value.ToString());
            int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
            TimeSpan gunfarkı = bugün - dönüş;
            int _gunfarki = gunfarkı.Days;
            int ucretfarki;
            //Ücret Farkı Hesapla
            ucretfarki = _gunfarki * ucret;
            txtEkstra.Text = ucretfarki.ToString();
            //Toplam Tutar Hesapla
        }

        private void a(object sender, EventArgs e)
        {

        }

        private void txtEkstra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtEkstra.Text)>=0 || int.Parse(txtEkstra.Text) <2)
            {
                DataGridViewRow satır = dataGridView1.CurrentRow;
                DateTime bugün = DateTime.Parse(DateTime.Now.ToShortDateString());
                int ucret = int.Parse(satır.Cells["kiraucreti"].Value.ToString());
                int tutar = int.Parse(satır.Cells["tutar"].Value.ToString());
                DateTime çıkış = DateTime.Parse(satır.Cells["cikistarih"].Value.ToString());
                TimeSpan gun = bugün - çıkış;
                int _gun = gun.Days;
                int toplamtutar = _gun * ucret;
                //Toplamtutar,_guntutar ve ucret satış tablosuna aktarılacak
                string sorgu1 = "delete from sözleşme where plaka='"+satır.Cells["plaka"].Value.ToString()+"'";
                SqlCommand komut = new SqlCommand();
                arac.ekle_sil_guncelle(komut, sorgu1);
                string sorgu2 = "update araç set durumu='BOŞ' where plaka ='"+satır.Cells["plaka"].Value.ToString()+"'";
                SqlCommand komut3 = new SqlCommand();
                arac.ekle_sil_guncelle(komut3, sorgu2);

                string sorgu3 = "insert into satış(tc,adsoyad,plaka,marka,seri,yil,renk,gun,fiyat,tutar,tarih1,tarih2) values(@tc,@adsoyad,@plaka,@marka,@seri,@yil,@renk,@gun,@fiyat,@tutar,@tarih1,@tarih2)";
                SqlCommand komut2 = new SqlCommand(sorgu2);
                komut2.Parameters.AddWithValue("@tc", satır.Cells["tc"].Value.ToString());
                komut2.Parameters.AddWithValue("@adsoyad", satır.Cells["adsoyad"].Value.ToString());
                komut2.Parameters.AddWithValue("@plaka", satır.Cells["plaka"].Value.ToString());
                komut2.Parameters.AddWithValue("@marka", satır.Cells["marka"].Value.ToString());
                komut2.Parameters.AddWithValue("@seri", satır.Cells["seri"].Value.ToString());
                komut2.Parameters.AddWithValue("@yil", satır.Cells["yil"].Value.ToString());
                komut2.Parameters.AddWithValue("@renk", satır.Cells["renk"].Value.ToString());
                komut2.Parameters.AddWithValue("@gun", _gun);
                komut2.Parameters.AddWithValue("@fiyat", ucret );
                komut2.Parameters.AddWithValue("@tutar", toplamtutar);
                komut2.Parameters.AddWithValue("@tarih1", satır.Cells["cikistarih"].Value.ToString());
                komut2.Parameters.AddWithValue("@tarih2", DateTime.Now.ToShortDateString());

                arac.ekle_sil_guncelle(komut2, sorgu3);

                MessageBox.Show("Araç Teslim Edildi");
                comboAraçlar.Text = "";
                comboAraçlar.Items.Clear();
                Boş_Araçlar();
                Yenile();
                foreach (Control item in groupBox1.Controls) if (item is TextBox) item.Text = "";
                foreach (Control item in groupBox2.Controls) if (item is TextBox) item.Text = "";
                comboAraçlar.Text = "";
                Temizle();

                txtEkstra.Text = "";          
            }
            else if (txtEkstra.Text == "")
            {
                MessageBox.Show("Lütfen Seçim Yapınız: ", "Uyarı!");
            }
        }
    }
}
