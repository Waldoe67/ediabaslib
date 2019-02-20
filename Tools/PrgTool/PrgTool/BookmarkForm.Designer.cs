namespace PrgTool {
    partial class BookmarkForm {
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
            this.dgvBookmarks = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookmarks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookmarks
            // 
            this.dgvBookmarks.AllowUserToAddRows = false;
            this.dgvBookmarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookmarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookmarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookmarks.Location = new System.Drawing.Point(12, 12);
            this.dgvBookmarks.Name = "dgvBookmarks";
            this.dgvBookmarks.ReadOnly = true;
            this.dgvBookmarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookmarks.Size = new System.Drawing.Size(1043, 664);
            this.dgvBookmarks.TabIndex = 0;
            this.dgvBookmarks.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvBookmarks_UserDeletedRow);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(12, 682);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(112, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Bookmarks";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // BookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 717);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvBookmarks);
            this.Name = "BookmarkForm";
            this.Text = "Bookmarks";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookmarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookmarks;
        private System.Windows.Forms.Button btnExport;
    }
}