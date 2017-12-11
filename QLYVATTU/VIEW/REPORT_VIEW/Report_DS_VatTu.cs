using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLYVATTU.MODEL;
using DevExpress.XtraReports.UI;

namespace QLYVATTU.VIEW.REPORT_VIEW
{
    public partial class Report_DS_VatTu : Form
    {
        public Report_DS_VatTu()
        {
            InitializeComponent();
        }

        private static DataTable rp;
        private void Report_DS_VatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DS_VATTU' table. You can move, or remove it, as needed.
            
            
            VatTu rpt = new VatTu();
            rp = rpt.getVatTu();
            if(rp == null)
            {
                return;
            }
            else
            {
                sP_DS_VATTUGridControl.DataSource = rp;
            }
            

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            VatTu rpt = new VatTu();
            rp = rpt.getVatTu();


            REPORT.rptDanhMucVatTu report = new REPORT.rptDanhMucVatTu();
            report.DataSource = rp;
            report.ShowPreviewDialog();
        }
    }
}
