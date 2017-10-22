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
    public partial class TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        private DataTable nv;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien();
            sP_LAY_NHANVIENGridControl.DataSource = nv;
            sP_LAY_NHANVIENGridControl.DataMember = nv.TableName;

        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }
    }
}