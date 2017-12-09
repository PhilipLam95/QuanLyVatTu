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
using QLYVATTU.STACK;
using QLYVATTU.LIST_ARRAY;
using DevExpress.XtraReports.UI;

namespace QLYVATTU.VIEW
{
    public partial class MatHang : Form
    {
        public MatHang()
        {
            InitializeComponent();
        }

        private Stack<Command> _commands;
        FrmMain f = Program.fmain;
        private DataTable vt;
        private DataTable lvt;
        private static DataTable rp;

        private void MatHang_Load(object sender, EventArgs e)
        {

            btnReload.PerformClick();
            _commands = new Stack<Command>();
            loadvattu();
            loadLoaiVT();
        }

        private void loadvattu()
        {
            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            sP_DS_VATTUGridControl.DataSource = vt;
            sP_DS_VATTUGridControl.DataMember = vt.TableName;

        }

        private void loadLoaiVT()
        {
            VatTu loaivattu = new VatTu();
            lvt = loaivattu.getLoaiVatTu();
            foreach (DataRow row in lvt.Rows)
            {
                cBoxLoaiVT.Items.Add(row[1]);
            }
            cBoxLoaiVT.SelectedIndex = 0;
            //sP_DS_LOAIVTGridControl.DataSource = lvt;
            //sP_DS_LOAIVTGridControl.DataMember = lvt.TableName;
        }



        private int Execute(string _operator, ListVatTu _operand, ListVatTu oldstate)
        {
            Command command = new Vattu_Command(_operator, _operand, oldstate);
            int code = command.Execute();
            _commands.Push(command);
            btnUndo.Enabled = true;
            return code;
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

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnableFor();
        }


        private void EnableFor()
        {
            tBoxMaVT.Enabled = true;
            tboxTenVT.Enabled = true;
            cBoxLoaiVT.Enabled = true;
            tBoxDonvi.Enabled = true;
            tBoxDongia.Enabled = true;

            tBoxMaVT.Text = "";
            tboxTenVT.Text = "";
            cBoxLoaiVT.SelectedIndex = 0;
            tBoxDonvi.Text = "";
            tBoxDongia.Text = "";
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void sP_DS_VATTUGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            int noError = 0;
            string errors = "Nội dung bạn nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu.";
            if (tboxTenVT.Text.Trim() == "")
            {
                //MessageBox.Show("Nội dung câu hỏi không được bỏ trống");
                errors += "\r\n+ Tên vật tư bị bỏ trống";
                noError++;
            }
            if (tBoxDonvi.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án A không được bỏ trống");
                errors += "\r\n+ Đơn vị bị bỏ trống";
                noError++;
            }
            if (tBoxDongia.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Đáp án B bị bỏ trống";
                noError++;
            }
            if (cBoxLoaiVT.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án C không được bỏ trống");
                errors += "\r\n+ Đơn giá bị bỏ trống";
                noError++;
            }
            if (noError > 0)
            {
                MessageBox.Show(errors);
                btnLuu.Enabled = true;
                return;
            }
            DataRow red = gridView1.GetFocusedDataRow();
            string MA_LOAI_TRONGBANG = lvt.Select(string.Format("TENLOAI='{0}'", red["TENLOAI"].ToString()))[0][0].ToString();// doc ma loại trong gridview1
            ListVatTu VT_TrongBang = new ListVatTu
            {
                MAVT = red["MAVT"].ToString(),
                TENVT = red["TENVT"].ToString(),
                DONVI = red["DONVI"].ToString(),
                DONGIA = Convert.ToDecimal(red["DONGIA"].ToString()),
                MALOAI = MA_LOAI_TRONGBANG,

            };

            string MA_LOAI_TRONGFORM = lvt.Select(string.Format("TENLOAI ='{0}'", cBoxLoaiVT.Text))[0][0].ToString();
            ListVatTu VT_TrongFORM = new ListVatTu
            {
                MAVT = tBoxMaVT.Text.Trim().ToUpper(),
                TENVT = tboxTenVT.Text.Trim(),
                DONVI = tBoxDonvi.Text.Trim(),
                DONGIA = Convert.ToDecimal(tBoxDongia.Text.Trim()),
                MALOAI = MA_LOAI_TRONGFORM,
            };


            if (tBoxMaVT.Enabled)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (tBoxMaVT.Text == gridView1.GetRowCellValue(i, gridView1.Columns["MAVT"]).ToString() || tboxTenVT.Text == gridView1.GetRowCellValue(i, gridView1.Columns["TENVT"]).ToString())
                    {
                        MessageBox.Show("Vat tu them da ton tai");
                        break;
                    }
                    else
                    {
                        if (i == (gridView1.RowCount - 1))
                        {
                            int code = Execute("insert", VT_TrongFORM, VT_TrongBang);
                            if (code == 0)
                            {
                                btnReload.PerformClick();

                            }
                            else
                            {
                                MessageBox.Show("Thêm Vật tư thất bại");
                            }
                            break;
                        }
                    }
                }

