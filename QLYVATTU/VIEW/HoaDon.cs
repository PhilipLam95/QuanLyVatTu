using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class HoaDon
    {
        public static String SP_DANHSACHPHIEUXUAT = "SP_DANHSACHPHIEUXUAT";

        public DataTable getHoaDon() // lay nhan vien
        {
            DataTable hoadon = Access.ExecuteQuery(SP_DANHSACHPHIEUXUAT, null);
            return hoadon;
        }

    }
}
