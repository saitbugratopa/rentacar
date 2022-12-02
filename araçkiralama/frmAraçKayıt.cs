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
    public partial class frmAraçKayıt : Form
    {
        Araç_Kiralama arackiralama = new Araç_Kiralama(); 
        public frmAraçKayıt()
        {
            InitializeComponent();
        }

        private void BtnResim_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                else if (markacombo.SelectedIndex == 7 )
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

        private void btnKayıt_Click(object sender, EventArgs e)
        {
            string cümle = "insert into araç(plaka,marka,seri,yil,renk,km,yakit,kiraucreti,resim,tarih,durumu) values(@plaka,@marka,@seri,@yil,@renk,@km,@yakit,@kiraucreti,@resim,@tarih,@durumu)";
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
            komut2.Parameters.AddWithValue("@durumu", "BOŞ");
            arackiralama.ekle_sil_guncelle(komut2, cümle);
            sericombo.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void yilcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ücrettxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Yakitcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Kmtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Renktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sericombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Plakatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
