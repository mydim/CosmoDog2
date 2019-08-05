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
using Newtonsoft.Json.Linq;

namespace CosmoDog.UIControl
{
    public partial class TypeCollectionViewBox : UserControl
    {
        public TypeCollectionViewBox()
        {
            InitializeComponent();
        }

        internal void Init(CosmosDBBox cosmosDb, DocumentCollection col, TypeSchema type, string text)
        {
            gbMain.Text = string.Format($"{col.Id} - {type.ItemStorageType}");

            var where = "1=0";
            foreach (var field in type.Fields)
            {
                where = where + " or c." + field + "='" + text + "'";
            }

            var documents = FrmMain.ExecuteQuery(cosmosDb.Client, col, where);

            if (!documents.Any())
            {
                this.Visible = false;
                return;
            }

            Height = 60 + documents.Count * 23;

            var document = documents[0];

            var table = new DataTable();
            foreach (var prop in document.Properties())
            {
                table.Columns.Add(prop.Name, typeof(string));//prop.Type
            }

            var values = new object[table.Columns.Count];

             
            foreach (var doc in documents)
            {
                int i = 0;
                foreach (var value in doc.Properties())
                {
                    values[i] = value.Value;
                    i++;
                }
                table.Rows.Add(values);
                
            }

            gcMain.DataSource = table;
        }

        public static DataTable ToDataTable(JObject jobj)
        {
            var table = new DataTable();
            //for (int i = 0; i < props.Count; i++)
            //{
            //    PropertyDescriptor prop = props[i];
            //    table.Columns.Add(prop.Name, prop.PropertyType);
            //}
            //object[] values = new object[props.Count];
            //foreach (T item in data)
            //{
            //    for (int i = 0; i < values.Length; i++)
            //    {
            //        values[i] = props[i].GetValue(item);
            //    }
            //    table.Rows.Add(values);
            //}
            return table;
        }
    }
}
