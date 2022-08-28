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
    public partial class KullaniciYeniKayit2 : Form
    {
        private TblKullanicilarBLL2 _tblKullanicilarBLL2;

        public KullaniciYeniKayit2()
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

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco2 kullanicilar = new TblKullanicilarPoco2();
            kullanicilar = _tblKullanicilarBLL2.kaydetKullanici2(txtid.Text, txtKitapadi.Text);

            MessageBox.Show("Kaydiniz tamamlanmıştır..");
            Listele();
        }

        private void KullaniciYeniKayit2_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtKitapadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
         
        }
    }
}
