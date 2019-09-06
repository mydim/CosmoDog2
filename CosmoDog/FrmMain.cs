using Microsoft.Azure.Documents.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Linq;
using System.Threading;
using System.Diagnostics;
using System.IO.Compression;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using Microsoft.Azure.CosmosDB.BulkExecutor;
using MongoDB.Bson;
using Newtonsoft.Json.Linq;
using Exception = System.Exception;

namespace CosmoDog
{
    public partial class FrmMain : Form
    {
        public static string DefaultText;

        public static FrmMain Instance;
        public FrmMain()
        {
            FrmMain.Instance = this;
            
            InitializeComponent();
            FrmMain.DefaultText = this.Text;

            tbMaxThreads.Text = RegistryUtils.Read("CosmoDog-MaxThreads", MaxThreads.ToString());
            tbMaxThreads_TextChanged(null, null);

            tbImportFolder.Text = RegistryUtils.Read("CosmoDog-ImportFolder", "");
            tbImportZip.Text = RegistryUtils.Read("CosmoDog-ImportZip", "");

            tbExportFolder.Text = RegistryUtils.Read("CosmoDog-ExportFolder", "");
            
        }

        public Document GetDocument(DocumentClient client, string altLink, string id)
        {
            var document = client.CreateDocumentQuery(altLink,new FeedOptions() {EnableCrossPartitionQuery = true}) //, PartitionKey = ro.PartitionKey})
                .Where(d => d.Id == id).AsEnumerable().FirstOrDefault();
            return document;
        }

        #region Base Async
        
        private void UpdateProgress(string text, object doc=null)
        {
            Debug.WriteLine(text);
            //Instance.lbLog.Invoke(new Action(() => FrmMain.Instance.UpdateProgressStatic(text, doc)));
        }

        public void UpdateProgressStatic(string text, Document doc)
        {
            Debug.WriteLine(text);
            //Thread.Sleep(1000);
            //Instance.LogWriteLine(text + " " + doc.Id);
            //
            //Application.DoEvents();
        }

        #endregion

