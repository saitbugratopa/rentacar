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
    public partial class frmAraçListele : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama();
        public frmAraçListele()
        {
            InitializeComponent();
        }

        private void Plakatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            Plakatxt.Text = satır.Cells["plaka"].Value.ToString();
            markacombo.Text = satır.Cells["marka"].Value.ToString();
            sericombo.Text = satır.Cells["seri"].Value.ToString();
            yilcombo.Text = satır.Cells["yil"].Value.ToString();
            Renktxt.Text = satır.Cells["renk"].Value.ToString();
            Kmtxt.Text = satır.Cells["km"].Value.ToString();
            Yakitcombo.Text = satır.Cells["yakit"].Value.ToString();
            Ücrettxt.Text = satır.Cells["kiraucreti"].Value.ToString();
            pictureBox1.ImageLocation = satır.Cells["resim"].Value.ToString();
           
        }

        private void frmAraçListele_Load(object sender, EventArgs e)
        {
            YenileAraçlarListesi();
            try
            {
                comboAraçlar.SelectedIndex = 0;
            }
            catch 
            {
                ;
            }
        }

        private void YenileAraçlarListesi()
        {
            string cümle = "select *from araç";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void BtnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update araç set marka=@marka,seri=@seri,yil=@yil,renk=@renk,km=@km,yakit=@yakit,kiraucreti=@kiraucreti,resim=@resim,tarih=@tarih where plaka=@plaka";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@plaka", Plakatxt.Text);
            komut2.Parameters.AddWithValue("@marka", markacombo.Text);
            komut2.Parameters.AddWithValue("@seri", sericombo.Text);
            komut2.Parameters.AddWithValue("@yil", yilcombo.Text);
            komut2.Parameters.AddWithValue("@renk", Renktxt.Text);
            komut2.Parameters.AddWithValue("@km", Kmtxt.Text);
            komut2.Parameters.AddWithValue("@yakit", Yakitcombo.Text);
            komut2.Parameters.AddWithValue("@kiraucreti", int.Parse(Ücrettxt.Text));
            komut2.Parameters.AddWithValue("@resim", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
            YenileAraçlarListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from araç where plaka='" + satır.Cells["plaka"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            YenileAraçlarListesi();
            pictureBox1.ImageLocation = "";
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
        }

        private void yilcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sericombo.Items.Clear();
                if (markacombo.SelectedIndex == 0)
                {
                    sericombo.Items.Add("3 Serisi");
                    sericombo.Items.Add("5 Serisi");
                    sericombo.Items.Add("7 Serisi");
                }
                else if (markacombo.SelectedIndex == 1)
                {
                    sericombo.Items.Add("Doblo");
                    sericombo.Items.Add("Egea");
                    sericombo.Items.Add("Fiorino");
                    sericombo.Items.Add("Linea");
                    sericombo.Items.Add("Punto");

                }
                else if (markacombo.SelectedIndex == 2)
                {
                    sericombo.Items.Add("Range Rover Evoque");
                    sericombo.Items.Add("Range Rover Sports");
                    sericombo.Items.Add("Range Rover Vogue");

                }
                else if (markacombo.SelectedIndex == 3)
                {
                    sericombo.Items.Add("A Serisi");
                    sericombo.Items.Add("C Serisi");
                    sericombo.Items.Add("E Serisi");
                    sericombo.Items.Add("S Serisi");

                }
                else if (markacombo.SelectedIndex == 4)
                {
                    sericombo.Items.Add("Astra");
                    sericombo.Items.Add("Combo");
                    sericombo.Items.Add("Corsa");
                    sericombo.Items.Add("Grandland X");
                    sericombo.Items.Add("İnsignia");

                }
                else if (markacombo.SelectedIndex == 5)
                {
                    sericombo.Items.Add("Clio");
                    sericombo.Items.Add("Captur");
                    sericombo.Items.Add("Megane");
                    sericombo.Items.Add("Symbol");
                    sericombo.Items.Add("Talisman");

                }
                else if (markacombo.SelectedIndex == 6)
                {
                    sericombo.Items.Add("Auris");
                    sericombo.Items.Add("Corolla");
                    sericombo.Items.Add("Hilux");
                    sericombo.Items.Add("Rav4");

                }
                else if (markacombo.SelectedIndex == 7)
                {
                    sericombo.Items.Add("Amarok");
                    sericombo.Items.Add("Caddy");
                    sericombo.Items.Add("Golf");
                    sericombo.Items.Add("Jetta");
                    sericombo.Items.Add("Passat");
                    sericombo.Items.Add("Touareg");

                }
            }
            catch
            {

                ;
            }
        }

        private void comboAraçlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboAraçlar.SelectedIndex==0)
                {
                    YenileAraçlarListesi();
                }
                if (comboAraçlar.SelectedIndex == 1)
                {
                    string cümle = "select *from araç where durumu='BOŞ'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }
                if (comboAraçlar.SelectedIndex == 2)
                {
                    string cümle = "select *from araç where durumu='DOLU'";
                    SqlDataAdapter adtr2 = new SqlDataAdapter();
                    dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
                }

            }
            catch 
            {
                ;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
