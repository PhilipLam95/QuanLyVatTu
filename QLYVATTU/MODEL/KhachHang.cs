using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class KhachHang
    {
        public static String SP_TIMKIEM_KHACHHANG = "SP_TIMKIEM_KHACHHANG";

        public static String SP_DS_KHACHHANG = "SP_DS_KHACHHANG";

        public DataTable getKhachHang()
        {
            DataTable khachhang = Access.ExecuteQuery(SP_DS_KHACHHANG, null);
            return khachhang;
        }
        public DataTable getTimKhachHang(String[] param)
        {
            String[] name = { "@TUKHOA" };
            DataTable khachhang = Access.ExecuteQuery(SP_TIMKIEM_KHACHHANG, name, param, 1);
            return khachhang;
        }
    }
}
