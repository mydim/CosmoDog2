namespace CosmoDog.UIControl
{
    partial class TypeCollectionViewBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridGroupSummaryItem gridGroupSummaryItem1 = new DevExpress.XtraGrid.GridGroupSummaryItem();
            this.gbMain = new DevExpress.XtraEditors.GroupControl();
            this.gcMain = new DevExpress.XtraGrid.GridControl();
            this.gcView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcView)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.gcMain);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 0);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(1090, 390);
            this.gbMain.TabIndex = 0;
            this.gbMain.Text = "{Collection} - {Type}";
            // 
            // gcMain
            // 
            this.gcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMain.Location = new System.Drawing.Point(2, 20);
            this.gcMain.MainView = this.gcView;
            this.gcMain.Name = "gcMain";
            this.gcMain.Size = new System.Drawing.Size(1086, 368);
            this.gcMain.TabIndex = 0;
            this.gcMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcView});
            // 
            // gcView
            // 
            this.gcView.GridControl = this.gcMain;
            gridGroupSummaryItem1.SummaryType = DevExpress.Data.SummaryItemType.Count;
            this.gcView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            gridGroupSummaryItem1});
            this.gcView.Name = "gcView";
            this.gcView.OptionsSelection.InvertSelection = true;
            this.gcView.OptionsView.ColumnAutoWidth = false;
            this.gcView.OptionsView.ShowFooter = true;
            this.gcView.OptionsView.ShowGroupedColumns = true;
            this.gcView.OptionsView.ShowGroupPanel = false;
            this.gcView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gcView_RowCellClick);
            // 
            // TypeCollectionViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMain);
            this.Name = "TypeCollectionViewBox";
            this.Size = new System.Drawing.Size(1090, 390);
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbMain;
        private DevExpress.XtraGrid.GridControl gcMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gcView;
    }
}
