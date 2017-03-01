using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Watcher {
    public partial class QueryForm : Form {

        private string[] dataHolder;

        public QueryForm() {
            InitializeComponent();
            CenterToParent();
        }
        public QueryForm(SQLiteDataReader reader, string ext) {
            InitializeComponent();
            CenterToParent();
            dataHolder = new string[4];
            PopulateResults(reader, ext);
        }
        
        public void PopulateResults(SQLiteDataReader reader, string ext) {
            while (reader.Read()) {
                ClearDataHolder();
                try {
                    for (int cols = 0; cols < reader.FieldCount; cols++) {
                        if (reader.GetName(cols).Equals("FileName")) {
                            dataHolder[0] = reader["FileName"].ToString();
                        }//end if
                        else if (reader.GetName(cols).Equals("Path")) {
                            dataHolder[1] = reader["Path"].ToString();
                        }//end elseif
                        else if (reader.GetName(cols).Equals("Event")) {
                            dataHolder[2] = reader["Event"].ToString();
                        }//end elseif
                        else if (reader.GetName(cols).Equals("TimeStamp")) {
                            dataHolder[3] = reader["TimeStamp"].ToString();
                        }//end elseif
                    }//end for     

                    if (ext.Equals("")) {
                        DgvQueryResults.Rows.Add(dataHolder[0], dataHolder[1], dataHolder[2], dataHolder[3]);
                    }
                    else if (ext.Equals(System.IO.Path.GetExtension(dataHolder[0]))) {
                        DgvQueryResults.Rows.Add(dataHolder[0], dataHolder[1], dataHolder[2], dataHolder[3]);
                    }//end elseif
                    
                }//end try
                catch (IndexOutOfRangeException eIndex) {
                    MessageBox.Show(eIndex.Message);
                }//end catch
            }//end while
        }//end PopulateResults

        public void ClearDataHolder() {
            for (int x = 0; x < dataHolder.Length; x++) {
                dataHolder[x] = "";
            }
        }//end clear data
    }
}
