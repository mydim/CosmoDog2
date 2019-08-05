namespace CosmoDog
{
    partial class CosmosDBBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDB = new System.Windows.Forms.ComboBox();
            this.tbEndpoint = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCollections = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchPattern = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDB);
            this.groupBox1.Controls.Add(this.tbEndpoint);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection (AccountEndpoint;AccountKey / DB Name)";
            // 
            // cbDB
            // 
            this.cbDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDB.FormattingEnabled = true;
            this.cbDB.Location = new System.Drawing.Point(3, 36);
            this.cbDB.Name = "cbDB";
            this.cbDB.Size = new System.Drawing.Size(443, 21);
            this.cbDB.TabIndex = 4;
            this.cbDB.SelectedIndexChanged += new System.EventHandler(this.cbDB_SelectedIndexChanged);
            // 
            // tbEndpoint
            // 
            this.tbEndpoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbEndpoint.Location = new System.Drawing.Point(3, 16);
            this.tbEndpoint.Name = "tbEndpoint";
            this.tbEndpoint.Size = new System.Drawing.Size(443, 20);
            this.tbEndpoint.TabIndex = 0;
            this.tbEndpoint.Text = "AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIW" +
    "EHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
            this.tbEndpoint.TextChanged += new System.EventHandler(this.tbEndpoint_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCollections);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbSearchPattern);
            this.groupBox2.Controls.Add(this.btnSelectAll);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 434);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Collections";
            // 
            // cbCollections
            // 
            this.cbCollections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbCollections.FormattingEnabled = true;
            this.cbCollections.Location = new System.Drawing.Point(3, 16);
            this.cbCollections.Name = "cbCollections";
            this.cbCollections.Size = new System.Drawing.Size(443, 415);
            this.cbCollections.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pattern";
            // 
            // tbSearchPattern
            // 
            this.tbSearchPattern.Location = new System.Drawing.Point(229, -3);
            this.tbSearchPattern.Name = "tbSearchPattern";
            this.tbSearchPattern.Size = new System.Drawing.Size(100, 20);
            this.tbSearchPattern.TabIndex = 2;
            this.tbSearchPattern.Text = "V3";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(335, -5);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(108, 23);
            this.btnSelectAll.TabIndex = 1;
            this.btnSelectAll.Text = "Select/Unselect all";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // CosmosDBBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CosmosDBBox";
            this.Size = new System.Drawing.Size(449, 507);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbEndpoint;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox cbCollections;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchPattern;
        private System.Windows.Forms.ComboBox cbDB;
    }
}
