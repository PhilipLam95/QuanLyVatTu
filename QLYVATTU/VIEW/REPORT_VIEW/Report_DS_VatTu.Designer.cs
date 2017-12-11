namespace QLYVATTU.VIEW.REPORT_VIEW
{
    partial class Report_DS_VatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report_DS_VatTu));
            this.qL_VATTUDataSet = new QLYVATTU.QL_VATTUDataSet();
            this.sP_DS_VATTUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_DS_VATTUTableAdapter = new QLYVATTU.QL_VATTUDataSetTableAdapters.SP_DS_VATTUTableAdapter();
            this.tableAdapterManager = new QLYVATTU.QL_VATTUDataSetTableAdapters.TableAdapterManager();
            this.sP_DS_VATTUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONVI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // sP_DS_VATTUTableAdapter
            // 
            this.sP_DS_VATTUTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CHITIETDDHTableAdapter = null;
            this.tableAdapterManager.CHITIETHDTableAdapter = null;
            this.tableAdapterManager.CHITIETKHOTableAdapter = null;
            this.tableAdapterManager.CHITIETNCCTableAdapter = null;
            this.tableAdapterManager.CHITIETPNTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DONDHTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.LOAIVTTableAdapter = null;
            this.tableAdapterManager.NHACUNGCAPTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLYVATTU.QL_VATTUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // sP_DS_VATTUGridControl
            // 
            this.sP_DS_VATTUGridControl.DataSource = this.sP_DS_VATTUBindingSource;
            this.sP_DS_VATTUGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_DS_VATTUGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_DS_VATTUGridControl.MainView = this.gridView1;
            this.sP_DS_VATTUGridControl.Name = "sP_DS_VATTUGridControl";
            this.sP_DS_VATTUGridControl.Size = new System.Drawing.Size(658, 363);
            this.sP_DS_VATTUGridControl.TabIndex = 1;
            this.sP_DS_VATTUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAVT,
            this.colTENVT,
            this.colMALOAI,
            this.colTENLOAI,
            this.colDONGIA,
            this.colDONVI});
            this.gridView1.GridControl = this.sP_DS_VATTUGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 68);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(186, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH VẬT TƯ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sP_DS_VATTUGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 363);
            this.panel2.TabIndex = 3;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
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
            // colMALOAI
            // 
            this.colMALOAI.Caption = "Mã loại";
            this.colMALOAI.FieldName = "MALOAI";
            this.colMALOAI.Name = "colMALOAI";
            this.colMALOAI.Visible = true;
            this.colMALOAI.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            // 
            // colDONVI
            // 
            this.colDONVI.Caption = "Đơn vị";
            this.colDONVI.FieldName = "DONVI";
            this.colDONVI.Name = "colDONVI";
            this.colDONVI.Visible = true;
            this.colDONVI.VisibleIndex = 5;
            // 
            // colTENLOAI
            // 
            this.colTENLOAI.Caption = "Tên loại";
            this.colTENLOAI.FieldName = "TENLOAI";
            this.colTENLOAI.Name = "colTENLOAI";
            this.colTENLOAI.Visible = true;
            this.colTENLOAI.VisibleIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPrint);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 431);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 48);
            this.panel3.TabIndex = 4;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(282, 6);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 32);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "In ";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Report_DS_VatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 479);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_DS_VatTu";
            this.Text = "Report_DS_VatTu";
            this.Load += new System.EventHandler(this.Report_DS_VatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_DS_VATTUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private QL_VATTUDataSet qL_VATTUDataSet;
        private System.Windows.Forms.BindingSource sP_DS_VATTUBindingSource;
        private QL_VATTUDataSetTableAdapters.SP_DS_VATTUTableAdapter sP_DS_VATTUTableAdapter;
        private QL_VATTUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_DS_VATTUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colDONVI;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}