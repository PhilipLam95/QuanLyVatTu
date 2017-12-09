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
using QLYVATTU.LIST_ARRAY;
using QLYVATTU.STACK;
using System.Data.SqlClient;

namespace QLYVATTU.VIEW
{
    public partial class LoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public LoaiHang()
        {
            InitializeComponent();
        }
        private Stack<Command>  _commands;
        private DataTable lvt;
        private void LoaiHang_Load(object sender, EventArgs e)
        {
            loadLoaiVT();
            _commands = new Stack<Command>();

        }

        private void loadLoaiVT()
        {
            VatTu loaivattu = new VatTu();
            lvt = loaivattu.getLoaiVatTu();
            sP_DS_LOAIVTGridControl.DataSource = lvt;
            sP_DS_LOAIVTGridControl.DataMember = lvt.TableName;
        }

        private void FocusRowChange()
        {
            DataRow red = gridView1.GetFocusedDataRow();
            tBoxMaloai.Text = red["MALOAI"].ToString();
            tBoxTenLoai.Text = red["TENLOAI"].ToString();
            tBoxMaloai.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private int Execute(string _operator, ListLoaiVatTu _operand, ListLoaiVatTu oldstate)
        {
            Command command = new LoaiVTCommand(_operator, _operand, oldstate);
            int code = command.Execute();
            _commands.Push(command);
            return code;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            FocusRowChange();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tBoxMaloai.Enabled = true;
            tBoxTenLoai.Enabled = true;

            tBoxMaloai.Text = "";
            tBoxTenLoai.Text = "";
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            int noError = 0;
            string errors = "Nội dung bạn nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu.";
            if (tBoxMaloai.Text.Trim() == "")
            {
                
                errors += "\r\n+ Mã loại vật tư bị bỏ trống";
                noError++;
            }
            if (tBoxTenLoai.Text.Trim() == "")
            {
                
                errors += "\r\n+ Tên loại vật tư bị bỏ trống";
                noError++;
            }
            if (noError > 0)
            {
                MessageBox.Show(errors);
                btnLuu.Enabled = true;
                return;
            }

            DataRow red = gridView1.GetFocusedDataRow();
            ListLoaiVatTu LvtTrongBang = new ListLoaiVatTu { MALOAI = red["MALOAI"].ToString(), TENLOAI = red["TENLOAI"].ToString()};
            ListLoaiVatTu LvtTrongForm = new ListLoaiVatTu { MALOAI = tBoxMaloai.Text.Trim().ToUpper(), TENLOAI = tBoxTenLoai.Text.Trim().ToUpper() };


            if(tBoxMaloai.Enabled)
            {
                int code = Execute("insert", LvtTrongForm, LvtTrongBang);
                if (code == 0)
                {
                    btnReload.PerformClick();
                    MessageBox.Show("Them loai vat tu thanh cong");
                    btnUndo.Enabled = true;
                    //MessageBox.Show("Tạo môn học thành công");
                }
                else
                {
                    MessageBox.Show("Tạo loại vật tư thất bại");
                }
                tBoxMaloai.Enabled = false;
            }
            else
            {
                int code = Execute("update", LvtTrongForm, LvtTrongBang);
                if (code == 0)
                {
                    btnReload.PerformClick();
                   MessageBox.Show("Lưu loại vật tư thành công");
                    btnUndo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lưu loại vật tư thất bại");
                }
               
            }
            btnLuu.Enabled = true;
            
        }

        private void tBoxTenLoai_TextChanged(object sender, EventArgs e)
        {
            if(tBoxTenLoai.Text.Trim() == "")
            {
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadLoaiVT();
            btnLuu.Enabled = false;
            FocusRowChange();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(_commands.Count > 0)
            {
                btnUndo.Enabled = true;
                Command command = _commands.Pop();// go bỏ phần tử cuối cùn trong stack Command;
                int code = command.UnExecute();
                if(code == 0)
                {
                    btnReload.PerformClick();
                }
                else
                {
                    MessageBox.Show("Phục hồi thất bại");
                }
                if(_commands.Count == 0 || _commands.Count  < 0)
                {
                    btnUndo.Enabled = false;
                }
            }
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            tBoxTenLoai.Text = "";

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                btnXoa.Enabled = false;
                DataRow red = gridView1.GetFocusedDataRow();
                ListLoaiVatTu LvtTrongBang = new ListLoaiVatTu { MALOAI = red["MALOAI"].ToString(), TENLOAI = red["TENLOAI"].ToString() };
                ListLoaiVatTu LvtTrongForm = new ListLoaiVatTu { MALOAI = tBoxMaloai.Text.Trim().ToUpper(), TENLOAI = tBoxTenLoai.Text.Trim().ToUpper() };
                int code = Execute("delete", LvtTrongForm, LvtTrongBang);
                if (code == 0)
                {
                    //MessageBox.Show("Xoá thành công");
                    btnReload.PerformClick();
                    MessageBox.Show("Xoa thanh` cong");
                    btnUndo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("LOẠI VẬT TƯ NÀY ĐANG SỬ DỤNG .BẠN KHÔNG ĐƯỢC XÓA");
                }
                tBoxMaloai.Enabled = false;
                btnXoa.Enabled = true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}