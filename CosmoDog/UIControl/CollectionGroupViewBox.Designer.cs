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
            this.gbQuery = new System.Windows.Forms.GroupBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.tbQueryString = new System.Windows.Forms.TextBox();
            this.pResults = new System.Windows.Forms.Panel();
            this.gbHistory.SuspendLayout();
            this.gbResults.SuspendLayout();
            this.gbQuery.SuspendLayout();
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
            this.gbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResults.Location = new System.Drawing.Point(200, 50);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(861, 543);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // gbQuery
            // 
            this.gbQuery.Controls.Add(this.btnPaste);
            this.gbQuery.Controls.Add(this.tbQueryString);
            this.gbQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbQuery.Location = new System.Drawing.Point(200, 0);
            this.gbQuery.Name = "gbQuery";
            this.gbQuery.Size = new System.Drawing.Size(861, 50);
            this.gbQuery.TabIndex = 0;
            this.gbQuery.TabStop = false;
            this.gbQuery.Text = "Query";
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(506, 16);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(109, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Paste and Run";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // tbQueryString
            // 
            this.tbQueryString.Location = new System.Drawing.Point(6, 19);
            this.tbQueryString.Name = "tbQueryString";
            this.tbQueryString.Size = new System.Drawing.Size(494, 20);
            this.tbQueryString.TabIndex = 0;
            this.tbQueryString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQueryString_KeyDown);
            // 
            // pResults
            // 
            this.pResults.AutoScroll = true;
            this.pResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pResults.Location = new System.Drawing.Point(3, 16);
            this.pResults.Name = "pResults";
            this.pResults.Size = new System.Drawing.Size(855, 524);
            this.pResults.TabIndex = 0;
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
    }
}
