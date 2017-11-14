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

namespace QLYVATTU.VIEW
{
    public partial class TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        private DataTable nv;
   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien();
            sP_LAY_NHANVIENGridControl.DataSource = nv;
           sP_LAY_NHANVIENGridControl.DataMember = nv.TableName;
            Check_role_congty();

        }


        private void Check_role_congty()
        {
            if(Access.ROLE == "CongTy")
            {
               
                rabtnChiNhanh.Checked = false;
                rabtnChiNhanh.Visible = false;
                rabtnUser.Checked = false;
                rabtnUser.Visible = false;
                rabtnCongTy.Checked = true;
                rabtnCongTy.Visible = true;
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }


        private bool CheckForTaoTaiKhoan()
        {
            if(tboxUserName.Text == "")
            {
                MessageBox.Show("Tên tài khoản không được để trống");
                return false;
            }

            if(tboxPassword.Text == "")
            {
                MessageBox.Show("Mật Khẩu không được để trống");
                return false;
            }
            if(tboxHo.Text == "" || tboxTen.Text == "")
            {
                MessageBox.Show("Họ và tên không được để trống");
                return false;
            }

            if(nGAYSINHDateEdit.Text == "")
            {
                MessageBox.Show("Hãy chọn ngày sinh");
                return false;
            }
            if(tboxDiachi.Text =="")
            {
                MessageBox.Show("Nhập địa chỉ");
                return false;

            }

            if(tboxSDT.Text== "")
            {
                MessageBox.Show("Nhập số điện thoại");
                return false;
            }

            if(tboxSDT.MaxLength <9)
            {
                MessageBox.Show("Số điện thoại phải từ 9 số trở lên");
                return false;
            }
            else
            {
                return true;
            }


         
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            CheckForTaoTaiKhoan();
            string ho = tboxHo.Text.ToString();
            string ten = tboxTen.Text.ToString();
            string phai = "";
            if (rabtnNam.Checked == true)
            {
                phai = rabtnNam.Text.ToString();
            }
            else
            {
                phai = rabtnNu.Text.ToString();
            }
            string role = "";
            if (Access.ROLE == "ChiNhanh")
            {
                if (rabtnUser.Checked == true)
                {
                    role = rabtnUser.Text.ToString();
                }
                else
                {
                    role = rabtnChiNhanh.Text.ToString();
                }
            }
            else
            {
                role = Access.ROLE;
            }


            DateTime ngaysinh = this.nGAYSINHDateEdit.DateTime;
            string  nsinh = String.Format("{0:MM-dd-yyyy}", ngaysinh);
            string diachi = tboxDiachi.Text.ToString();
            string sodt = tboxSDT.Text.ToString();
            string password = tboxPassword.Text.ToString();
            string username = tboxUserName.Text.ToString();
            //string role = "CHINHANH";
            string[] param = { ho, ten, phai , nsinh,diachi,sodt, username , password, role };
            NhanVien nhanvien = new NhanVien();
            int x  =  nhanvien.InserCusomer(param);
            if(x == 0)
            {
                MessageBox.Show("Tạo tài khoản thành công");
            }






        }

        private void tboxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập kiểu số ", "Thông Báo ");
            }

            
        }
    }
}