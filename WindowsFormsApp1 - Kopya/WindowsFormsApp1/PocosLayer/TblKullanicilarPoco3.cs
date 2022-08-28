using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.PocosLayer
{
    class TblKullanicilarPoco3
    {
        private string _kitapID { get; set; }

        private string _yazaryasi { get; set; }


        public TblKullanicilarPoco3()
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


        public string yazaryasi
        {
            get
            {
                return _yazaryasi;
            }

            set
            {
                _yazaryasi = value;
            }
        }

    }    

}

