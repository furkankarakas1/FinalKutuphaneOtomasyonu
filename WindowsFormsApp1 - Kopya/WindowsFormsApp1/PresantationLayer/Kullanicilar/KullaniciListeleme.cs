using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.dbConn;
using WindowsFormsApp1.PresantationLayer;


namespace WindowsFormsApp1.PresantationLayer.Kullanicilar
{
    public partial class KullaniciListeleme : Form
    {

   
        public SqlCommand sorgu;
        public KullaniciListeleme()
        {
            InitializeComponent();

        }


        public void Listeleme(){



            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView2.DataSource = bindingSource;

            }

        
        public string secim_kullaniciAdi;
        public string secim_Kadi;
        public string secim_yazar;
        public string secim_turu;


        private void btnListe_Click(object sender, EventArgs e)
        {
            if (rbTümListe.Checked == true)
            {

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from tbl_kitaplar ", yeniBaglanti.baglanti);

                Listeleme();

            }

            if (RbSeçilen.Checked == true)
            {
                if (cbKullaniciAdi.Checked == true)
                {
                    secim_kullaniciAdi = "KullaniciAdi,";
                }
                else { secim_kullaniciAdi = ""; }

                if (cbKAd.Checked == true)
                {
                    secim_Kadi = "KitapAdi,";
                }
                else { secim_Kadi = ""; }

                if (cbYazar.Checked == true)
                {
                    secim_yazar = "Yazar,";
                }
                else { secim_yazar = ""; }

                if (cbturu.Checked == true)
                {
                    secim_turu = "KitapTuru";
                }
                else { secim_turu = ""; }

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + secim_kullaniciAdi + secim_Kadi + secim_yazar + secim_turu +
                    " from tbl_kitaplar", yeniBaglanti.baglanti);



                Listeleme();


            }
        }

        private void KullaniciListeleme_Load(object sender, EventArgs e)
        {

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from tbl_kitaplar ", yeniBaglanti.baglanti);


            Listeleme();

            cbKullaniciAdi.Enabled = false;
            cbKAd.Enabled = false;
            cbYazar.Enabled = false;
            cbturu.Enabled = false;

        }


       





        private void btnanamenu_Click(object sender, EventArgs e)
        {
            AnaMenu Giris = new AnaMenu();
            Giris.Show();
            this.Close();

        }

        private void rbTümListe_CheckedChanged(object sender, EventArgs e)
        {
            cbKullaniciAdi.Enabled = false;
            cbKAd.Enabled = false;
            cbYazar.Enabled = false;
            cbturu.Enabled = false;
        }

        private void RbSeçilen_CheckedChanged(object sender, EventArgs e)
        {
            cbKullaniciAdi.Enabled = true;
            cbKAd.Enabled = true;
            cbYazar.Enabled = true;
            cbturu.Enabled = true;
        }


    }
}
