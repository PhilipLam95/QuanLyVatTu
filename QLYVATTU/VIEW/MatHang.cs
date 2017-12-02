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
using DevExpress.XtraGrid.Views.Grid;

namespace QLYVATTU.VIEW
{
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }
        private DataTable vt;
        private DataTable lvt;

        private void MatHang_Load(object sender, EventArgs e)
        {
        

            loadvattu();
        }

        private void loadvattu()
        {
            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            sP_DS_VATTUGridControl.DataSource = vt;
            sP_DS_VATTUGridControl.DataMember = vt.TableName;

            VatTu loaivattu = new VatTu();
            lvt = loaivattu.getLoaiVatTu();
            sP_DS_LOAIVTGridControl.DataSource = lvt;
            sP_DS_LOAIVTGridControl.DataMember = lvt.TableName;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
           Form frm = Program.fmain.CheckExists(typeof(VIEW.DonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DonDatHang f = new VIEW.DonDatHang() { MdiParent = Program.fmain, Text = "Đơn Đặt Hàng" };
                f.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {
            var gridView1 = sender as GridView;
            if (gridView1.FocusedColumn != gridView1.Columns["TENVT"] && 
                gridView1.FocusedColumn != gridView1.Columns["MALOAI"] &&
                gridView1.FocusedColumn != gridView1.Columns["TENLOAI"] &&
                gridView1.FocusedColumn != gridView1.Columns["DONGIA"] &&
                gridView1.FocusedColumn != gridView1.Columns["DONVI"] ||
               gridView1.FocusedRowHandle == DevExpress.XtraGrid.GridControl.NewItemRowHandle)
                return;
            e.Cancel = true;
        }
    }
}