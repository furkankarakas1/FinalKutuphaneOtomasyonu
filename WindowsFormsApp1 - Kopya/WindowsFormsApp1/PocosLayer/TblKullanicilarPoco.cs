using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.PocosLayer
{
    class TblKullanicilarPoco
    {

        private string _kitapID { get; set; }

        private string _kitapAdi { get; set; }

        private string _kullaniciAdi { get; set; }

        private string _sifre{ get; set; }

        private string _yazar { get; set; }

        private string _kitapTuru { get; set; }

        private string _yayinEvi { get; set; }

        public TblKullanicilarPoco()
        {

        }

        public string kitapID
        {
            get
            {
                return _kitapID;
            }

            set
            {
                _kitapID = value;
            }


        }


        public string kitapAdi
        {
            get
            {
                return _kitapAdi;
            }

            set
            {
                _kitapAdi = value;
            }


        }

        public string kullaniciAdi
        {
            get
            {
                return _kullaniciAdi;
            }

            set
            {
                _kullaniciAdi = value;
            }


        }

        public string sifre
        {
            get
            {
                return _sifre;
            }

            set
            {
                _sifre = value;
            }


        }


        public string yazar
        {
            get
            {
                return _yazar;
            }

            set
            {
                _yazar = value;
            }


        }


        public string kitapTuru
        {
            get
            {
                return _kitapTuru;
            }

            set
            {
                _kitapTuru = value;
            }


        }



        public string yayinEvi
        {
            get
            {
                return _yayinEvi;
            }

            set
            {
                _yayinEvi = value;
            }


        }

    }
}
