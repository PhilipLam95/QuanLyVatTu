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
        public FrmMain()
        {
            InitializeComponent();
        }

        //check form 
        private Form CheckExists(Type ftype)
        {

            
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(VIEW.DangNhap));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DangNhap f = new VIEW.DangNhap() { MdiParent = this, Text = "Đăng nhập" };
                f.Show();
            }

        }

        private void btnLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.LoaiHang));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.LoaiHang f = new VIEW.LoaiHang() { MdiParent = this, Text = "Các loại hàng" };
                f.Show();
            }
        }


        private void FrmMain_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }


        private void btnHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        
    }
}
