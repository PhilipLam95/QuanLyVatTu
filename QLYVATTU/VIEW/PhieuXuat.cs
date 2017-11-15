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

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DSVT_PHIEUXUAT' table. You can move, or remove it, as needed.
            //this.sP_DSVT_PHIEUXUATTableAdapter.Fill(this.qL_VATTUDataSet.SP_DSVT_PHIEUXUAT);

            KhachHang khachhang = new KhachHang();
            kh = khachhang.getKhachHang();
            sP_TIMKIEM_KHACHHANGGridControl.DataSource = kh;
            sP_TIMKIEM_KHACHHANGGridControl.DataMember = kh.TableName;


            HoaDon hoadon = new HoaDon();
            hd = hoadon.getHoaDon();
            sP_DANHSACHPHIEUXUATGridControl.DataSource = hd;
            sP_DANHSACHPHIEUXUATGridControl.DataMember = hd.TableName;

            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            sP_DSVT_PHIEUXUATGridControl.DataSource = vt;
            sP_DSVT_PHIEUXUATGridControl.DataMember = vt.TableName;

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

        private void simpleButton1_Click(object sender, EventArgs e)
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
    }
}
