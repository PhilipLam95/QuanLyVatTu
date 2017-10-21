using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLYVATTU.MODEL
{
    class Access
    {
    	public static String DATA_SOURCE = @"DELL-A75\SERVER1";//địa chỉ cơ sở dữ liệu
        public static String INITIAL_CATALOG = "QLVT";//tên cơ sở dữ liệu
        public static String CONNECTION_STRING;// 
        public static String USERNAME = "sa";//tài khoản
        public static String PASSWORD = "123";//mật khẩu



        public static SqlConnection con;
        public static bool Open()
        {
     
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            try
            {
              
                con = new SqlConnection();
                CONNECTION_STRING = "Data Source=" + DATA_SOURCE + "; "
                        + "Initial Catalog=" + INITIAL_CATALOG + ";"
                        + "Persist Security Info=True" + ";" 
                        + "User ID =" + USERNAME + ";"
                        + "password =" + PASSWORD +";";
                con.ConnectionString = CONNECTION_STRING;
                con.Open();
                MessageBox.Show(CONNECTION_STRING);


                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERR---------" + e.ToString());
                return false;
            }
        }


         //thực thi sp ép về dạng reader
        public static SqlDataReader execSP(String sp, SqlParameter[] param)
        {
            SqlDataReader sdr;
            try
            {
                SqlConnection myCon = new SqlConnection();//tạo kết nối riêng cho hàm này sử dụng, vì khi SqlDataReader sử dụng connection thì những thực thi khác k thể dùng connection này nữa
                myCon.ConnectionString = CONNECTION_STRING;
                myCon.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure; // định dạng quyền truy xuất này là sp
                command.CommandText = sp; // câu lệnh sp

                if (param != null)
                    command.Parameters.AddRange(param); // đưa các thông số vào sp

                command.Connection = myCon;
                sdr = command.ExecuteReader();
            }
            catch (Exception e)
            {
                sdr = null;
                //MessageBox.Show(e.ToString());
            }

            return sdr;
        }

         //Thực thi SP return int
        public static int execIntSP(String sp, SqlParameter[] param)
        {
            SqlConnection myCon = new SqlConnection();//tạo connection riêng cho hàm này sử dụng
            myCon.ConnectionString = CONNECTION_STRING;
            try
            {
                myCon.Open();
                //tạo command thực thi sp
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;//định dạng thực thi sp
                command.CommandText = sp;// câu lệnh sp
                command.Connection = myCon; // connect tới csdl

                //tạo biến SqlParam nhận giá trị return
                SqlParameter returnValue = new SqlParameter("@Return", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);
                //truyền đối số cần thiết vào sp
                if (param != null)
                    command.Parameters.AddRange(param);
                command.ExecuteNonQuery();//thưc thi
                int intReturn = 0;
                //ép về int32 và return
                try
                {
                    intReturn = Convert.ToInt32(returnValue.Value);
                }
                catch (Exception e)
                {
                    intReturn = 0;
                    Console.WriteLine(e.ToString());
                }

                //đóng kết nối
                if (myCon.State == ConnectionState.Open)
                    myCon.Close();
                return intReturn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //đóng kết nối
                if (myCon.State == ConnectionState.Open)
                    myCon.Close();
                return -1;
            }
        }

         //Thực thi sp ép về dạng DataTable
        public static DataTable execDataTableSP(String sp, SqlParameter[] param)
        {
            SqlConnection myCon = new SqlConnection();//tạo connection riêng để dùng cho hàm này
            myCon.ConnectionString = CONNECTION_STRING;
            DataTable dt = new DataTable();
            try
            {
                myCon.Open();//mở connect
                //tạo command thực thi sp
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;//khai báo thực thi dạng sp
                command.CommandText = sp;//khai báo sp để thực thi
                command.Connection = myCon;
                //truyền thông số vào sp
                if (param != null)
                    command.Parameters.AddRange(param);

                //tạo DataAdapter để đổ dữ liệu vào DataTable
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = command;
                da.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            //đóng connect
            if (myCon.State == ConnectionState.Open)
                myCon.Close();
            return dt;
        }


        public static void close()
        {
            if (con != null)
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }








    }
}
