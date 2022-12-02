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
    public partial class frmSatış : Form
    {
        public frmSatış()
        {
            InitializeComponent();
        }
        Araç_Kiralama arac = new Araç_Kiralama();
        private void frmSatış_Load(object sender, EventArgs e)
        {
            string sorgu2 = "select *from satış";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = arac.listele(adtr2,sorgu2);
            arac.satışhesapla(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cümle = "delete from satış";
            SqlCommand komut2 = new SqlCommand();
            arac.ekle_sil_guncelle(komut2, cümle);

        }
    }
}
