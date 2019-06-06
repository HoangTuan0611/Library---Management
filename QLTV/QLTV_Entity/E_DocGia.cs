using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTV_Entity
{
    public class E_DocGia
    {
        private string _iddocgia;
        private string _hoten;
        private string _loaidocgia;
        private string _ngaysinh;
        private string _diachi;
        private string _email;
        private string _ngaylapthe;

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

        public string loaidocgia
        {
            get
            {
                return _loaidocgia;
            }

            set
            {
                _loaidocgia = value;
            }
        }

        public string ngaysinh 
        {
            get
            {
                return _ngaysinh;
            }

            set
            {
                _ngaysinh = value;
            }
        }

        public string diachi 
        {
            get
            {
                return _diachi;
            }

            set
            {
                _diachi = value;
            }
        }
        public string email 
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }
        public string ngaylapthe 
        {
            get
            {
                return _ngaylapthe;
            }

            set
            {
                _ngaylapthe = value;
            }
        }
    }
}
