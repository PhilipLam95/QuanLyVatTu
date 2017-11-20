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
        

        private DataTable vt;
        private DataTable ddh;
        private SqlDataReader maDDH;
        private BindingList<cmd_DonDatHang> _DonDH;
        DataTable chitietDDH = new DataTable();
        private void gridVIEWData()
        {
            chitietDDH.Columns.Add("MaDDH", typeof(string));
            chitietDDH.Columns.Add("MaVT", typeof(string));
            chitietDDH.Columns.Add("TenVT", typeof(string));
            chitietDDH.Columns.Add("Soluong", typeof(int));
            chitietDDH.Columns.Add("NhaCC", typeof(string));
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DonDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DS_DONDATHANG' table. You can move, or remove it, as needed.
            // this.sP_DS_DONDATHANGTableAdapter.Fill(this.qL_VATTUDataSet.SP_DS_DONDATHANG);
        
                gridVIEWData();
                gridControl1.DataSource = chitietDDH;
                gridControl1.DataBindings.Clear();
               
            

            loadVattu();
            loadDDH();
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

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "TRTHAI")
            {
                if (Convert.ToInt32(e.Value)== 0 )
                {

                    e.DisplayText = "Đang xử lý";

                }
                if (Convert.ToInt32(e.Value) == 1)
                {
                    e.DisplayText = "Hàng về";
                }
                if (Convert.ToInt32(e.Value) == 2)
                {
                    e.DisplayText = "Đã nhập hàng";
                }


            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {

            chitietDDH.Rows.Add(labelDDH.Text, tBoxMavattu.Text, tBoxTenvattu.Text, tBoxSoluong.Text, tBoxNhacc.Text);
            gridControl1.DataSource = chitietDDH;
            gridControl1.DataBindings.Clear();
            string[] a = labelDDH.Text; 


        }

        private void FocusedRowChanged()
        {
            DataRow red = gridViewVatTu.GetFocusedDataRow();
            tBoxMavattu.Text = red["MAVT"].ToString();
            tBoxTenvattu.Text = red["TENVT"].ToString();
            //MessageBox.Show(tBoxMavattu.Text);
            
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
            panel6.Visible = true;
            string[] param = { Access.MACN };
            DonDH dondh = new DonDH();
            maDDH = dondh.getMaDDH();
            maDDH.Read();
            labelDDH.Text = maDDH["MADDH"].ToString();
            maDDH.Close();





        }
    }
}
