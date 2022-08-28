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
    public partial class KullaniciYeniKayit3 : Form
    {

        private TblKullanicilarBLL3 _tblKullanicilarBLL3;
        public KullaniciYeniKayit3()
        {
            InitializeComponent();
            _tblKullanicilarBLL3 = new TblKullanicilarBLL3();
        }

        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            SqlCommand sorgu = new SqlCommand("Select * from tbl_yas ", yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco3 kullanicilar = new TblKullanicilarPoco3();
            kullanicilar = _tblKullanicilarBLL3.kaydetKullanici3(txtid.Text, txtyas.Text);

            MessageBox.Show("Kaydiniz tamamlanmıştır..");
            Listele();
        }

        private void KullaniciYeniKayi3_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtyas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
