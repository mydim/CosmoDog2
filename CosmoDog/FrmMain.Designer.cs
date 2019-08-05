using Alex75.JsonViewer.WindowsForm;

namespace CosmoDog
{
    partial class FrmMain
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
            this.gbSource = new System.Windows.Forms.GroupBox();
            this.btnSwtichConnection = new System.Windows.Forms.Button();
            this.cosmosSource = new CosmoDog.CosmosDBBox();
            this.gbDest = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbBulkUpload = new System.Windows.Forms.CheckBox();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnChooseZip = new System.Windows.Forms.Button();
            this.tbImportFolder = new System.Windows.Forms.TextBox();
            this.btnImportFolder = new System.Windows.Forms.Button();
            this.btnImportFromZip = new System.Windows.Forms.Button();
            this.tbImportZip = new System.Windows.Forms.TextBox();
            this.btnCreateCollectionFromSource = new System.Windows.Forms.Button();
            this.btnReacreateCollections = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteDataInSelected = new System.Windows.Forms.Button();
            this.cosmosDest = new CosmoDog.CosmosDBBox();
            this.btnOverride = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lRecordsFound = new System.Windows.Forms.Label();
            this.cbFilterList = new System.Windows.Forms.ComboBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.jsonTreeView = new Alex75.JsonViewer.WindowsForm.JsonTreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFilterValue4 = new System.Windows.Forms.TextBox();
            this.tbFilterValue3 = new System.Windows.Forms.TextBox();
            this.tbFilterValue2 = new System.Windows.Forms.TextBox();
            this.tbFilterField4 = new System.Windows.Forms.TextBox();
            this.tbFilterValue1 = new System.Windows.Forms.TextBox();
            this.tbFilterField3 = new System.Windows.Forms.TextBox();
            this.tbFilterField2 = new System.Windows.Forms.TextBox();
            this.tbFilterField1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCopyAsync = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpImport = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.collectionGroupViewBox1 = new CosmoDog.UIControl.CollectionGroupViewBox();
            this.panel1.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbDest.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpImport.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tpQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbSource);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 499);
            this.panel1.TabIndex = 2;
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.btnSwtichConnection);
            this.gbSource.Controls.Add(this.cosmosSource);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Location = new System.Drawing.Point(0, 0);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(624, 499);
            this.gbSource.TabIndex = 2;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source DB";
            // 
            // btnSwtichConnection
            // 
            this.btnSwtichConnection.Location = new System.Drawing.Point(573, 0);
            this.btnSwtichConnection.Name = "btnSwtichConnection";
            this.btnSwtichConnection.Size = new System.Drawing.Size(51, 23);
            this.btnSwtichConnection.TabIndex = 2;
            this.btnSwtichConnection.Text = "<>";
            this.btnSwtichConnection.UseVisualStyleBackColor = true;
            this.btnSwtichConnection.Click += new System.EventHandler(this.btnSwtichConnection_Click);
            // 
            // cosmosSource
            // 
            this.cosmosSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cosmosSource.EndPoint = "AccountEndpoint=https://stp-nosqlacct-v-degop2.documents.azure.com:443/;AccountKe" +
    "y=QUTGAtthw8z1tnsEZIKqhPQjcQlHLPNh6OyILi27gqlwFnasCHvfn2Atx5ztSmzzpllFlHIvX3TWmh" +
    "VqVmawRQ==";
            this.cosmosSource.Location = new System.Drawing.Point(3, 16);
            this.cosmosSource.Name = "cosmosSource";
            this.cosmosSource.Size = new System.Drawing.Size(618, 480);
            this.cosmosSource.TabIndex = 0;
            // 
            // gbDest
            // 
            this.gbDest.Controls.Add(this.groupBox5);
            this.gbDest.Controls.Add(this.btnCreateCollectionFromSource);
            this.gbDest.Controls.Add(this.btnReacreateCollections);
            this.gbDest.Controls.Add(this.button1);
            this.gbDest.Controls.Add(this.btnDeleteDataInSelected);
            this.gbDest.Controls.Add(this.cosmosDest);
            this.gbDest.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDest.Location = new System.Drawing.Point(0, 0);
            this.gbDest.Name = "gbDest";
            this.gbDest.Size = new System.Drawing.Size(459, 788);
            this.gbDest.TabIndex = 3;
            this.gbDest.TabStop = false;
            this.gbDest.Text = "Destination DB for Import / Main Connection";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbBulkUpload);
            this.groupBox5.Controls.Add(this.btnChooseFolder);
            this.groupBox5.Controls.Add(this.btnChooseZip);
            this.groupBox5.Controls.Add(this.tbImportFolder);
            this.groupBox5.Controls.Add(this.btnImportFolder);
            this.groupBox5.Controls.Add(this.btnImportFromZip);
            this.groupBox5.Controls.Add(this.tbImportZip);
            this.groupBox5.Location = new System.Drawing.Point(6, 676);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 110);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Zip to collections";
            // 
            // cbBulkUpload
            // 
            this.cbBulkUpload.AutoSize = true;
            this.cbBulkUpload.Checked = true;
            this.cbBulkUpload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBulkUpload.Location = new System.Drawing.Point(18, 74);
            this.cbBulkUpload.Name = "cbBulkUpload";
            this.cbBulkUpload.Size = new System.Drawing.Size(84, 17);
            this.cbBulkUpload.TabIndex = 6;
            this.cbBulkUpload.Text = "Bulk Upload";
            this.cbBulkUpload.UseVisualStyleBackColor = true;
            this.cbBulkUpload.Visible = false;
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(124, 46);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(35, 23);
            this.btnChooseFolder.TabIndex = 5;
            this.btnChooseFolder.Text = "...";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnChooseZip
            // 
            this.btnChooseZip.Location = new System.Drawing.Point(124, 17);
            this.btnChooseZip.Name = "btnChooseZip";
            this.btnChooseZip.Size = new System.Drawing.Size(35, 23);
            this.btnChooseZip.TabIndex = 5;
            this.btnChooseZip.Text = "...";
            this.btnChooseZip.UseVisualStyleBackColor = true;
            this.btnChooseZip.Click += new System.EventHandler(this.btnChooseZip_Click);
            // 
            // tbImportFolder
            // 
            this.tbImportFolder.Location = new System.Drawing.Point(18, 48);
            this.tbImportFolder.Name = "tbImportFolder";
            this.tbImportFolder.Size = new System.Drawing.Size(100, 20);
            this.tbImportFolder.TabIndex = 0;
            // 
            // btnImportFolder
            // 
            this.btnImportFolder.Location = new System.Drawing.Point(176, 45);
            this.btnImportFolder.Name = "btnImportFolder";
            this.btnImportFolder.Size = new System.Drawing.Size(154, 23);
            this.btnImportFolder.TabIndex = 4;
            this.btnImportFolder.Text = "Import from folder";
            this.btnImportFolder.UseVisualStyleBackColor = true;
            this.btnImportFolder.Click += new System.EventHandler(this.btnImportFolder_Click);
            // 
            // btnImportFromZip
            // 
            this.btnImportFromZip.Location = new System.Drawing.Point(176, 16);
            this.btnImportFromZip.Name = "btnImportFromZip";
            this.btnImportFromZip.Size = new System.Drawing.Size(154, 23);
            this.btnImportFromZip.TabIndex = 4;
            this.btnImportFromZip.Text = "Import from zip";
            this.btnImportFromZip.UseVisualStyleBackColor = true;
            this.btnImportFromZip.Click += new System.EventHandler(this.btnImportFromZip_Click);
            // 
            // tbImportZip
            // 
            this.tbImportZip.Location = new System.Drawing.Point(18, 19);
            this.tbImportZip.Name = "tbImportZip";
            this.tbImportZip.Size = new System.Drawing.Size(100, 20);
            this.tbImportZip.TabIndex = 0;
            // 
            // btnCreateCollectionFromSource
            // 
            this.btnCreateCollectionFromSource.Location = new System.Drawing.Point(290, 636);
            this.btnCreateCollectionFromSource.Name = "btnCreateCollectionFromSource";
            this.btnCreateCollectionFromSource.Size = new System.Drawing.Size(157, 23);
            this.btnCreateCollectionFromSource.TabIndex = 3;
            this.btnCreateCollectionFromSource.Text = "Create Collection from Source";
            this.btnCreateCollectionFromSource.UseVisualStyleBackColor = true;
            this.btnCreateCollectionFromSource.Click += new System.EventHandler(this.btnCreateCollectionFromSource_Click);
            // 
            // btnReacreateCollections
            // 
            this.btnReacreateCollections.Location = new System.Drawing.Point(146, 636);
            this.btnReacreateCollections.Name = "btnReacreateCollections";
            this.btnReacreateCollections.Size = new System.Drawing.Size(138, 23);
            this.btnReacreateCollections.TabIndex = 3;
            this.btnReacreateCollections.Text = "Reacreate Collections";
            this.btnReacreateCollections.UseVisualStyleBackColor = true;
            this.btnReacreateCollections.Click += new System.EventHandler(this.btnReacreateCollections_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Async";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteDataInSelected
            // 
            this.btnDeleteDataInSelected.Location = new System.Drawing.Point(2, 607);
            this.btnDeleteDataInSelected.Name = "btnDeleteDataInSelected";
            this.btnDeleteDataInSelected.Size = new System.Drawing.Size(269, 23);
            this.btnDeleteDataInSelected.TabIndex = 3;
            this.btnDeleteDataInSelected.Text = "Delete data in selected collections of destination";
            this.btnDeleteDataInSelected.UseVisualStyleBackColor = true;
            this.btnDeleteDataInSelected.Click += new System.EventHandler(this.btnDeleteDataInSelected_Click);
            // 
            // cosmosDest
            // 
            this.cosmosDest.Dock = System.Windows.Forms.DockStyle.Top;
            this.cosmosDest.EndPoint = "AccountEndpoint=https://localhost:8081/;AccountKey=C2y6yDjf5/R+ob0N8A7Cgv30VRDJIW" +
    "EHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
            this.cosmosDest.Location = new System.Drawing.Point(3, 16);
            this.cosmosDest.Name = "cosmosDest";
            this.cosmosDest.Size = new System.Drawing.Size(453, 586);
            this.cosmosDest.TabIndex = 1;
            // 
            // btnOverride
            // 
            this.btnOverride.Location = new System.Drawing.Point(184, 517);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(283, 23);
            this.btnOverride.TabIndex = 3;
            this.btnOverride.Text = "Override selected collections data at destination";
            this.btnOverride.UseVisualStyleBackColor = true;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(184, 546);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(283, 23);
            this.btnMerge.TabIndex = 3;
            this.btnMerge.Text = "Merge selected collections data at destination";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 16);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(618, 112);
            this.lbLog.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 628);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 131);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lRecordsFound);
            this.groupBox4.Controls.Add(this.cbFilterList);
            this.groupBox4.Controls.Add(this.btnRunQuery);
            this.groupBox4.Controls.Add(this.jsonTreeView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(624, 698);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // lRecordsFound
            // 
            this.lRecordsFound.AutoSize = true;
            this.lRecordsFound.Location = new System.Drawing.Point(446, 0);
            this.lRecordsFound.Name = "lRecordsFound";
            this.lRecordsFound.Size = new System.Drawing.Size(64, 13);
            this.lRecordsFound.TabIndex = 3;
            this.lRecordsFound.Text = "Records:{0}";
            // 
            // cbFilterList
            // 
            this.cbFilterList.FormattingEnabled = true;
            this.cbFilterList.Location = new System.Drawing.Point(52, -3);
            this.cbFilterList.Name = "cbFilterList";
            this.cbFilterList.Size = new System.Drawing.Size(388, 21);
            this.cbFilterList.TabIndex = 2;
            this.cbFilterList.SelectedIndexChanged += new System.EventHandler(this.cbFilterList_SelectedIndexChanged);
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(539, -5);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(79, 23);
            this.btnRunQuery.TabIndex = 1;
            this.btnRunQuery.Text = "Run query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonTreeView.ImageIndex = 0;
            this.jsonTreeView.Location = new System.Drawing.Point(3, 16);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.SelectedImageIndex = 0;
            this.jsonTreeView.Size = new System.Drawing.Size(618, 679);
            this.jsonTreeView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbFilterValue4);
            this.groupBox3.Controls.Add(this.tbFilterValue3);
            this.groupBox3.Controls.Add(this.tbFilterValue2);
            this.groupBox3.Controls.Add(this.tbFilterField4);
            this.groupBox3.Controls.Add(this.tbFilterValue1);
            this.groupBox3.Controls.Add(this.tbFilterField3);
            this.groupBox3.Controls.Add(this.tbFilterField2);
            this.groupBox3.Controls.Add(this.tbFilterField1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 137);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter by field";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Field";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Field";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Field";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field";
            // 
            // tbFilterValue4
            // 
            this.tbFilterValue4.Location = new System.Drawing.Point(227, 96);
            this.tbFilterValue4.Name = "tbFilterValue4";
            this.tbFilterValue4.Size = new System.Drawing.Size(391, 20);
            this.tbFilterValue4.TabIndex = 0;
            // 
            // tbFilterValue3
            // 
            this.tbFilterValue3.Location = new System.Drawing.Point(227, 70);
            this.tbFilterValue3.Name = "tbFilterValue3";
            this.tbFilterValue3.Size = new System.Drawing.Size(391, 20);
            this.tbFilterValue3.TabIndex = 0;
            // 
            // tbFilterValue2
            // 
            this.tbFilterValue2.Location = new System.Drawing.Point(227, 44);
            this.tbFilterValue2.Name = "tbFilterValue2";
            this.tbFilterValue2.Size = new System.Drawing.Size(391, 20);
            this.tbFilterValue2.TabIndex = 0;
            // 
            // tbFilterField4
            // 
            this.tbFilterField4.Location = new System.Drawing.Point(52, 97);
            this.tbFilterField4.Name = "tbFilterField4";
            this.tbFilterField4.Size = new System.Drawing.Size(134, 20);
            this.tbFilterField4.TabIndex = 0;
            this.tbFilterField4.Text = "templateId";
            // 
            // tbFilterValue1
            // 
            this.tbFilterValue1.Location = new System.Drawing.Point(227, 18);
            this.tbFilterValue1.Name = "tbFilterValue1";
            this.tbFilterValue1.Size = new System.Drawing.Size(391, 20);
            this.tbFilterValue1.TabIndex = 0;
            // 
            // tbFilterField3
            // 
            this.tbFilterField3.Location = new System.Drawing.Point(52, 71);
            this.tbFilterField3.Name = "tbFilterField3";
            this.tbFilterField3.Size = new System.Drawing.Size(134, 20);
            this.tbFilterField3.TabIndex = 0;
            this.tbFilterField3.Text = "baseTemplateId";
            // 
            // tbFilterField2
            // 
            this.tbFilterField2.Location = new System.Drawing.Point(52, 45);
            this.tbFilterField2.Name = "tbFilterField2";
            this.tbFilterField2.Size = new System.Drawing.Size(134, 20);
            this.tbFilterField2.TabIndex = 0;
            this.tbFilterField2.Text = "anonymousTenantId";
            // 
            // tbFilterField1
            // 
            this.tbFilterField1.Location = new System.Drawing.Point(52, 19);
            this.tbFilterField1.Name = "tbFilterField1";
            this.tbFilterField1.Size = new System.Drawing.Size(134, 20);
            this.tbFilterField1.TabIndex = 0;
            this.tbFilterField1.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 63);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Query";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(618, 44);
            this.textBox1.TabIndex = 0;
            // 
            // btnCopyAsync
            // 
            this.btnCopyAsync.Location = new System.Drawing.Point(473, 546);
            this.btnCopyAsync.Name = "btnCopyAsync";
            this.btnCopyAsync.Size = new System.Drawing.Size(154, 23);
            this.btnCopyAsync.TabIndex = 3;
            this.btnCopyAsync.Text = "Copy Async to destination";
            this.btnCopyAsync.UseVisualStyleBackColor = true;
            this.btnCopyAsync.Click += new System.EventHandler(this.btnCopyAsync_Click);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpImport);
            this.tcMain.Controls.Add(this.tabPage4);
            this.tcMain.Controls.Add(this.tpQuery);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(459, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(638, 788);
            this.tcMain.TabIndex = 3;
            // 
            // tpImport
            // 
            this.tpImport.Controls.Add(this.label9);
            this.tpImport.Controls.Add(this.groupBox1);
            this.tpImport.Controls.Add(this.panel1);
            this.tpImport.Controls.Add(this.btnMerge);
            this.tpImport.Controls.Add(this.btnOverride);
            this.tpImport.Controls.Add(this.btnCopyAsync);
            this.tpImport.Location = new System.Drawing.Point(4, 22);
            this.tpImport.Name = "tpImport";
            this.tpImport.Padding = new System.Windows.Forms.Padding(3);
            this.tpImport.Size = new System.Drawing.Size(630, 762);
            this.tpImport.TabIndex = 0;
            this.tpImport.Text = "Export";
            this.tpImport.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.collectionGroupViewBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(630, 762);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Explorer";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.groupBox2);
            this.tpQuery.Controls.Add(this.groupBox3);
            this.tpQuery.Controls.Add(this.groupBox4);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(630, 704);
            this.tpQuery.TabIndex = 2;
            this.tpQuery.Text = "Query";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 42);
            this.label9.TabIndex = 6;
            this.label9.Text = "<<<<<<<";
            // 
            // collectionGroupViewBox1
            // 
            this.collectionGroupViewBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionGroupViewBox1.Location = new System.Drawing.Point(3, 3);
            this.collectionGroupViewBox1.Name = "collectionGroupViewBox1";
            this.collectionGroupViewBox1.Size = new System.Drawing.Size(624, 756);
            this.collectionGroupViewBox1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 788);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.gbDest);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cosmo Dog. Data Import/Export tool  / Author: Dmitriy Frolov";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbDest.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpImport.ResumeLayout(false);
            this.tpImport.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tpQuery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CosmosDBBox cosmosSource;
        private CosmosDBBox cosmosDest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDest;
        private System.Windows.Forms.GroupBox gbSource;
        private System.Windows.Forms.Button btnDeleteDataInSelected;
        private System.Windows.Forms.Button btnOverride;
        private System.Windows.Forms.Button btnMerge;
        public System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFilterValue3;
        private System.Windows.Forms.TextBox tbFilterValue2;
        private System.Windows.Forms.TextBox tbFilterValue1;
        private System.Windows.Forms.TextBox tbFilterField3;
        private System.Windows.Forms.TextBox tbFilterField2;
        private System.Windows.Forms.TextBox tbFilterField1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private JsonTreeView jsonTreeView;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Label lRecordsFound;
        private System.Windows.Forms.ComboBox cbFilterList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCopyAsync;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnChooseZip;
        private System.Windows.Forms.Button btnImportFromZip;
        private System.Windows.Forms.TextBox tbImportZip;
        private System.Windows.Forms.Button btnReacreateCollections;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox tbImportFolder;
        private System.Windows.Forms.Button btnImportFolder;
        private System.Windows.Forms.Button btnCreateCollectionFromSource;
        private System.Windows.Forms.Button btnSwtichConnection;
        private System.Windows.Forms.CheckBox cbBulkUpload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbFilterValue4;
        private System.Windows.Forms.TextBox tbFilterField4;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpImport;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.Label label9;
        private UIControl.CollectionGroupViewBox collectionGroupViewBox1;
    }
}

