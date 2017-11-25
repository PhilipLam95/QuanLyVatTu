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
        public static String SP_DSVT_PHIEUXUAT = "SP_DSVT_PHIEUXUAT";
        public DataTable getVatTu() 
        {
            DataTable hoadon = Access.ExecuteQuery(SP_DSVT_PHIEUXUAT, null);
            return hoadon;
        }
    }
}
