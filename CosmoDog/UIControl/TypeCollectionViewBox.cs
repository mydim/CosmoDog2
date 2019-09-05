using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Helpers;
using Microsoft.Azure.Documents;
using Newtonsoft.Json.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace CosmoDog.UIControl
{
    public partial class TypeCollectionViewBox : UserControl
    {
        public TypeCollectionViewBox()
        {
            InitializeComponent();
            gcView.CustomDrawGroupRow += GcView_CustomDrawGroupRow;
            //gcView.OptionsBehavior.ReadOnly = true;
            gcView.OptionsBehavior.Editable= false;
        }

        

        private void GcView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            var info = e.Info as GridGroupRowInfo;
            string caption = info.Column.Caption;
            if (info.Column.Caption == string.Empty)
                caption = info.Column.ToString();
            info.GroupText = string.Format("{0} : {1} (count= {2})", caption, info.GroupValueText, gcView.GetChildRowCount(e.RowHandle));
        }


        private string textEverywhereLast = "";
        private DocumentCollection col;
        private TypeSchema type;

        internal void Init(CosmosDBBox cosmosDb, DocumentCollection col, TypeSchema type, string text, string textEverywhere)
        {
            this.col =col;
            this.type = type;

            gbMain.Text = string.Format($"{col.Id} - {type.ItemStorageType}");

            var where = "c.itemStorageType='"+type.ItemStorageType+"'";

            if(text.Length>0)
            foreach (var field in type.Fields)
            {
                where = where + " or c." + field + "='" + text + "'";
            }
            var documents = FrmMain.ExecuteQuery<JObject>(cosmosDb.Client, col, where);

            if (!documents.Any())
            {
                this.Visible = false;
                return;
            }

            BuildTable(documents,textEverywhere);
        }

        
        private void BuildTable(List<JObject> documents, string textEverywhere="")
        {if(documents.Count==0)
            return;
            this.textEverywhereLast = textEverywhere;
            var document = documents[0];

            var table = new DataTable();
            foreach (var prop in document.Properties())
            {
                //if (prop.Name.StartsWith("_"))continue;
                //if (prop.Name == CollectionTypes.TypeField)continue;
                var isHidden = (prop.Name.StartsWith("_")) || (prop.Name == CollectionTypes.TypeField);
                //if continue;
                table.Columns.Add(prop.Name, typeof(string)).ReadOnly = isHidden;//prop.Type
            }

            var values = new object[table.Columns.Count];

             
            foreach (var doc in documents)
            {
                if ((this.type!=null) && (textEverywhere != "" && !doc.ToString().Contains(textEverywhere)))
                    continue;

                int i = 0;
                foreach (var value in doc.Properties())
                {
                    if (table.Columns[i].ReadOnly)
                        continue;

                    values[i] = value.Value;
                    i++;
                }
                table.Rows.Add(values);
                
            }
            Height = 100 + table.Rows.Count * 21;
            if (table.Rows.Count==0)
            {
                this.Visible = false;
                return;
            }

            gcMain.Dock = DockStyle.Fill;
            gcMain.DataSource = table;
            for (int i = 0; i < table.Columns.Count; i++)
            {
                var col = gcView.Columns[i];
                System.Guid g;
                var value = table.Rows[0][i].ToString();
                if (Regex.IsMatch(value, @"\w*"))
                {
                    col.Width = 100;
                }else
                if (System.Guid.TryParse(value, out g))
                {
                    if (g != Guid.Empty)
                    {
                        col.Width = 150;
                    }
                }
                else
                    col.Width = col.GetBestWidth();

                if (!table.Columns[i].ReadOnly)
                    continue;
                        
                col.Visible = false;
                
            }

            if (this.type == null)
            {
                gcView.FindFilterText = textEverywhere;
            }
        }

        internal void Init(string value, string columnName, object sourceId, string textEverywhereLast)
        {
            var arr = JToken.Parse(value);
            if (arr.Children().Any())
            {
                gbMain.Text = columnName+" of id:"+sourceId+(textEverywhereLast!=""?" Applied filter:"+textEverywhereLast:"");
                var documents = arr.Select(c => c.ToObject<JObject>()).ToList();
                BuildTable(documents, textEverywhereLast);
            }
            else
                BuildTable(new List<JObject>());
        }

        //public static DataTable ToDataTable(JObject jobj)
        //{
        //    var table = new DataTable();
        //    //for (int i = 0; i < props.Count; i++)
        //    //{
        //    //    PropertyDescriptor prop = props[i];
        //    //    table.Columns.Add(prop.Name, prop.PropertyType);
        //    //}
        //    //object[] values = new object[props.Count];
        //    //foreach (T item in data)
        //    //{
        //    //    for (int i = 0; i < values.Length; i++)
        //    //    {
        //    //        values[i] = props[i].GetValue(item);
        //    //    }
        //    //    table.Rows.Add(values);
        //    //}
        //    return table;
        //}

        private void gcView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            if (OnCellClickHandler != null)
            {
                OnCellClickHandler(e.CellValue?.ToString() ?? "", e.Clicks, gcView.FocusedColumn.Name,
                    gcView.GetFocusedDataRow()["id"]);
            }

        }


        public delegate void OnCellClick(string value, int clicks, string columnName, object sourceId);

        public event OnCellClick OnCellClickHandler;
    }
}
