using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLYVATTU.MODEL;
using System.Data.SqlClient;

namespace QLYVATTU.VIEW
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {

        
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhapcs_Load(object sender, EventArgs e)
        {
            add_CN();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void add_CN()
        {

            foreach (Connection cnn in Access.CnnList)
            {
                    comboBox1.Items.Add(cnn.Name);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private bool CheckEmpty()
        {

            if (tboxTaiKhoan.Text == "")
            {
                MessageBox.Show(" Tên tài khoản không được để trống");
                return false;
            }

            if (tboxMatKhau.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu của bạn");
                return false;
            }
            else
                return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            CheckEmpty();
            Connection cnn = Access.CnnList[comboBox1.SelectedIndex];
                Access.DATA_SOURCE = cnn.DataSource;
                Access.MACN = cnn.MaCN;
                string username = tboxTaiKhoan.Text.Trim().ToUpper();
                string password = tboxMatKhau.Text.Trim();
                Access.USERNAME = username;
                Access.PASSWORD = password;

            if (!Access.Connect())
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu của bạn đã sai !!!");
                return;
            }
            else
            {
                try
                {
                    /*SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@LOGINNAME", Access.USERNAME);
                    SqlDataReader reader = Access.ExecSqlDataReader("SP_DANGNHAP", param);
                    if (reader.Read())
                    {
                        Console.WriteLine(reader["MANV"].ToString() + reader["HOTEN"].ToString() + reader["ROLE"].ToString());

                        Access.ROLE = reader["ROLE"].ToString();
                        Access.HOTEN = reader["HOTEN"].ToString();
                        Access.MANV = reader["MANV"].ToString();
                        MessageBox.Show(" Đăng Nhập Thành Công ! ");
                        Program.fmain.HienThiQuyen();
                        /*
                        if (Access.ROLE == "CongTy")
                        {
                           
                            return;
                        }
                        if (Access.role == "Chinhanh")
                        {
                           
                            return;
                        }
                        


                    }*/
                }

                catch
                {
                    MessageBox.Show("Sai thông tin tài khoản");
                }
            }
           



            /* foreach (DataRow dr in tenchinhanh.Rows)
             {
                 if ( dr["TENCN"].ToString() == comboBox1.Text)
                 {

                 }

             }*/


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}