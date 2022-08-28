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
    public partial class KullaniciListeleme4 : Form
    {
        public SqlCommand sorgu;
        public KullaniciListeleme4()
        {
            InitializeComponent();
        }

        public void Listeleme()
        {

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView2.DataSource = bindingSource;

        }
        public string secim_kullaniciAdi;
        public string secim_Kadi;


        private void btnListe_Click(object sender, EventArgs e)
        {
            if (rbTümListe.Checked == true)
            {

                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select * from tbl_yayinseri ", yeniBaglanti.baglanti);

                Listeleme();

            }

            if (RbSeçilen.Checked == true)
            {
                if (cbKullaniciAdi.Checked == true)
                {
                    secim_kullaniciAdi = "KitapID,";
                }
                else { secim_kullaniciAdi = ""; }

                if (cbKAd.Checked == true)
                {
                    secim_Kadi = "YayinSerisi";
                }
                else { secim_Kadi = ""; }


                VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
                sorgu = new SqlCommand("Select " + secim_kullaniciAdi + secim_Kadi +
                    " From tbl_yayinseri", yeniBaglanti.baglanti);



                Listeleme();


            }

        }

        private void KullaniciListeleme4_Load(object sender, EventArgs e)
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            sorgu = new SqlCommand("Select * from tbl_yayinseri ", yeniBaglanti.baglanti);


            Listeleme();

            cbKullaniciAdi.Enabled = false;
            cbKAd.Enabled = false;

        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

        }

        private void rbTümListe_CheckedChanged(object sender, EventArgs e)
        {
            cbKullaniciAdi.Enabled = false;
            cbKAd.Enabled = false;

        }

        private void RbSeçilen_CheckedChanged(object sender, EventArgs e)
        {
            cbKullaniciAdi.Enabled = true;
            cbKAd.Enabled = true;

        }

        private void btnanamenu_Click(object sender, EventArgs e)
        {
            AnaMenu Giris = new AnaMenu();
            Giris.Show();
            this.Close();
        }
    }
}
