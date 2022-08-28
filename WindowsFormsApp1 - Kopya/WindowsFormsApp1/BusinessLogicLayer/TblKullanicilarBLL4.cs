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
    class TblKullanicilarBLL4
    {

        private TblKullanicilarDAO4 _tblKullanicilarDAO4;
        public TblKullanicilarBLL4()
        {
            _tblKullanicilarDAO4 = new TblKullanicilarDAO4();
        }

        public TblKullanicilarPoco4 kaydetKullanici4(string kitapid, string yayinserisi)
        {

            TblKullanicilarPoco4 kullaniciKaydet4 = new TblKullanicilarPoco4();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO4.insertKullanici(kitapid, yayinserisi);
            foreach (DataRow dr in dataTable.Rows)
            {

                dr["KitapID"] = kullaniciKaydet4.kitapID;

                dr["YayinSerisi"] = kullaniciKaydet4.yayinserisi;

            }

            return kullaniciKaydet4;


        }

        public TblKullanicilarPoco4 guncellemeKullanici4(string kitapid, string yayinserisi)
        {
            TblKullanicilarPoco4 kullaniciGuncelle4 = new TblKullanicilarPoco4();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO4.updateKullanici4(kitapid, yayinserisi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["YayinSerisi"] = kullaniciGuncelle4.yayinserisi;

            }
            return kullaniciGuncelle4;





        }

        public TblKullanicilarPoco4 silKullanici(string kitapid)
        {
            TblKullanicilarPoco4 kullaniciSil = new TblKullanicilarPoco4();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO4.deleteKullanici(Convert.ToString(kitapid));

            return kullaniciSil;

        }


    }
}
