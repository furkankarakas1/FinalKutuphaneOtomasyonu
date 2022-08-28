using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1.PocosLayer
{
    class TblKullanicilarPoco4
    {

        private string _kitapID { get; set; }

        private string _yayinserisi { get; set; }


        public TblKullanicilarPoco4()
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


        public string yayinserisi
        {
            get
            {
                return _yayinserisi;
            }

            set
            {
                _yayinserisi = value;
            }
        }

    }
}
