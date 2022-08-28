using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccessObjectLayer;
using WindowsFormsApp1.PocosLayer;
using System.Data;


namespace WindowsFormsApp1.BusinessLogicLayer
{
    class TblKullanicilarBLL
    {

        private TblKullanicilarDAO _tblKullanicilarDAO;
        public TblKullanicilarBLL()
        {
            _tblKullanicilarDAO = new TblKullanicilarDAO();
        }

        public TblKullanicilarPoco getSorgu(string kullaniciAdi, string sifre)
        {
            TblKullanicilarPoco kullaniciGirisi = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            dataTable = _tblKullanicilarDAO.searchKullaniciAdiveSifre(kullaniciAdi , sifre);

            foreach (DataRow dr in dataTable.Rows)
            {
                kullaniciGirisi.kullaniciAdi = dr["kullaniciAdi"].ToString();
                kullaniciGirisi.sifre = dr["sifre"].ToString();
            }

            return kullaniciGirisi;
        }

        public TblKullanicilarPoco kaydetKullanici(string kitapid, string kitapadi, string kullaniciadi, string sifre,
            string yazar_, string kitapturu_, string yayinEvi_)
        {
        
            TblKullanicilarPoco kullaniciKaydet = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO.insertKullanici(kitapid, kitapadi, kullaniciadi, sifre, yazar_, kitapturu_, yayinEvi_);
                foreach(DataRow dr in dataTable.Rows)
            {

                dr["kitapid"] = kullaniciKaydet.kitapID;

                dr["kitapadi"] = kullaniciKaydet.kitapAdi;

                dr["kullaniciadi"] = kullaniciKaydet.kullaniciAdi;

                dr["sifre"] = kullaniciKaydet.sifre;

                dr["yazar_"] = kullaniciKaydet.yazar;

                dr["kitapturu_"] = kullaniciKaydet.kitapTuru;

                dr["yayinEvi_"] = kullaniciKaydet.yayinEvi;

            }

            return kullaniciKaydet;
        }
        

        public TblKullanicilarPoco guncellemeKullanici(string kitapid, string kitapadi, string kullaniciadi, string sifre,
            string yazar_, string kitapturu_, string yayinEvi_)
        {
            TblKullanicilarPoco kullaniciGuncelle = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO.updateKullanici(kitapid,kitapadi, kullaniciadi, sifre, yazar_, kitapturu_, yayinEvi_);

            foreach ( DataRow dr in dataTable.Rows)
            {
                dr["KitapAdi"] = kullaniciGuncelle.kitapAdi;

                dr["KullaniciAdi"] = kullaniciGuncelle.kullaniciAdi;

                dr["Sifre"] = kullaniciGuncelle.sifre;

                dr["Yazar"] = kullaniciGuncelle.yazar;

                dr["kitapTuru"] = kullaniciGuncelle.kitapTuru;

                dr["YayinEvi"] = kullaniciGuncelle.yayinEvi;

                 }
            return kullaniciGuncelle;

        }

        public TblKullanicilarPoco silKullanici(string kitapid)
        {
            TblKullanicilarPoco kullaniciSil = new TblKullanicilarPoco();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO.deleteKullanici(Convert.ToString(kitapid));

            return kullaniciSil;

        }
    }
}
