using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLYVATTU.MODEL
{
    class DonDH
    {

        public static string SP_DS_DONDATHANG = "SP_DS_DONDATHANG";
        public static string SP_LAYMADONDATHANG_TUDONG = "SP_LAYMADONDATHANG_TUDONG";

        public DataTable getDonDatHang()
        {
            DataTable dondh = Access.ExecuteQuery(SP_DS_DONDATHANG, null);
            return dondh;
        }

        public SqlDataReader getMaDDH()
        {

            SqlDataReader maddh = Access.ExecSqlDataReader(SP_LAYMADONDATHANG_TUDONG,null);
            return maddh;
        }
    }
}
