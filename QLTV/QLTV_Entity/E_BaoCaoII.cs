using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_Entity
{
    public class E_BaoCaoII
    {
        private string _ngay;
        private string _stt;
        private string _masach;
        private string _tensach;
        private string _ngaymuon;
        private string _songaytratre;

        public string ngay 
        {
            get
            {
                return _ngay;
            }

            set
            {
                _ngay = value;
            }
        }

        public string stt 
        {
            get
            {
                return _stt;
            }

            set
            {
                _stt = value;
            }
        }
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

        public string songaytratre 
        {
            get
            {
                return _songaytratre;
            }

            set
            {
                _songaytratre = value;
            }
        }
    }
}
