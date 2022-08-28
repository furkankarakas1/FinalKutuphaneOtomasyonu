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
    public partial class KullaniciGuncelleme4 : Form
    {
        private TblKullanicilarBLL4 _tblKullanicilarBLL4;
        public KullaniciGuncelleme4()
        {
            InitializeComponent();
            _tblKullanicilarBLL4 = new TblKullanicilarBLL4();
        }
       
        public void Listele()
        {
            VeriTabaniBaglantisi yeniBaglanti = new VeriTabaniBaglantisi();
            SqlCommand sorgu = new SqlCommand("Select * from tbl_yayinseri ", yeniBaglanti.baglanti);

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;


        }

        private void btngunelle_Click(object sender, EventArgs e)
        {
            TblKullanicilarPoco4 kullanicilar = new TblKullanicilarPoco4();
            kullanicilar = _tblKullanicilarBLL4.guncellemeKullanici4(txtid2.Text, txtyasi.Text);

            MessageBox.Show("Güncelleme işlemi tamamlandı");
            Listele();

        }

        private void KullaniciGuncelleme4_Load(object sender, EventArgs e)
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
