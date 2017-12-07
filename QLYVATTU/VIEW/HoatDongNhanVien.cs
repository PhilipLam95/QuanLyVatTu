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
using QLYVATTU.MODEL;
using DevExpress.XtraReports.UI;
using QLYVATTU.LIST_ARRAY;

namespace QLYVATTU.VIEW
{
    public partial class HoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public HoatDongNhanVien()
        {
            InitializeComponent();
        }

        List<ListNhanVien> LISTNV = new List<ListNhanVien>();
        private static DataTable nhanvien;
        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void HoatDongNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_LAYCHINHANH' table. You can move, or remove it, as needed.
            this.sP_LAYCHINHANHTableAdapter.Fill(this.qL_VATTUDataSet.SP_LAYCHINHANH);


            
          
        }


      
        private void btnPreview_Click(object sender, EventArgs e)
        {

            DateTime DateFrom = this.dtDateFrom.DateTime;
            DateTime DateTo = this.dtDateTo.DateTime;
            String idNV = cbbMaNV.Text.ToString();
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            string[] param = { idNV, timeDateFrom, timeDateTo };

            Report rpt = new Report();
            DataTable x = rpt.HoatDongNhanVien(param);

            REPORT.rptHoatDongNhanVien report = new REPORT.rptHoatDongNhanVien();
            report.DataSource = x;
            report.ShowPreviewDialog();
       
        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListNhanVien list in LISTNV )
            {
                for (int i = 0; i < LISTNV.Count; i++)
                {
                    if (cbbMaNV.Text == LISTNV[i].MaNV)
                    {
                        txtTenNV.Text = (LISTNV[i].HO +" "+ LISTNV[i].TEN);
                        
                    }
                }


            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            string macn = comboBox1.SelectedValue.ToString();
            string[] param = { macn };
            LISTNV.Clear();
            NhanVien nv = new NhanVien();
            nhanvien = nv.getNhanVienTheoCN(param);
            
            foreach (DataRow row in nhanvien.Rows)
            {
                ListNhanVien lnv = new ListNhanVien()
                {
                    MaNV = row["MANV"].ToString(),
                    MaCN = row["MACN"].ToString(),
                    HO = row["HO"].ToString(),
                    TEN = row["TEN"].ToString(),
                    DiaChi = row["DIACHI"].ToString(),
                    Sdt = row["SODT"].ToString(),

                };
                LISTNV.Add(lnv);
            }

            foreach (ListNhanVien lnv in LISTNV.ToList())
            {

                cbbMaNV.Items.Add(lnv.MaNV);

            }
           
            cbbMaNV.SelectedIndex = 0;
           
        }
    }
}