﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class NhanVien
    {
        public static String SP_LAY_NHANVIEN = "SP_LAY_NHANVIEN";
        public static String SP_TAOTAIKHOAN_NHANVIEN = "SP_TAOTAIKHOAN_NHANVIEN";
        public static String SP_CHUYEN_NV = "SP_CHUYEN_NV";
        public static String SP_KIEMTRA_ROLE = "SP_KIEMTRA_ROLE";
        public static String SP_LOAD_USER = "SP_LOAD_USER";
        public DataTable getNhanVien() // lay nhan vien
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LAY_NHANVIEN, null);
            return nhanvien;
        }

        public DataTable getUser() // lay nhan vien để chuyển chi nhánh
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LOAD_USER, null);
            return nhanvien;
        }

        public int InserCusomer(string[] param)
        {
            string[] name = { "@HO", "@TEN", "@PHAI", "@NGAYSINH", "@DIACHI", "@SDT", "@LGNAME", "@PASS", "@ROLE" };
            int x = Access.ExecuteNonQuery("SP_TAOTAIKHOAN_NHANVIEN", name, param, 9);
            return x;
        }

        //chuyển nhân viên sang chi nhánh khác để làm việc
        public int ChuyenNV(string[] param)
        {
            string[] name = { "@MANV", "@MACN", "@TENLOGIN", "@ROLE" };
            int x = Access.ExecuteNonQuery(SP_CHUYEN_NV, name, param, 4);
            return x;
        }
        //kiem tra role nhan vien co duoc chuyen sang chi nhanh khac hay kg
        //neu role conty thi kg dc chuyen
        public SqlDataReader KiemTraNV(string[] param)
        {
            string[] name = { "@MANV" };
            SqlDataReader role = Access.ExecSqlDataReader(SP_KIEMTRA_ROLE, name, param, 1);
            return role;
        }

        public DataTable getNhanVienTheoCN(string[] param)
        {
            string[] name = { "@MACN" };
            DataTable NV = Access.ExecuteQuery("SP_LAY_NHANVIENTHEOCN", name, param, 1);
            return NV;
        }

    }
}