                tBoxMaVT.Enabled = false;
                btnLuu.Enabled = true;

            }
            else
            {

                int code = Execute("update", VT_TrongFORM, VT_TrongBang);
                if (code == 0)
                {
                    btnReload.PerformClick();

                }
                else
                {
                    MessageBox.Show("Lưu vật tư thất bại");
                }

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnXoa.Enabled = false;
            DataRow red = gridView1.GetFocusedDataRow();
            string MA_LOAI_TRONGBANG = lvt.Select(string.Format("TENLOAI='{0}'", red["TENLOAI"].ToString()))[0][0].ToString();// doc ma loại trong gridview1
            MessageBox.Show(MA_LOAI_TRONGBANG);
            ListVatTu VT_TrongBang = new ListVatTu
            {
                MAVT = red["MAVT"].ToString(),
                TENVT = red["TENVT"].ToString(),
                DONVI = red["DONVI"].ToString(),
                DONGIA = Convert.ToDecimal(red["DONGIA"].ToString()),
                MALOAI = MA_LOAI_TRONGBANG,

            };
            string MA_LOAI_TRONGFORM = lvt.Select(string.Format("TENLOAI ='{0}'", cBoxLoaiVT.Text))[0][0].ToString();
            ListVatTu VT_TrongFORM = new ListVatTu
            {
                MAVT = tBoxMaVT.Text.Trim().ToUpper(),
                TENVT = tboxTenVT.Text.Trim(),
                DONVI = tBoxDonvi.Text.Trim(),
                DONGIA = Convert.ToDecimal(tBoxDongia.Text.Trim()),
                MALOAI = MA_LOAI_TRONGFORM,
            };

            int code = Execute("delete", VT_TrongFORM, VT_TrongBang);
            if (code == 0)
            {
                //MessageBox.Show("Xoá thành công");
                btnReload.PerformClick();
            }
            else
                MessageBox.Show("Xoá thất bại.");
            tBoxMaVT.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_commands.Count > 0)
            {
                Command command = _commands.Pop();
                int code = command.UnExecute();
                if (code == 0)
                {
                    btnReload.PerformClick();
                    //MessageBox.Show("Phục hồi thành công");
                }
                else
                    MessageBox.Show("Phục hồi thất bại.");
                if (_commands.Count == 0)
                    btnUndo.Enabled = false;
            }
        }

        private void FocusedRowChanged()
        {
            tBoxMaVT.Enabled = false;
            tboxTenVT.Enabled = true;
            cBoxLoaiVT.Enabled = true;
            tBoxDonvi.Enabled = true;
            tBoxDongia.Enabled = true;
            DataRow red = gridView1.GetFocusedDataRow();
            tBoxMaVT.Text = red["MAVT"].ToString();
            tboxTenVT.Text = red["TENVT"].ToString();
            cBoxLoaiVT.Text = red["TENLOAI"].ToString();
            tBoxDongia.Text = red["DONGIA"].ToString();
            tBoxDonvi.Text = red["DONVI"].ToString();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }



        private void gridView1_Click(object sender, EventArgs e)
        {
            FocusedRowChanged();
        }


        private void TextChange()
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void UnTextChange()
        {

            if (tBoxMaVT.Text.Trim() == "" || tboxTenVT.Text.Trim() == "" || tBoxDonvi.Text.Trim() == "" || tBoxDongia.Text.Trim() == "")
            {
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
        }



        private void tBoxMaVT_TextChanged(object sender, EventArgs e)
        {
            TextChange();
            UnTextChange();
        }

        private void tboxTenVT_TextChanged(object sender, EventArgs e)
        {
            TextChange();
            UnTextChange();
        }

        private void cBoxLoaiVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextChange();
            UnTextChange();
        }

        private void tBoxDonvi_TextChanged(object sender, EventArgs e)
        {
            TextChange();
            UnTextChange();
        }

        private void tBoxDongia_TextChanged(object sender, EventArgs e)
        {
            TextChange();
            UnTextChange();
        }

        private void tBoxDongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập kiểu số cho đơn giá ", "Thông Báo ");
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadvattu();
            btnLuu.Enabled = false;
            FocusedRowChanged();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            tBoxMaVT.Text = "";
            tboxTenVT.Text = "";
            tBoxDonvi.Text = "";
            tBoxDongia.Text = "";
            tBoxMaVT.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            VatTu rpt = new VatTu();
            rp = rpt.getVatTu();


            REPORT.rptDanhMucVatTu report = new REPORT.rptDanhMucVatTu();
            report.DataSource = rp;
            report.ShowPreviewDialog();
        }
    }
}