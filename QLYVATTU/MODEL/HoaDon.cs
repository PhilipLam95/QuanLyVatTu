using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class HoaDon
    {
        public static String SP_DANHSACHPHIEUXUAT = "SP_DANHSACHPHIEUXUAT";
        public static String SP_DS_KHO = "SP_DS_KHO";
        public static String SP_LOAD_CT_KHO = "SP_LOAD_CT_KHO";
        public static String SP_LAYMA_PHIEUXUAT = "SP_LAYMA_PHIEUXUAT";

        public DataTable getHoaDon() // lay hoa don (phieu xuat)
        {
            DataTable hoadon = Access.ExecuteQuery(SP_DANHSACHPHIEUXUAT, null);
            return hoadon;
        }
        //lay danh sach kho day vao combobox
        public DataTable getKho()
        {
            DataTable kho = Access.ExecuteQuery(SP_DS_KHO, null);
            return kho;
        }
        //lay ma ko theo ten kho khi selected, sau khi lay ma kho se lay chi tiet kho co nhung vat tu nao va so luong ton
        public DataTable getChiTietKho(String[] param)
        {
            String[] name = {"@TENKHO"};
            DataTable chiTietKho = Access.ExecuteQuery(SP_LOAD_CT_KHO, name, param, 1);
            return chiTietKho;
        }
        //lay ma hoa don
        public SqlDataReader getMaPX()
        {
            SqlDataReader maHD = Access.ExecSqlDataReader(SP_LAYMA_PHIEUXUAT, null);
            return maHD;
        }
    }
}
