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
        public DataTable getNhanVien() // lay nhan vien
        {
            DataTable nhanvien = Access.execDataTableSP(SP_LAY_NHANVIEN, null);
            return nhanvien;
        }
    }
}
