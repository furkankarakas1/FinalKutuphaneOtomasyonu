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
    

    class TblKullanicilarDAO4
    {
        private VeriTabaniBaglantisi baglanti;
        public TblKullanicilarDAO4()
        {
            baglanti = new VeriTabaniBaglantisi();
        }


        public bool insertKullanici(string kitapid, string yayinserisi)
        {
            string sorgu = string.Format("Insert Into tbl_yayinseri(KitapID,YayinSerisi) " +
                "values (@KitapID,@YayinSerisi)");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@KitapID", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kitapid);

            sqlParameters[1] = new SqlParameter("@YayinSerisi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(yayinserisi);





            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateKullanici4(string kitapid, string yayinseri)
        {
            string sorgu = string.Format("Update tbl_yayinseri set YayinSerisi = @YayinSerisi " +
                "where KitapID = '" + kitapid + "'");


            SqlParameter[] sqlParameters = new SqlParameter[1];


            sqlParameters[0] = new SqlParameter("@YayinSerisi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(yayinseri);


            return baglanti.executeUpdateQuery(sorgu, sqlParameters);


        }

        public bool deleteKullanici(string kitapid)
        {

            string sorgu = string.Format("delete from tbl_yayinseri where KitapID = '" + kitapid + "'");


            return baglanti.executeDeleteQuery(sorgu);

        }

    }
}
