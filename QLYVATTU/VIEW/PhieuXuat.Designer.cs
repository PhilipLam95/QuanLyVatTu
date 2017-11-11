namespace QLYVATTU.VIEW
{
    partial class PhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label hotenTbox;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuXuat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sP_DANHSACHPHIEUXUATGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DANHSACHPHIEUXUATBindingSource = new System.Windows.Forms.BindingSource();
            this.qL_VATTUDataSet = new QLYVATTU.QL_VATTUDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sdtTbox = new System.Windows.Forms.TextBox();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource();
            this.diachiTbox = new System.Windows.Forms.TextBox();
            this.tenkhoCompobox = new System.Windows.Forms.ComboBox();
            this.kHOBindingSource = new System.Windows.Forms.BindingSource();
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sP_TIMKIEM_KHACHHANGGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_TIMKIEM_KHACHHANGBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tboxHotenSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            hotenTbox = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHPHIEUXUATGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHPHIEUXUATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TIMKIEM_KHACHHANGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TIMKIEM_KHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotenTbox
            // 
            hotenTbox.AutoSize = true;
            hotenTbox.Location = new System.Drawing.Point(15, 25);
            hotenTbox.Name = "hotenTbox";
            hotenTbox.Size = new System.Drawing.Size(46, 13);
            hotenTbox.TabIndex = 0;
            hotenTbox.Text = "Họ Tên:";
            hotenTbox.Click += new System.EventHandler(this.hotenTbox_Click);
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(15, 88);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(76, 13);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên Kho Xuất:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 13);
            label1.TabIndex = 4;
            label1.Text = "Địa Chỉ :";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(247, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 6;
            label2.Text = "Số Điện Thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 26);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 13);
            label3.TabIndex = 1;
            label3.Text = "Họ Tên:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sP_DANHSACHPHIEUXUATGridControl);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 180);
            this.panel1.TabIndex = 0;
            // 
            // sP_DANHSACHPHIEUXUATGridControl
            // 
            this.sP_DANHSACHPHIEUXUATGridControl.DataSource = this.sP_DANHSACHPHIEUXUATBindingSource;
            this.sP_DANHSACHPHIEUXUATGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DANHSACHPHIEUXUATGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DANHSACHPHIEUXUATGridControl.MainView = this.gridView1;
            this.sP_DANHSACHPHIEUXUATGridControl.Name = "sP_DANHSACHPHIEUXUATGridControl";
            this.sP_DANHSACHPHIEUXUATGridControl.Size = new System.Drawing.Size(481, 180);
            this.sP_DANHSACHPHIEUXUATGridControl.TabIndex = 0;
            this.sP_DANHSACHPHIEUXUATGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_DANHSACHPHIEUXUATGridControl.Click += new System.EventHandler(this.sP_DANHSACHPHIEUXUATGridControl_Click);
            // 
            // sP_DANHSACHPHIEUXUATBindingSource
            // 
            this.sP_DANHSACHPHIEUXUATBindingSource.DataMember = "SP_DANHSACHPHIEUXUAT";
            this.sP_DANHSACHPHIEUXUATBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // qL_VATTUDataSet
            // 
            this.qL_VATTUDataSet.DataSetName = "QL_VATTUDataSet";
            this.qL_VATTUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_DANHSACHPHIEUXUATGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.sdtTbox);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.diachiTbox);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(tENKHOLabel);
            this.groupBox1.Controls.Add(this.tenkhoCompobox);
            this.groupBox1.Controls.Add(hotenTbox);
            this.groupBox1.Controls.Add(this.hOTENTextBox);
            this.groupBox1.Location = new System.Drawing.Point(1, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng Và Kho Xuất";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sdtTbox
            // 
            this.sdtTbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "HOTEN", true));
            this.sdtTbox.Location = new System.Drawing.Point(331, 22);
            this.sdtTbox.Name = "sdtTbox";
            this.sdtTbox.Size = new System.Drawing.Size(139, 20);
            this.sdtTbox.TabIndex = 7;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // diachiTbox
            // 
            this.diachiTbox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "HOTEN", true));
            this.diachiTbox.Location = new System.Drawing.Point(96, 53);
            this.diachiTbox.Name = "diachiTbox";
            this.diachiTbox.Size = new System.Drawing.Size(374, 20);
            this.diachiTbox.TabIndex = 5;
            this.diachiTbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tenkhoCompobox
            // 
            this.tenkhoCompobox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHOBindingSource, "TENKHO", true));
            this.tenkhoCompobox.FormattingEnabled = true;
            this.tenkhoCompobox.Location = new System.Drawing.Point(96, 85);
            this.tenkhoCompobox.Name = "tenkhoCompobox";
            this.tenkhoCompobox.Size = new System.Drawing.Size(139, 21);
            this.tenkhoCompobox.TabIndex = 3;
            // 
            // kHOBindingSource
            // 
            this.kHOBindingSource.DataMember = "KHO";
            this.kHOBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "HOTEN", true));
            this.hOTENTextBox.Location = new System.Drawing.Point(96, 22);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.Size = new System.Drawing.Size(139, 20);
            this.hOTENTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(this.tboxHotenSearch);
            this.groupBox2.Location = new System.Drawing.Point(488, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 199);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm Khách hàng";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sP_TIMKIEM_KHACHHANGGridControl);
            this.panel2.Location = new System.Drawing.Point(6, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 121);
            this.panel2.TabIndex = 3;
            // 
            // sP_TIMKIEM_KHACHHANGGridControl
            // 
            this.sP_TIMKIEM_KHACHHANGGridControl.DataSource = this.sP_TIMKIEM_KHACHHANGBindingSource;
            this.sP_TIMKIEM_KHACHHANGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_TIMKIEM_KHACHHANGGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_TIMKIEM_KHACHHANGGridControl.MainView = this.gridView2;
            this.sP_TIMKIEM_KHACHHANGGridControl.Name = "sP_TIMKIEM_KHACHHANGGridControl";
            this.sP_TIMKIEM_KHACHHANGGridControl.Size = new System.Drawing.Size(426, 121);
            this.sP_TIMKIEM_KHACHHANGGridControl.TabIndex = 3;
            this.sP_TIMKIEM_KHACHHANGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sP_TIMKIEM_KHACHHANGBindingSource
            // 
            this.sP_TIMKIEM_KHACHHANGBindingSource.DataMember = "SP_TIMKIEM_KHACHHANG";
            this.sP_TIMKIEM_KHACHHANGBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.sP_TIMKIEM_KHACHHANGGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.simpleButton1.Location = new System.Drawing.Point(277, 19);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(90, 34);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Tìm kiếm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tboxHotenSearch
            // 
            this.tboxHotenSearch.Location = new System.Drawing.Point(60, 23);
            this.tboxHotenSearch.Name = "tboxHotenSearch";
            this.tboxHotenSearch.Size = new System.Drawing.Size(211, 20);
            this.tboxHotenSearch.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Location = new System.Drawing.Point(1, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 135);
            this.panel3.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 132);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mặt Hàng Trong Phiếu";
            // 
            // PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 466);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuXuat";
            this.Text = "PhieuXuat";
            this.Load += new System.EventHandler(this.PhieuXuat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHPHIEUXUATGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DANHSACHPHIEUXUATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_TIMKIEM_KHACHHANGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_TIMKIEM_KHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private QL_VATTUDataSet qL_VATTUDataSet;
        private System.Windows.Forms.BindingSource sP_DANHSACHPHIEUXUATBindingSource;
        private DevExpress.XtraGrid.GridControl sP_DANHSACHPHIEUXUATGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.BindingSource kHOBindingSource;
        private System.Windows.Forms.TextBox diachiTbox;
        private System.Windows.Forms.ComboBox tenkhoCompobox;
        private System.Windows.Forms.TextBox sdtTbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox tboxHotenSearch;
        private System.Windows.Forms.BindingSource sP_TIMKIEM_KHACHHANGBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl sP_TIMKIEM_KHACHHANGGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}