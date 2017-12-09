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
        public static string SP_DS_VATTU_TRONGKHO = "SP_DS_VATTU_TRONGKHO";

        public static string SP_DS_CT_NCC = "SP_DS_CT_NCC";

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

        public DataTable getVatTuTrongKho(string[] param)
        {
            string[] name = { "@MAKHO" , "@MANCC" };
            DataTable vattu = Access.ExecuteQuery(SP_DS_VATTU_TRONGKHO, name, param, 2);
            return vattu;
        }

        public DataTable getVatTuTheoNCC(string[] param)
        {
            string[] name = {  "@MANCC" };
            DataTable vattu = Access.ExecuteQuery(SP_DS_CT_NCC, name, param, 1);
            return vattu;
        }
    }
}
