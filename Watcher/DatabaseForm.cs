using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watcher {
    public partial class DatabaseForm : Form {
        public DatabaseForm() {
            InitializeComponent();
            CenterToParent();
        }
        public DatabaseForm(String dbFileName) {
            InitializeComponent();
            CenterToParent();

            FillDatabaseInfo(dbFileName);
        }//end constructor

        private void FillDatabaseInfo(String dbFileName) {

        }//end FillDatabaseInfo
    }
}
