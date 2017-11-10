namespace QLYVATTU.VIEW
{
    partial class TaoTaiKhoan
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
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxHo = new System.Windows.Forms.TextBox();
            this.tboxTen = new System.Windows.Forms.TextBox();
            this.rabtnNam = new System.Windows.Forms.RadioButton();
            this.rabtnNu = new System.Windows.Forms.RadioButton();
            this.nGAYSINHDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.tboxDiachi = new System.Windows.Forms.TextBox();
            this.tboxSDT = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabtnChiNhanh = new System.Windows.Forms.RadioButton();
            this.rabtnCongTy = new System.Windows.Forms.RadioButton();
            this.btnTao = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sP_LAY_NHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.sP_LAY_NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            sODTLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_NHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            nGAYSINHLabel.Location = new System.Drawing.Point(265, 119);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(90, 19);
            nGAYSINHLabel.TabIndex = 13;
            nGAYSINHLabel.Text = "Ngày sinh :";
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            sODTLabel.Location = new System.Drawing.Point(265, 200);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(50, 19);
            sODTLabel.TabIndex = 15;
            sODTLabel.Text = "SĐT :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            label3.Location = new System.Drawing.Point(265, 246);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 19);
            label3.TabIndex = 18;
            label3.Text = "Nhóm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(265, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(265, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(265, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phái :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(598, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(27, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 228);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(30, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "TIN CẬY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(32, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 19);
            this.label7.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(3, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "CÔNG TY TNHH 3 THÀNH VIÊN";
            // 
            // tboxHo
            // 
            this.tboxHo.Location = new System.Drawing.Point(361, 44);
            this.tboxHo.Name = "tboxHo";
            this.tboxHo.Size = new System.Drawing.Size(194, 21);
            this.tboxHo.TabIndex = 7;
            // 
            // tboxTen
            // 
            this.tboxTen.Location = new System.Drawing.Point(651, 44);
            this.tboxTen.Name = "tboxTen";
            this.tboxTen.Size = new System.Drawing.Size(94, 21);
            this.tboxTen.TabIndex = 8;
            // 
            // rabtnNam
            // 
            this.rabtnNam.AutoSize = true;
            this.rabtnNam.Checked = true;
            this.rabtnNam.Location = new System.Drawing.Point(361, 83);
            this.rabtnNam.Name = "rabtnNam";
            this.rabtnNam.Size = new System.Drawing.Size(47, 17);
            this.rabtnNam.TabIndex = 9;
            this.rabtnNam.TabStop = true;
            this.rabtnNam.Text = "NAM";
            this.rabtnNam.UseVisualStyleBackColor = true;
            // 
            // rabtnNu
            // 
            this.rabtnNu.AutoSize = true;
            this.rabtnNu.Location = new System.Drawing.Point(457, 83);
            this.rabtnNu.Name = "rabtnNu";
            this.rabtnNu.Size = new System.Drawing.Size(39, 17);
            this.rabtnNu.TabIndex = 10;
            this.rabtnNu.TabStop = true;
            this.rabtnNu.Text = "NU";
            this.rabtnNu.UseVisualStyleBackColor = true;
            // 
            // nGAYSINHDateEdit
            // 
            this.nGAYSINHDateEdit.EditValue = null;
            this.nGAYSINHDateEdit.Location = new System.Drawing.Point(361, 121);
            this.nGAYSINHDateEdit.Name = "nGAYSINHDateEdit";
            this.nGAYSINHDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYSINHDateEdit.Size = new System.Drawing.Size(194, 20);
            this.nGAYSINHDateEdit.TabIndex = 14;
            // 
            // tboxDiachi
            // 
            this.tboxDiachi.Location = new System.Drawing.Point(361, 157);
            this.tboxDiachi.Name = "tboxDiachi";
            this.tboxDiachi.Size = new System.Drawing.Size(220, 21);
            this.tboxDiachi.TabIndex = 15;
            // 
            // tboxSDT
            // 
            this.tboxSDT.Location = new System.Drawing.Point(361, 202);
            this.tboxSDT.MaxLength = 11;
            this.tboxSDT.Name = "tboxSDT";
            this.tboxSDT.Size = new System.Drawing.Size(168, 21);
            this.tboxSDT.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 27);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 54);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.tboxPassword);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tboxUserName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.btnTao);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tboxSDT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(sODTLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tboxDiachi);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(nGAYSINHLabel);
            this.panel3.Controls.Add(this.tboxHo);
            this.panel3.Controls.Add(this.nGAYSINHDateEdit);
            this.panel3.Controls.Add(this.tboxTen);
            this.panel3.Controls.Add(this.rabtnNu);
            this.panel3.Controls.Add(this.rabtnNam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(780, 270);
            this.panel3.TabIndex = 19;
            // 
            // tboxPassword
            // 
            this.tboxPassword.Location = new System.Drawing.Point(651, 8);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '*';
            this.tboxPassword.Size = new System.Drawing.Size(117, 21);
            this.tboxPassword.TabIndex = 23;
            this.tboxPassword.Tag = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(561, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Mật khẩu :";
            // 
            // tboxUserName
            // 
            this.tboxUserName.Location = new System.Drawing.Point(361, 8);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(168, 21);
            this.tboxUserName.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(238, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tên tài khoản :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabtnChiNhanh);
            this.groupBox1.Controls.Add(this.rabtnCongTy);
            this.groupBox1.Location = new System.Drawing.Point(361, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 45);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn nhóm";
            // 
            // rabtnChiNhanh
            // 
            this.rabtnChiNhanh.AutoSize = true;
            this.rabtnChiNhanh.Checked = true;
            this.rabtnChiNhanh.Location = new System.Drawing.Point(155, 20);
            this.rabtnChiNhanh.Name = "rabtnChiNhanh";
            this.rabtnChiNhanh.Size = new System.Drawing.Size(78, 17);
            this.rabtnChiNhanh.TabIndex = 20;
            this.rabtnChiNhanh.TabStop = true;
            this.rabtnChiNhanh.Text = "CHINHANH";
            this.rabtnChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rabtnCongTy
            // 
            this.rabtnCongTy.AutoSize = true;
            this.rabtnCongTy.Location = new System.Drawing.Point(19, 20);
            this.rabtnCongTy.Name = "rabtnCongTy";
            this.rabtnCongTy.Size = new System.Drawing.Size(66, 17);
            this.rabtnCongTy.TabIndex = 20;
            this.rabtnCongTy.Text = "CONGTY";
            this.rabtnCongTy.UseVisualStyleBackColor = true;
            // 
            // btnTao
            // 
            this.btnTao.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTao.Appearance.Options.UseFont = true;
            this.btnTao.Image = ((System.Drawing.Image)(resources.GetObject("btnTao.Image")));
            this.btnTao.Location = new System.Drawing.Point(614, 127);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(146, 79);
            this.btnTao.TabIndex = 17;
            this.btnTao.Text = "Tạo Tài Khoản";
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sP_LAY_NHANVIENGridControl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 324);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(780, 130);
            this.panel4.TabIndex = 20;
            // 
            // sP_LAY_NHANVIENGridControl
            // 
            this.sP_LAY_NHANVIENGridControl.DataSource = this.sP_LAY_NHANVIENBindingSource;
            this.sP_LAY_NHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LAY_NHANVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_LAY_NHANVIENGridControl.MainView = this.gridView1;
            this.sP_LAY_NHANVIENGridControl.Name = "sP_LAY_NHANVIENGridControl";
            this.sP_LAY_NHANVIENGridControl.Size = new System.Drawing.Size(780, 130);
            this.sP_LAY_NHANVIENGridControl.TabIndex = 0;
            this.sP_LAY_NHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_LAY_NHANVIENBindingSource
            // 
            this.sP_LAY_NHANVIENBindingSource.DataMember = "SP_LAY_NHANVIEN";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colMACN,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colSODT});
            this.gridView1.GridControl = this.sP_LAY_NHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 1;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 2;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Gioi tính";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 6;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điên thọai";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 7;
            // 
            // TaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 454);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "TaoTaiKhoan";
            this.Text = "TaoTaiKhoan";
            this.Load += new System.EventHandler(this.TaoTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYSINHDateEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_NHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tboxHo;
        private System.Windows.Forms.TextBox tboxTen;
        private System.Windows.Forms.RadioButton rabtnNam;
        private System.Windows.Forms.RadioButton rabtnNu;
        private QL_VATTUDataSet qL_VATTUDataSet;
        private DevExpress.XtraEditors.DateEdit nGAYSINHDateEdit;
        private System.Windows.Forms.TextBox tboxDiachi;
        private System.Windows.Forms.TextBox tboxSDT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnTao;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource sP_LAY_NHANVIENBindingSource;
        private DevExpress.XtraGrid.GridControl sP_LAY_NHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabtnChiNhanh;
        private System.Windows.Forms.RadioButton rabtnCongTy;
        private QL_VATTUDataSet qL_VATTUDataSet1;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Label label10;
    }
}