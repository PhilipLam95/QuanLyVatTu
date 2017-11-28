using QLYVATTU.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLYVATTU
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //goi view

        public static FrmMain INSTANCE;
        public FrmMain()
        {
            InitializeComponent();
        }

        private DataTable tenchinhanh;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
            VIEW.DangNhap f = new VIEW.DangNhap() { MdiParent = this, Text = "Đăng nhập" };
            f.Show();
            
        }

        private void LoadSetting() // cài đặt begin
        {
            ChiNhanh chinhanh = new ChiNhanh();
            tenchinhanh = chinhanh.getChiNhanh();

            if (tenchinhanh == null)
            {
                MessageBox.Show("Lỗi CDSL! Không thể lấy danh sách chi nhánh");
                return;
            }
            else if (tenchinhanh.Rows.Count == 0)
            {
                MessageBox.Show("Trong CSDL không có chi nhánh nào . ");
                return;
            }

            foreach (DataRow dr in tenchinhanh.Rows)
            {
                Connection cnn = new Connection()
                {
                    Name = dr["TENCN"].ToString(),
                    DataSource = dr["DATASOURCE"].ToString(),
                    MaCN = dr["MA_CHINHANH"].ToString(),

                };
                Access.CnnList.Add(cnn);

            }

        }

        //check form 
        public Form CheckExists(Type ftype)
        {

            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        //Check Null Value TextBox()
         public bool CheckNullValue(TextBox textbox)
         {
             if (textbox.Text == "")
            {
                MessageBox.Show("Giá trị " + textbox.Tag + " không được để trống");
                 return false;
             }
            return true;
        }

        public bool CheckNullValueCBox(ComboBox combobox)
        {
             if (combobox.Text == "")
             {
                 MessageBox.Show("Giá trị " + combobox.Tag + " không được để trống");
               return false;
            }
             return true;
         }


        public bool CheckNullValueTextEdit(DevExpress.XtraEditors.TextEdit TextEdit)
        {
            if (TextEdit.Text == "")
            {
                MessageBox.Show("Giá trị " + TextEdit.Tag + " không được để trống");
                return false;
            }
            return true;
        }


        //----------------------------------------------------------GỌI FORM ----------------------------------------------------------
        private void btnLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//FORM LOAI HÀNG
        {
            Form frm = this.CheckExists(typeof(VIEW.LoaiHang));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.LoaiHang f = new VIEW.LoaiHang() { MdiParent = this, Text = "Các loại hàng" };
                f.Show();
            }
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//FORM TẠO TÀI KHOẢN
        {
            Form frm = this.CheckExists(typeof(VIEW.TaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.TaoTaiKhoan f = new VIEW.TaoTaiKhoan() { MdiParent = this, Text = "Tạo tài khoản" };
                f.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//FORM DỔI MẬT KHẨU
        {
            Form frm = this.CheckExists(typeof(VIEW.DoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DoiMatKhau f = new VIEW.DoiMatKhau() { MdiParent = this, Text = "Đổi Mật Khẩu " };
                f.Show();
            }
        }


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// FORM PHIẾU XUẤT
        {
            Form frm = this.CheckExists(typeof(VIEW.PhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.PhieuXuat f = new VIEW.PhieuXuat() { MdiParent = this, Text = "Phiếu xuất " };
                f.Show();
            }
        }


        private void btnHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.MatHang));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.MatHang f = new VIEW.MatHang() { MdiParent = this, Text = "Các mặt hàng " };
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//form Don dat hàng
        {
            Form frm = this.CheckExists(typeof(VIEW.DonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DonDatHang f = new VIEW.DonDatHang() { MdiParent = this, Text = "Đơn Đặt Hàng " };
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//form nhập hàng
        {
            Form frm = this.CheckExists(typeof(VIEW.PhieuNhap));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.PhieuNhap f = new VIEW.PhieuNhap() { MdiParent = this, Text = "Phiếu Nhâp " };
                f.Show();
            }
        }


        private void btnBaoCaoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(REPORT.BaoCaoHang));
            if (frm != null) frm.Activate();
            else
            {
                REPORT.BaoCaoHang f = new REPORT.BaoCaoHang() { MdiParent = this, Text = "Báo Cáo Hàng " };
                f.Show();
            }
        }

        //----------------------------------------------------------GỌI FORM ----------------------------------------------------------


        private void FrmMain_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }


        


        public void HienThiQuanLyNhanVien()
        {
            rbQLNhanvien.Visible = true;
        }

        public void HienThiKhoHang()
        {
            rbpNghiepVu.Visible = true;
        }

        public void HienThiBaoCao()
        {
            
        }

        public void HienThiTrangChu()
        {
            btnLoaiHang.Enabled = true;
            btnHang.Enabled = true;
            btnNhaCC.Enabled = true;
            btnKhachHang.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            //btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDangXuat.Visible = true;
        }


        public void ReturnDefault()
        {
            btnLoaiHang.Enabled = false;
            btnHang.Enabled = false;
            btnNhaCC.Enabled = false;
            btnKhachHang.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            // btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnDangXuat.Visible = false;
            rbQLNhanvien.Visible = false;
            rbpNghiepVu.Visible = false;
            label1.Visible = false;
        }


        public void HienThiQuyen_ChiNhanh()
        {
            label1.Visible = true;
            label1.Text = "Xin chào " + Access.HOTEN;
            HienThiTrangChu();
            HienThiQuanLyNhanVien();
            HienThiKhoHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }

        public void HienThiQuyen_CongTy()
        {
            label1.Visible = true;
            label1.Text = "Xin chào " + Access.HOTEN;
            HienThiTrangChu();
            HienThiBaoCao();
            HienThiQuanLyNhanVien();
            HienThiKhoHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }

       

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            ReturnDefault();
            VIEW.DangNhap f = new VIEW.DangNhap() { MdiParent = this, Text = "Đăng nhập" };
            f.Show();
        }

        int x =450, y = 85, a = 1;

       

        Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if(x >= 800)
                {
                    a = -1;
                    label1.ForeColor = Color.FromArgb(random.Next(0, 225), random.Next(0, 225), random.Next(0, 225));
                }
                if(x <450)
                {
                    a = 1;
                    label1.ForeColor = Color.FromArgb(random.Next(0, 225), random.Next(0, 225), random.Next(0, 225));
                }

            }
            catch
            {

            }
        }
    }
}
