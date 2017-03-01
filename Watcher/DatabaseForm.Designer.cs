namespace Watcher {
    partial class DatabaseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelDatabseName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvDatabaseView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatabaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDatabseName
            // 
            this.labelDatabseName.AutoSize = true;
            this.labelDatabseName.Location = new System.Drawing.Point(65, 9);
            this.labelDatabseName.Name = "labelDatabseName";
            this.labelDatabseName.Size = new System.Drawing.Size(57, 13);
            this.labelDatabseName.TabIndex = 0;
            this.labelDatabseName.Text = "name here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database:";
            // 
            // DgvDatabaseView
            // 
            this.DgvDatabaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatabaseView.Location = new System.Drawing.Point(13, 61);
            this.DgvDatabaseView.Name = "DgvDatabaseView";
            this.DgvDatabaseView.Size = new System.Drawing.Size(737, 251);
            this.DgvDatabaseView.TabIndex = 2;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 324);
            this.Controls.Add(this.DgvDatabaseView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDatabseName);
            this.Name = "DatabaseForm";
            this.Text = "Watcher Database";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatabaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDatabseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvDatabaseView;
    }
}