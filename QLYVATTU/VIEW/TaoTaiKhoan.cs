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
using QLYVATTU.STACK;
using QLYVATTU.LIST_ARRAY;

namespace QLYVATTU.VIEW
{
    public partial class TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        private DataTable nv;

        private Stack<Command> _commands;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            panel6.Visible = false;
            _commands = new Stack<Command>();
            load_DS_NHANVIEn();
            loadTheoRole();
            //int gioitinh = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]));
            Check_role_congty();

            Timer timer = new Timer();
            timer.Interval = (10 * 700); // 6 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        private int Execute(string _operator, ListNhanVien _operand, ListNhanVien oldstate)
        {
            Command command = new NhanVienCommand(_operator, _operand, oldstate);
            int code = command.Execute();
            _commands.Push(command);
            MessageBox.Show(_commands.Count.ToString());
            btnUndo.Enabled = true;
            return code;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            loadTheoRole();
        }


        private void load_DS_NHANVIEn()
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien();
            sP_LAY_NHANVIENGridControl.DataSource = nv;
            sP_LAY_NHANVIENGridControl.DataMember = nv.TableName;
        }


        private void load_DS_NhanVien_ChiNhanh_User()
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien_User_ChiNhanh();
            if (nv == null)
            {
                sP_LAYNHANVIEN_USERGridControl.DataSource = null;
            }
            else
            {
                sP_LAYNHANVIEN_USERGridControl.DataSource = nv;
                sP_LAYNHANVIEN_USERGridControl.DataMember = nv.TableName;
            }
        }

        private void load_DS_Nhanvien_User()
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVienUser();
            sP_LAYNHANVIEN_USERGridControl.DataSource = nv;
            sP_LAYNHANVIEN_USERGridControl.DataMember = nv.TableName;
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
            else
            {
                rabtnChiNhanh.Checked = true;
                rabtnChiNhanh.Visible = true;
                rabtnUser.Checked = false;
                rabtnUser.Visible = true;
                rabtnCongTy.Checked = false;
                rabtnCongTy.Visible = false;

            }
        }

      


        private void loadTheoRole()
        {
            if (Access.ROLE == "CongTy")
            {
                load_DS_NhanVien_ChiNhanh_User();

            }
            else
            {
                load_DS_Nhanvien_User();
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
                loadTheoRole();


            }
            else
            {
                MessageBox.Show("Tạo tài khoản lỗi");
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

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if(e.Column.FieldName == "PHAI")
            //{
            //    if((bool)e.Value == true)
            //    {

            //        Convert.ToString(e.Value == "Nam"); 

            //    }
            //    else
            //    {
            //        Convert.ToString(e.Value == "Nữ");
            //    }
               
            //}
        }

        private void sP_LAY_NHANVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void FocusRowChangeData()
        {


            tboxUserName.Enabled = false;
            tboxPassword.Enabled = false;
            btnXoa.Enabled = true;
            panel6.Visible = true;
            DataRow red = gridView1.GetFocusedDataRow();
            if(red == null)
            {
                return;
            }
            else
            {
                tboxHo.Text = red["HO"].ToString();
                tboxTen.Text = red["TEN"].ToString();
                tboxSDT.Text = red["SODT"].ToString();
                tboxDiachi.Text = red["DIACHI"].ToString();
                nGAYSINHDateEdit.Text = red["NGAYSINH"].ToString();
                lbMaNhanVien.Text = red["MANV"].ToString();

                //string manv = red["MANV"].ToString();
                if (red["PHAI"].ToString() == "Nam")
                {
                    rabtnNam.Checked = true;
                }
                else
                {
                    rabtnNu.Checked = true;
                }


                if (red["CHUCVU"].ToString() == "Giám đốc")
                {
                    rabtnChiNhanh.Checked = true;
                    rabtnCongTy.Enabled = false;
                }

                if (red["CHUCVU"].ToString() == "Nhân Viên")
                {
                    rabtnUser.Checked = true;
                    rabtnCongTy.Enabled = false;
                }


                if (red["TRTHAI"].ToString() == "Đang làm")
                {
                    rptDangLam.Checked = true;
                }
                else
                {
                    rptDaNghi.Checked = true;
                }
            }
           

            rabtnCongTy.Visible = true;
            rabtnChiNhanh.Visible = true;
            rabtnUser.Visible = true;



            btnLuu.Enabled = false;
            btnHuy.Enabled = true;


        }
       


        private void EventforHUy()
        {
            panel6.Visible = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = false;

            tboxUserName.Enabled = false;
            tboxPassword.Enabled = false;

            tboxUserName.Text = "";
            tboxPassword.Text = "";
            tboxHo.Text = "";
            tboxTen.Text = "";
            tboxSDT.Text = "";
            tboxDiachi.Text = "";
            nGAYSINHDateEdit.Text = "";
            tboxUserName.Enabled = true;
            tboxPassword.Enabled = true;
            tboxHo.Enabled = true;
            tboxHo.Enabled = true;
            tboxSDT.Enabled = true;
            tboxDiachi.Enabled = true;
            nGAYSINHDateEdit.Enabled = true;
        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EventforHUy();
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getManvtudong();
            foreach (DataRow s in nv.Rows)
            {
                lbMaNhanVien.Text = s[0].ToString();
            }

            

            if( Access.ROLE == "CongTy")
            {
                rabtnCongTy.Visible = true;
                rabtnChiNhanh.Visible = false;
                rabtnUser.Visible = false;
                rabtnCongTy.Checked = true;
            }
            else
            {
                rabtnCongTy.Visible = false;
                rabtnChiNhanh.Visible = true;
                rabtnUser.Visible = true;
                rabtnUser.Checked = true;
            }

            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            int noError = 0;
            string errors = "Nội dung bạn nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu.";
            if (tboxHo.Text.Trim() == "")
            {
                //MessageBox.Show("Nội dung câu hỏi không được bỏ trống");
                errors += "\r\n+ Họ bị bỏ trống";
                noError++;
            }
            if (tboxTen.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án A không được bỏ trống");
                errors += "\r\n+ Tên bị bỏ trống";
                noError++;
            }
            if (tboxDiachi.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Địa chỉ bị bỏ trống";
                noError++;
            }
            if (tboxSDT.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Số điện thoại bị bỏ trống";
                noError++;
            }
            if (nGAYSINHDateEdit.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Ngày sing bị bỏ trống";
                noError++;
            }

            if (noError > 0)
            {
                MessageBox.Show(errors);
                btnLuu.Enabled = true;
                return;
            }

            DataRow red = gridView1.GetFocusedDataRow();

            string MANV = lbMaNhanVien.Text.ToString();


            string role_login = "";
            if (rabtnCongTy.Checked)
            {
                role_login = rabtnCongTy.Text.ToString();
            }

            if(rabtnChiNhanh.Checked)
            {
                role_login = rabtnChiNhanh.Text.ToString();
            }

            if(rabtnUser.Checked)
            {
                role_login = rabtnUser.Text.ToString();
            }

            MessageBox.Show(role_login);
            string gioitinh = "";
            if(rabtnNam.Checked )
            {
                gioitinh = rabtnNam.Text.ToString();
            }
            else
            {
                gioitinh = rabtnNu.Text.ToString();
            }

            string trthai = "";
            if(rptDangLam.Checked)
            {
                trthai = rptDangLam.Text.ToString();
            }
            else
            {
                trthai = rptDaNghi.Text.ToString();
            }

         

            DateTime ngsinh = this.nGAYSINHDateEdit.DateTime;
            String nsinh = String.Format("{0:MM-dd-yyyy}", ngsinh);

            
            ListNhanVien NHANVIEN_TrongFORM = new ListNhanVien
            {

                MaNV = lbMaNhanVien.Text.ToString(),
                HO = tboxHo.Text.ToString(),
                TEN = tboxTen.Text.ToString(),
                Phai = gioitinh,
                NgaySinh = nsinh,
                DiaChi = tboxDiachi.Text.ToString(),
                Sdt = tboxSDT.Text.ToString(),
                login = tboxUserName.Text.Trim().ToString(),
                matkhau = tboxPassword.Text.Trim().ToString(),
                role = role_login,
                Trangthai = trthai,

            };

            if (red != null)
            {
                ListNhanVien NHANVIEN_TrongBang = new ListNhanVien
                {
                    MaNV = red["MANV"].ToString(),
                    HO = red["HO"].ToString(),
                    TEN = red["TEN"].ToString(),
                    Phai = red["PHAI"].ToString(),
                    NgaySinh = red["NGAYSINH"].ToString(),
                    DiaChi = red["DIACHI"].ToString(),
                    Sdt = red["SODT"].ToString(),
                    role = red["CHUCVU"].ToString(),
                    Trangthai = red["TRTHAI"].ToString(),
                };
            }
            else
            {
                ListNhanVien NHANVIEN_TrongBang = new ListNhanVien
                {
                    MaNV = "",
                    HO = "",
                    TEN = "",
                    Phai = "",
                    NgaySinh = "",
                    DiaChi = "",
                    Sdt = "",
                    role = "",
                    Trangthai = "",
                };

            }



            if (tboxUserName.Enabled)
            {
                if (tboxUserName.Text.Trim() == ""  || tboxPassword.Text.Trim() == "")
                {
                    MessageBox.Show("UserName hoặc mật khẩu bạn đã bỏ trống");
                    return;
                }
                else
                {
                    int code = Execute("insert", NHANVIEN_TrongFORM, NHANVIEN_TrongBang);
                    if (code == 0)
                    {
                        btnReload.PerformClick();
                        MessageBox.Show("Thêm nhân viên thành công");
                        tboxUserName.Text = "";
                        tboxPassword.Text = "";
                        if(Access.ROLE == "CongTy")
                        {
                            
                            load_DS_NhanVien_ChiNhanh_User();
                        }
                        else
                        {
                            load_DS_Nhanvien_User();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }
               
            }
            else
            {
                int code = Execute("update", NHANVIEN_TrongFORM, NHANVIEN_TrongBang);
                if (code == 0)
                {
                    btnReload.PerformClick();
                    MessageBox.Show("Lưu nhân viên thành công");

                }
                else
                {
                    MessageBox.Show("Lưu nhân viên thất bại");
                }
            }
        }

        private void sP_LAYNHANVIEN_USERGridControl_Click(object sender, EventArgs e)
        {
            FocusRowChangeData();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (_commands.Count > 0)
            {
                Command command = _commands.Pop();
                int code = command.UnExecute();
                if (code == 0)
                {
                    btnReload.PerformClick();
                    //MessageBox.Show("Phục hồi thành công");
                }
                else
                    MessageBox.Show("Phục hồi thất bại.");
                if (_commands.Count == 0)
                    btnUndo.Enabled = false;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaoTaiKhoan_Load(sender, e);
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            FocusRowChangeData();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       

        private void rptDangLam_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rptDaNghi_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EventforHUy();
        }

        private void tboxHo_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxTen_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnNam_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnNu_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void nGAYSINHDateEdit_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxDiachi_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxSDT_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnUser_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnCongTy_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnChiNhanh_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
    }
}