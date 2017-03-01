using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using System.Data.SQLite;

namespace Watcher {

    public partial class FileSystemWatcher : Form {

        private System.IO.FileSystemWatcher watcher;
        private Form AboutForm;
        private Form queryForm;


        //SQLite inits
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        public SQLiteDataReader sqlite_datareader;
        private string sqlite_dbname;
        private string extDB;

        public FileSystemWatcher() {
            InitializeComponent();
            CenterToScreen();

            AboutForm = new AboutForm();
            AboutForm.Owner = this;
        }//end constructor

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void StartWatcher() {

            watcher = new System.IO.FileSystemWatcher();
            watcher.Path = TbDirectory.Text;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            // Watch Specific File Types
            if (!CbDirectory.Text.Equals("")) {
                watcher.Filter = CbDirectory.Text;
            }//end if

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);

            // Begin watching.
            watcher.EnableRaisingEvents = true;

            watcher.IncludeSubdirectories = true;

        }//end Watcher

        public Boolean CheckPath() {
            if(Directory.Exists(TbDirectory.Text)) {
                return true;
            }//end if
            else {
                return false;
            }//end else
        }//end CheckPath

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e) {
            this.Invoke(new Action(delegate () {
                this.DgvWatcherEvents.Rows.Add(e.Name, Path.GetExtension(e.Name), e.FullPath, e.ChangeType, DateTime.Now);
            }));
        }//end OnChanged

        private void OnRenamed(object source, RenamedEventArgs e) {
            this.Invoke(new Action(delegate () {
                this.DgvWatcherEvents.Rows.Add(e.Name, Path.GetExtension(e.Name), e.FullPath, e.ChangeType, DateTime.Now);
            }));
        }//end OnRenamed

        /*
         * 
         * 
         * GUI Elements handled below
         * 
         * 
        **/

        private void BtnStart_Click(object sender, EventArgs e) {
            if (CheckPath()) {
                StartWatcher();
                BtnStart.Enabled = false;
                startToolStripMenuItem1.Enabled = false;
                BtnStop.Enabled = true;
                stopToolStripMenuItem1.Enabled = true;
                BtnWrite.Enabled = true;
                writeToDatabaseToolStripMenuItem.Enabled = true;
            }//end if
            else {
                MessageBox.Show("Invalid Path Specified.");
            }//end else
        }//end BtnStart

        private void BtnStop_Click(object sender, EventArgs e) {
            if (watcher.EnableRaisingEvents == true) {
                watcher.EnableRaisingEvents = false;
                BtnStart.Enabled = true;
                startToolStripMenuItem1.Enabled = true;
                BtnStop.Enabled = false;
                stopToolStripMenuItem1.Enabled = false;        
            }//end if
            else {
                MessageBox.Show("Watcher isn't running.");
            }//end else
        }//end BtnStop

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                DialogResult result = MessageBox.Show("Do you really want to Exit?", "Exit File System Watcher", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) {
                    if (sqlite_cmd != null) {
                        sqlite_cmd.Dispose();
                    }//end if
                    if (sqlite_conn != null) {
                        sqlite_conn.Dispose();
                    }//end if
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }//end if
                else {
                    e.Cancel = true;
                }//end else
            }//end if
            else {
                e.Cancel = true;
            }//end else

        }//end Form1 Closing

        // About Form
        private void aboutToolStripMenuItem_About_Click(object sender, EventArgs e) {
            AboutForm.Show();
        }

        private void ConnectDatabse() {

            sqlite_dbname = TbDatabase.Text;

            if (File.Exists(sqlite_dbname + ".db")) {
                sqlite_conn = new SQLiteConnection("Data source=" + sqlite_dbname + ".db;Version=3;Compress=True;");
            }//end if
            else {
                sqlite_conn = new SQLiteConnection("Data source=./" + sqlite_dbname + ".db;Version=3;Compress=True;");
            }//end else

            sqlite_conn.Open();
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS WatcherDB (FileName VARCHAR(50), Path VARCHAR(100), Event VARCHAR(25), TimeStamp VARCHAR(50));";
            sqlite_cmd.ExecuteNonQuery();

        }//end InitializeDatabase

        private void WriteToDatabase() {

            extDB = CbDatabase.Text;
            
            for (int rows = 0; rows < DgvWatcherEvents.Rows.Count; rows++) {
                if (extDB.Equals("")) {
                    sqlite_cmd.CommandText = "INSERT INTO WatcherDB (FileName, Path, Event, TimeStamp) VALUES (?, ?, ?, ?);";
                    sqlite_cmd.Parameters.Add("@FileName", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[0].Value;
                    sqlite_cmd.Parameters.Add("@Path", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[2].Value;
                    sqlite_cmd.Parameters.Add("@Event", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[3].Value;
                    sqlite_cmd.Parameters.Add("@TimeStamp", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[4].Value;
                    sqlite_cmd.ExecuteNonQuery();
                }//end if
                else if (extDB.Equals(System.IO.Path.GetExtension(DgvWatcherEvents.Rows[rows].Cells[0].Value.ToString()))) {
                    sqlite_cmd.CommandText = "INSERT INTO WatcherDB (FileName, Path, Event, TimeStamp) VALUES (?, ?, ?, ?);";
                    sqlite_cmd.Parameters.Add("@FileName", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[0].Value;
                    sqlite_cmd.Parameters.Add("@Path", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[2].Value;
                    sqlite_cmd.Parameters.Add("@Event", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[3].Value;
                    sqlite_cmd.Parameters.Add("@TimeStamp", DbType.String).Value = DgvWatcherEvents.Rows[rows].Cells[4].Value;
                    sqlite_cmd.ExecuteNonQuery();
                }//end elseif
            }//end for

        }//end WriteToDatabase

        private void BtnWrite_Click(object sender, EventArgs e) {
            // is the watcher still running? we need to shut it down if it is
            if(watcher.EnableRaisingEvents == true) {
                watcher.EnableRaisingEvents = false;
                BtnStart.Enabled = true;
                startToolStripMenuItem1.Enabled = true;
                BtnStop.Enabled = false;
                stopToolStripMenuItem1.Enabled = false;
                BtnClear.Enabled = true;
                clearToolStripMenuItem.Enabled = true;
                BtnWrite.Enabled = false;
                writeToDatabaseToolStripMenuItem.Enabled = false;

                //SQLite
                ConnectDatabse();
                WriteToDatabase();
                sqlite_conn.Close();
            }//end if
            else {
                ConnectDatabse();
                WriteToDatabase();
                sqlite_conn.Close();
            }//end else

            // Enable/Disable buttons
            BtnQuery.Enabled = true;
            queryToolStripMenuItem.Enabled = true;
            BtnClear.Enabled = true;
            clearToolStripMenuItem.Enabled = true;

        }//end btnWrite

        private void BtnClear_Click(object sender, EventArgs e) {

            sqlite_conn.Open();
            if(sqlite_datareader != null) {
                sqlite_datareader.Close();
            }//end if
            sqlite_cmd.CommandText = "DROP TABLE IF EXISTS 'WatcherDB';";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS WatcherDB (FileName VARCHAR(50), Path VARCHAR(100), Event VARCHAR(25), TimeStamp VARCHAR(50));";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_conn.Close();

        }//end clear

        private void BtnQuery_Click(object sender, EventArgs e) {

            extDB = CbDatabase.Text;
            sqlite_conn.Open();

            String sqlite_query = TbDatabase.Text;
            sqlite_cmd = new SQLiteCommand(sqlite_query, sqlite_conn);
            sqlite_datareader = sqlite_cmd.ExecuteReader();

            queryForm = new QueryForm(sqlite_datareader, extDB);
            queryForm.Show();

            sqlite_datareader.Close();
            sqlite_conn.Close();
        }//end query

        // These all just call the button click corresponded with their actions
        private void startToolStripMenuItem1_Click(object sender, EventArgs e) {
            BtnStart_Click(sender, e);
        }//end StartToolStrip

        private void stopToolStripMenuItem1_Click(object sender, EventArgs e) {
            BtnStop_Click(sender, e);
        }//End stopToolStrip

        private void writeToDatabaseToolStripMenuItem_Click(object sender, EventArgs e) {
            BtnWrite_Click(sender, e);
        }//end write menu

        private void clearToolStripMenuItem_Click(object sender, EventArgs e) {
            BtnClear_Click(sender, e);
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e) {
            BtnQuery_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("1). Enter a Path to watch that directory\n2). Click Start\n3). Before writing to a database, specify a name\n4). Use the same text field for Queries");
        }
    }//end class

}//end namespace
