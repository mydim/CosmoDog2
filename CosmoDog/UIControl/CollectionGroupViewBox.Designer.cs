namespace CosmoDog.UIControl
{
    partial class CollectionGroupViewBox
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
            this.gbHistory = new System.Windows.Forms.GroupBox();
            this.queryHistoryBox1 = new CosmoDog.UIControl.QueryHistoryBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.pResults = new System.Windows.Forms.Panel();
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.btnSearchEverywhere = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.tbQueryStringEverywhere = new System.Windows.Forms.TextBox();
            this.tbQueryString = new System.Windows.Forms.TextBox();
            this.gcAdditionalView = new System.Windows.Forms.GroupBox();
            this.queryHistoryBox2 = new CosmoDog.UIControl.QueryHistoryBox();
            this.gbHistory.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbQuery.SuspendLayout();
            this.gcAdditionalView.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHistory
            // 
            this.gbHistory.Controls.Add(this.queryHistoryBox1);
            this.gbHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbHistory.Location = new System.Drawing.Point(0, 0);
            this.gbHistory.Name = "gbHistory";
            this.gbHistory.Size = new System.Drawing.Size(200, 593);
            this.gbHistory.TabIndex = 0;
            this.gbHistory.TabStop = false;
            this.gbHistory.Text = "Query history";
            this.gbHistory.Visible = false;
            // 
            // queryHistoryBox1
            // 
            this.queryHistoryBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryHistoryBox1.Location = new System.Drawing.Point(3, 16);
            this.queryHistoryBox1.Name = "queryHistoryBox1";
            this.queryHistoryBox1.Size = new System.Drawing.Size(194, 574);
            this.queryHistoryBox1.TabIndex = 0;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.pResults);
            this.gbResults.Controls.Add(this.gcAdditionalView);
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResults.Location = new System.Drawing.Point(200, 50);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(861, 543);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // pResults
            // 
            this.pResults.AutoScroll = true;
            this.pResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pResults.Location = new System.Drawing.Point(3, 16);
            this.pResults.Name = "pResults";
            this.pResults.Size = new System.Drawing.Size(855, 353);
            this.pResults.TabIndex = 0;
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.btnSearchEverywhere);
            this.gbQuery.Controls.Add(this.btnRun);
            this.gbQuery.Controls.Add(this.btnPaste);
            this.gbQuery.Controls.Add(this.tbQueryStringEverywhere);
            this.gbQuery.Controls.Add(this.tbQueryString);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuery.Location = new System.Drawing.Point(200, 0);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(861, 50);
            this.gbQuery.TabIndex = 0;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "Query";
            // 
            // btnSearchEverywhere
            // 
            this.btnSearchEverywhere.Location = new System.Drawing.Point(710, 16);
            this.btnSearchEverywhere.Name = "btnSearchEverywhere";
            this.btnSearchEverywhere.Size = new System.Drawing.Size(93, 23);
            this.btnSearchEverywhere.TabIndex = 1;
            this.btnSearchEverywhere.Text = "Paste and Run";
            this.btnSearchEverywhere.UseVisualStyleBackColor = true;
            this.btnSearchEverywhere.Click += new System.EventHandler(this.btnSearchEverywhere_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(809, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(375, 16);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(90, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste and Run";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // tbQueryStringEverywhere
            // 
            this.tbQueryStringEverywhere.Location = new System.Drawing.Point(492, 18);
            this.tbQueryStringEverywhere.Name = "tbQueryStringEverywhere";
            this.tbQueryStringEverywhere.Size = new System.Drawing.Size(212, 20);
            this.tbQueryStringEverywhere.TabIndex = 0;
            this.tbQueryStringEverywhere.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQueryString_KeyDown);
            // 
            // tbQueryString
            // 
            this.tbQueryString.Location = new System.Drawing.Point(6, 19);
            this.tbQueryString.Name = "tbQueryString";
            this.tbQueryString.Size = new System.Drawing.Size(363, 20);
            this.tbQueryString.TabIndex = 0;
            this.tbQueryString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQueryString_KeyDown);
            // 
            // gcAdditionalView
            // 
            this.gcAdditionalView.Controls.Add(this.queryHistoryBox2);
            this.gcAdditionalView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcAdditionalView.Location = new System.Drawing.Point(3, 369);
            this.gcAdditionalView.Name = "gcAdditionalView";
            this.gcAdditionalView.Size = new System.Drawing.Size(855, 171);
            this.gcAdditionalView.TabIndex = 0;
            this.gcAdditionalView.TabStop = false;
            this.gcAdditionalView.Text = "SubView";
            this.gcAdditionalView.Visible = false;
            // 
            // queryHistoryBox2
            // 
            this.queryHistoryBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryHistoryBox2.Location = new System.Drawing.Point(3, 16);
            this.queryHistoryBox2.Name = "queryHistoryBox2";
            this.queryHistoryBox2.Size = new System.Drawing.Size(849, 152);
            this.queryHistoryBox2.TabIndex = 0;
            // 
            // CollectionGroupViewBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbQuery);
            this.Controls.Add(this.gbHistory);
            this.Name = "CollectionGroupViewBox";
            this.Size = new System.Drawing.Size(1061, 593);
            this.gbHistory.ResumeLayout(false);
            this.gbResults.ResumeLayout(false);
            this.gbQuery.ResumeLayout(false);
            this.gbQuery.PerformLayout();
            this.gcAdditionalView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHistory;
        private QueryHistoryBox queryHistoryBox1;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.GroupBox gbQuery;
        private System.Windows.Forms.TextBox tbQueryString;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Panel pResults;
        private System.Windows.Forms.Button btnSearchEverywhere;
        private System.Windows.Forms.TextBox tbQueryStringEverywhere;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox gcAdditionalView;
        private QueryHistoryBox queryHistoryBox2;
    }
}
