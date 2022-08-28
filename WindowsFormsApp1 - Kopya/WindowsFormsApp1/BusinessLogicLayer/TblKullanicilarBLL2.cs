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
    class TblKullanicilarBLL2
    {
        private TblKullanicilarDAO2 _tblKullanicilarDAO2;

        public TblKullanicilarBLL2()
        {
            _tblKullanicilarDAO2 = new TblKullanicilarDAO2();
        }

        public TblKullanicilarPoco2 kaydetKullanici2(string kitapid, string kitapserisi)
        {

            TblKullanicilarPoco2 kullaniciKaydet2 = new TblKullanicilarPoco2();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO2.insertKullanici(kitapid, kitapserisi);
            foreach (DataRow dr in dataTable.Rows)
            {

                dr["kitapid"] = kullaniciKaydet2.kitapID;

                dr["kitapserisi"] = kullaniciKaydet2.kitapSerisi;

            }

            return kullaniciKaydet2;
        }
        public TblKullanicilarPoco2 guncellemeKullanici2(string kitapid, string kitapserisi)
        {
            TblKullanicilarPoco2 kullaniciGuncelle2 = new TblKullanicilarPoco2();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO2.updateKullanici2(kitapid, kitapserisi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["KitapSerisi"] = kullaniciGuncelle2.kitapSerisi;

            }
            return kullaniciGuncelle2;

        }

        public TblKullanicilarPoco2 silKullanici(string kitapid)
        {
            TblKullanicilarPoco2 kullaniciSil = new TblKullanicilarPoco2();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO2.deleteKullanici(Convert.ToString(kitapid));

            return kullaniciSil;

        }


    }
}
