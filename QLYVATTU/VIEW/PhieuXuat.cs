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
using DevExpress.XtraGrid;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QLYVATTU.VIEW
{
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
        }

        private DataTable hd;
        private DataTable kh;
        private DataTable vt;
        private DataTable kho;
        private string maKH = ""; //lưu mã khách hàng để add vào phiếu xuất
        private string maVT = ""; //lay ma vat tu khi click vao de add vao chi tiet hoa don
        private string maPX = ""; //tao phieu xuat, luu ma phieu xuat de huy phieu,
        private int soVT; //so luong vat tu cho vao phieu xuat
        private int soVTKho; //số vật tư còn trong kho để so sánh với số vt xuất
        private string giaVT;
        DataTable chiTietPX = new DataTable();

        FrmMain f = Program.fmain;
        //xây dụng hàm kiểm tra chuỗi nhập có phải số kg, true là số
        private bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        //phuong thuc dinh nghia cot gv
        private void gridViewChiTietPX()
        {
            chiTietPX.Columns.Add("Mã Vật Tư", typeof(string));
            chiTietPX.Columns.Add("Tên Vật Tư", typeof(string));
            chiTietPX.Columns.Add("Số lượng", typeof(int));
            chiTietPX.Columns.Add("Đơn Giá", typeof(string));
            //chiTietPX.Columns.Add("Xóa", typeof(Int32));
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DS_KHO' table. You can move, or remove it, as needed.
            //this.sP_DS_KHOTableAdapter.Fill(this.qL_VATTUDataSet.SP_DS_KHO);
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DSVT_PHIEUXUAT' table. You can move, or remove it, as needed.
            //this.sP_DSVT_PHIEUXUATTableAdapter.Fill(this.qL_VATTUDataSet.SP_DSVT_PHIEUXUAT);
            
            KhachHang khachhang = new KhachHang();
            kh = khachhang.getKhachHang();
            gvKH.DataSource = kh;
            gvKH.DataMember = kh.TableName;
            //sP_TIMKIEM_KHACHHANGGridControl.DataSource = kh;  //thay datasource thàng gridview
            //sP_TIMKIEM_KHACHHANGGridControl.DataMember = kh.TableName;


            HoaDon hoadon = new HoaDon();
            hd = hoadon.getHoaDon();
            gvDSPX.DataSource = hd;
            gvDSPX.DataMember = hd.TableName;

            //do ten kho vao combobox
            kho = hoadon.getKho();
            cb_DSKho.Items.Clear();
            foreach (DataRow dr in kho.Rows)
            {
                cb_DSKho.Items.Add(dr["TENKHO"]);
                //cb_DSKho.ValueMember = "MAKHO";
                //MessageBox.Show(dr["MAKHO"].ToString());
            }
            cb_DSKho.SelectedIndex = -1;

            gridViewChiTietPX();
            
            //NHẬN SỰ KIỆN CLICK ĐỂ LẤY MÃ KHO MỚI LOAD DANH SÁCH VẬT TƯ TRONG KHO
            //VatTu vattu = new VatTu();
            //vt = vattu.getVatTu();
            //gvVatTu.DataSource = vt;
            //gvVatTu.DataMember = vt.TableName;
            lbMaKH.Hide();  //label lay ma khach hang khi lay ma tu dong hoac click chuot kh co san
        }

        private void sP_DANHSACHPHIEUXUATGridControl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void hotenTbox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.sP_CHITIETHDTableAdapter.Fill(this.qL_VATTUDataSet.SP_CHITIETHD, mAPXToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
               // this.sP_CHITIETHDTableAdapter.Fill(this.qL_VATTUDataSet.SP_CHITIETHD, mAPXToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cb_DSKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenKho = cb_DSKho.SelectedItem.ToString();
            HoaDon hoaDon = new HoaDon();
            string[] param = { tenKho };
            try
            {
                DataTable ctKho = hoaDon.getChiTietKho(param);
                gvVatTu.DataSource = ctKho;
                gvVatTu.DataMember = ctKho.TableName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tương tác CSDL! "+ex.ToString());
            }
        }

        private void gvKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow red = gridView2.GetFocusedDataRow();
            //MessageBox.Show(red["Họ Tên"].ToString());
            maKH = red["Mã Khách Hàng"].ToString();
            lbMaKH.Text = maKH;
            tbTenKH.Text = red["Họ tên"].ToString();
            tbSDT.Text = red["Số Điện Thoại"].ToString();
            tbDiaChi.Text = red["Địa Chỉ"].ToString();

            //mếu chọn khách hàng có sẵn thì cho readonly -> kg cho sửa
            tbTenKH.Enabled = false;
            tbSDT.Enabled = false;
            tbDiaChi.Enabled = false;
            btTaoKH.Enabled = false;
            //btHuyPX.Enabled = true;
        }

        private void gvVT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow vattu = gridView4.GetFocusedDataRow();
            maVT = vattu["Mã Vật Tư"].ToString();
            //MessageBox.Show(""+maVT+"*");
            tbTenVT.Text = vattu["Tên Vật Tư"].ToString();
            lbDonViTinh.Text = vattu["Đơn Vị Tính"].ToString();
            soVTKho = Convert.ToInt32(vattu["Số Lượng Tồn"]);
            giaVT = vattu["Đơn Giá VT"].ToString();
        }

        private void btTaoPX_Click(object sender, EventArgs e)  //kg can
        {
            //string tenKH = tbTenKH.Text;
            //string soDT = tbSDT.Text;
            //string diaChi = tbDiaChi.Text;
            //if (tenKH == "" || soDT == "" || diaChi == "")
            //{
            //    MessageBox.Show("Vui Lòng Chọn Khách Hàng Hoặc Điền Thông Tin Đầy Đủ!");
            //}
            //else if (maKH == "")
            //{
            //    MessageBox.Show("Vui Lòng Nhấn 'Tạo Khách Hàng Mới' Để Tiếp Tục!");
            //}
            //else
            //{
            //    if (cb_DSKho.SelectedIndex == -1)
            //    {
            //        MessageBox.Show("Vui Lòng Chọn Kho Để Xuất Hàng!");
            //    }
            //}
        }

        private void btTaoKH_Click(object sender, EventArgs e)
        {
            string tenKH = tbTenKH.Text;
            string soDT = tbSDT.Text;
            string diaChi = tbDiaChi.Text;
            if (tenKH == "" || soDT == "" || diaChi == "")
            {
                MessageBox.Show("Vui Lòng Chọn Khách Hàng Hoặc Điền Thông Tin Đầy Đủ!");
            }
            else if (IsNumber(soDT) == false || soDT.Length > 11 || soDT.Length < 10)
            {
                MessageBox.Show("Số Điện Thoại Chưa Đúng ĐỊnh Dạng!");
            }
            else
            {
                SqlDataReader maKhachHang;
                KhachHang khachhang = new KhachHang();
                //tạo 1 mã khách hàng mới
                maKhachHang = khachhang.getMaKhachHang();
                maKhachHang.Read();
                maKH = maKhachHang["MAKH"].ToString();
                maKhachHang.Close();
                //truyền mã thêm khách hàng mới
                string[] param = { maKH, tenKH, soDT, diaChi };
                int result = khachhang.taoKhachHang(param);
                if (result == 0)
                {
                    MessageBox.Show("Đã Tạo Khách hàng Thành Công!");
                    kh = khachhang.getKhachHang();
                    gvKH.DataSource = kh;
                    gvKH.DataMember = kh.TableName;
                }
                else
                {
                    MessageBox.Show("Tạo Khách Hàng Lỗi!");
                }
            }
        }

        private void btThemPX_Click(object sender, EventArgs e)
        {
            ////--------xét điều kiện thêm vào chi tiết phiếu xuất----------//
            if(IsNumber(tbSLVT.Text) == false){
                MessageBox.Show("Số Lượng Vật Tư Xuất Phải Là Số!");
            }
            else
            {
                try
                {
                    bool tenVT = f.CheckNullValue(tbTenVT);
                    bool soLuong = f.CheckNullValue(tbSLVT);

                    if (tenVT && soLuong)
                    {
                        for (int i = 0; i < gridView3.RowCount; i++)
                        {

                            string maVatTu = gridView3.GetRowCellValue(i, gridView3.Columns[0]).ToString();
                            string tenVatTu = gridView3.GetRowCellValue(i, gridView3.Columns[1]).ToString();
                            //string soluong = gridView3.GetRowCellValue(i, gridView3.Columns[2]).ToString();
                            //string giaVatTu = gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString();

                            if (maVatTu == maVT && tenVatTu == tbTenVT.Text)
                            {
                                int tempSL = Int32.Parse(gridView3.GetRowCellValue(i, gridView3.Columns[2]).ToString()) + Int32.Parse(tbSLVT.Text);
                                //MessageBox.Show(tempSL.ToString());
                                if (tempSL > soVTKho)
                                {
                                    MessageBox.Show("Số Vật Tư Cần Xuất Quá Số Lượng Vật Tư trong Kho!");
                                    return;
                                }
                                else
                                {
                                    gridView3.DeleteRow(i);
                                    //chiTietPX.Rows[i].Delete();
                                    chiTietPX.Rows.Add(maVT, tbTenVT.Text, tempSL, giaVT);
                                    gvChiTietHD.DataSource = chiTietPX;
                                    gvChiTietHD.DataBindings.Clear();
                                    tempSL = 0;
                                    return;
                                }
                            }
                        }
                        if ((Convert.ToInt32(tbSLVT.Text)) > soVTKho)
                        {
                            MessageBox.Show("Số Vật Tư Cần Xuất Quá Số Lượng Vật Tư trong Kho!");
                            return;
                        }
                        else
                        {
                             chiTietPX.Rows.Add(maVT, tbTenVT.Text, tbSLVT.Text, giaVT);
                             gvChiTietHD.DataSource = chiTietPX;
                             gvChiTietHD.DataBindings.Clear();
                             return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai " + ex);

                }  
            }
               
        }

        private void btLapPX_Click(object sender, EventArgs e)
        {
            string tenKH = tbTenKH.Text;
            string soDT = tbSDT.Text;
            string diaChi = tbDiaChi.Text;
            if (tenKH == "" || soDT == "" || diaChi == "")
            {
                MessageBox.Show("Vui Lòng Chọn Khách Hàng Hoặc Điền Thông Tin Đầy Đủ!");
            }
            else if (maKH == "")
            {
                MessageBox.Show("Vui Lòng Nhấn 'Tạo Khách Hàng Mới' Để Tiếp Tục!");
            }
            else
            {
                if (cb_DSKho.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui Lòng Chọn Kho Để Xuất Hàng!");
                }
            }
        }

        private void btHuyKH_Click(object sender, EventArgs e)
        {
            tbTenKH.Enabled = true;
            tbSDT.Enabled = true;
            tbDiaChi.Enabled = true;
            tbTenKH.Text = "";
            tbSDT.Text = "";
            tbDiaChi.Text = "";
            btTaoKH.Enabled = true;
        }
      
    }
}
