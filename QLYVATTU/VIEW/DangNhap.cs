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

namespace QLYVATTU.VIEW
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {

        public DataTable tenchinhanh;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhapcs_Load(object sender, EventArgs e)
        {
            add_CN();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void add_CN()
        {
            MODEL.ChiNhanh chinhanh = new MODEL.ChiNhanh();
            tenchinhanh = chinhanh.getChiNhanh();
            comboBox1.Items.Clear();
            foreach (DataRow dr in tenchinhanh.Rows)
            {
                comboBox1.Items.Add(dr["TENCN"].ToString());
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}