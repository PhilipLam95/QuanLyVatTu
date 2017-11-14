namespace QLYVATTU
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnMatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhaCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.rbHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDoiTac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLNhanvien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnLoaiHang,
            this.btnMatHang,
            this.btnHang,
            this.btnNhaCC,
            this.btnKhachHang,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnTaoTK,
            this.barButtonItem7,
            this.btnDoiMatKhau});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHome,
            this.rbQLNhanvien,
            this.rbpNghiepVu,
            this.rbpBaoCao});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(889, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Id = 15;
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Caption = "LOẠI HÀNG";
            this.btnLoaiHang.Enabled = false;
            this.btnLoaiHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiHang.Glyph")));
            this.btnLoaiHang.Id = 1;
            this.btnLoaiHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiHang.LargeGlyph")));
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiHang_ItemClick);
            // 
            // btnMatHang
            // 
            this.btnMatHang.Id = 4;
            this.btnMatHang.Name = "btnMatHang";
            // 
            // btnHang
            // 
            this.btnHang.Caption = "MẶT HÀNG";
            this.btnHang.Enabled = false;
            this.btnHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHang.Glyph")));
            this.btnHang.Id = 3;
            this.btnHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHang.LargeGlyph")));
            this.btnHang.Name = "btnHang";
            this.btnHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHang_ItemClick);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Caption = "NHÀ CUNG CẤP";
            this.btnNhaCC.Enabled = false;
            this.btnNhaCC.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.Glyph")));
            this.btnNhaCC.Id = 5;
            this.btnNhaCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.LargeGlyph")));
            this.btnNhaCC.Name = "btnNhaCC";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "KHÁCH HÀNG";
            this.btnKhachHang.Enabled = false;
            this.btnKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Glyph")));
            this.btnKhachHang.Id = 6;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "LẬP ĐƠN ĐẶT HÀNG";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "NHẬP HÀNG";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "XUẤT HÀNG";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "NHÂN VIÊN";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "QUẢN LÝ TÀI KHOẢN";
            this.btnTaoTK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.Glyph")));
            this.btnTaoTK.Id = 11;
            this.btnTaoTK.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.LargeGlyph")));
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "SAO LƯU-PHỤC HỒI";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "ĐỔI MẬT KHẨU";
            this.btnDoiMatKhau.Enabled = false;
            this.btnDoiMatKhau.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Glyph")));
            this.btnDoiMatKhau.Id = 14;
            this.btnDoiMatKhau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.LargeGlyph")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // rbHome
            // 
            this.rbHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpTaiKhoan,
            this.rbpHeThong,
            this.rbDoiTac});
            this.rbHome.Name = "rbHome";
            this.rbHome.Text = "Trang chủ";
            // 
            // rbpTaiKhoan
            // 
            this.rbpTaiKhoan.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbpTaiKhoan.Name = "rbpTaiKhoan";
            this.rbpTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.ItemLinks.Add(this.btnLoaiHang);
            this.rbpHeThong.ItemLinks.Add(this.btnHang);
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "HỆ THỐNG";
            // 
            // rbDoiTac
            // 
            this.rbDoiTac.ItemLinks.Add(this.btnNhaCC);
            this.rbDoiTac.ItemLinks.Add(this.btnKhachHang);
            this.rbDoiTac.Name = "rbDoiTac";
            this.rbDoiTac.Text = "ĐỐI TÁC";
            // 
            // rbQLNhanvien
            // 
            this.rbQLNhanvien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbQLNhanvien.Name = "rbQLNhanvien";
            this.rbQLNhanvien.Text = "Quản Lý Nhân Viên";
            this.rbQLNhanvien.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "QUẢN LÝ";
            // 
            // rbpNghiepVu
            // 
            this.rbpNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpNghiepVu.Name = "rbpNghiepVu";
            this.rbpNghiepVu.Text = "Kho Hàng";
            this.rbpNghiepVu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "NHẬP XUẤT HÀNG HÓA";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo Cáo";
            this.rbpBaoCao.Visible = false;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem1";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(756, 69);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(121, 46);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.Visible = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(353, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(889, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.FrmMain_GiveFeedback);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnLoaiHang;
        private DevExpress.XtraBars.BarButtonItem btnMatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpHeThong;
        private DevExpress.XtraBars.BarButtonItem btnHang;
        private DevExpress.XtraBars.BarButtonItem btnNhaCC;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDoiTac;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQLNhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

