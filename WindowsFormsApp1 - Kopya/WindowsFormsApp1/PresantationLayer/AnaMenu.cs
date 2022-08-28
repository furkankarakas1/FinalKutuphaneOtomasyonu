using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.PresantationLayer.Kullanicilar;

namespace WindowsFormsApp1.PresantationLayer
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void kullanıcıKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYeniKayit yeniKayit = new KullaniciYeniKayit();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleme kullaniciGuncelleme = new KullaniciGuncelleme();
            kullaniciGuncelleme.Show();
            this.Close();
        }

        private void kullaniciSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciKayitSilme kullaniciSil= new KullaniciKayitSilme();
            kullaniciSil.Show();
            this.Close();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciListeleme kullaniciListe = new KullaniciListeleme();
            kullaniciListe.Show();
            this.Close();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kullaniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYeniKayit2 yeniKayit = new KullaniciYeniKayit2();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciGüncelle2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleme2 yeniKayit = new KullaniciGuncelleme2();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KullaniciKayitSilme2 kullaniciSil = new KullaniciKayitSilme2();
            kullaniciSil.Show();
            this.Close();


        }

        private void kullaniciListele2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciListeleme2 kullaniciListe = new KullaniciListeleme2();
            kullaniciListe.Show();
            this.Close();
        }

        private void kullaniciKayit3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYeniKayit3 yeniKayit = new KullaniciYeniKayit3();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciGuncelle3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleme3 yeniKayit = new KullaniciGuncelleme3();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciSilToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KullaniciKayitSilme3 yeniKayit = new KullaniciKayitSilme3();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciListele3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciListeleme3 yeniKayit = new KullaniciListeleme3();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciKayit4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYeniKayit4 yeniKayit = new KullaniciYeniKayit4();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciGuncelle4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciGuncelleme4 yeniKayit = new KullaniciGuncelleme4();
            yeniKayit.Show();
            this.Close();

        }

        private void kullaniciSil4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciKayitSilme4 yeniKayit = new KullaniciKayitSilme4();
            yeniKayit.Show();
            this.Close();
        }

        private void kullaniciListele4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciListeleme4 yeniKayit = new KullaniciListeleme4();
            yeniKayit.Show();
            this.Close();
        }
    }

    
}
