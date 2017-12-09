namespace QLYVATTU.VIEW
{
    partial class MatHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatHang));
            this.sP_DS_LOAIVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VATTUDataSet = new QLYVATTU.QL_VATTUDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sP_DS_VATTUGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_DS_VATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxMaVT = new System.Windows.Forms.TextBox();
            this.cBoxLoaiVT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxTenVT = new System.Windows.Forms.TextBox();
            this.tBoxDongia = new System.Windows.Forms.TextBox();
            this.tBoxDonvi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnThemLoai = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_LOAIVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // sP_DS_LOAIVTBindingSource
            // 
            this.sP_DS_LOAIVTBindingSource.DataMember = "SP_DS_LOAIVT";
            this.sP_DS_LOAIVTBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // qL_VATTUDataSet
            // 
            this.qL_VATTUDataSet.DataSetName = "QL_VATTUDataSet";
            this.qL_VATTUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sP_DS_VATTUGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 311);
            this.panel2.TabIndex = 0;
            // 
            // sP_DS_VATTUGridControl
            // 
            this.sP_DS_VATTUGridControl.DataSource = this.sP_DS_VATTUBindingSource;
            this.sP_DS_VATTUGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DS_VATTUGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DS_VATTUGridControl.MainView = this.gridView1;
            this.sP_DS_VATTUGridControl.Name = "sP_DS_VATTUGridControl";
            this.sP_DS_VATTUGridControl.Size = new System.Drawing.Size(1242, 311);
            this.sP_DS_VATTUGridControl.TabIndex = 0;
            this.sP_DS_VATTUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.sP_DS_VATTUGridControl.Click += new System.EventHandler(this.sP_DS_VATTUGridControl_Click);
            // 
            // sP_DS_VATTUBindingSource
            // 
            this.sP_DS_VATTUBindingSource.DataMember = "SP_DS_VATTU";
            this.sP_DS_VATTUBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colTENLOAI,
            this.colDONGIA,
            this.colDONVI});
            this.gridView1.GridControl = this.sP_DS_VATTUGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.OptionsColumn.AllowEdit = false;
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 4;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 2;
            // 
            // colDONVI
            // 
            this.colDONVI.Caption = "Đơn vị";
            this.colDONVI.FieldName = "DONVI";
            this.colDONVI.Name = "colDONVI";
            this.colDONVI.Visible = true;
            this.colDONVI.VisibleIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mã vật tư";
            // 
            // tBoxMaVT
            // 
            this.tBoxMaVT.Enabled = false;
            this.tBoxMaVT.Location = new System.Drawing.Point(215, 3);
            this.tBoxMaVT.Name = "tBoxMaVT";
            this.tBoxMaVT.Size = new System.Drawing.Size(396, 20);
            this.tBoxMaVT.TabIndex = 18;
            this.tBoxMaVT.Tag = "Mã vật tư";
            this.tBoxMaVT.TextChanged += new System.EventHandler(this.tBoxMaVT_TextChanged);
            // 
            // cBoxLoaiVT
            // 
            this.cBoxLoaiVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxLoaiVT.Enabled = false;
            this.cBoxLoaiVT.FormattingEnabled = true;
            this.cBoxLoaiVT.Location = new System.Drawing.Point(215, 85);
            this.cBoxLoaiVT.Name = "cBoxLoaiVT";
            this.cBoxLoaiVT.Size = new System.Drawing.Size(318, 21);
            this.cBoxLoaiVT.TabIndex = 15;
            this.cBoxLoaiVT.Tag = "Loại vật tư";
            this.cBoxLoaiVT.SelectedIndexChanged += new System.EventHandler(this.cBoxLoaiVT_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(3, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Loại vật tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên vật tư";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(3, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Đơn vị";
            // 
            // tboxTenVT
            // 
            this.tboxTenVT.Enabled = false;
            this.tboxTenVT.Location = new System.Drawing.Point(215, 40);
            this.tboxTenVT.Name = "tboxTenVT";
            this.tboxTenVT.Size = new System.Drawing.Size(318, 20);
            this.tboxTenVT.TabIndex = 1;
            this.tboxTenVT.Tag = "Tên vật tư";
            this.tboxTenVT.TextChanged += new System.EventHandler(this.tboxTenVT_TextChanged);
            // 
            // tBoxDongia
            // 
            this.tBoxDongia.Enabled = false;
            this.tBoxDongia.Location = new System.Drawing.Point(268, 194);
            this.tBoxDongia.MaxLength = 10;
            this.tBoxDongia.Name = "tBoxDongia";
            this.tBoxDongia.Size = new System.Drawing.Size(431, 20);
            this.tBoxDongia.TabIndex = 12;
            this.tBoxDongia.Tag = "Đơn giá";
            this.tBoxDongia.TextChanged += new System.EventHandler(this.tBoxDongia_TextChanged);
            this.tBoxDongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxDongia_KeyPress);
            // 
            // tBoxDonvi
            // 
            this.tBoxDonvi.Enabled = false;
            this.tBoxDonvi.Location = new System.Drawing.Point(215, 125);
            this.tBoxDonvi.Name = "tBoxDonvi";
            this.tBoxDonvi.Size = new System.Drawing.Size(387, 20);
            this.tBoxDonvi.TabIndex = 10;
            this.tBoxDonvi.Tag = "Đơn vị";
            this.tBoxDonvi.TextChanged += new System.EventHandler(this.tBoxDonvi_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(56, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Đơn giá";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.tBoxDongia);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Controls.Add(this.btnThemLoai);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 311);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1242, 330);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(720, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "VND";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.91633F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.08366F));
            this.tableLayoutPanel1.Controls.Add(this.tBoxDonvi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cBoxLoaiVT, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBoxMaVT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxTenVT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(53, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.74468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.25532F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 166);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(660, -30);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(99, 30);
            this.btnThemLoai.TabIndex = 3;
            this.btnThemLoai.Text = "Thêm Loại vật tư";
            this.btnThemLoai.Click += new System.EventHandler(this.btnThemLoai_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 641);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnReload,
            this.btnUndo,
            this.btnLuu,
            this.btnHuy,
            this.btnPrint});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHuy),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrint)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = ((System.Drawing.Image)(resources.GetObject("btnThem.Glyph")));
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnThem.LargeGlyph")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.Glyph")));
            this.btnXoa.Id = 1;
            this.btnXoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnXoa.LargeGlyph")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 2;
            this.btnReload.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReload.LargeGlyph")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Quay Lại";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 3;
            this.btnUndo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.LargeGlyph")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Enabled = false;
            this.btnLuu.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.Glyph")));
            this.btnLuu.Id = 4;
            this.btnLuu.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLuu.LargeGlyph")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHuy.Glyph")));
            this.btnHuy.Id = 5;
            this.btnHuy.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHuy.LargeGlyph")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In";
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 6;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrint_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1242, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 665);
            this.barDockControlBottom.Size = new System.Drawing.Size(1242, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 641);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1242, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 641);
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 665);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MatHang";
            this.Text = "MatHang";
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_LOAIVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private QL_VATTUDataSet qL_VATTUDataSet;
        private System.Windows.Forms.BindingSource sP_DS_LOAIVTBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnThemLoai;
        private System.Windows.Forms.TextBox tboxTenVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource sP_DS_VATTUBindingSource;
        private DevExpress.XtraGrid.GridControl sP_DS_VATTUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDONVI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxDongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxDonvi;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ComboBox cBoxLoaiVT;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxMaVT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
    }
}