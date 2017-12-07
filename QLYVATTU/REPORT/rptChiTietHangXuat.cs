using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLYVATTU.REPORT
{
    public partial class rptChiTietHangXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public rptChiTietHangXuat()
        {
            InitializeComponent();
            lbNgaybaocao.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

    }
}