        #region Delete Async
        public async Task DeleteDocumentQueue(int maxThreads, IList<Document> docs, DocumentCollection col)
        {
            var options = new ParallelOptions() { MaxDegreeOfParallelism = maxThreads };
            Parallel.ForEach(docs, options, doc =>
            {
                try
                {
                    DeleteDocument(doc, col);
                    
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
                
            });
        }

        public void DeleteDocument(Document doc, DocumentCollection col)
        {
            try
            {
                this.UpdateProgress("Deleting document id:"+doc.Id+" Col:"+col.Id, doc);
                if (col.PartitionKey?.Paths.Count > 0)
                {
                    var a = doc.GetPropertyValue<dynamic>(col.PartitionKey?.Paths[0].Replace("/", ""));
                    var ro = new RequestOptions();
                    ro.ConsistencyLevel = ConsistencyLevel.Session;
                    ro.PartitionKey = new PartitionKey(a ?? "");

                    cosmosDest.Client.DeleteDocumentAsync(doc.AltLink, ro).Wait();
                }
                else
                {
                    cosmosDest.Client.DeleteDocumentAsync(doc.SelfLink).Wait();
                }
                this.UpdateProgress("Delete document id:"+doc.Id+" Col:"+col.Id, doc);
            }
            catch (Exception e)
            {
                try
                {       
                    if (col.PartitionKey?.Paths.Count > 0)
                    {
                        var a = doc.GetPropertyValue<dynamic>(col.PartitionKey?.Paths[0].Replace("/", ""));
                        var ro = new RequestOptions();
                        ro.ConsistencyLevel = ConsistencyLevel.Session;
                        ro.PartitionKey = new PartitionKey(Undefined.Value);

                        cosmosDest.Client.DeleteDocumentAsync(doc.AltLink, ro).Wait();
                    }
                }
                catch (Exception exception)
                {
                }
                this.UpdateProgress("Cannot !!! delete doc " + doc.Id + " from " + col.Id, doc);
            }
        }

        #endregion

        #region Copy async
        public async Task CopyDocumentQueue(int maxThreads, IList<Document> docs, DocumentCollection colSource)
        {
            var options = new ParallelOptions() { MaxDegreeOfParallelism = maxThreads };

            Parallel.ForEach(docs, options, doc =>
            {
                try
                {
                    CopyDocument(doc, colSource);
                    this.UpdateProgress("Copy doc " + doc.Id + " in " + colSource.Id, doc);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
             
                //Thread.Sleep(250);
            });

        }
        
        
        public void CopyDocument(Document doc, DocumentCollection colSource)
        {
            try
            {
                var ro = new RequestOptions();
                if (colSource.PartitionKey?.Paths.Count > 0)
                {
                    var a = doc.GetPropertyValue<dynamic>(colSource.PartitionKey?.Paths[0].Replace("/", ""));
                    ro.PartitionKey = new PartitionKey(a);
                }

                var colDest = cosmosDest.DocumentCollectionDict[colSource.Id];
                cosmosDest.Client.UpsertDocumentAsync(colDest.SelfLink, doc, ro).Wait();
            }
            catch (Exception e)
            {
                this.UpdateProgress("Cannot !!! Copy doc " + doc.Id + " from " + colSource.Id, doc);
            }
        }
        #endregion

        #region Export Documents Async
        public async Task ExportDocumentQueue(int maxThreads, IList<JObject> docs, DocumentCollection col, string folder)
        {
            folder = folder + "\\Tenant." + col.Id+"\\";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            var options = new ParallelOptions() { MaxDegreeOfParallelism = maxThreads };
            Parallel.ForEach(docs, options, doc =>
            {
                try
                {
                    ExportDocument(doc, col, folder);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
                
            });
        }

        public void ExportDocument(JObject doc, DocumentCollection col, string folder)
        {
            var id = doc.GetValue("id");
            if (id == null)
            {
            }

            try
            {
                
                this.UpdateProgress("Export document id:"+id+" Col:"+col.Id, doc);

                var fileName = folder +id + ".json";
                
                using (var file = new System.IO.StreamWriter(fileName, false))
                {
                    var jsondata = doc.ToString();
                    file.Write(jsondata);
                }
            }
            catch (Exception e)
            {
                this.UpdateProgress("Cannot !!! export doc " + id + " from " + col.Id, doc);
            }
        }

        #endregion

        //public void DeleteDataInSelectedCollections()
        //{
        //    foreach (var coll in cosmosDest.SelectedCollections)
        //    {
        //        LogWriteLine("Delete from " + coll.Id);

        //        var docs = cosmosDest.Client.CreateDocumentQuery(coll.DocumentsLink);
        //        foreach (var doc in docs)
        //        {
        //            LogWriteLine("Delete doc " + doc.Id + " in " + coll.Id);
        //            try
        //            {
        //                DeleteDocument(doc, coll);

                        
        //            }
        //            catch (Exception e)
        //            {
        //                LogWriteLine("Cannot !!! Delete doc " + doc.Id + " in " + coll.Id);
                        
        //            }
                    
        //        }
        //    }
        //    LogWriteLine("Deleting done!");
        //}

        public void CopyFromSourceToDestination()
        {
            foreach (var coll in cosmosSource.SelectedCollections)
            {
                LogWriteLine("Copy from " + coll.Id);

                var docs = cosmosSource.Client.CreateDocumentQuery(coll.DocumentsLink, new FeedOptions() {EnableCrossPartitionQuery = true});

                ResetDestinationColletion(coll, false);

                foreach (var doc in docs)
                {
                    LogWriteLine("Copy doc " + doc.Id + " in " + coll.Id);
                    try
                    {
                        var ro = new RequestOptions();
                        if (coll.PartitionKey?.Paths.Count > 0)
                        {
                            var a = doc.GetPropertyValue<dynamic>(coll.PartitionKey?.Paths[0].Replace("/", ""));
                            ro.PartitionKey = new PartitionKey(a);
                        }

                        var dest = cosmosDest.DocumentCollectionDict[coll.Id];
                        cosmosDest.Client.UpsertDocumentAsync(dest.SelfLink, doc, ro).Wait();
                        

                    }
                    catch (Exception e)
                    {
                        LogWriteLine("Cannot !!! Copy doc " + doc.Id + " in " + coll.Id);
                    }
                }
            }

            LogWriteLine("Copy done!");
        }

        //private void btnDeleteDataInSelected_Click(object sender, EventArgs e)
        //{
        //    lbLog.Items.Clear();
        //    DeleteDataInSelectedCollections();
        //}

        private void btnOverride_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
            DeleteDataInSelectedCollectionsAsync();
            CopyFromSourceToDestination();
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            lbLog.Items.Clear();
            CopyFromSourceToDestination();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cosmosDest.SelectedCollection == null)
            {
                Text = "Please select collection";
                return;
            }

            this.Text = FrmMain.DefaultText = this.Text;
            
            //cosmosDest.Client.CreateDocumentQuery(cosmosDest.SelectedCollection.Name, )

            //var uri=  UriFactory.CreateDocumentCollectionUri(cosmosDest.Database.Id, cosmosDest.SelectedCollection.Obj.Id, tbFilterField1.Text);
            //.ToString(), tbFilterField1.Text);
            
            var baseDocumentQuery = cosmosDest.Client.CreateDocumentQuery(cosmosDest.SelectedCollection.Obj.SelfLink, new FeedOptions(){EnableCrossPartitionQuery = true});
          
            // Add any optional filter or sorting functions that were specified.
            var query = baseDocumentQuery.Where(x=> x.Id == tbFilterValue1.Text);
            var run = query.AsDocumentQuery();
            var response = run.ExecuteNextAsync();
            //var response = baseDocumentQuery.Select(x=> x.Id == tbFilterValue1.Text);
            var data = response.Result.FirstOrDefault();

            //if (data == null)
            //{
            //    query = baseDocumentQuery.Where(x=> x.tr == tbFilterValue1.Text);
            //    run = query.AsDocumentQuery();
            //     response = run.ExecuteNextAsync();
            //    //var response = baseDocumentQuery.Select(x=> x.Id == tbFilterValue1.Text);
            //    data = response.Result.FirstOrDefault();
            //}

            //cosmosDest.Client.ReadDocumentAsync(UriFactory.CreateDocumentUri(cosmosDest.Database.Id,
                //cosmosDest.SelectedCollection.Obj.Id, tbFilterField1.Text), new FeedOptions(){EnableCrossPartitionQuery = true}).Result;

            if (data != null)
            {
                jsonTreeView.ShowJson(data.ToString());
            }

            var list = GetListOfDocuments(cosmosDest.Client, cosmosDest.SelectedCollection.Obj.SelfLink);
            cbFilterList.Items.Clear();
            list.ForEach(x => cbFilterList.Items.Add(x));
        }

        public List<dynamic> GetListOfDocuments(DocumentClient client, string collection)
        {
            var baseDocumentQuery = client.CreateDocumentQuery(collection, new FeedOptions(){EnableCrossPartitionQuery = true});
        //    var query = baseDocumentQuery.Where(x=> x.Id == tbFilterValue1.Text);
            var run = baseDocumentQuery.AsDocumentQuery();
            var response = run.ExecuteNextAsync();

            return response.Result.ToList();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cosmosDest.Init();

            collectionGroupViewBox1.Init(cosmosDest);
        }

        private void btnDeleteDataInSelectedCollectionsAsync_Click(object sender, EventArgs e)
        {
            DeleteDataInSelectedCollectionsAsync();
        }


        void DeleteDataInSelectedCollectionsAsync()
        {
            foreach (var coll in cosmosDest.SelectedCollections)
            {
                LogWriteLine("Delete from " + coll.Id);

                var docs = cosmosDest.Client.CreateDocumentQuery(coll.DocumentsLink, new FeedOptions() { EnableCrossPartitionQuery = true });
                var list = docs.ToList();
                if (tbDeleteFilterValue.Text != "")
                {
                    if (cbDeleteFilterConditionEquals.Checked)
                    {
                        list = list.Where(i => i.GetPropertyValue<JValue>(tbDeleteFilterField.Text).Value.ToString() == tbDeleteFilterValue.Text).ToList();
                    }
                    else
                    {
                        list = list.Where(i => i.GetPropertyValue<JValue>(tbDeleteFilterField.Text).Value.ToString() != tbDeleteFilterValue.Text).ToList();
                    }
                }

                DeleteDocumentQueue(MaxThreads, list, coll).Wait();

            }
            LogWriteLine("Deleting done!");
        }

        private void ResetDestinationColletion(DocumentCollection colSource, bool needDelete = false)
        {
            var dc = new DocumentCollection();
            dc.Id = colSource.Id;
            if (colSource.PartitionKey?.Paths.Count > 0)
            {
                var pk = colSource.PartitionKey?.Paths[0];
                dc.PartitionKey = new PartitionKeyDefinition();
                dc.PartitionKey.Paths = new Collection<string>(){pk};
            }

            if (needDelete)
            {
                var uri= UriFactory.CreateDocumentCollectionUri(cosmosDest.Database.Id, colSource.Id);

                cosmosDest.Client.DeleteDocumentCollectionAsync(uri).Wait();
            }

            cosmosDest.Client.CreateDocumentCollectionIfNotExistsAsync(cosmosDest.DatabaseSelfLink, dc, new RequestOptions {OfferThroughput = 1000}).Wait();
        }

        private int MaxThreads = 10;
        private void btnCopyAsync_Click(object sender, EventArgs e)
        {
            var tasks = new List<Task>();

            //var options = new ParallelOptions() { MaxDegreeOfParallelism = maxThreads };
            
            //Parallel.ForEach(cosmosSource.SelectedCollections, options, doc =>

            foreach (var coll in cosmosSource.SelectedCollections)
            {
                LogWriteLine("Copy from " + coll.Id);

                var docs = cosmosSource.Client.CreateDocumentQuery(coll.DocumentsLink,
                    new FeedOptions() {EnableCrossPartitionQuery = true});

                CopyDocumentQueue(MaxThreads, docs.ToList(), coll).Wait();
            }


            LogWriteLine("Copy done!");
        }

        // using Microsoft.Win32;
        string GetDownloadFolderPath() 
        {
            return Registry.GetValue(@"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", String.Empty).ToString();
        }

        private void btnChooseZip_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = GetDownloadFolderPath();
                openFileDialog.Filter = "zip (*.zip)|*.zip";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    tbImportZip.Text = openFileDialog.FileName;
                }
                
            }
            
        }

        void LogWriteLine(string str)
        {
            lbLog.Items.Add(str);
            lbLog.SelectedIndex = lbLog.Items.Count - 1;
        }

        private void btnImportFromZip_Click(object sender, EventArgs e)
        {
            try
            {
                LogWriteLine("Unzip...");
                var zipFile = tbImportZip.Text;
                var tempFolder = GetTempDirectory();
                ZipFile.ExtractToDirectory(zipFile, tempFolder);
                var rootFolder = Directory.GetDirectories(tempFolder).First();
                tbImportFolder.Text = rootFolder;
                ImportFromFolder(rootFolder);
            }
            catch (Exception exception)
            {
                LogWriteLine("Exception: "+ exception.Message);
            }
        }

        void ImportFromFolder(string rootFolder)
        {
            try
            {
                var start = DateTime.Now;
                LogWriteLine("Upload start " + start);
                var jsons = Directory.GetFiles(rootFolder, "*.json");
                //LogWriteLine("Upload assessements from " + rootFolder);
                foreach (var json in jsons)
                {
                    var fileName = Path.GetFileName(json).ToLower().Replace(".json", "").Replace("tenant.", "");
                    LogWriteLine("Upload file:" + fileName);
                    ImportFileToCollectionAsync(json, fileName);

                    //LogWriteLine("Upload ControlFamilies...");
                    //ImportFolderJsonsToCollection(folder + @"\Tenant.ControlFamilies", "ControlFamilyLookupV3");
                }


                //LogWriteLine("Upload ComplianceDashboardTiles...");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.ComplianceDashboardTileV3", "ComplianceDashboardTileV3");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.ComplianceDashboardTileV3.1", "ComplianceDashboardTileV3.1");

                //LogWriteLine("Upload ControlFamilyLookupV3...");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.ControlFamilyLookupV3", "ControlFamilyLookupV3");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.ControlFamilyLookupV3.1", "ControlFamilyLookupV3.1");

                //LogWriteLine("Upload CustomerActions...");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.CustomerActionLookupV3",
                //    "CustomerActionLookupV3");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.CustomerActionLookupV3.1",
                //    "CustomerActionLookupV3.1");

                //LogWriteLine("Upload Lookups...");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.LookUpStorageV3", "LookUpStorageV3");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.LookUpStorageV3.1", "LookUpStorageV3.1");

                //LogWriteLine("Upload UserActions...");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.UserActionsV3", "UserActionsV3");
                //ImportFolderJsonsToCollection(rootFolder + @"\Tenant.UserActionsV3.1", "UserActionsV3.1");

                LogWriteLine("Upload Done!");
                var end = DateTime.Now - start;
                LogWriteLine("Duration: " + end.TotalSeconds);
            }
            catch (Exception exception)
            {
                LogWriteLine("Exception: " + exception.Message);
            }
        }

        private async Task ImportFileToCollectionAsync(string jsonFile, string collectionIdDestination)
        {
            //if (!Directory.Exists(folder))
            //{
            //    return;
            //}

            var options = new ParallelOptions() {MaxDegreeOfParallelism = MaxThreads};

            //var jsonFiles = Directory.GetFiles(folder, "*.json");

            var documentsToImportInBatch = new List<string>();
            //foreach (var jsonFile in jsonFiles)
            //{
                documentsToImportInBatch.Add(File.ReadAllText(jsonFile));
            //}

            if (cbBulkUpload.Checked)
            {
                var dataCollection = cosmosDest.DocumentCollectionDict[collectionIdDestination];
                IBulkExecutor bulkExecutor = new BulkExecutor(cosmosDest.Client, dataCollection);
                await bulkExecutor.InitializeAsync();
                //var bulkExecutor = new BulkImportAsync(cosmosDest.Client, dataCollection);
                //bulkExecutor.InitializeAsync().Wait();
                // Set retries to 0 to pass complete control to bulk executor.
                cosmosDest.Client.ConnectionPolicy.RetryOptions.MaxRetryWaitTimeInSeconds = 0;
                cosmosDest.Client.ConnectionPolicy.RetryOptions.MaxRetryAttemptsOnThrottledRequests = 0;
                var tokenSource = new CancellationTokenSource();
                var token = tokenSource.Token;


                //Parallel.ForEach(jsonFiles, options,
                //    jsonFile => { documentsToImportInBatch.Add(File.ReadAllText(jsonFile)); });

                //var s = "{  \"name\": \"Afzaal Ahmad Zeeshan\",  \"id\": {"+Guid.NewGuid()+"}  /} ";

                try
                {


                    await bulkExecutor.BulkImportAsync(
                        documentsToImportInBatch,
                        enableUpsert: true,
                        disableAutomaticIdGeneration: true,
                        maxConcurrencyPerPartitionKeyRange: 2000,
                        maxInMemorySortingBatchSize: null,
                        cancellationToken: token);

                }
                catch (Exception e)
                {
                    throw e;
                }

                //var s = documentsToImportInBatch[0];
                //documentsToImportInBatch.Clear();
                //documentsToImportInBatch.Add(s);
                ////.Result;
            }
            else
            {   
                var collectionUri = UriFactory.CreateDocumentCollectionUri(cosmosDest.DbName, collectionIdDestination);
                
                Parallel.ForEach(documentsToImportInBatch, options,
                    doc => { cosmosDest.Client.UpsertDocumentAsync(collectionUri, JObject.Parse(doc)).Wait(); });
            }
            
        }

        public static List<T> ExecuteQuery<T>(DocumentClient client, DocumentCollection col, string where)
        {
            if(where.Length<4)// == "1=1")||(where == "1=0")
                where = "";

            var query = "SELECT * FROM c "  + (where ==""?"":"WHERE ")+ where;

            var querySqlQuerySpec = new SqlQuerySpec(query);
            var documents = client.CreateDocumentQuery<T>(col.SelfLink, query,
                new FeedOptions() { EnableCrossPartitionQuery = true }).AsEnumerable().ToList();

            return documents;
        }

        public string GetTempDirectory() {

            string path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            Directory.CreateDirectory(path);
            return path;
        }

        private void cbFilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var jsonObj = cbFilterList.SelectedItem?.ToString();
            jsonTreeView.ShowJson(jsonObj.ToString());
        }

        private void btnReacreateCollections_Click(object sender, EventArgs e)
        {
            foreach (var coll in cosmosDest.SelectedCollections)
            {
                LogWriteLine("Recreate from " + coll.Id);

                ResetDestinationColletion(coll, true);
            }
            cosmosDest.RefreshCollections();
            LogWriteLine("Recreate done!");
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();

            if (tbExportFolder.Text != "")
            {
                fbd.SelectedPath = tbExportFolder.Text;
            }
            else
            {
                fbd.SelectedPath = Application.ExecutablePath;
            }
            DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    if (((Button) sender) == btnChooseExportFolder)
                    {
                        tbExportFolder.Text = fbd.SelectedPath;
                    }
                    else
                    {
                        tbImportFolder.Text = fbd.SelectedPath;
                    }
                }
            
        }

        private void btnImportFolder_Click(object sender, EventArgs e)
        {
            ImportFromFolder(tbImportFolder.Text);
        }

        private void btnCreateCollectionFromSource_Click(object sender, EventArgs e)
        {
            foreach (var coll in cosmosSource.SelectedCollections)
            {
                LogWriteLine("Create from Source " + coll.Id);

                ResetDestinationColletion(coll, true);
            }
            cosmosDest.RefreshCollections();
            LogWriteLine("Create from Source done!");
        }

        private void btnSwtichConnection_Click(object sender, EventArgs e)
        {
            var temp = cosmosSource.EndPoint;
            cosmosSource.EndPoint = cosmosDest.EndPoint;
            cosmosDest.EndPoint = temp;
        }

        private void tbMaxThreads_TextChanged(object sender, EventArgs e)
        {
            MaxThreads = int.Parse(tbMaxThreads.Text);
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistryUtils.Write("CosmoDog-MaxThreads", tbMaxThreads.Text);
            RegistryUtils.Write("CosmoDog-ImportFolder", tbImportFolder.Text);
            RegistryUtils.Write("CosmoDog-ImportZip", tbImportZip.Text);
            RegistryUtils.Write("CosmoDog-ExportFolder", tbExportFolder.Text);
        }


        private bool isFirstTimeSourceInit = true;
        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tpExport)
            {
                if (isFirstTimeSourceInit)
                {
                    isFirstTimeSourceInit = false;
                    cosmosSource.Init();
                }
            }
        }

        private void btnExportToFolder_Click(object sender, EventArgs e)
        {
            var where = "";

            if (tbExportPartitionKey.Text.Trim() != "")
                where = $"c.{tbExportPartitionKey.Text}='{tbExportPartitionValue.Text}'";
            foreach (var col in cosmosDest.SelectedCollections)
            {
                LogWriteLine("Export from " + col.Id);
                
                //var docs = cosmosDest.Client.CreateDocumentQuery(coll.DocumentsLink, new FeedOptions() {EnableCrossPartitionQuery = true});
                var docs = FrmMain.ExecuteQuery<JObject>(cosmosDest.Client, col, where);

                ExportDocumentQueue(MaxThreads, docs.ToList(), col, tbExportFolder.Text).Wait();
            }
            LogWriteLine("Export done!");
        }

        private void collectionGroupViewBox1_Load(object sender, EventArgs e)
        {

        }

    }
}
