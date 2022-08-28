using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using WindowsFormsApp1.dbConn;

namespace WindowsFormsApp1.DataAccessObjectLayer
{
    class TblKullanicilarDAO3
    {
        private VeriTabaniBaglantisi baglanti;

        public TblKullanicilarDAO3()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertKullanici(string kitapid, string yazaryasi)
        {
            string sorgu = string.Format("Insert Into tbl_yas(KitapID,YazarYasi) " +
                "values (@KitapID,@YazarYasi)");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@KitapID", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kitapid);

            sqlParameters[1] = new SqlParameter("@YazarYasi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(yazaryasi);





            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }


        public bool updateKullanici3(string kitapid, string yazaryasi)
        {
            string sorgu = string.Format("Update tbl_yas set YazarYasi = @YazarYasi " +
                "where KitapID = '" + kitapid + "'");


            SqlParameter[] sqlParameters = new SqlParameter[1];


            sqlParameters[0] = new SqlParameter("@YazarYasi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(yazaryasi);


            return baglanti.executeUpdateQuery(sorgu, sqlParameters);


        }

        public bool deleteKullanici(string kitapid)
        {

            string sorgu = string.Format("delete from tbl_yas where KitapID = '" + kitapid + "'");


            return baglanti.executeDeleteQuery(sorgu);

        }



    }
}
