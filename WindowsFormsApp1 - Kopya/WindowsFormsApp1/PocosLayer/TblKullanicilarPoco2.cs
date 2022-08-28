using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.PocosLayer
{
    class TblKullanicilarPoco2
    {
        private string _kitapID { get; set; }

        private string _kitapserisi { get; set; }

          
        public TblKullanicilarPoco2()
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


        public string kitapSerisi
        {
            get
            {
                return _kitapserisi;
            }

            set
            {
                _kitapserisi = value;
            }


        }

    }
}
