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
    class TblKullanicilarDAO
    {

        private VeriTabaniBaglantisi baglanti;

        public TblKullanicilarDAO()
        {
            baglanti = new VeriTabaniBaglantisi();

        }

        public DataTable searchKullaniciAdiveSifre(string kullaniciAdi, string sifre)
        {

            string sorgu = string.Format("Select * from tbl_kitaplar where KullaniciAdi = @KullaniciAdi and Sifre = @Sifre");

            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kullaniciAdi);

            sqlParameters[1] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(sifre);

            return baglanti.executeSelectQuery(sorgu, sqlParameters);

        }


        public bool insertKullanici(string kitapid, string kitapadi, string kullaniciadi, string sifre,
            string yazar_, string kitapturu_, string yayinEvi_)
        {
            string sorgu = string.Format("insert into tbl_kitaplar(KitapID,KitapAdi,KullaniciAdi,Sifre,Yazar,KitapTuru,YayinEvi)" +
                " values(@KitapID,@KitapAdi,@KullaniciAdi,@Sifre,@Yazar,@KitapTuru,@YayinEvi)");

            SqlParameter[] sqlParameters = new SqlParameter[7];

            sqlParameters[0] = new SqlParameter("@KitapID", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kitapid);

            sqlParameters[1] = new SqlParameter("@KitapAdi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kitapadi);

            sqlParameters[2] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(kullaniciadi);

            sqlParameters[3] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(sifre);

            sqlParameters[4] = new SqlParameter("@Yazar", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(yazar_);

            sqlParameters[5] = new SqlParameter("@KitapTuru", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(kitapturu_);

            sqlParameters[6] = new SqlParameter("@YayinEvi", SqlDbType.NVarChar);
            sqlParameters[6].Value = Convert.ToString(yayinEvi_);



            return baglanti.executeInsertQuery(sorgu, sqlParameters);
        }


        public bool updateKullanici(string kitapid, string kitapadi, string kullaniciadi, string sifre,
            string yazar_, string kitapturu_, string yayinEvi_)
        {
            string sorgu = string.Format("Update tbl_kitaplar set KitapAdi = @KitapAdi , KullaniciAdi = @KullaniciAdi , Sifre = @Sifre , Yazar = @Yazar," + 
                "KitapTuru = @KitapTuru , YayinEvi = @YayinEvi where kitapID = '" + kitapid + "'");


            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@KitapAdi", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(kitapadi);

            sqlParameters[1] = new SqlParameter("@KullaniciAdi", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(kullaniciadi);

            sqlParameters[2] = new SqlParameter("@Sifre", SqlDbType.NVarChar);
            sqlParameters[2].Value = Convert.ToString(sifre);

            sqlParameters[3] = new SqlParameter("@Yazar", SqlDbType.NVarChar);
            sqlParameters[3].Value = Convert.ToString(yazar_);

            sqlParameters[4] = new SqlParameter("@KitapTuru", SqlDbType.NVarChar);
            sqlParameters[4].Value = Convert.ToString(kitapturu_);

            sqlParameters[5] = new SqlParameter("@YayinEvi", SqlDbType.NVarChar);
            sqlParameters[5].Value = Convert.ToString(yayinEvi_);

            return baglanti.executeUpdateQuery(sorgu, sqlParameters);


        }

        public bool deleteKullanici(string kitapid)
        {

            string sorgu = string.Format("delete from tbl_kitaplar where KitapID = '" + kitapid + "'");


            return baglanti.executeDeleteQuery(sorgu);

        }

    }
}
 