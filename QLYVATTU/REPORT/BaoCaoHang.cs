using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYVATTU.REPORT
{
    public partial class BaoCaoHang : Form
    {
        public BaoCaoHang()
        {
            InitializeComponent();
        }

        private void pHIEUNHAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHIEUNHAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_VATTUDataSet);

        }

        private void BaoCaoHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.qL_VATTUDataSet.PHIEUNHAP);

        }
    }
}
