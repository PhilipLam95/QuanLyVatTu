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
using QLYVATTU.CMD;
using DevExpress.XtraEditors;
using System.Data.SqlClient;



namespace QLYVATTU.VIEW
{
    public partial class DonDatHang : Form
    {
        public DonDatHang()
        {
            InitializeComponent();
        }


        FrmMain f = Program.fmain; // gọi form chính để lấy function trong form
        private DataTable vt;
        private static DataTable ddh;
        private DataTable kho;
        private DataTable nhacungcap;
        private SqlDataReader maDDH;
        private BindingList<cmd_DonDatHang> _DonDH;
        DataTable chitietDDH = new DataTable();
        List<cmd_Kho> cnnkho = new List<cmd_Kho>();
        List<cmd_Nhacungcap> cnnNhacungcap = new List<cmd_Nhacungcap>();

        private void gridVIEWData()
        {

            chitietDDH.Columns.Add("Mã Đơn Đặt Hàng", typeof(string));
            chitietDDH.Columns.Add("Mã Vât Tư", typeof(string));
            chitietDDH.Columns.Add("Tên Vật Tư", typeof(string));
            chitietDDH.Columns.Add("Số lượng", typeof(int));
            chitietDDH.Columns.Add("Nhà cung cấp", typeof(string));
            chitietDDH.Columns.Add("Mã kho", typeof(string));
            chitietDDH.Columns.Add("Xóa", typeof(bool));
            chitietDDH.Columns[6].DefaultValue = false;
        }

        private void load_nhacungcap()

        {
            DonDH dondh = new DonDH();
            nhacungcap = dondh.getNhacungcap();
            foreach (DataRow dr in nhacungcap.Rows)
            {
                cmd_Nhacungcap cnhacungcap = new cmd_Nhacungcap()
                {
                    MaNCC = dr[0].ToString(),
                    TenNCC = dr[1].ToString(),
                    Diachi_NCC = dr[2].ToString(),
                    SDT_NCC = dr[3].ToString(),

                };
                cnnNhacungcap.Add(cnhacungcap);
            }

        }

        private void load_kho()
        {

            DonDH dondh = new DonDH();
            kho = dondh.getKho();
            foreach (DataRow dr in kho.Rows)
            {
                cmd_Kho ckho = new cmd_Kho()
                {
                    MaKho = dr[0].ToString(),
                    TenKho = dr[1].ToString(),
                    MaCN = dr[2].ToString(),

                };
                cnnkho.Add(ckho);
            }

        }

        private void loadVattu()
        {
            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            sP_DS_VATTUGridControl.DataSource = vt;
            sP_DS_VATTUGridControl.DataMember = vt.TableName;
        }

        private void loadDDH()
        {
            DonDH dondh = new DonDH();
            ddh = dondh.getDonDatHang();
            sP_DS_DONDATHANGGridControl.DataSource = ddh;
            sP_DS_DONDATHANGGridControl.DataMember = ddh.TableName;

        }

