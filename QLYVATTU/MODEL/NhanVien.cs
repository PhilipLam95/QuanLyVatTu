using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class NhanVien
    {
        public static String SP_LAY_NHANVIEN = "SP_LAY_NHANVIEN";
        public static String SP_TAOTAIKHOAN_NHANVIEN = "SP_TAOTAIKHOAN_NHANVIEN";
        public DataTable getNhanVien() // lay nhan vien
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LAY_NHANVIEN, null);
            return nhanvien;
        }


        public  int InserCusomer(string[] param)
        {
            string[] name = { "@HO","@TEN", "@PHAI","@NGAYSINH", "@DIACHI", "@SDT","@LGNAME", "@PASS","@ROLE" };
            int x = Access.ExecuteNonQuery("SP_TAOTAIKHOAN_NHANVIEN", name, param, 9);
            return x;
        }

       
    }
}
