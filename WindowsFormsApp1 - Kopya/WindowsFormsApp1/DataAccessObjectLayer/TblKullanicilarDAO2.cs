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

    
    class TblKullanicilarDAO2
    {
        private VeriTabaniBaglantisi baglanti;

        public TblKullanicilarDAO2()
        {
            baglanti = new VeriTabaniBaglantisi();
        }

        public bool insertKullanici(string kitapid, string kitapserisi)
        {
            string sorgu = string.Format("Insert Into tbl_seri(KitapID,KitapSerisi) " +
                "values (@KitapID,@KitapSerisi)");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@KitapID", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kitapid);

            sqlParameters[1] = new SqlParameter("@KitapSerisi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kitapserisi);

 



            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }

        public bool updateKullanici2(string kitapid, string kitapserisi)
        {
            string sorgu = string.Format("Update tbl_seri set KitapSerisi = @KitapSerisi " +
                "where KitapID = '" + kitapid + "'");


            SqlParameter[] sqlParameters = new SqlParameter[1];


            sqlParameters[0] = new SqlParameter("@KitapSerisi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kitapserisi);


            return baglanti.executeUpdateQuery(sorgu, sqlParameters);


        }

        public bool deleteKullanici(string kitapid)
        {

            string sorgu = string.Format("delete from tbl_seri where KitapID = '" + kitapid + "'");


            return baglanti.executeDeleteQuery(sorgu);

        }



    }
}