        private void loadChiTiet_DDH()
        {
            DonDH dondh = new DonDH();
            ddh = dondh.getChiTietDonDatHang();
            sP_DS_CHITIET_DONDATHANGGridControl.DataSource = ddh;
            sP_DS_CHITIET_DONDATHANGGridControl.DataMember = ddh.TableName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DS_CHITIET_DONDATHANG' table. You can move, or remove it, as needed.
            //this.sP_DS_CHITIET_DONDATHANGTableAdapter.Fill(this.qL_VATTUDataSet.SP_DS_CHITIET_DONDATHANG);


            load_kho();
            foreach (cmd_Kho ckho in cnnkho)
            {
                mAKHOComboBox.Items.Add(ckho.MaKho);
                tENKHOComboBox.Items.Add(ckho.TenKho);
            }
            mAKHOComboBox.SelectedIndex = 0;
            tENKHOComboBox.SelectedIndex = 0;


            load_nhacungcap();
            Console.WriteLine(cnnNhacungcap);

            String[] array = cnnNhacungcap.Select(I => Convert.ToString(cnnNhacungcap)).ToArray();
            Console.WriteLine(array);

            foreach (cmd_Nhacungcap cnhacungcap in cnnNhacungcap.ToList())
            {

                cBoxNhaCC.Items.Add(cnhacungcap.MaNCC);
                if (cnnNhacungcap.Count > 0)
                {
                    label10.Text = cnnNhacungcap[0].SDT_NCC;
                    rTboxDiachiNCC.Text = cnnNhacungcap[0].Diachi_NCC;
                    label8.Text = cnnNhacungcap[0].TenNCC;
                }
            }
            cBoxNhaCC.SelectedIndex = 0;




            gridVIEWData();
            gridControl1.DataSource = chitietDDH;
            gridControl1.DataBindings.Clear();
            loadVattu();
            loadDDH();
            loadChiTiet_DDH();

        }


        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {

                bool soluongBool = f.CheckNullValue(tBoxSoluong);
                bool mavattuBool = f.CheckNullValue(tBoxMavattu);
                bool tenvattuBool = f.CheckNullValue(tBoxTenvattu);
                Console.WriteLine(gridView3.RowCount);
                if (soluongBool && mavattuBool && tenvattuBool)
                {
                    for (int i = 0; i < gridView3.RowCount; i++)
                    {

                        string mavattu = gridView3.GetRowCellValue(i, gridView3.Columns[1]).ToString();
                        string tenvattu = gridView3.GetRowCellValue(i, gridView3.Columns[2]).ToString();
                        string soluong = gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString();
                        string nhacungcap = gridView3.GetRowCellValue(i, gridView3.Columns[4]).ToString();

                        if (mavattu == tBoxMavattu.Text && tenvattu == tBoxTenvattu.Text)
                        {
                            int x = Int32.Parse(gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString()) + Int32.Parse(tBoxSoluong.Text);
                            gridView3.DeleteRow(i);
                            chitietDDH.Rows.Add(labelDDH.Text, tBoxMavattu.Text, tBoxTenvattu.Text, x, cBoxNhaCC.SelectedItem, mAKHOComboBox.SelectedItem);
                            gridControl1.DataSource = chitietDDH;
                            gridControl1.DataBindings.Clear();
                            for (int j = 0; j < 6; j++)
                            {
                                gridView3.Columns[j].OptionsColumn.AllowEdit = false;
                                gridView3.Columns[3].OptionsColumn.AllowEdit = true;
                            }

                            x = 0;
                            return;
                        }
                    }
                    chitietDDH.Rows.Add(labelDDH.Text, tBoxMavattu.Text, tBoxTenvattu.Text, tBoxSoluong.Text, cBoxNhaCC.SelectedItem, mAKHOComboBox.SelectedItem);
                    gridControl1.DataSource = chitietDDH;
                    gridControl1.DataBindings.Clear();
                    for (int j = 0; j < 6; j++)
                    {
                        gridView3.Columns[j].OptionsColumn.AllowEdit = false;
                        gridView3.Columns[3].OptionsColumn.AllowEdit = true;
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Mời bạn nhập giá trị");


            }



        }

        private void FocusedRowChanged()
        {
            DataRow red = gridViewVatTu.GetFocusedDataRow();
            tBoxMavattu.Text = red["MAVT"].ToString();
            tBoxTenvattu.Text = red["TENVT"].ToString();
            tBoxSoluongKho.Text = red["SOLUONGTON"].ToString();
            tboxDonvi.Text = red["DONVI"].ToString();
        }

        private void gridViewVatTu_Click(object sender, EventArgs e)
        {
            FocusedRowChanged();
        }

        private void tBoxSoluong_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnThietLapDDH_Click(object sender, EventArgs e)
        {
            bool makho = f.CheckNullValueCBox(mAKHOComboBox);
            bool tenkho = f.CheckNullValueCBox(tENKHOComboBox);
            bool nhacc = f.CheckNullValueCBox(cBoxNhaCC);
            if (makho && tenkho && nhacc)
            {
                tBoxSoluong.Enabled = true;
                btnThem.Enabled = true;
                cBoxNhaCC.Enabled = false;
                mAKHOComboBox.Enabled = false;
                tENKHOComboBox.Enabled = false;
                btnThietLapDDH.Visible = false;
                btnHuy.Visible = true;
                gridView3.OptionsBehavior.Editable = true;


                DonDH dondh = new DonDH();
                maDDH = dondh.getMaDDH();
                maDDH.Read();
                labelDDH.Text = maDDH["MADDH"].ToString();
                maDDH.Close();
            }


        }

        private void EventHandleFor_btnHUY()
        {
            gridControl1.DataSource = null;
            mAKHOComboBox.Enabled = true;
            tENKHOComboBox.Enabled = true;
            cBoxNhaCC.Enabled = true;
            btnThietLapDDH.Visible = true;
            gridView3.Columns.Clear();
            chitietDDH.Clear();

            btnHuy.Visible = false;
            gridView3.OptionsBehavior.Editable = false;
            tBoxMavattu.Text = "";
            labelDDH.Text = "";
            tBoxTenvattu.Text = "";
            tBoxSoluong.Text = "";
            tBoxSoluong.Enabled = false;
            tboxDonvi.Text = "";
            tBoxSoluongKho.Text = "";
            btnThem.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            EventHandleFor_btnHUY();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            try
            {

                int numberRow = gridView3.RowCount;
                if (numberRow == 0)
                {
                    MessageBox.Show("Nhập chị tiết đơn hàng của bạn");
                    return;
                }
                for (int i = 0; i < numberRow; i++)
                {

                    string maddh = labelDDH.Text.ToString();
                    string mavt = gridView3.GetRowCellValue(i, gridView3.Columns[1]).ToString();
                    string soluong = gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString();
                    string maNV = Access.MANV.ToString();
                    string nhacc = gridView3.GetRowCellValue(i, gridView3.Columns[4]).ToString();
                    string makho = gridView3.GetRowCellValue(i, gridView3.Columns[5]).ToString();
                    string[] param = { maddh, mavt, soluong, maNV, makho, nhacc };
                    DonDH dondh = new DonDH();
                    int x = dondh.Create_DonHang(param);
                    if (x == 0 && i == (numberRow - 1))
                    {
                        MessageBox.Show("Thêm Đơn đặt hàng " + labelDDH.Text + " thành công");
                        loadDDH();
                        loadChiTiet_DDH();
                        EventHandleFor_btnHUY();
                    }
                }


            }
            catch
            {
                MessageBox.Show("Them DDH that bai");
            }
        }

        private void mAKHOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (cmd_Kho ckho in cnnkho)
            {

                if (mAKHOComboBox.Text == ckho.MaKho)
                {
                    tENKHOComboBox.Text = ckho.TenKho;
                }
            }
        }

        private void tENKHOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (cmd_Kho ckho in cnnkho)
            {
                if (tENKHOComboBox.Text == ckho.TenKho)
                {
                    mAKHOComboBox.Text = ckho.MaKho;
                }

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxNhaCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (cmd_Nhacungcap cnhacungcap in cnnNhacungcap)
            {
                for (int i = 0; i < cnnNhacungcap.Count; i++)
                {
                    if (cBoxNhaCC.Text == cnnNhacungcap[i].MaNCC)
                    {
                        label10.Text = cnnNhacungcap[i].SDT_NCC;
                        rTboxDiachiNCC.Text = cnnNhacungcap[i].Diachi_NCC;
                        label8.Text = cnnNhacungcap[i].TenNCC;
                    }
                }


            }


        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView3.RowCount; i++)
            {
                var check = gridView3.GetRowCellValue(i, gridView3.Columns[6]).ToString(); ;

                if (check == "True")
                {
                    gridView3.DeleteRow(i);
                }



            }




        }


    }
}