using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json.Linq;

namespace CosmoDog.UIControl
{
    public partial class CollectionGroupViewBox : UserControl
    {
        public CollectionGroupViewBox()
        {
            InitializeComponent();
        }

        private CosmosDBBox cosmosDb;

        public void Init(CosmosDBBox cosmosDb)
        {
            this.cosmosDb = cosmosDb;
        }

        private void tbQueryString_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Return)
                Search();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            tbQueryString.Text = Clipboard.GetText();
            Search();
        }

        void Search()
        {
            GetSchema();

            pResults.SuspendLayout();
            pResults.Controls.Clear();

            foreach (var col in schema)
            {
                foreach (var type in col.Value)
                {
                    var tcol = new TypeCollectionViewBox();
                    tcol.Dock = DockStyle.Top;
                    tcol.Height = 150;
                    tcol.Init(this.cosmosDb, col.Key, type, tbQueryString.Text, tbQueryStringEverywhere.Text);
                    tcol.OnCellClickHandler += Tcol_OnCellClickHandler;
                    pResults.Controls.Add(tcol);
                }
            }

            pResults.ResumeLayout();

            //var s = schema.First().Value.Select(c => c.ItemStorageType).First().ToList();
            //MessageBox.Show(string.Join(Environment.NewLine,s ));
        }

        private void Tcol_OnCellClickHandler(string value, int clicks, string columnName, object sourceId)
        {
            if (clicks == 1)
            {
                if (value.StartsWith("[") && value.EndsWith("]"))
                {
                    var tcol = new TypeCollectionViewBox();
                    tcol.Dock = DockStyle.Top;
                    tcol.Init(value, columnName, sourceId, this.tbQueryStringEverywhere.Text);
                    tcol.OnCellClickHandler += Tcol_OnCellClickHandler;
                    pResults.Controls.Add(tcol);
                }
            }
            else
            if (clicks == 2)
            {
                tbQueryString.Text = "";
                tbQueryStringEverywhere.Text = value;
                Search();
            }
        }

        private CollectionTypes schema;

        CollectionTypes GetSchema()
        {
            //if (schema != null)
            //    return this.schema;
            schema = new CollectionTypes();

            foreach (var col in cosmosDb.SelectedCollections)
            {
                schema.Add(cosmosDb, col);
            }
            return this.schema;
        }

        private void btnSearchEverywhere_Click(object sender, EventArgs e)
        {
            tbQueryStringEverywhere.Text = Clipboard.GetText();
            Search();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Search();
        }
    }

    /// <summary>
    /// Key - 
    /// Value - propeties of a type
    /// </summary>
    public class TypeSchema
    {
        public string ItemStorageType;
        public List<string> Fields;

        public TypeSchema(string itemStorageType, List<string> fields)
        {
            this.ItemStorageType = itemStorageType;
            this.Fields = fields;
        }
    }

    public class CollectionTypes : Dictionary<DocumentCollection, List<TypeSchema>>
    {
        public static string TypeField = "itemStorageType";

        public void Add(CosmosDBBox cosmosDb, DocumentCollection col)
        {
            var typeSchemas = new List<TypeSchema>();
            while (FindCollectionTypeSchemas(cosmosDb, col, typeSchemas))
            {
            }

            if (typeSchemas.Count > 0)
            {
                this.Add(col, typeSchemas);
            }
        }

        bool FindCollectionTypeSchemas(CosmosDBBox cosmosDb, DocumentCollection col, List<TypeSchema> typeSchemas)
        {
            var where = "1=1";

            foreach (var t in typeSchemas)
            {
                where = where + " and c." + TypeField + " != '" + t.ItemStorageType + "'";
            }
            
            var document = FrmMain.ExecuteQuery<JObject>(cosmosDb.Client, col, where).FirstOrDefault();

            if (AddTypeSchema(typeSchemas, document))
                return true;
            else
                return false;
        }



        public bool AddTypeSchema(List<TypeSchema> typeSchemas, JObject document)
        {
            if (document == null)
                return false;
            var itemStorageType = "";
            var fields = new List<string>();
            //var o = Newtonsoft.Json.Linq.JObject.Parse(document.ToString());

            foreach (var prop in document.Properties())
            {
                fields.Add(prop.Name);

                if (CollectionTypes.TypeField == prop.Name)
                {
                    itemStorageType = prop.Value.ToString() ?? "";
                }
            }

            if (itemStorageType != "")
            {
                var typeSchema = new TypeSchema(itemStorageType, fields);
                typeSchemas.Add(typeSchema);
                return true;
            }

            return false;
        }

    }
}
