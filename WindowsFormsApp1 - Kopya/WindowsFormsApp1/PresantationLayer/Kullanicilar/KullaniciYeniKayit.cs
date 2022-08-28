using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.PresantationLayer;
using WindowsFormsApp1.BusinessLogicLayer;
using WindowsFormsApp1.dbConn;
using System.Data.SqlClient;
using WindowsFormsApp1.PocosLayer;


namespace WindowsFormsApp1.PresantationLayer.Kullanicilar
{


    public partial class KullaniciYeniKayit : Form
    {

        private TblKullanicilarBLL _tblKullanicilarBLL;

        public KullaniciYeniKayit()
        {
            InitializeComponent();
            _tblKullanicilarBLL = new TblKullanicilarBLL();
        }


        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            SqlCommand sorgu = new SqlCommand("Select * from tbl_kitaplar ",yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;


        }


        private void btnanamenu_Click(object sender, EventArgs e)
        {
            AnaMenu girisEkranı = new AnaMenu();
            girisEkranı.Show();
            this.Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco kullanicilar = new TblKullanicilarPoco();
            kullanicilar = _tblKullanicilarBLL.kaydetKullanici(txtid.Text ,txtKitapadi.Text , txtkullaniciAdi.Text, txtsifre.Text,
               txtyazar.Text , txtTuru.Text, txtYayinEvi.Text);

            MessageBox.Show("Kaydiniz tamamlanmıştır..");  
            Listele();

        }

        private void KullaniciYeniKayit_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapadi.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtkullaniciAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtsifre.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtyazar.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtTuru.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtYayinEvi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
