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
using System.Data.SqlClient;
using QLYVATTU.MODEL;
using DevExpress.XtraReports.UI;


namespace QLYVATTU.VIEW.REPORT_VIEW
{
    public partial class ChiTietHangNhap : DevExpress.XtraEditors.XtraForm
    {
        public ChiTietHangNhap()
        {
            InitializeComponent();
        }

        private void btnHangNhap_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = this.editDateFrom.DateTime;
            DateTime DateTo = this.editDateTo.DateTime;
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { timeDateFrom, timeDateTo, MACN };

            Report rpt = new Report();
            DataTable x = rpt.ChiTietHangNhap(param);

            REPORT.rptChiTietHangNhap report = new REPORT.rptChiTietHangNhap();
            report.DataSource = x;
            report.ShowPreviewDialog();


        }

        private void btnHangXuat_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = this.editDateFrom.DateTime;
            DateTime DateTo = this.editDateTo.DateTime;
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { timeDateFrom, timeDateTo, MACN };

            Report rpt = new Report();
            DataTable x = rpt.ChiTietHangXuat(param);

            REPORT.rptChiTietHangXuat report = new REPORT.rptChiTietHangXuat();
            report.DataSource = x;
            report.ShowPreviewDialog();

        }




        private void btnTongThu_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = this.editDateFrom.DateTime;
            DateTime DateTo = this.editDateTo.DateTime;
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { timeDateFrom, timeDateTo, MACN };

            Report rpt = new Report();
            DataTable x = rpt.TongThu(param);

            REPORT.rptTongThu report = new REPORT.rptTongThu();
            report.DataSource = x;
            report.ShowPreviewDialog();
        }

        private void btnTongChi_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = this.editDateFrom.DateTime;
            DateTime DateTo = this.editDateTo.DateTime;
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { timeDateFrom, timeDateTo, MACN };

            Report rpt = new Report();
            DataTable x = rpt.TongChi(param);

            REPORT.rptTongChi report = new REPORT.rptTongChi();
            report.DataSource = x;
            report.ShowPreviewDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTKNhapXuat_Click(object sender, EventArgs e)
        {
            DateTime DateFrom = this.editDateFrom.DateTime;
            DateTime DateTo = this.editDateTo.DateTime;
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { timeDateFrom, timeDateTo, MACN };

            Report rpt = new Report();
            DataTable x = rpt.ThongKeNhapXuat(param);

            REPORT.rptThongKeNhapXuat report = new REPORT.rptThongKeNhapXuat();
            report.DataSource = x;
            report.ShowPreviewDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChiTietHangNhap_Load(object sender, EventArgs e)
        {
            foreach (Connection cnn in Access.CnnList)
            {

                cbbChiNhanh.Items.Add(cnn.Name);
                if (Access.MACN == cnn.MaCN.ToString())
                {
                    cbbChiNhanh.Text = cnn.Name.ToString();
                }

            }
            cbbChiNhanh.SelectedIndex = 0;



            if (Access.ROLE == "CongTy")
            {
                cbbChiNhanh.Enabled = true;
            }
            else
            {
                cbbChiNhanh.Enabled = false;
            }

        }
    }
}