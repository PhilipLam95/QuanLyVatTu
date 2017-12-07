using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLYVATTU.REPORT
{
    public partial class rptDanhMucVatTu : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDanhMucVatTu()
        {
            InitializeComponent();
            lbNgaybaocao.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

    }
}
