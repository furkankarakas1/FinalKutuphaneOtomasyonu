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


    class TblKullanicilarBLL3

    {

        private TblKullanicilarDAO3 _tblKullanicilarDAO3;

        public TblKullanicilarBLL3()
        {
            _tblKullanicilarDAO3 = new TblKullanicilarDAO3();
        }


        public TblKullanicilarPoco3 kaydetKullanici3(string kitapid, string yazaryasi)
        {

            TblKullanicilarPoco3 kullaniciKaydet3 = new TblKullanicilarPoco3();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO3.insertKullanici(kitapid, yazaryasi);
            foreach (DataRow dr in dataTable.Rows)
            {

                dr["KitapID"] = kullaniciKaydet3.kitapID;

                dr["YazarYasi"] = kullaniciKaydet3.yazaryasi;

            }

            return kullaniciKaydet3;


        }


        public TblKullanicilarPoco3 guncellemeKullanici3(string kitapid, string yasi)
        {
            TblKullanicilarPoco3 kullaniciGuncelle3 = new TblKullanicilarPoco3();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO3.updateKullanici3(kitapid, yasi);

            foreach (DataRow dr in dataTable.Rows)
            {
                dr["YazarYasi"] = kullaniciGuncelle3.yazaryasi;

            }
            return kullaniciGuncelle3;

        }

        public TblKullanicilarPoco3 silKullanici(string kitapid)
        {
            TblKullanicilarPoco3 kullaniciSil = new TblKullanicilarPoco3();
            DataTable dataTable = new DataTable();

            _tblKullanicilarDAO3.deleteKullanici(Convert.ToString(kitapid));

            return kullaniciSil;

        }


    }
}