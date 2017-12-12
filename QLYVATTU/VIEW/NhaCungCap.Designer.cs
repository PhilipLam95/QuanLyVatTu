namespace QLYVATTU.VIEW
{
    partial class NhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhaCungCap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.grvCTNCC = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grthemNCC = new System.Windows.Forms.GroupBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbTenNCC = new System.Windows.Forms.TextBox();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.lbTenNCC = new System.Windows.Forms.Label();
            this.grDSNCC = new System.Windows.Forms.GroupBox();
            this.grvNCC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbXacNhan = new System.Windows.Forms.GroupBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.btTaoNCC = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.tbTenVT = new System.Windows.Forms.TextBox();
            this.lbTenVT = new System.Windows.Forms.Label();
            this.gbDSVT = new System.Windows.Forms.GroupBox();
            this.grvDSVT = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCTNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.grthemNCC.SuspendLayout();
            this.grDSNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvNCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbXacNhan.SuspendLayout();
            this.gbDSVT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDSVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.grthemNCC);
            this.panel1.Controls.Add(this.grDSNCC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 499);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.grvCTNCC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 192);
            this.panel3.TabIndex = 2;
            // 
            // btXoa
            // 
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.Location = new System.Drawing.Point(576, 6);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(56, 23);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // grvCTNCC
            // 
            this.grvCTNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvCTNCC.Location = new System.Drawing.Point(0, 0);
            this.grvCTNCC.MainView = this.gridView2;
            this.grvCTNCC.Name = "grvCTNCC";
            this.grvCTNCC.Size = new System.Drawing.Size(677, 192);
            this.grvCTNCC.TabIndex = 0;
            this.grvCTNCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.grvCTNCC;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // grthemNCC
            // 
            this.grthemNCC.Controls.Add(this.tbSDT);
            this.grthemNCC.Controls.Add(this.tbDiaChi);
            this.grthemNCC.Controls.Add(this.tbTenNCC);
            this.grthemNCC.Controls.Add(this.lbDiaChi);
            this.grthemNCC.Controls.Add(this.lbSDT);
            this.grthemNCC.Controls.Add(this.lbTenNCC);
            this.grthemNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grthemNCC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grthemNCC.Location = new System.Drawing.Point(0, 207);
            this.grthemNCC.Name = "grthemNCC";
            this.grthemNCC.Size = new System.Drawing.Size(677, 100);
            this.grthemNCC.TabIndex = 1;
            this.grthemNCC.TabStop = false;
            this.grthemNCC.Text = "Thêm Chỉnh Sửa Nhà Cung Cấp Mới";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(453, 31);
            this.tbSDT.MaxLength = 11;
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(158, 22);
            this.tbSDT.TabIndex = 1;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(179, 63);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(432, 22);
            this.tbDiaChi.TabIndex = 1;
            // 
            // tbTenNCC
            // 
            this.tbTenNCC.Location = new System.Drawing.Point(179, 27);
            this.tbTenNCC.Name = "tbTenNCC";
            this.tbTenNCC.Size = new System.Drawing.Size(174, 22);
            this.tbTenNCC.TabIndex = 1;
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(55, 70);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(46, 15);
            this.lbDiaChi.TabIndex = 0;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(392, 34);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(41, 15);
            this.lbSDT.TabIndex = 0;
            this.lbSDT.Text = "Số ĐT";
            // 
            // lbTenNCC
            // 
            this.lbTenNCC.AutoSize = true;
            this.lbTenNCC.Location = new System.Drawing.Point(55, 34);
            this.lbTenNCC.Name = "lbTenNCC";
            this.lbTenNCC.Size = new System.Drawing.Size(109, 15);
            this.lbTenNCC.TabIndex = 0;
            this.lbTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // grDSNCC
            // 
            this.grDSNCC.Controls.Add(this.grvNCC);
            this.grDSNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.grDSNCC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grDSNCC.Location = new System.Drawing.Point(0, 0);
            this.grDSNCC.Name = "grDSNCC";
            this.grDSNCC.Size = new System.Drawing.Size(677, 207);
            this.grDSNCC.TabIndex = 0;
            this.grDSNCC.TabStop = false;
            this.grDSNCC.Text = "Danh Sách Nhà Cung Cấp";
            // 
            // grvNCC
            // 
            this.grvNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvNCC.Location = new System.Drawing.Point(3, 18);
            this.grvNCC.MainView = this.gridView1;
            this.grvNCC.Name = "grvNCC";
            this.grvNCC.Size = new System.Drawing.Size(671, 186);
            this.grvNCC.TabIndex = 0;
            this.grvNCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grvNCC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.DSNCC_RowClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbXacNhan);
            this.panel2.Controls.Add(this.gbDSVT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(677, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 499);
            this.panel2.TabIndex = 1;
            // 
            // gbXacNhan
            // 
            this.gbXacNhan.Controls.Add(this.btHuy);
            this.gbXacNhan.Controls.Add(this.btTaoNCC);
            this.gbXacNhan.Controls.Add(this.btThem);
            this.gbXacNhan.Controls.Add(this.tbTenVT);
            this.gbXacNhan.Controls.Add(this.lbTenVT);
            this.gbXacNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbXacNhan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbXacNhan.Location = new System.Drawing.Point(0, 307);
            this.gbXacNhan.Name = "gbXacNhan";
            this.gbXacNhan.Size = new System.Drawing.Size(533, 192);
            this.gbXacNhan.TabIndex = 1;
            this.gbXacNhan.TabStop = false;
            this.gbXacNhan.Text = "Xác Nhận Và Hoàn Thành";
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(309, 109);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 36);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btTaoNCC
            // 
            this.btTaoNCC.Location = new System.Drawing.Point(129, 109);
            this.btTaoNCC.Name = "btTaoNCC";
            this.btTaoNCC.Size = new System.Drawing.Size(129, 36);
            this.btTaoNCC.TabIndex = 2;
            this.btTaoNCC.Text = "Tạo Nhà Cung Cấp";
            this.btTaoNCC.UseVisualStyleBackColor = true;
            this.btTaoNCC.Click += new System.EventHandler(this.btTaoNCC_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(385, 34);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm Vào";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // tbTenVT
            // 
            this.tbTenVT.Location = new System.Drawing.Point(167, 35);
            this.tbTenVT.Name = "tbTenVT";
            this.tbTenVT.Size = new System.Drawing.Size(174, 22);
            this.tbTenVT.TabIndex = 1;
            // 
            // lbTenVT
            // 
            this.lbTenVT.AutoSize = true;
            this.lbTenVT.Location = new System.Drawing.Point(63, 39);
            this.lbTenVT.Name = "lbTenVT";
            this.lbTenVT.Size = new System.Drawing.Size(67, 15);
            this.lbTenVT.TabIndex = 0;
            this.lbTenVT.Text = "Tên Vật Tư";
            // 
            // gbDSVT
            // 
            this.gbDSVT.Controls.Add(this.grvDSVT);
            this.gbDSVT.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDSVT.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gbDSVT.Location = new System.Drawing.Point(0, 0);
            this.gbDSVT.Name = "gbDSVT";
            this.gbDSVT.Size = new System.Drawing.Size(533, 307);
            this.gbDSVT.TabIndex = 0;
            this.gbDSVT.TabStop = false;
            this.gbDSVT.Text = "Danh Sách Vật Tư Cần Bán";
            // 
            // grvDSVT
            // 
            this.grvDSVT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDSVT.Location = new System.Drawing.Point(3, 18);
            this.grvDSVT.MainView = this.gridView3;
            this.grvDSVT.Name = "grvDSVT";
            this.grvDSVT.Size = new System.Drawing.Size(527, 286);
            this.grvDSVT.TabIndex = 0;
            this.grvDSVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.grvDSVT;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView3.OptionsFind.AlwaysVisible = true;
            this.gridView3.OptionsFind.FindNullPrompt = "Nhập Từ Khóa Cần Tìm";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.VatTu_RowClick);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NhaCungCap";
            this.Text = "NhaCungCap";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCTNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.grthemNCC.ResumeLayout(false);
            this.grthemNCC.PerformLayout();
            this.grDSNCC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvNCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbXacNhan.ResumeLayout(false);
            this.gbXacNhan.PerformLayout();
            this.gbDSVT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvDSVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grDSNCC;
        private DevExpress.XtraGrid.GridControl grvNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl grvCTNCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox grthemNCC;
        private System.Windows.Forms.TextBox tbSDT;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbTenNCC;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbSDT;
        private System.Windows.Forms.Label lbTenNCC;
        private System.Windows.Forms.GroupBox gbXacNhan;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btTaoNCC;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox tbTenVT;
        private System.Windows.Forms.Label lbTenVT;
        private System.Windows.Forms.GroupBox gbDSVT;
        private DevExpress.XtraGrid.GridControl grvDSVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btXoa;
    }
}