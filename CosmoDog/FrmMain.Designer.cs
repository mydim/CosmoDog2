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
            this.gbDest = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbDeleteFilterConditionEquals = new System.Windows.Forms.CheckBox();
            this.btnDeleteDataInSelectedCollectionsAsync = new System.Windows.Forms.Button();
            this.tbDeleteFilterValue = new System.Windows.Forms.TextBox();
            this.tbMaxThreads = new System.Windows.Forms.TextBox();
            this.tbDeleteFilterField = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lMaxThreads = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbIsNeedCleanExportFolder = new System.Windows.Forms.CheckBox();
            this.tbExportPartitionValue = new System.Windows.Forms.TextBox();
            this.tbExportPartitionKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExportToFolder = new System.Windows.Forms.Button();
            this.btnChooseExportFolder = new System.Windows.Forms.Button();
            this.tbExportFolder = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbBulkUpload = new System.Windows.Forms.CheckBox();
            this.btnChooseImportFolder = new System.Windows.Forms.Button();
            this.btnChooseZip = new System.Windows.Forms.Button();
            this.tbImportFolder = new System.Windows.Forms.TextBox();
            this.btnImportFolder = new System.Windows.Forms.Button();
            this.btnImportFromZip = new System.Windows.Forms.Button();
            this.tbImportZip = new System.Windows.Forms.TextBox();
            this.btnReacreateCollections = new System.Windows.Forms.Button();
            this.btnCreateCollectionFromSource = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnOverride = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
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
            this.tpExplorer = new System.Windows.Forms.TabPage();
            this.tpExport = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.tpQuery = new System.Windows.Forms.TabPage();
            this.collectionGroupViewBox1 = new CosmoDog.UIControl.CollectionGroupViewBox();
            this.cosmosSource = new CosmoDog.CosmosDBBox();
            this.cosmosDest = new CosmoDog.CosmosDBBox();
            this.panel1.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbDest.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpExplorer.SuspendLayout();
            this.tpExport.SuspendLayout();
            this.tpQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbSource);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 499);
            this.panel1.TabIndex = 2;
            // 
            // gbSource
            // 
            this.gbSource.Controls.Add(this.btnSwtichConnection);
            this.gbSource.Controls.Add(this.cosmosSource);
            this.gbSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSource.Location = new System.Drawing.Point(0, 0);
            this.gbSource.Name = "gbSource";
            this.gbSource.Size = new System.Drawing.Size(792, 499);
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
            // gbDest
            // 
            this.gbDest.Controls.Add(this.groupBox7);
            this.gbDest.Controls.Add(this.groupBox6);
            this.gbDest.Controls.Add(this.groupBox1);
            this.gbDest.Controls.Add(this.groupBox5);
            this.gbDest.Controls.Add(this.btnReacreateCollections);
            this.gbDest.Controls.Add(this.cosmosDest);
            this.gbDest.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbDest.Location = new System.Drawing.Point(0, 0);
            this.gbDest.Name = "gbDest";
            this.gbDest.Size = new System.Drawing.Size(291, 927);
            this.gbDest.TabIndex = 3;
            this.gbDest.TabStop = false;
            this.gbDest.Text = "Destination DB for Import / Main Connection";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbDeleteFilterConditionEquals);
            this.groupBox7.Controls.Add(this.btnDeleteDataInSelectedCollectionsAsync);
            this.groupBox7.Controls.Add(this.tbDeleteFilterValue);
            this.groupBox7.Controls.Add(this.tbMaxThreads);
            this.groupBox7.Controls.Add(this.tbDeleteFilterField);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.lMaxThreads);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Location = new System.Drawing.Point(6, 480);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 109);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Delete";
            // 
            // cbDeleteFilterConditionEquals
            // 
            this.cbDeleteFilterConditionEquals.AutoSize = true;
            this.cbDeleteFilterConditionEquals.Location = new System.Drawing.Point(38, 69);
            this.cbDeleteFilterConditionEquals.Name = "cbDeleteFilterConditionEquals";
            this.cbDeleteFilterConditionEquals.Size = new System.Drawing.Size(57, 17);
            this.cbDeleteFilterConditionEquals.TabIndex = 9;
            this.cbDeleteFilterConditionEquals.Text = "equals";
            this.cbDeleteFilterConditionEquals.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDataInSelectedCollectionsAsync
            // 
            this.btnDeleteDataInSelectedCollectionsAsync.Location = new System.Drawing.Point(163, 69);
            this.btnDeleteDataInSelectedCollectionsAsync.Name = "btnDeleteDataInSelectedCollectionsAsync";
            this.btnDeleteDataInSelectedCollectionsAsync.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteDataInSelectedCollectionsAsync.TabIndex = 3;
            this.btnDeleteDataInSelectedCollectionsAsync.Text = "Delete Async";
            this.btnDeleteDataInSelectedCollectionsAsync.UseVisualStyleBackColor = true;
            this.btnDeleteDataInSelectedCollectionsAsync.Click += new System.EventHandler(this.btnDeleteDataInSelectedCollectionsAsync_Click);
            // 
            // tbDeleteFilterValue
            // 
            this.tbDeleteFilterValue.Location = new System.Drawing.Point(209, 43);
            this.tbDeleteFilterValue.Name = "tbDeleteFilterValue";
            this.tbDeleteFilterValue.Size = new System.Drawing.Size(58, 20);
            this.tbDeleteFilterValue.TabIndex = 6;
            // 
            // tbMaxThreads
            // 
            this.tbMaxThreads.Location = new System.Drawing.Point(209, 17);
            this.tbMaxThreads.Name = "tbMaxThreads";
            this.tbMaxThreads.Size = new System.Drawing.Size(53, 20);
            this.tbMaxThreads.TabIndex = 7;
            this.tbMaxThreads.Text = "10";
            this.tbMaxThreads.TextChanged += new System.EventHandler(this.tbMaxThreads_TextChanged);
            // 
            // tbDeleteFilterField
            // 
            this.tbDeleteFilterField.Location = new System.Drawing.Point(38, 43);
            this.tbDeleteFilterField.Name = "tbDeleteFilterField";
            this.tbDeleteFilterField.Size = new System.Drawing.Size(125, 20);
            this.tbDeleteFilterField.TabIndex = 7;
            this.tbDeleteFilterField.Text = "anonymousTenantId";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Filter";
            // 
            // lMaxThreads
            // 
            this.lMaxThreads.AutoSize = true;
            this.lMaxThreads.Location = new System.Drawing.Point(128, 20);
            this.lMaxThreads.Name = "lMaxThreads";
            this.lMaxThreads.Size = new System.Drawing.Size(69, 13);
            this.lMaxThreads.TabIndex = 8;
            this.lMaxThreads.Text = "Max Threads";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Value";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbIsNeedCleanExportFolder);
            this.groupBox6.Controls.Add(this.tbExportPartitionValue);
            this.groupBox6.Controls.Add(this.tbExportPartitionKey);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.btnExportToFolder);
            this.groupBox6.Controls.Add(this.btnChooseExportFolder);
            this.groupBox6.Controls.Add(this.tbExportFolder);
            this.groupBox6.Location = new System.Drawing.Point(6, 721);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 77);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Export data to folder";
            // 
            // cbIsNeedCleanExportFolder
            // 
            this.cbIsNeedCleanExportFolder.AutoSize = true;
            this.cbIsNeedCleanExportFolder.Checked = true;
            this.cbIsNeedCleanExportFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsNeedCleanExportFolder.Location = new System.Drawing.Point(118, 52);
            this.cbIsNeedCleanExportFolder.Name = "cbIsNeedCleanExportFolder";
            this.cbIsNeedCleanExportFolder.Size = new System.Drawing.Size(85, 17);
            this.cbIsNeedCleanExportFolder.TabIndex = 6;
            this.cbIsNeedCleanExportFolder.Text = "Clean Folder";
            this.cbIsNeedCleanExportFolder.UseVisualStyleBackColor = true;
            this.cbIsNeedCleanExportFolder.Visible = false;
            // 
            // tbExportPartitionValue
            // 
            this.tbExportPartitionValue.Location = new System.Drawing.Point(209, 19);
            this.tbExportPartitionValue.Name = "tbExportPartitionValue";
            this.tbExportPartitionValue.Size = new System.Drawing.Size(58, 20);
            this.tbExportPartitionValue.TabIndex = 6;
            this.tbExportPartitionValue.Text = "0";
            // 
            // tbExportPartitionKey
            // 
            this.tbExportPartitionKey.Location = new System.Drawing.Point(38, 19);
            this.tbExportPartitionKey.Name = "tbExportPartitionKey";
            this.tbExportPartitionKey.Size = new System.Drawing.Size(125, 20);
            this.tbExportPartitionKey.TabIndex = 7;
            this.tbExportPartitionKey.Text = "anonymousTenantId";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "PK";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Value";
            // 
            // btnExportToFolder
            // 
            this.btnExportToFolder.Location = new System.Drawing.Point(209, 48);
            this.btnExportToFolder.Name = "btnExportToFolder";
            this.btnExportToFolder.Size = new System.Drawing.Size(56, 23);
            this.btnExportToFolder.TabIndex = 4;
            this.btnExportToFolder.Text = "Export";
            this.btnExportToFolder.UseVisualStyleBackColor = true;
            this.btnExportToFolder.Click += new System.EventHandler(this.btnExportToFolder_Click);
            // 
            // btnChooseExportFolder
            // 
            this.btnChooseExportFolder.Location = new System.Drawing.Point(77, 48);
            this.btnChooseExportFolder.Name = "btnChooseExportFolder";
            this.btnChooseExportFolder.Size = new System.Drawing.Size(35, 23);
            this.btnChooseExportFolder.TabIndex = 5;
            this.btnChooseExportFolder.Text = "...";
            this.btnChooseExportFolder.UseVisualStyleBackColor = true;
            this.btnChooseExportFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // tbExportFolder
            // 
            this.tbExportFolder.Location = new System.Drawing.Point(6, 51);
            this.tbExportFolder.Name = "tbExportFolder";
            this.tbExportFolder.Size = new System.Drawing.Size(65, 20);
            this.tbExportFolder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 804);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // lbLog
            // 
            this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 16);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(279, 101);
            this.lbLog.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbBulkUpload);
            this.groupBox5.Controls.Add(this.btnChooseImportFolder);
            this.groupBox5.Controls.Add(this.btnChooseZip);
            this.groupBox5.Controls.Add(this.tbImportFolder);
            this.groupBox5.Controls.Add(this.btnImportFolder);
            this.groupBox5.Controls.Add(this.btnImportFromZip);
            this.groupBox5.Controls.Add(this.tbImportZip);
            this.groupBox5.Location = new System.Drawing.Point(6, 624);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 94);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Import data";
            // 
            // cbBulkUpload
            // 
            this.cbBulkUpload.AutoSize = true;
            this.cbBulkUpload.Checked = true;
            this.cbBulkUpload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBulkUpload.Location = new System.Drawing.Point(6, 74);
            this.cbBulkUpload.Name = "cbBulkUpload";
            this.cbBulkUpload.Size = new System.Drawing.Size(84, 17);
            this.cbBulkUpload.TabIndex = 6;
            this.cbBulkUpload.Text = "Bulk Upload";
            this.cbBulkUpload.UseVisualStyleBackColor = true;
            this.cbBulkUpload.Visible = false;
            // 
            // btnChooseImportFolder
            // 
            this.btnChooseImportFolder.Location = new System.Drawing.Point(77, 46);
            this.btnChooseImportFolder.Name = "btnChooseImportFolder";
            this.btnChooseImportFolder.Size = new System.Drawing.Size(35, 23);
            this.btnChooseImportFolder.TabIndex = 5;
            this.btnChooseImportFolder.Text = "...";
            this.btnChooseImportFolder.UseVisualStyleBackColor = true;
            this.btnChooseImportFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnChooseZip
            // 
            this.btnChooseZip.Location = new System.Drawing.Point(77, 17);
            this.btnChooseZip.Name = "btnChooseZip";
            this.btnChooseZip.Size = new System.Drawing.Size(35, 23);
            this.btnChooseZip.TabIndex = 5;
            this.btnChooseZip.Text = "...";
            this.btnChooseZip.UseVisualStyleBackColor = true;
            this.btnChooseZip.Click += new System.EventHandler(this.btnChooseZip_Click);
            // 
            // tbImportFolder
            // 
            this.tbImportFolder.Location = new System.Drawing.Point(6, 48);
            this.tbImportFolder.Name = "tbImportFolder";
            this.tbImportFolder.Size = new System.Drawing.Size(65, 20);
            this.tbImportFolder.TabIndex = 0;
            // 
            // btnImportFolder
            // 
            this.btnImportFolder.Location = new System.Drawing.Point(164, 45);
            this.btnImportFolder.Name = "btnImportFolder";
            this.btnImportFolder.Size = new System.Drawing.Size(101, 23);
            this.btnImportFolder.TabIndex = 4;
            this.btnImportFolder.Text = "Import from folder";
            this.btnImportFolder.UseVisualStyleBackColor = true;
            this.btnImportFolder.Click += new System.EventHandler(this.btnImportFolder_Click);
            // 
            // btnImportFromZip
            // 
            this.btnImportFromZip.Location = new System.Drawing.Point(164, 16);
            this.btnImportFromZip.Name = "btnImportFromZip";
            this.btnImportFromZip.Size = new System.Drawing.Size(101, 23);
            this.btnImportFromZip.TabIndex = 4;
            this.btnImportFromZip.Text = "Import from zip";
            this.btnImportFromZip.UseVisualStyleBackColor = true;
            this.btnImportFromZip.Click += new System.EventHandler(this.btnImportFromZip_Click);
            // 
            // tbImportZip
            // 
            this.tbImportZip.Location = new System.Drawing.Point(6, 19);
            this.tbImportZip.Name = "tbImportZip";
            this.tbImportZip.Size = new System.Drawing.Size(65, 20);
            this.tbImportZip.TabIndex = 0;
            // 
            // btnReacreateCollections
            // 
            this.btnReacreateCollections.Location = new System.Drawing.Point(12, 595);
            this.btnReacreateCollections.Name = "btnReacreateCollections";
            this.btnReacreateCollections.Size = new System.Drawing.Size(138, 23);
            this.btnReacreateCollections.TabIndex = 3;
            this.btnReacreateCollections.Text = "Reacreate Collections";
            this.btnReacreateCollections.UseVisualStyleBackColor = true;
            this.btnReacreateCollections.Click += new System.EventHandler(this.btnReacreateCollections_Click);
            // 
            // btnCreateCollectionFromSource
            // 
            this.btnCreateCollectionFromSource.Location = new System.Drawing.Point(184, 596);
            this.btnCreateCollectionFromSource.Name = "btnCreateCollectionFromSource";
            this.btnCreateCollectionFromSource.Size = new System.Drawing.Size(191, 23);
            this.btnCreateCollectionFromSource.TabIndex = 3;
            this.btnCreateCollectionFromSource.Text = "Create collections from Source";
            this.btnCreateCollectionFromSource.UseVisualStyleBackColor = true;
            this.btnCreateCollectionFromSource.Click += new System.EventHandler(this.btnDeleteDataInSelectedCollectionsAsync_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(291, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 927);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lRecordsFound);
            this.groupBox4.Controls.Add(this.cbFilterList);
            this.groupBox4.Controls.Add(this.btnRunQuery);
            this.groupBox4.Controls.Add(this.jsonTreeView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(792, 895);
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
            this.jsonTreeView.Size = new System.Drawing.Size(786, 876);
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
            this.groupBox3.Size = new System.Drawing.Size(792, 137);
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
            this.groupBox2.Size = new System.Drawing.Size(792, 63);
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
            this.textBox1.Size = new System.Drawing.Size(786, 44);
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
            this.tcMain.Controls.Add(this.tpExplorer);
            this.tcMain.Controls.Add(this.tpExport);
            this.tcMain.Controls.Add(this.tpQuery);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(291, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(806, 927);
            this.tcMain.TabIndex = 3;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpExplorer
            // 
            this.tpExplorer.Controls.Add(this.collectionGroupViewBox1);
            this.tpExplorer.Location = new System.Drawing.Point(4, 22);
            this.tpExplorer.Name = "tpExplorer";
            this.tpExplorer.Padding = new System.Windows.Forms.Padding(3);
            this.tpExplorer.Size = new System.Drawing.Size(798, 901);
            this.tpExplorer.TabIndex = 1;
            this.tpExplorer.Text = "Explorer";
            this.tpExplorer.UseVisualStyleBackColor = true;
            // 
            // tpExport
            // 
            this.tpExport.Controls.Add(this.label9);
            this.tpExport.Controls.Add(this.panel1);
            this.tpExport.Controls.Add(this.btnMerge);
            this.tpExport.Controls.Add(this.btnOverride);
            this.tpExport.Controls.Add(this.btnCreateCollectionFromSource);
            this.tpExport.Controls.Add(this.btnCopyAsync);
            this.tpExport.Location = new System.Drawing.Point(4, 22);
            this.tpExport.Name = "tpExport";
            this.tpExport.Padding = new System.Windows.Forms.Padding(3);
            this.tpExport.Size = new System.Drawing.Size(798, 901);
            this.tpExport.TabIndex = 0;
            this.tpExport.Text = "Export";
            this.tpExport.UseVisualStyleBackColor = true;
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
            // tpQuery
            // 
            this.tpQuery.Controls.Add(this.groupBox2);
            this.tpQuery.Controls.Add(this.groupBox3);
            this.tpQuery.Controls.Add(this.groupBox4);
            this.tpQuery.Location = new System.Drawing.Point(4, 22);
            this.tpQuery.Name = "tpQuery";
            this.tpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuery.Size = new System.Drawing.Size(798, 901);
            this.tpQuery.TabIndex = 2;
            this.tpQuery.Text = "Query";
            this.tpQuery.UseVisualStyleBackColor = true;
            // 
            // collectionGroupViewBox1
            // 
            this.collectionGroupViewBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectionGroupViewBox1.Location = new System.Drawing.Point(3, 3);
            this.collectionGroupViewBox1.Name = "collectionGroupViewBox1";
            this.collectionGroupViewBox1.Size = new System.Drawing.Size(792, 895);
            this.collectionGroupViewBox1.TabIndex = 0;
            // 
            // cosmosSource
            // 
            this.cosmosSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cosmosSource.EndPoint = "AccountEndpoint=https://stp-nosqlacct-v-degop2.documents.azure.com:443/;AccountKe" +
    "y=QUTGAtthw8z1tnsEZIKqhPQjcQlHLPNh6OyILi27gqlwFnasCHvfn2Atx5ztSmzzpllFlHIvX3TWmh" +
    "VqVmawRQ==";
            this.cosmosSource.Location = new System.Drawing.Point(3, 16);
            this.cosmosSource.Name = "cosmosSource";
            this.cosmosSource.Size = new System.Drawing.Size(786, 480);
            this.cosmosSource.TabIndex = 0;
            // 
            // cosmosDest
            // 
            this.cosmosDest.Dock = System.Windows.Forms.DockStyle.Top;
            this.cosmosDest.EndPoint = "AccountEndpoint=https://stp-nosqlacct-v-dmfro2.documents.azure.com:443/;AccountKe" +
    "y=yagValEDVjeRMpFQLWX3P8FzrjCckkVF49Xo0k1XFCw9knoIjRNfFaHwcuIhAdVM95rxdAvvRbprZd" +
    "qPpHTk3Q==;";
            this.cosmosDest.Location = new System.Drawing.Point(3, 16);
            this.cosmosDest.Name = "cosmosDest";
            this.cosmosDest.Size = new System.Drawing.Size(285, 458);
            this.cosmosDest.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 927);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.gbDest);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cosmo Dog. Data Import/Export tool  / Author: Dmitriy Frolov";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbDest.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpExplorer.ResumeLayout(false);
            this.tpExport.ResumeLayout(false);
            this.tpExport.PerformLayout();
            this.tpQuery.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private CosmosDBBox cosmosSource;
        private CosmosDBBox cosmosDest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDest;
        private System.Windows.Forms.GroupBox gbSource;
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
        private System.Windows.Forms.Button btnDeleteDataInSelectedCollectionsAsync;
        private System.Windows.Forms.Button btnCopyAsync;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnChooseZip;
        private System.Windows.Forms.Button btnImportFromZip;
        private System.Windows.Forms.TextBox tbImportZip;
        private System.Windows.Forms.Button btnReacreateCollections;
        private System.Windows.Forms.Button btnChooseImportFolder;
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
        private System.Windows.Forms.TabPage tpExport;
        private System.Windows.Forms.TabPage tpExplorer;
        private System.Windows.Forms.TabPage tpQuery;
        private System.Windows.Forms.Label label9;
        private UIControl.CollectionGroupViewBox collectionGroupViewBox1;
        private System.Windows.Forms.Label lMaxThreads;
        private System.Windows.Forms.TextBox tbMaxThreads;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbIsNeedCleanExportFolder;
        private System.Windows.Forms.TextBox tbExportPartitionValue;
        private System.Windows.Forms.TextBox tbExportPartitionKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExportToFolder;
        private System.Windows.Forms.Button btnChooseExportFolder;
        private System.Windows.Forms.TextBox tbExportFolder;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbDeleteFilterConditionEquals;
        private System.Windows.Forms.TextBox tbDeleteFilterValue;
        private System.Windows.Forms.TextBox tbDeleteFilterField;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

