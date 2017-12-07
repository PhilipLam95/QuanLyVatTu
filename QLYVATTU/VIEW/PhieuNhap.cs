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
using System.Data.SqlClient;
using QLYVATTU.LIST_ARRAY;

namespace QLYVATTU.VIEW
{
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
        }
        CT_PhieuNhap ctpn;
        public static int soluong_nay = 0;
        FrmMain f = Program.fmain;
        private static DataTable pnhap;
        private static SqlDataReader maphieu;
        DataTable chitietPN = new DataTable();
        List<ListPhieuNhap> cnnphieunhap = new List<ListPhieuNhap>();

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DS_CHITIET_PHIEUNHAP' table. You can move, or remove it, as needed.
            //this.sP_DS_CHITIET_PHIEUNHAPTableAdapter.Fill(this.qL_VATTUDataSet.SP_DS_CHITIET_PHIEUNHAP);
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.CHITIETPN' table. You can move, or remove it, as needed.
            //this.cHITIETPNTableAdapter.Fill(this.qL_VATTUDataSet.CHITIETPN);
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DS_PHIEUNHAP' table. You can move, or remove it, as needed.
            //this.sP_DS_PHIEUNHAPTableAdapter.Fill(this.qL_VATTUDataSet.SP_DS_PHIEUNHAP);
            gridViewChiTietPhieuNhapData();
            loadDonHang_ChuaNhap();
            load_DS_PhieuNhap();
            loadMaPN_TuDong();
            load_Chitiet_PN();

            Timer timer = new Timer();
            timer.Interval = (10 * 600); // 6 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loadDonHang_ChuaNhap();
            load_DS_PhieuNhap();
            loadMaPN_TuDong();
            load_Chitiet_PN();
        }




        private void gridViewChiTietPhieuNhapData()
        {

            chitietPN.Columns.Add("Mã Đơn Hàng", typeof(string));
            chitietPN.Columns.Add("Mã vật tư", typeof(string));
            chitietPN.Columns.Add("Tên vật tư", typeof(string));
            chitietPN.Columns.Add("Số lượng", typeof(int));
            chitietPN.Columns.Add("Đơn giá", typeof(decimal));
            chitietPN.Columns.Add("Đơn vị", typeof(string));
            chitietPN.Columns.Add("Xóa", typeof(bool));
            chitietPN.Columns[6].DefaultValue = false;

        }

        private void load_DS_PhieuNhap()
        {

            MDPhieuNhap phieunhap = new MDPhieuNhap();
            pnhap = phieunhap.getDS_PHIEUNHAP();
            sP_DS_PHIEUNHAPGridControl.DataSource = pnhap;
            sP_DS_PHIEUNHAPGridControl.DataMember = pnhap.TableName;
        }

        private void loadDonHang_ChuaNhap()
        {
            MDPhieuNhap phieunhap = new MDPhieuNhap();
            pnhap = phieunhap.getDS_DonDatHang_ChuaNhap();
            sP_DS_DONDATHANG_CHUANHAPGridControl.DataSource = pnhap;
            sP_DS_DONDATHANG_CHUANHAPGridControl.DataMember = pnhap.TableName;
        }

        private void loadMaPN_TuDong()
        {
            MDPhieuNhap phieunhap = new MDPhieuNhap();
            maphieu = phieunhap.getMaPhieuNhap_TuDong();
            maphieu.Read();
            label1.Text = maphieu["MAPN"].ToString();
            maphieu.Close();
        }

        private void load_Chitiet_PN()
        {
            //MDPhieuNhap phieunhap = new MDPhieuNhap();
            //pnhap = phieunhap.getChiTietPhieuNhap();
            //sP_DS_CHITIET_PHIEUNHAPGridControl.DataSource = pnhap;
            //sP_DS_CHITIET_PHIEUNHAPGridControl.DataMember = pnhap.TableName;

        }

        private void FocusedRowChanged_for_DDH_CHUANHAP()// lấy sự kiện click trong gridViewDDH_CHUANHAP load Data lên gridViewDDH_CHUANHAP
        {
            DataRow red = gridViewDDH_CHUANHAP.GetFocusedDataRow();
            if (red == null)
            {
                return;
            } 
            else
            { 
                EventHandleForBtnHuy();
                NgaylapDateEdit.Text = red["NGAY"].ToString();

                string MADDH = red["MADDH"].ToString();
                string[] param = { MADDH };

                MDPhieuNhap phieunhap = new MDPhieuNhap();
                pnhap = phieunhap.getChiTietDonDatHangTheoMa(param);
                sP_DS_CHITIET_DONDATHANG_THEOMAGridControl.DataSource = pnhap;
                sP_DS_CHITIET_DONDATHANG_THEOMAGridControl.DataMember = pnhap.TableName;
                if (label1.Text != "")
                {
                    loadMaPN_TuDong();
                }
            }
        }

        private void FocusedRowGetData()
        {
            DataRow read = gridView2.GetFocusedDataRow();
            if (read == null)
            {
                return;
            }
            else
            {
                madhTbox.Text = read["MADDH"].ToString();
                MavtTbox.Text = read["MAVT"].ToString();
                TenVTTbox.Text = read["TENVT"].ToString();
                DonviTbox.Text = read["DONVI"].ToString();
                mKhoTbox.Text = read["MAKHO"].ToString();
                SoluongTbox.Text = read["SOLUONG"].ToString();
                tEditGiaBanKH.Text =  read["DONGIA"].ToString();
                DongiaTbox.Text = "";

            }

        }

        private void FocusedRowGetData_gridViewChiTietPN()
        {
            DataRow read = gridViewChiTietPhieuNhap.GetFocusedDataRow();
            if (read == null)
            {
                return;
            }
            else
            {
                madhTbox.Text = read[0].ToString();
                MavtTbox.Text = read[1].ToString();
                TenVTTbox.Text = read[2].ToString();
                DonviTbox.Text = read[5].ToString();
                DongiaTbox.Text = read[4].ToString();
                SoluongTbox.Text = read[3].ToString();

            }
        }
        //---------------------------------------------GirdView click---------------------------------------------------------------------------------------
        private void gridView2_Click(object sender, EventArgs e)
        {
            FocusedRowGetData();
        }

        private void gridViewDDH_CHUANHAP_Click(object sender, EventArgs e)
        {
            FocusedRowChanged_for_DDH_CHUANHAP();
        }


        private void gridViewChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            FocusedRowGetData_gridViewChiTietPN();
        }
        //---------------------------------------------GirdView click---------------------------------------------------------------------------------------
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnBatDau_Click(object sender, EventArgs e)
        //{
        //    groupBox2.Visible = true;
        //    loadMaPN_TuDong();
        //    btnHuy.Visible = true;
        //    btnBatDau.Visible = false;
        //    btnChiTietPn.Enabled = true;


        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private bool CheckSoluongNhap(int soluong)
        {
            
            string mavt = MavtTbox.Text.ToString();// mat vat tu trong text box
            string tenvt = TenVTTbox.Text.ToString();
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (mavt == gridView2.GetRowCellValue(i, gridView2.Columns[2]).ToString())
                {
                    if (soluong > Int32.Parse(gridView2.GetRowCellValue(i, gridView2.Columns[1]).ToString()))
                    {
                        MessageBox.Show("Số lượng nhập của vật tư :" + "'" + tenvt.ToUpper() + "'" + " lớn hơn số lượng trong đơn hàng " + madhTbox.Text);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }

            }
            return true;
        }

        private bool CheckGiaNhap(decimal tong_gia_nhap)
        {
            string mavt = MavtTbox.Text.ToString();
            int soluongnhap = Convert.ToInt32(SoluongTbox.Text.ToString());
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (mavt == gridView2.GetRowCellValue(i, gridView2.Columns[2]).ToString())
                {
                    if (tong_gia_nhap > (Convert.ToDecimal(gridView2.GetRowCellValue(i, gridView2.Columns[6]).ToString()) * soluongnhap))// nếu tổng giá nhập trên số lượng sản phẩm đó  > tổng giá bán trên số lượng sản phẩm
                    {
                        DialogResult d = MessageBox.Show(" Tổng giả nhập trên số lượng sản phẩm này lớn hơn tổng giá bán. Bạn có chắc chắn mình nhập đúng Đơn giá nhập này ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (d == DialogResult.Yes)
                        {

                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                    else
                    {
                        return true;
                    }
                }

            }
            return true;
        }

        private void btnChiTietPn_Click(object sender, EventArgs e)
        {
            try
            {               
                bool maddh = f.CheckNullValueTextEdit(madhTbox);
                bool mavt = f.CheckNullValueTextEdit(MavtTbox);
                bool soluongnhap = f.CheckNullValue(SoluongTbox);
                bool dongia = f.CheckNullValue(DongiaTbox);

                if (maddh && mavt && soluongnhap && dongia) // check null value
                {
                    
                    int soluong = Int32.Parse(SoluongTbox.Text.ToString());
                    decimal tong_gianhap = Convert.ToDecimal(DongiaTbox.Text.ToString());
                    bool check_soluongnhap = CheckSoluongNhap(soluong);
                    bool check_dongia = CheckGiaNhap(tong_gianhap);
                    if (check_soluongnhap)// check so luong nhap so voi so luong trong don hang`
                    {
                        if (check_dongia)
                        {
                            
                            if (gridViewChiTietPhieuNhap.RowCount == 0)
                            {

                                chitietPN.Rows.Add(madhTbox.Text, MavtTbox.Text, TenVTTbox.Text, soluong, tong_gianhap, DonviTbox.Text);
                                gridControl1.DataSource = chitietPN;
                                gridControl1.DataBindings.Clear();

                            }
                            else
                            {
                                for (int j = 0; j < gridViewChiTietPhieuNhap.RowCount; j++)
                                {
                                    if (MavtTbox.Text.ToString() == (gridViewChiTietPhieuNhap.GetRowCellValue(j, gridViewChiTietPhieuNhap.Columns[1]).ToString()))
                                    {
                                        int soluong_truocdo_trongPN = Int32.Parse(gridViewChiTietPhieuNhap.GetRowCellValue(j, gridViewChiTietPhieuNhap.Columns[3]).ToString());// số lượng trước đó trong CT phiếu nhập
                                        //int soluong_lan2_cuaPN_theoVT = soluong + soluong_truocdo_trongPN;
                                        //bool check_nhaplan2_theoma = CheckSoluongNhapLan2TheoMa(soluong_lan2_cuaPN_theoVT);
                                     
                                            gridViewChiTietPhieuNhap.DeleteRow(j);
                                            chitietPN.Rows.Add(madhTbox.Text, MavtTbox.Text, TenVTTbox.Text, soluong, tong_gianhap, DonviTbox.Text);
                                            gridControl1.DataSource = chitietPN;
                                            gridControl1.DataBindings.Clear();
                                       
                                        break;
                                    }
                                    else
                                    {
                                        if (j == (gridViewChiTietPhieuNhap.RowCount - 1))
                                        {
                                            chitietPN.Rows.Add(madhTbox.Text, MavtTbox.Text, TenVTTbox.Text, soluong, tong_gianhap, DonviTbox.Text);
                                            gridControl1.DataSource = chitietPN;
                                            gridControl1.DataBindings.Clear();
                                            break;
                                        }

                                    }


                                }
                            }

                            for (int j = 0; j < 6; j++)
                            {
                                gridViewChiTietPhieuNhap.Columns[j].OptionsColumn.AllowEdit = false;
                                gridViewChiTietPhieuNhap.Columns[4].OptionsColumn.AllowEdit = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("co loi");
            }

        }


        //private bool CheckSoluongNhapLan2TheoMa(int soluong_lan2_cuaPN_theoVT)
        //{
        //    MessageBox.Show(soluong_lan2_cuaPN_theoVT.ToString());
        //    string mavt = MavtTbox.Text.ToString();
        //    for (int i = 0; i < gridView2.RowCount; i++)
        //    {

        //        if (mavt == gridView2.GetRowCellValue(i, gridView2.Columns[2]).ToString())
        //        {
        //            if (soluong_lan2_cuaPN_theoVT > Int32.Parse(gridView2.GetRowCellValue(i, gridView2.Columns[1]).ToString()))
        //            {
        //                MessageBox.Show("Sô lưong nhập sản phẩm này nhiều hơn số lương trong đơn hàng");
        //                return false;
        //            }
        //            else
        //            {
        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            if (i == (gridView2.RowCount - 1))
        //            {
        //                break;
        //            }
        //        }

        //    }
        //    return true;
        //}


        private void EventHandleForBtnHuy()
        {
            madhTbox.Text = "";
            MavtTbox.Text = "";
            TenVTTbox.Text = "";
            DonviTbox.Text = "";
            SoluongTbox.Text = "";
            mKhoTbox.Text = "";
            DongiaTbox.Text = "";
            NgaylapDateEdit.Text = "";
            tEditGiaBanKH.Text = "";
            btnChiTietPn.Enabled = false;
            sP_DS_CHITIET_DONDATHANG_THEOMAGridControl.DataSource = null;

            int i = 0;
            while(i < gridViewChiTietPhieuNhap.RowCount)
            {
                gridViewChiTietPhieuNhap.DeleteRow(i);
            }
            return;

        }


        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {

                int numberRow = gridViewChiTietPhieuNhap.RowCount;
                if (numberRow == 0)
                {
                    MessageBox.Show("Nhập chị tiết Phiếu Nhập của đơn hàng");
                    return;
                }
                for (int i = 0; i < numberRow; i++)
                {

                    string mapn = label1.Text.ToString();
                    string maddh = gridViewChiTietPhieuNhap.GetRowCellValue(i, gridViewChiTietPhieuNhap.Columns[0]).ToString();
                    string mavt = gridViewChiTietPhieuNhap.GetRowCellValue(i, gridViewChiTietPhieuNhap.Columns[1]).ToString();
                    string soluongnhap = gridViewChiTietPhieuNhap.GetRowCellValue(i, gridViewChiTietPhieuNhap.Columns[3]).ToString();
                    string maNV = Access.MANV.ToString();
                    string dongia_nhap = gridViewChiTietPhieuNhap.GetRowCellValue(i, gridViewChiTietPhieuNhap.Columns[4]).ToString();
                    string[] param = { mapn, maddh, mavt, maNV, soluongnhap, dongia_nhap };
                    MDPhieuNhap pnhap = new MDPhieuNhap();
                    int x = pnhap.CreatePhieuNhap(param);
                    if (x == 0 && i == (numberRow - 1))
                    {
                        MessageBox.Show("Thêm  Phiếu nhập : " + label1.Text + " thành công");
                        loadDonHang_ChuaNhap();
                        load_DS_PhieuNhap();
                        load_Chitiet_PN();
                        EventHandleForBtnHuy();
                    }
                   
                    
                }


            }
            catch
            {
                MessageBox.Show("Them DDH that bai");
            }
            EventHandleForBtnHuy();
        }

        private void SoluongTbox_TextChanged(object sender, EventArgs e)
        {
            if(SoluongTbox.Text != "" && DongiaTbox.Text !="")
            {
                btnChiTietPn.Enabled = true;
            }
            else
            {
                btnChiTietPn.Enabled = false;
            }
        }


        private void DongiaTbox_Leave(object sender, EventArgs e)
        {

            String Text = ((TextBox)sender).Text.Replace(",", "");
            int Num;
            if (int.TryParse(Text, out Num))
            {
                Text = String.Format("{0:N0}", Num);
                ((TextBox)sender).Text = Text;
            }
        }

        private void DongiaTbox_TextChanged_1(object sender, EventArgs e)
        {
            if (SoluongTbox.Text == "" || DongiaTbox.Text == "")
            {
                btnChiTietPn.Enabled = false;
            }
            else
            {
                btnChiTietPn.Enabled = true;
                TextBox t = (TextBox)sender;
                if (t.Tag != null && t.Tag.ToString() == "0") return;
                String Text = t.Text;
                int selStart = t.SelectionStart;
                //int commaCount_Before = 0;
                int commaCount_After = 0;
                //for (int i = 0; i < Text.Length; i++)
                //{
                //    if (Text.Substring(i, 1) == ",")
                //    {
                //        commaCount_Before++;
                //    }
                //}
                Decimal Num;
                Text = Text.Replace(",", "");
                if (Decimal.TryParse(Text, out Num))
                {
                    Text = String.Format("{0:N0}", Num);
                    t.Text = Text;
                }
                for (int i = 0; i < Text.Length; i++)
                {
                    if (Text.Substring(i, 1) == ",")
                    {
                        commaCount_After++;
                    }
                }
                int diff = (commaCount_After -1/*- commaCount_Before*/);
                if (diff >= 0)
                {
                    t.SelectionStart = selStart + (commaCount_After- 1/* - commaCount_Before*/);
                }

            }
        }

        private void gridViewChiTietPhieuNhap_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            
            DataRow red = gridViewChiTietPhieuNhap.GetFocusedDataRow();
            if (red == null)
            {
                return;
            }
            else
            {
                int soluong_update = Int32.Parse(red[3].ToString());
                bool check_soluongnhap = CheckSoluongNhap(soluong_update);
                if (!check_soluongnhap)
                {
                    gridViewChiTietPhieuNhap.SetRowCellValue(gridViewChiTietPhieuNhap.FocusedRowHandle, gridViewChiTietPhieuNhap.Columns[3], soluong_nay);
                    gridViewChiTietPhieuNhap.Columns[3].OptionsColumn.AllowEdit = false;
                }
            }                            
        }

        
        private void gridViewChiTietPhieuNhap_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            DataRow red = gridViewChiTietPhieuNhap.GetFocusedDataRow();
            if (red == null)
            {
                return;
            }
            else
            {
                soluong_nay = Int32.Parse(red[3].ToString());
                gridViewChiTietPhieuNhap.Columns[3].OptionsColumn.AllowEdit = true;

            }
           
            
        }

        private void gridViewChiTietPhieuNhap_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

        }

      

        private void gridViewChiTietPhieuNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataRow red = gridViewChiTietPhieuNhap.GetFocusedDataRow();
                int soluong_update = Int32.Parse(red[3].ToString());
                bool check_soluongnhap = CheckSoluongNhap(soluong_update);
                if (!check_soluongnhap)
                {
                    gridViewChiTietPhieuNhap.SetRowCellValue(gridViewChiTietPhieuNhap.FocusedRowHandle, gridViewChiTietPhieuNhap.Columns[3], soluong_nay);
                    gridViewChiTietPhieuNhap.Columns[3].OptionsColumn.AllowEdit = false;
                }
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow red = gridView1.GetFocusedDataRow();
             string ma_pn = red[2].ToString();
            
            if (ctpn == null)
            {
                ctpn = new CT_PhieuNhap();
                ctpn.Sender(ma_pn);    //Gọi delegate
                ctpn.Show();

            }
            else
            {
                ctpn.Hide();
                ctpn = new CT_PhieuNhap();
                ctpn.Activate();
                ctpn.Show();

                ctpn.Sender(ma_pn);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int y = gridViewChiTietPhieuNhap.RowCount;
            for (int i = 0; i < y; i++)
            {
                bool check = (bool)gridViewChiTietPhieuNhap.GetRowCellValue(i, gridViewChiTietPhieuNhap.Columns[6]); ;

                if (check)
                {
                    gridViewChiTietPhieuNhap.DeleteRow(i);
                    y--;
                    i = -1;

                }
            }
        }
    }
}
