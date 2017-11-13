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
        private Form CheckExists(Type ftype)
        {

            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }


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

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.TaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.TaoTaiKhoan f = new VIEW.TaoTaiKhoan() { MdiParent = this, Text = "Tạo tài khoản" };
                f.Show();
            }
        }


        private void FrmMain_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }


        private void btnHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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


        public void AnTrangChu()
        {
            btnLoaiHang.Enabled = false;
            btnHang.Enabled = false;
            btnNhaCC.Enabled = false;
            btnKhachHang.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            // btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnDangXuat.Visible = false;
        }
        public void HienThiQuyen_ChiNhanh()
        {

            HienThiTrangChu();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }

        public void HienThiQuyen_CongTy()
        {
            HienThiTrangChu();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.PhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.PhieuXuat f = new VIEW.PhieuXuat() { MdiParent = this, Text = "Phiếu xuất " };
                f.Show();
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            AnTrangChu();
            VIEW.DangNhap f = new VIEW.DangNhap() { MdiParent = this, Text = "Đăng nhập" };
            f.Show();
        }
    }
}
