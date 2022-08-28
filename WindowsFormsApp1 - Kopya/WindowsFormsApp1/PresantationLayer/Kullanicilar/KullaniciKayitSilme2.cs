using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLogicLayer;
using WindowsFormsApp1.dbConn;
using System.Data.SqlClient;
using WindowsFormsApp1.PocosLayer;
namespace WindowsFormsApp1.PresantationLayer.Kullanicilar
{
    public partial class KullaniciKayitSilme2 : Form
    {

        private TblKullanicilarBLL2 _tblKullanicilarBLL2;
        public KullaniciKayitSilme2()
        {
            InitializeComponent();
            _tblKullanicilarBLL2 = new TblKullanicilarBLL2();
        }

        public void Listele()
        {

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            SqlCommand sorgu = new SqlCommand("Select * from tbl_seri ", yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco2 kullaniciSil = new TblKullanicilarPoco2();
            kullaniciSil = _tblKullanicilarBLL2.silKullanici( txtid2.Text);

            MessageBox.Show("silme islemi okeylendi");
            Listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtid2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapseri.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void KullaniciKayitSilme2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnanamenu_Click(object sender, EventArgs e)
        {
            AnaMenu Giris = new AnaMenu();
            Giris.Show();
            this.Close();

        }
    }
}
