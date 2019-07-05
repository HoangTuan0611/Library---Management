using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_Entity
{
    public class E_PhieuMuonSach
    {        
        private string _masach;
        private string _iddocgia;
        private string _tensach;
        private string _theloai;
        private string _tacgia;
        private string _hoten;
        private string _ngaymuon;


        public string masach 
        {
            get
            {
                return _masach;
            }

            set
            {
                _masach = value;
            }
        }
        public string iddocgia 
        {
            get
            {
                return _iddocgia;
            }

            set
            {
                _iddocgia = value;
            }
        }

        public string tensach 
        {
            get
            {
                return _tensach;
            }

            set
            {
                _tensach = value;
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

        public string tacgia 
        {
            get
            {
                return _tacgia;
            }

            set
            {
                _tacgia = value;
            }
        }
        public string hoten 
        {
            get
            {
                return _hoten;
            }

            set
            {
                _hoten = value;
            }
        }
        public string ngaymuon 
        {
            get
            {
                return _ngaymuon;
            }

            set
            {
                _ngaymuon = value;
            }
        }
    }
}
