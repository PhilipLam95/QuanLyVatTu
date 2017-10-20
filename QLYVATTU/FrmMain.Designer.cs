﻿namespace QLYVATTU
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
            this.rbHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.rbDoiTac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNhaCC = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.rbpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
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
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 10;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHome,
            this.rbpNghiepVu,
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(889, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "ĐĂNG NHẬP";
            this.btnDangNhap.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Glyph")));
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.LargeGlyph")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Caption = "LOẠI HÀNG";
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
            this.btnHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHang.Glyph")));
            this.btnHang.Id = 3;
            this.btnHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHang.LargeGlyph")));
            this.btnHang.Name = "btnHang";
            this.btnHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHang_ItemClick);
            // 
            // rbHome
            // 
            this.rbHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.rbDoiTac});
            this.rbHome.Name = "rbHome";
            this.rbHome.Text = "Trang chủ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoaiHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHang);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "HỆ THỐNG";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // rbDoiTac
            // 
            this.rbDoiTac.ItemLinks.Add(this.btnNhaCC);
            this.rbDoiTac.ItemLinks.Add(this.btnKhachHang);
            this.rbDoiTac.Name = "rbDoiTac";
            this.rbDoiTac.Text = "ĐỐI TÁC";
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Caption = "NHÀ CUNG CẤP";
            this.btnNhaCC.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.Glyph")));
            this.btnNhaCC.Id = 5;
            this.btnNhaCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.LargeGlyph")));
            this.btnNhaCC.Name = "btnNhaCC";
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "KHÁCH HÀNG";
            this.btnKhachHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Glyph")));
            this.btnKhachHang.Id = 6;
            this.btnKhachHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.LargeGlyph")));
            this.btnKhachHang.Name = "btnKhachHang";
            // 
            // rbpNghiepVu
            // 
            this.rbpNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpNghiepVu.Name = "rbpNghiepVu";
            this.rbpNghiepVu.Text = "Kho Hàng";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "NHẬP XUẤT HÀNG HÓA";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "LẬP ĐƠN ĐẶT HÀNG";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem1";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
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
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 367);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnLoaiHang;
        private DevExpress.XtraBars.BarButtonItem btnMatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnHang;
        private DevExpress.XtraBars.BarButtonItem btnNhaCC;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDoiTac;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
