namespace QLYVATTU.VIEW.REPORT_VIEW
{
    partial class Report_DS_NhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxCHINHANH = new System.Windows.Forms.ComboBox();
            this.sP_REPORT_DS_NHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_VATTUDataSet = new QLYVATTU.QL_VATTUDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sP_REPORT_DS_NHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sP_REPORT_DS_NHANVIENTableAdapter = new QLYVATTU.QL_VATTUDataSetTableAdapters.SP_REPORT_DS_NHANVIENTableAdapter();
            this.tableAdapterManager = new QLYVATTU.QL_VATTUDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORT_DS_NHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORT_DS_NHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboxCHINHANH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 46);
            this.panel1.TabIndex = 0;
            // 
            // cboxCHINHANH
            // 
            this.cboxCHINHANH.FormattingEnabled = true;
            this.cboxCHINHANH.Location = new System.Drawing.Point(279, 12);
            this.cboxCHINHANH.Name = "cboxCHINHANH";
            this.cboxCHINHANH.Size = new System.Drawing.Size(138, 21);
            this.cboxCHINHANH.TabIndex = 0;
            this.cboxCHINHANH.SelectedIndexChanged += new System.EventHandler(this.cboxCHINHANH_SelectedIndexChanged);
            // 
            // sP_REPORT_DS_NHANVIENBindingSource
            // 
            this.sP_REPORT_DS_NHANVIENBindingSource.DataMember = "SP_REPORT_DS_NHANVIEN";
            this.sP_REPORT_DS_NHANVIENBindingSource.DataSource = this.qL_VATTUDataSet;
            // 
            // qL_VATTUDataSet
            // 
            this.qL_VATTUDataSet.DataSetName = "QL_VATTUDataSet";
            this.qL_VATTUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 340);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 123);
            this.panel2.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(601, 49);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Data";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sP_REPORT_DS_NHANVIENGridControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(688, 294);
            this.panel3.TabIndex = 2;
            // 
            // sP_REPORT_DS_NHANVIENGridControl
            // 
            this.sP_REPORT_DS_NHANVIENGridControl.DataSource = this.sP_REPORT_DS_NHANVIENBindingSource;
            this.sP_REPORT_DS_NHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_REPORT_DS_NHANVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_REPORT_DS_NHANVIENGridControl.MainView = this.gridView1;
            this.sP_REPORT_DS_NHANVIENGridControl.Name = "sP_REPORT_DS_NHANVIENGridControl";
            this.sP_REPORT_DS_NHANVIENGridControl.Size = new System.Drawing.Size(688, 294);
            this.sP_REPORT_DS_NHANVIENGridControl.TabIndex = 0;
            this.sP_REPORT_DS_NHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sP_REPORT_DS_NHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // sP_REPORT_DS_NHANVIENTableAdapter
            // 
            this.sP_REPORT_DS_NHANVIENTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh:";
            // 
            // Report_DS_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 463);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Report_DS_NhanVien";
            this.Text = "Report_DS_NhanVien";
            this.Load += new System.EventHandler(this.Report_DS_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORT_DS_NHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_VATTUDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_REPORT_DS_NHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboxCHINHANH;
        private QL_VATTUDataSet qL_VATTUDataSet;
        private System.Windows.Forms.BindingSource sP_REPORT_DS_NHANVIENBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraGrid.GridControl sP_REPORT_DS_NHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QL_VATTUDataSetTableAdapters.SP_REPORT_DS_NHANVIENTableAdapter sP_REPORT_DS_NHANVIENTableAdapter;
        private QL_VATTUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
    }
}