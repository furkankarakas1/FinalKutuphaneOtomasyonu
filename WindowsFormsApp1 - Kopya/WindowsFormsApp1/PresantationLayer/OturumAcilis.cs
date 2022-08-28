using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.PresantationLayer;
using WindowsFormsApp1.BusinessLogicLayer;
using WindowsFormsApp1.PocosLayer;

using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OturumAcilis : Form
    {

        TblKullanicilarBLL _tblKullanicilarBLL;
        public OturumAcilis()
        {
            InitializeComponent();
            _tblKullanicilarBLL = new TblKullanicilarBLL();
        }

        private void OturumAcilis_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            TblKullanicilarPoco _tblKullanicilarPoco = new TblKullanicilarPoco();

            _tblKullanicilarPoco = _tblKullanicilarBLL.getSorgu(textBox1.Text, textBox2.Text);


            if (( _tblKullanicilarPoco.kullaniciAdi == null) || (_tblKullanicilarPoco.sifre == null))
            {
                MessageBox.Show("hatalı giris yaptınız");
            }
            else
            {
                this.Hide();
                MessageBox.Show("hoşgeldiniz : " +  _tblKullanicilarPoco.kullaniciAdi);
                AnaMenu girisEkranı = new AnaMenu();
                girisEkranı.Show();
                

            }



        }
    }
}
