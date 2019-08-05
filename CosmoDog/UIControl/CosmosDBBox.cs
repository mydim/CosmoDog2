using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents;
using System.Diagnostics;
using System.ComponentModel.Design;
using System.Threading;

namespace CosmoDog
{
    public partial class CosmosDBBox : UserControl
    {

        public StringItem<DocumentCollection> SelectedCollection
        {
            get { return cbCollections.SelectedItem as StringItem<DocumentCollection>; }
        }

        public string DatabaseSelfLink;
        public  Database Database;
        public Dictionary<string, DocumentCollection> DocumentCollectionDict;

        [Browsable(true)]
        [Category("Custom Values")]
        public string EndPoint
        {
            get { return tbEndpoint.Text;}
            set { tbEndpoint.Text = value; }
        }

        [Browsable(true)]
        [Category("Custom Values")]
        public string DbName
        {
            get
            {
                var db = ((StringItem<Database>) cbDB.SelectedItem).Obj;
                return db.Id;
            }
            //set { tbDB.Text = value; }
        }

        public CosmosDBBox()
        {
            InitializeComponent();
        }

        string GetValue(string str)
        {
             var i = str.IndexOf('=');
            return str.Substring(i+1, str.Length - i-1);
        }

        public Uri GetEndPoint {
            get
            {
                var l = tbEndpoint.Text.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                var end = GetValue(l[0]);
                return new Uri(end);
            }
        }

        public string GetAppKey {
            get
            {
                var l = tbEndpoint.Text.Split(new[] {';'}, StringSplitOptions.RemoveEmptyEntries);
                var key = GetValue(l[1]);
                return key;
            }
        }


        public DocumentClient Client;

        private void tbEndpoint_TextChanged(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
        if (this.DesignMode)
            {
                return;
            }

            try
            {
                this.cbDB.SelectedIndexChanged -= new System.EventHandler(this.cbDB_SelectedIndexChanged);
                //var end = GetEndPoint;
                //var key  = GetAppKey;

                this.Client = new DocumentClient(GetEndPoint, GetAppKey,
                    new ConnectionPolicy
                    {
                        ConnectionMode = ConnectionMode.Direct,
                        ConnectionProtocol = Protocol.Tcp,
                        MaxConnectionLimit = 1000
                    });
                // Set retry options high during initialization (default values).
                this.Client.ConnectionPolicy.RetryOptions.MaxRetryWaitTimeInSeconds = 30;
                this.Client.ConnectionPolicy.RetryOptions.MaxRetryAttemptsOnThrottledRequests = 9;
                this.Client.OpenAsync().Wait();

                //var listDatabasesOperationResult = Client.ReadDatabaseFeedAsync().Result;
                var dbs = Client.CreateDatabaseQuery().ToList();

                cbDB.Items.Clear();

                dbs.ForEach(db => cbDB.Items.Add(new StringItem<Database>(db.Id, db)));
                foreach (StringItem<Database> db in cbDB.Items)
                {
                    if (db.Obj.Id.Contains("-TU-"))
                    {
                        cbDB.SelectedItem = db;
                        this.DatabaseSelfLink = db.Obj.CollectionsLink;
                        this.Database = db.Obj;
                        break;
                    }
                }

                cbDB_SelectedIndexChanged(null, null);
            }
            catch (Exception exception)
            {
                Text = "Exception:" + exception.Message;
            }
            finally
            {this.cbDB.SelectedIndexChanged += new System.EventHandler(this.cbDB_SelectedIndexChanged);
            }
        }

        bool nextSelect = true;

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            if (cbCollections.Items.Count == 0)
            {
                tbEndpoint_TextChanged(null, null);
                return;
            }

            for (int i = 0; i < cbCollections.Items.Count; i++)
            {
                if ((tbSearchPattern.Text.Trim()=="") || ((StringItem<DocumentCollection>)cbCollections.Items[i]).Name.ToLower().Contains(tbSearchPattern.Text.ToLower()))
                    cbCollections.SetItemChecked(i, nextSelect);
            }

            nextSelect = !nextSelect;
        }

        public List<DocumentCollection> SelectedCollections
        {
            get
            {
                var list = new List<DocumentCollection>();
                for (int i = 0; i < cbCollections.CheckedItems.Count; i++)
                {
                    list.Add(((StringItem<DocumentCollection>)cbCollections.CheckedItems[i]).Obj);
                }

                return list;
            }
        }

        private void cbDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCollections();
        }

        public void RefreshCollections()
        {
            try
            {
                var db = ((StringItem<Database>) cbDB.SelectedItem).Obj;
                if (db == null)
                {
                    return;
                }

                var collections = Client.CreateDocumentCollectionQuery(db.SelfLink).ToList();

                this.DocumentCollectionDict = new Dictionary<string, DocumentCollection>();
                foreach (DocumentCollection collection in collections)
                {
                    var str = collection.AltLink.Replace("dbs/" + db.Id + "/colls/", "");
                    DocumentCollectionDict.Add(str, collection);
                }

                var i = 0;
                cbCollections.Items.Clear();
                foreach (var item in this.DocumentCollectionDict.OrderBy(x => x.Key))
                {
                    cbCollections.Items.Add(new StringItem<DocumentCollection>(item.Key, item.Value));
                    cbCollections.SetItemChecked(i, false);
                    i++;
                }

                nextSelect = true;
                Text = "OK";

            }
            catch (Exception exception)
            {
                Text = "Exception:" + exception.Message;
            }
        }
    }

    public class StringItem<T>
    {
        public string Name;
        public T Obj;

        public StringItem(string name, T obj)
        {
            this.Name = name;
            this.Obj = obj;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
