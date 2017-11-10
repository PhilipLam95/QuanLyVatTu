using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class KhachHang
    {
        public static String SP_TIMKIEM_KHACHHANG = "SP_TIMKIEM_KHACHHANG";
        public DataTable getKhachHang() // lay nhan vien
        {
            DataTable khachhang = Access.ExecuteQuery(SP_TIMKIEM_KHACHHANG, null);
            return khachhang;
        }
    }
}
