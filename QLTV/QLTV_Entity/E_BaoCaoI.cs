using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_Entity
{
    public class E_BaoCaoI
    {
        private string _thang;
        private string _theloai;
        private string _soluotmuon;
        private string _tile;

        public string thang 
        {
            get
            {
                return _thang;
            }

            set
            {
                _thang = value;
            }
        }



        public string theloai 
        {
            get
            {
                return _theloai;
            }

            set
            {
                _theloai = value;
            }
        }

        public string soluotmuon 
        {
            get
            {
                return _soluotmuon;
            }

            set
            {
                _soluotmuon = value;
            }
        }

        public string tile 
        {
            get
            {
                return _tile;
            }

            set
            {
                _tile = value;
            }
        }
    }
}
