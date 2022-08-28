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
    public partial class KullaniciKayitSilme : Form
    {

        private TblKullanicilarBLL _tblKullanicilarBLL;
        public KullaniciKayitSilme()
        {
            InitializeComponent();
            _tblKullanicilarBLL = new TblKullanicilarBLL();

        }


        public void Listele()
        {

            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            SqlCommand sorgu = new SqlCommand("Select * from tbl_kitaplar ", yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView2.DataSource = bindingSource;

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco kullaniciSil = new TblKullanicilarPoco();
            kullaniciSil = _tblKullanicilarBLL.silKullanici(txtid.Text);
            MessageBox.Show("silme islemi okeylendi");
            Listele();

        }

        private void KullaniciKayitSilme_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txtKitapadi.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtkullaniciAdi.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtsifre.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtyazar.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtTuru.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtYayinEvi.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnanamenu_Click(object sender, EventArgs e)
        {
            AnaMenu girisEkranı = new AnaMenu();
            girisEkranı.Show();
            this.Close();
        }
    }
}
