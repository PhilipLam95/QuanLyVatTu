using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class VatTu
    {

        public static String SP_DS_VATTU = "SP_DS_VATTU";

        public static String SP_DS_LOAIVT = "SP_DS_LOAIVT";

        public DataTable getVatTu() // lay nhan vien
        {
            DataTable vattu = Access.ExecuteQuery(SP_DS_VATTU, null);
            return vattu;
        }

        public DataTable getLoaiVatTu()
        {
            DataTable loaivattu = Access.ExecuteQuery(SP_DS_LOAIVT, null);
            return loaivattu;
        }
    }
}
