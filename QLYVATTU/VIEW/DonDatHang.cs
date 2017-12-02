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
using QLYVATTU.LIST_ARRAY;
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
        private static DataTable vt;
        private static DataTable ddh;
        private DataTable kho;
        private DataTable nhacungcap;
        private SqlDataReader maDDH;
        private BindingList<list_DonDatHang> _DonDH;
        DataTable chitietDDH = new DataTable();
        List<list_Kho> cnnkho = new List<list_Kho>();
        List<list_Nhacungcap> cnnNhacungcap = new List<list_Nhacungcap>();
        // ADDD CoLumns vao datatable chitietDDH----------------------------------------------------------------------------------------------------------
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
        // ADDD CoLumns vao datatable chitietDDH----------------------------------------------------------------------------------------------------------



        // Cac function load khi moi bat dau mo page-----------------------------------------------------------------------------------------------
        private void load_nhacungcap()

        {
            DonDH dondh = new DonDH(); // goi toi model DonDH
            nhacungcap = dondh.getNhacungcap();  // goi function trong MODEL DonDH
            foreach (DataRow dr in nhacungcap.Rows) //doc tung gia tri vao Datarow
            {
                list_Nhacungcap cnhacungcap = new list_Nhacungcap() // dua vao array
                {
                    MaNCC = dr[0].ToString(),
                    TenNCC = dr[1].ToString(),
                    Diachi_NCC = dr[2].ToString(),
                    SDT_NCC = dr[3].ToString(),

                };
                cnnNhacungcap.Add(cnhacungcap); // add array vao cmd_Nhacungcap
            }

        }

        private void load_kho() // load kho
        {

            DonDH dondh = new DonDH();
            kho = dondh.getKho();
            foreach (DataRow dr in kho.Rows)
            {
                list_Kho ckho = new list_Kho() // dua gia tri datarow vao array cua ckkho
                {
                    MaKho = dr[0].ToString(),
                    TenKho = dr[1].ToString(),
                    MaCN = dr[2].ToString(),

                };
                cnnkho.Add(ckho); // add array vao mang  cnnkho
            }

        }

        private void loadVattu() // load vat tu 
        {
            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            sP_DS_VATTUGridControl.DataSource = vt;
            sP_DS_VATTUGridControl.DataMember = vt.TableName;
        }


        private void loadVatthTrongKho() // load vattu co ma kho va so luong trong kho
        {
            string[] param = { mAKHOComboBox.Text.ToString() };
            VatTu vattu = new VatTu();
            vt = vattu.getVatTuTrongKho(param);
            sP_DS_VATTU_TRONGKHOGridControl.DataSource = vt;
            sP_DS_VATTU_TRONGKHOGridControl.DataMember = vt.TableName;
        }

        private void loadDDH() // load don dat hang
        {
            DonDH dondh = new DonDH();
            ddh = dondh.getDonDatHang();
            sP_DS_DONDATHANGGridControl.DataSource = ddh;
            sP_DS_DONDATHANGGridControl.DataMember = ddh.TableName;

        }

        private void loadChiTiet_DDH() // load Chitiet DDH
        {
            DonDH dondh = new DonDH();
            ddh = dondh.getChiTietDonDatHang();
            sP_DS_CHITIET_DONDATHANGGridControl.DataSource = ddh;
            sP_DS_CHITIET_DONDATHANGGridControl.DataMember = ddh.TableName;
        }
        // Cac function load khi moi bat dau mo page-----------------------------------------------------------------------------------------------

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //--------------------------------------------------------------------------------------------------------------------------------
        private void DonDatHang_Load(object sender, EventArgs e)// ham load dau tien
        {
            

            load_kho();
            foreach (list_Kho ckho in cnnkho)
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

            foreach (list_Nhacungcap cnhacungcap in cnnNhacungcap.ToList())
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
            loadVatthTrongKho();
            loadDDH();
            loadChiTiet_DDH();
            label12.Text = "'"+mAKHOComboBox.Text.Trim()+"':";
        }
        //---------------------------------------------------------------------------------------------------------

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)// Them tạm vào gridview
        {

            try
            {

                bool soluongBool = f.CheckNullValue(tBoxSoluong);// check empty soluong
                bool mavattuBool = f.CheckNullValue(tBoxMavattu);// check empty mavattu
                bool tenvattuBool = f.CheckNullValue(tBoxTenvattu);// check empty tenvattu
                Console.WriteLine(gridView3.RowCount);
                if (soluongBool && mavattuBool && tenvattuBool) // true thi thuc hien
                {
                    for (int i = 0; i < gridView3.RowCount; i++)
                    {

                        string mavattu = gridView3.GetRowCellValue(i, gridView3.Columns[1]).ToString(); // lay gia tri mavattu theo tung row
                        string tenvattu = gridView3.GetRowCellValue(i, gridView3.Columns[2]).ToString();// lay gia tri tenvattu theo tung row
                        string soluong = gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString();// lay gia tri soluong theo tung row
                        string nhacungcap = gridView3.GetRowCellValue(i, gridView3.Columns[4]).ToString();// lay gia tri nhacungcap theo tung row

                        if (mavattu == tBoxMavattu.Text && tenvattu == tBoxTenvattu.Text) // neu cung gia tri trong text box
                        {
                            int x = Int32.Parse(gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString()) + Int32.Parse(tBoxSoluong.Text);// + so luong san phảm cung Mã vật tư trong gridview3 
                            gridView3.DeleteRow(i);// delete row trung mavattu 
                            chitietDDH.Rows.Add(labelDDH.Text, tBoxMavattu.Text, tBoxTenvattu.Text, x, cBoxNhaCC.SelectedItem, mAKHOComboBox.SelectedItem);//add lai row trong datatable
                            gridControl1.DataSource = chitietDDH;//dua datatable chitietDDH vao lai gridcontrol
                            gridControl1.DataBindings.Clear();// clear databinding
                            for (int j = 0; j < 6; j++)
                            {
                                gridView3.Columns[j].OptionsColumn.AllowEdit = false;// columns khong dc chinh sua gia tri
                                gridView3.Columns[3].OptionsColumn.AllowEdit = true;// columns duoc chinh sua gia tri
                            }

                            x = 0;// dua x ve 0
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
            tboxDonvi.Text = red["DONVI"].ToString();
            string makho = mAKHOComboBox.SelectedItem.ToString();
            for(int i = 0;i<gridView4.RowCount;i++)
            {
                Console.WriteLine(gridView4.GetRowCellValue(i, gridView4.Columns["MAVT"]).ToString());
                Console.WriteLine(gridView4.GetRowCellValue(i, gridView4.Columns["MAKHO"]).ToString());
                if (tBoxMavattu.Text.ToString() == gridView4.GetRowCellValue(i, gridView4.Columns[0]).ToString()
                    && mAKHOComboBox.SelectedItem.ToString() == gridView4.GetRowCellValue(i, gridView4.Columns[7]).ToString())
                {
                    tBoxSoluongKho.Text = gridView4.GetRowCellValue(i, gridView4.Columns[6]).ToString();
                    break;
                }
                else
                {
                    tBoxSoluongKho.Text = "0";
                }
            }
        }

        private void  FocusedRowChangeIngridView4() // doc gia tri tu gridview ra textbox
        {
            DataRow red = gridView4.GetFocusedDataRow();
            tBoxMavattu.Text = red["MAVT"].ToString();
            tBoxTenvattu.Text = red["TENVT"].ToString();
            tboxDonvi.Text = red["DONVI"].ToString();
            tBoxSoluongKho.Text = red["SOLUONGTON"].ToString();
           
        }

        private void gridView4_Click(object sender, EventArgs e) // bat su kien click de thuc hien fucntion FocusedRowChangeIngridView4()
        {
            FocusedRowChangeIngridView4();
            label12.Text = gridView4.GetRowCellValue(gridView4.FocusedRowHandle, gridView4.Columns["MAKHO"]).ToString();
        }

        private void gridViewVatTu_Click(object sender, EventArgs e) // bat su kien click de thuc hien fucntion FocusedRowChanged()
        {
            FocusedRowChanged();
            label12.Text = mAKHOComboBox.Text;
        }

        private void tBoxSoluong_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnThietLapDDH_Click(object sender, EventArgs e) // bat dau lap don dat hang tren kho va tu nha cung cap nao`
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

        private void EventHandleFor_btnHUY() // SAU khi dat hang thanh` cong hay thuc hien btnHuy()
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

        private void btnDonHang_Click(object sender, EventArgs e) // Lap don hang` 
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
                    if (x == 0 && i == (numberRow - 1)) // vong lap cuoi cung x =0 
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
            foreach (list_Kho ckho in cnnkho)
            {

                if (mAKHOComboBox.Text == ckho.MaKho)
                {
                    tENKHOComboBox.Text = ckho.TenKho;
                }
            }
        }

        private void tENKHOComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (list_Kho ckho in cnnkho)
            {
                if (tENKHOComboBox.Text == ckho.TenKho)
                {
                    mAKHOComboBox.Text = ckho.MaKho;
                    label12.Text = ckho.MaKho;
                }

            }
            loadVatthTrongKho();
            load_soluongTrongKhoTheoCompoBox();


        }


        private void load_soluongTrongKhoTheoCompoBox()// load lai soluongKhoTbox theo compobox
        {
            
            if (tBoxMavattu.Text != "")
            {
                for (int i = 0; i < gridView4.RowCount; i++)
                {

                    if (tBoxMavattu.Text.ToString() == gridView4.GetRowCellValue(i, gridView4.Columns[0]).ToString()
                        && mAKHOComboBox.SelectedItem.ToString() == gridView4.GetRowCellValue(i, gridView4.Columns[7]).ToString())
                    {
                        tBoxSoluongKho.Text = gridView4.GetRowCellValue(i, gridView4.Columns[6]).ToString();
                        break;
                    }
                    else
                    {
                        tBoxSoluongKho.Text = "0";
                    }
                }
            }
            else
            {
                return;
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
            foreach (list_Nhacungcap cnhacungcap in cnnNhacungcap)
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
            int y = gridView3.RowCount;
            for (int i = 0; i < y; i++)
            {
                bool check = (bool)gridView3.GetRowCellValue(i, gridView3.Columns[6]); ;

                if (check)
                {
                    gridView3.DeleteRow(i);
                    y--;
                    i = -1;
                    
                }
            }




        }

        private void gridViewVatTu_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyData ==Keys.Enter)
            //{

            //}
        }

        
    }
}