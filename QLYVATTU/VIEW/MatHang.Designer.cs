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
            this.sP_DS_LOAIVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VATTUDataSet = new QLYVATTU.QL_VATTUDataSet();
            this.sP_DS_VATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.sP_DS_VATTUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sP_DS_LOAIVTGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSuaLoai = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemLoai = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDonDatHang = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_LOAIVTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_LOAIVTGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // sP_DS_VATTUBindingSource
            // 
            this.sP_DS_VATTUBindingSource.DataMember = "SP_DS_VATTU";
            this.sP_DS_VATTUBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sP_DS_VATTUGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 277);
            this.panel2.TabIndex = 0;
            // 
            // sP_DS_VATTUGridControl
            // 
            this.sP_DS_VATTUGridControl.DataSource = this.sP_DS_VATTUBindingSource;
            this.sP_DS_VATTUGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DS_VATTUGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DS_VATTUGridControl.MainView = this.gridView1;
            this.sP_DS_VATTUGridControl.Name = "sP_DS_VATTUGridControl";
            this.sP_DS_VATTUGridControl.Size = new System.Drawing.Size(658, 277);
            this.sP_DS_VATTUGridControl.TabIndex = 0;
            this.sP_DS_VATTUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENLOAI,
            this.colTENVT,
            this.colSOLUONGTON,
            this.colDONVI,
            this.colDONGIA,
            this.colMAKHO});
            this.gridView1.GridControl = this.sP_DS_VATTUGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTENVT, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMAVT
            // 
            this.colMAVT.AppearanceCell.Options.UseTextOptions = true;
            this.colMAVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 0;
            this.colMAVT.Width = 93;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.AppearanceCell.Options.UseTextOptions = true;
            this.colTENLOAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENLOAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOAI.Caption = "Tên loại";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 2;
            this.colTENLOAI.Width = 135;
            // 
            // colTENVT
            // 
            this.colTENVT.AppearanceCell.BackColor = System.Drawing.Color.Black;
            this.colTENVT.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.colTENVT.AppearanceCell.ForeColor = System.Drawing.Color.Gray;
            this.colTENVT.AppearanceCell.Options.UseBackColor = true;
            this.colTENVT.AppearanceCell.Options.UseFont = true;
            this.colTENVT.AppearanceCell.Options.UseForeColor = true;
            this.colTENVT.AppearanceCell.Options.UseTextOptions = true;
            this.colTENVT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENVT.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENVT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 150;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 1;
            this.colTENVT.Width = 150;
            // 
            // colSOLUONGTON
            // 
            this.colSOLUONGTON.AppearanceCell.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.AppearanceHeader.Options.UseTextOptions = true;
            this.colSOLUONGTON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSOLUONGTON.Caption = "Số lượng trong kho";
            this.colSOLUONGTON.FieldName = "SOLUONGTON";
            this.colSOLUONGTON.Name = "colSOLUONGTON";
            this.colSOLUONGTON.Visible = true;
            this.colSOLUONGTON.VisibleIndex = 3;
            this.colSOLUONGTON.Width = 200;
            // 
            // colDONVI
            // 
            this.colDONVI.AppearanceCell.Options.UseTextOptions = true;
            this.colDONVI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONVI.AppearanceHeader.Options.UseTextOptions = true;
            this.colDONVI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONVI.Caption = "Đơn vị";
            this.colDONVI.FieldName = "DONVI";
            this.colDONVI.Name = "colDONVI";
            this.colDONVI.Visible = true;
            this.colDONVI.VisibleIndex = 4;
            this.colDONVI.Width = 135;
            // 
            // colDONGIA
            // 
            this.colDONGIA.AppearanceCell.Options.UseTextOptions = true;
            this.colDONGIA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONGIA.AppearanceHeader.Options.UseTextOptions = true;
            this.colDONGIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 5;
            this.colDONGIA.Width = 135;
            // 
            // colMAKHO
            // 
            this.colMAKHO.AppearanceCell.Options.UseTextOptions = true;
            this.colMAKHO.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHO.AppearanceHeader.Options.UseTextOptions = true;
            this.colMAKHO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 6;
            this.colMAKHO.Width = 153;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 56);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các Loại vật tư";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.sP_DS_LOAIVTGridControl);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 166);
            this.panel4.TabIndex = 2;
            // 
            // sP_DS_LOAIVTGridControl
            // 
            this.sP_DS_LOAIVTGridControl.DataSource = this.sP_DS_LOAIVTBindingSource;
            this.sP_DS_LOAIVTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DS_LOAIVTGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DS_LOAIVTGridControl.MainView = this.gridView2;
            this.sP_DS_LOAIVTGridControl.Name = "sP_DS_LOAIVTGridControl";
            this.sP_DS_LOAIVTGridControl.Size = new System.Drawing.Size(355, 166);
            this.sP_DS_LOAIVTGridControl.TabIndex = 0;
            this.sP_DS_LOAIVTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOAI,
            this.colTENLOAI1});
            this.gridView2.GridControl = this.sP_DS_LOAIVTGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMALOAI
            // 
            this.colMALOAI.AppearanceCell.Options.UseTextOptions = true;
            this.colMALOAI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOAI.AppearanceHeader.Options.UseTextOptions = true;
            this.colMALOAI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMALOAI.Caption = "Mã Loại";
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 0;
            this.colMALOAI.Width = 175;
            // 
            // colTENLOAI1
            // 
            this.colTENLOAI1.AppearanceCell.Options.UseTextOptions = true;
            this.colTENLOAI1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOAI1.AppearanceHeader.Options.UseTextOptions = true;
            this.colTENLOAI1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTENLOAI1.Caption = "Tên Loại";
            this.colTENLOAI1.FieldName = "TENLOAI";
            this.colTENLOAI1.Name = "colTENLOAI1";
            this.colTENLOAI1.Visible = true;
            this.colTENLOAI1.VisibleIndex = 1;
            this.colTENLOAI1.Width = 521;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSuaLoai);
            this.panel5.Controls.Add(this.btnThemLoai);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(355, 333);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(303, 166);
            this.panel5.TabIndex = 4;
            // 
            // btnSuaLoai
            // 
            this.btnSuaLoai.Location = new System.Drawing.Point(188, 105);
            this.btnSuaLoai.Name = "btnSuaLoai";
            this.btnSuaLoai.Size = new System.Drawing.Size(99, 30);
            this.btnSuaLoai.TabIndex = 4;
            this.btnSuaLoai.Text = "Sửa Loại vật tư";
            // 
            // btnThemLoai
            // 
            this.btnThemLoai.Location = new System.Drawing.Point(47, 105);
            this.btnThemLoai.Name = "btnThemLoai";
            this.btnThemLoai.Size = new System.Drawing.Size(99, 30);
            this.btnThemLoai.TabIndex = 3;
            this.btnThemLoai.Text = "Thêm Loại vật tư";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại vật tư";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 499);
            this.panel1.TabIndex = 0;
            // 
            // btnDonDatHang
            // 
            this.btnDonDatHang.Location = new System.Drawing.Point(683, 71);
            this.btnDonDatHang.Name = "btnDonDatHang";
            this.btnDonDatHang.Size = new System.Drawing.Size(138, 23);
            this.btnDonDatHang.TabIndex = 1;
            this.btnDonDatHang.Text = "Lập Đơn Đặt Hàng";
            this.btnDonDatHang.Click += new System.EventHandler(this.btnDonDatHang_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(683, 127);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(138, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Phiếu xuất";
            // 
            // MatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 499);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnDonDatHang);
            this.Controls.Add(this.panel1);
            this.Name = "MatHang";
            this.Text = "MatHang";
            this.Load += new System.EventHandler(this.MatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_LOAIVTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_LOAIVTGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private QL_VATTUDataSet qL_VATTUDataSet;
        private System.Windows.Forms.BindingSource sP_DS_VATTUBindingSource;
        private System.Windows.Forms.BindingSource sP_DS_LOAIVTBindingSource;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl sP_DS_VATTUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGTON;
        private DevExpress.XtraGrid.Columns.GridColumn colDONVI;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl sP_DS_LOAIVTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnThemLoai;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSuaLoai;
        private DevExpress.XtraEditors.SimpleButton btnDonDatHang;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}