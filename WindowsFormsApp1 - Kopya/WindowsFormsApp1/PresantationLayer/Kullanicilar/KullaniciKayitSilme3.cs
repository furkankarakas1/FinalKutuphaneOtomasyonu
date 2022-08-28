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
    public partial class KullaniciKayitSilme3 : Form
    {
        private TblKullanicilarBLL3 _tblKullanicilarBLL3;
        public KullaniciKayitSilme3()
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

        private void btnSil_Click(object sender, EventArgs e)
        {

            TblKullanicilarPoco3 kullaniciSil = new TblKullanicilarPoco3();
            kullaniciSil = _tblKullanicilarBLL3.silKullanici(txtid2.Text);

            MessageBox.Show("silme islemi okeylendi");
            Listele();

        }

      

        private void KullaniciKayitSilme3_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtid2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtyasi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnanamenu_Click(object sender, EventArgs e)
        {
            AnaMenu Giris = new AnaMenu();
            Giris.Show();
            this.Close();
        }
    }
}
