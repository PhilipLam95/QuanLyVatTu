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
    public partial class Report_DS_NhanVien : Form
    {
        public Report_DS_NhanVien()
        {
            InitializeComponent();
        }

        private static DataTable rp;

        private void Report_DS_NhanVien_Load(object sender, EventArgs e)
        {
           
            load_DS_NhanVien();
            foreach (Connection cnn in Access.CnnList)
            {
               
                cboxCHINHANH.Items.Add(cnn.Name);
                if (Access.MACN == cnn.MaCN.ToString())
                {
                    cboxCHINHANH.Text = cnn.Name.ToString();
                }

            }

            if (Access.ROLE == "CongTy")
            {
                cboxCHINHANH.Enabled = true;
               
            }
            else
            {
                cboxCHINHANH.Enabled = false;
            }
        }

        private void load_DS_NhanVien()
        {
            Report report = new Report();
            rp = report.Load_REPORT_DS_NHANVIEN();
            sP_REPORT_DS_NHANVIENGridControl.DataSource = rp;
            sP_REPORT_DS_NHANVIENGridControl.DataMember = rp.TableName;
        }

        private void cboxCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection cnn = Access.CnnList[cboxCHINHANH.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { MACN };
            Report report = new Report();
            rp = report.Load_REPORT_DS_NHANVIEN_THEOMA(param);
            sP_REPORT_DS_NHANVIENGridControl.DataSource = rp;
            sP_REPORT_DS_NHANVIENGridControl.DataMember = rp.TableName;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            Connection cnn = Access.CnnList[cboxCHINHANH.SelectedIndex];
            string MACN = cnn.MaCN;
            string[] param = { MACN };

            Report rpt = new Report();
            rp = rpt.Load_REPORT_DS_NHANVIEN_THEOMA(param);

            
            REPORT.rptDanhSachNhanVien report = new REPORT.rptDanhSachNhanVien();
            report.DataSource = rp;
            report.ShowPreviewDialog();
        }
    }
}
