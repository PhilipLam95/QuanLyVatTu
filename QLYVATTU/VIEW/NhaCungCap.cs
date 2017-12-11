using QLYVATTU.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYVATTU.VIEW
{
    public partial class NhaCungCap : Form
    {
        private DataTable nhaCC;
        private DataTable vatTu;
        private DataTable ctNCC;
        private String maNCC = "";  //ma chi nhanh null co nghi la tao chi nhanh moi, nêu khac thi cap nhat
        private String maVT = "";
        private String maLoai = "";
        private String tenVT = "";
        private String donVi = "";
        private int index = 0; // chua cho nha cung cap
        DataTable ChiTietNCC = new DataTable();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void LoadLaiNCC()
        {
            tbTenNCC.Text = "";
            tbSDT.Text = "";
            tbDiaChi.Text = "";
            tbTenNCC.ReadOnly = false;
            tbSDT.ReadOnly = false;
            tbDiaChi.ReadOnly = false;
            tbTenVT.Text = "";

            tbTenVT.ReadOnly = true;
            MDNhaCungCap nhaCungCap = new MDNhaCungCap();
            nhaCC = nhaCungCap.getDSNCC();
            grvNCC.DataSource = nhaCC;
            grvNCC.DataMember = nhaCC.TableName;

            //danh sach vat tu
            VatTu vt = new VatTu();
            vatTu = vt.getVatTu();
            grvDSVT.DataSource = vatTu;
            grvDSVT.DataMember = vatTu.TableName;
        }

        private void GrvChiTietNCC()
        {
            ChiTietNCC.Columns.Add("Mã Vật Tư", typeof(string));
            ChiTietNCC.Columns.Add("Tên Vật Tư", typeof(string));
            ChiTietNCC.Columns.Add("Mã Loại", typeof(string));
            ChiTietNCC.Columns.Add("Đơn Vị", typeof(string));
            ChiTietNCC.Columns.Add("Xóa", typeof(bool));
            ChiTietNCC.Columns[4].DefaultValue = false;
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            tbTenVT.ReadOnly = true;
            MDNhaCungCap nhaCungCap = new MDNhaCungCap();
            nhaCC = nhaCungCap.getDSNCC();
            grvNCC.DataSource = nhaCC;
            grvNCC.DataMember = nhaCC.TableName;

            //danh sach vat tu
            VatTu vt = new VatTu();
            vatTu = vt.getVatTu();
            grvDSVT.DataSource = vatTu;
            grvDSVT.DataMember = vatTu.TableName;

            GrvChiTietNCC();
        }

        private void DSNCC_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow row = gridView1.GetFocusedDataRow();
            maNCC = row[0].ToString();

            tbTenNCC.Text = row[1].ToString();
            tbTenNCC.ReadOnly = true;
            tbSDT.Text = row[3].ToString();
            tbSDT.ReadOnly = true;
            tbDiaChi.Text = row[2].ToString();
            tbDiaChi.ReadOnly = true;
            //MessageBox.Show(maNCC);
            string[] param = { maNCC };
            MDNhaCungCap ncc = new MDNhaCungCap();
            ctNCC = ncc.getCTNCC(param);
            //grvCTNCC.DataSource = ctNCC;
            //grvCTNCC.DataMember = ctNCC.TableName;
            ChiTietNCC.Clear();
            foreach (DataRow ct in ctNCC.Rows)
            {
                
                ChiTietNCC.Rows.Add(ct[0], ct[1], ct[2], ct[3]);
                grvCTNCC.DataSource = ChiTietNCC;
                grvCTNCC.DataBindings.Clear();
            }
            btTaoNCC.Text = "Cập Nhật NCC";
        }

        private void VatTu_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (tbTenNCC.Text == "" && tbSDT.Text == "" && tbDiaChi.Text == "")
                MessageBox.Show("Bạn Chưa Điền Thông Tin Nhà Vật Tư Hoặc Chọn Nhà Cung Cấp Để Cập Nhật!", "Thông Báo");
            else
            {
                DataRow row = gridView3.GetFocusedDataRow();
                maVT = row[0].ToString();
                tbTenVT.Text = row[1].ToString();
                tenVT = row[1].ToString();
                maLoai = row[2].ToString();
                donVi = row[4].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                string mavattu = gridView2.GetRowCellValue(i, gridView2.Columns[0]).ToString();
                if (mavattu == maVT)
                {
                    MessageBox.Show("Nhà Cung Cấp Đã Có Vật Tư Này!");
                    return;
                }
            }
            //ChiTietNCC.NewRow();
            ChiTietNCC.Rows.Add(maVT, tenVT, maLoai, donVi);
            grvCTNCC.DataSource = ChiTietNCC;
            grvCTNCC.DataBindings.Clear();
            return;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int i = 0, z = 0;
            int y = gridView2.RowCount;
            for (i = 0; i < y; i++)
            {
                bool check = (bool)gridView2.GetRowCellValue(i, gridView2.Columns[4]);
                if (check)
                {
                    gridView2.DeleteRow(i);
                    y--;
                    i = -1;
                }
            }
            //grvCTNCC.DataBindings.Clear();
            //foreach (DataRow ct in ChiTietNCC.Rows)
            //{
            //    ct.Delete();
            //    if (ct != null) continue;
            //}
            //ChiTietNCC.Clear();
            //gan lai du lieu vao datatable
            //for (z = 0; z < gridView2.RowCount; z++)
            //{
            //    ChiTietNCC.Rows.Add(gridView2.Columns[0], gridView2.Columns[1], gridView2.Columns[2], gridView2.Columns[3]);
            //}
        }

        private void btTaoNCC_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                SqlDataReader ma;
                MDNhaCungCap ncc = new MDNhaCungCap();
                ma = ncc.GetMaNCC();
                ma.Read();
                maNCC = ma["MANCC"].ToString();
                ma.Close();
                string tenNCC = tbTenNCC.Text;
                string sdt = tbSDT.Text;
                string diachi = tbDiaChi.Text;
                if(!IsNumber(sdt))
                    MessageBox.Show("Số Điện Thoại Phải Là Số!");
                else{
                    try
                {
                    for(int i = 0; i < gridView2.RowCount; i++)
                    {
                        string vt = gridView2.GetRowCellValue(i, gridView2.Columns[0]).ToString();
                        string[] param = { maNCC, tenNCC, diachi, sdt, vt };
                        MDNhaCungCap nhacc = new MDNhaCungCap();
                        int x = nhacc.CreateNCC(param);
                        if (x == 0 && i == gridView2.RowCount - 1) 
                        {
                            MessageBox.Show("Bạn Đã Thêm Nhà Cung Cấp Thành Công!");
                            ChiTietNCC.Clear();
                            LoadLaiNCC();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.ToString());
                }
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            index = 0;
            LoadLaiNCC();
            ChiTietNCC.Clear();
            maNCC = "";
            maVT = "";
            btTaoNCC.Text = "Tạo Nhà Cung Cấp";
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }
    }
}
