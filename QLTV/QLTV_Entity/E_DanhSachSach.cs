using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_Entity
{
    public class E_DanhSachSach
    {
       
        private string _masach;
        private string _tensach;
        private string _theloai;
        private string _tacgia;
        private string _tinhtrang;
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
        public string tinhtrang 
        {
            get
            {
                return _tinhtrang;
            }

            set
            {
                _tinhtrang = value;
            }
        }
    }
}
