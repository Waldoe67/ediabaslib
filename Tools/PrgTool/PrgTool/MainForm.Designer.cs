namespace PrgTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer0 = new System.Windows.Forms.SplitContainer();
            this.lbPaths = new System.Windows.Forms.ListBox();
            this.btnShowBookmarks = new System.Windows.Forms.Button();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvEcus = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.dgvArgs = new System.Windows.Forms.DataGridView();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.ctxResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxResultAddToBookmarks = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbPath = new System.Windows.Forms.GroupBox();
            this.ecuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobArgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EcuDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecuCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer0)).BeginInit();
            this.splitContainer0.Panel1.SuspendLayout();
            this.splitContainer0.Panel2.SuspendLayout();
            this.splitContainer0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.ctxResult.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.gbPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobArgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer0
            // 
            this.splitContainer0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer0.Location = new System.Drawing.Point(12, 12);
            this.splitContainer0.Name = "splitContainer0";
            this.splitContainer0.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer0.Panel1
            // 
            this.splitContainer0.Panel1.Controls.Add(this.gbPath);
            this.splitContainer0.Panel1.Controls.Add(this.gbSearch);
            this.splitContainer0.Panel1.Controls.Add(this.btnShowBookmarks);
            this.splitContainer0.Panel1MinSize = 125;
            // 
            // splitContainer0.Panel2
            // 
            this.splitContainer0.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer0.Panel2MinSize = 300;
            this.splitContainer0.Size = new System.Drawing.Size(980, 845);
            this.splitContainer0.SplitterDistance = 181;
            this.splitContainer0.TabIndex = 12;
            // 
            // lbPaths
            // 
            this.lbPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPaths.FormattingEnabled = true;
            this.lbPaths.HorizontalScrollbar = true;
            this.lbPaths.Location = new System.Drawing.Point(6, 19);
            this.lbPaths.Name = "lbPaths";
            this.lbPaths.Size = new System.Drawing.Size(449, 121);
            this.lbPaths.Sorted = true;
            this.lbPaths.TabIndex = 18;
            // 
            // btnShowBookmarks
            // 
            this.btnShowBookmarks.Location = new System.Drawing.Point(568, 102);
            this.btnShowBookmarks.Name = "btnShowBookmarks";
            this.btnShowBookmarks.Size = new System.Drawing.Size(103, 23);
            this.btnShowBookmarks.TabIndex = 7;
            this.btnShowBookmarks.Text = "Show Bookmarks";
            this.btnShowBookmarks.UseVisualStyleBackColor = true;
            this.btnShowBookmarks.Click += new System.EventHandler(this.btnShowBookmarks_Click);
            // 
            // btnParse
            // 
            this.btnParse.Enabled = false;
            this.btnParse.Location = new System.Drawing.Point(461, 48);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Parse File(s)";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.Location = new System.Drawing.Point(461, 19);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnFileBrowse.TabIndex = 1;
            this.btnFileBrowse.Text = "Browse ...";
            this.btnFileBrowse.UseVisualStyleBackColor = true;
            this.btnFileBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Enabled = false;
            this.btnClearSearch.Location = new System.Drawing.Point(130, 45);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(95, 23);
            this.btnClearSearch.TabIndex = 23;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(6, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 20);
            this.txtSearch.TabIndex = 21;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvEcus);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(980, 660);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 12;
            // 
            // dgvEcus
            // 
            this.dgvEcus.AllowUserToAddRows = false;
            this.dgvEcus.AllowUserToDeleteRows = false;
            this.dgvEcus.AutoGenerateColumns = false;
            this.dgvEcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ecuNameDataGridViewTextBoxColumn,
            this.EcuDescription,
            this.originDataGridViewTextBoxColumn,
            this.revisionDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.ecuCommentDataGridViewTextBoxColumn});
            this.dgvEcus.DataSource = this.ecuBindingSource;
            this.dgvEcus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEcus.Location = new System.Drawing.Point(0, 0);
            this.dgvEcus.MultiSelect = false;
            this.dgvEcus.Name = "dgvEcus";
            this.dgvEcus.ReadOnly = true;
            this.dgvEcus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEcus.Size = new System.Drawing.Size(980, 113);
            this.dgvEcus.TabIndex = 10;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvResults);
            this.splitContainer2.Size = new System.Drawing.Size(980, 543);
            this.splitContainer2.SplitterDistance = 348;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvJobs);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvArgs);
            this.splitContainer3.Size = new System.Drawing.Size(348, 543);
            this.splitContainer3.SplitterDistance = 380;
            this.splitContainer3.TabIndex = 0;
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AutoGenerateColumns = false;
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobNameDataGridViewTextBoxColumn,
            this.jobCommentDataGridViewTextBoxColumn});
            this.dgvJobs.DataSource = this.jobBindingSource;
            this.dgvJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJobs.Location = new System.Drawing.Point(0, 0);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobs.Size = new System.Drawing.Size(348, 380);
            this.dgvJobs.TabIndex = 11;
            // 
            // dgvArgs
            // 
            this.dgvArgs.AllowUserToAddRows = false;
            this.dgvArgs.AllowUserToDeleteRows = false;
            this.dgvArgs.AutoGenerateColumns = false;
            this.dgvArgs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.argNameDataGridViewTextBoxColumn,
            this.argTypeDataGridViewTextBoxColumn,
            this.argCommentDataGridViewTextBoxColumn});
            this.dgvArgs.DataSource = this.jobArgBindingSource;
            this.dgvArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArgs.Location = new System.Drawing.Point(0, 0);
            this.dgvArgs.MultiSelect = false;
            this.dgvArgs.Name = "dgvArgs";
            this.dgvArgs.ReadOnly = true;
            this.dgvArgs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArgs.Size = new System.Drawing.Size(348, 159);
            this.dgvArgs.TabIndex = 12;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultNameDataGridViewTextBoxColumn,
            this.resultTypeDataGridViewTextBoxColumn,
            this.resultCommentDataGridViewTextBoxColumn});
            this.dgvResults.DataSource = this.jobResultBindingSource;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(0, 0);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(628, 543);
            this.dgvResults.TabIndex = 11;
            // 
            // ctxResult
            // 
            this.ctxResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxResultAddToBookmarks});
            this.ctxResult.Name = "ctxResult";
            this.ctxResult.Size = new System.Drawing.Size(173, 26);
            // 
            // ctxResultAddToBookmarks
            // 
            this.ctxResultAddToBookmarks.Name = "ctxResultAddToBookmarks";
            this.ctxResultAddToBookmarks.Size = new System.Drawing.Size(172, 22);
            this.ctxResultAddToBookmarks.Text = "Add to Bookmarks";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnClearSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Location = new System.Drawing.Point(568, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(234, 84);
            this.gbSearch.TabIndex = 24;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Job/Result:";
            // 
            // gbPath
            // 
            this.gbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPath.Controls.Add(this.lbPaths);
            this.gbPath.Controls.Add(this.btnFileBrowse);
            this.gbPath.Controls.Add(this.btnParse);
            this.gbPath.Location = new System.Drawing.Point(3, 12);
            this.gbPath.Name = "gbPath";
            this.gbPath.Size = new System.Drawing.Size(547, 156);
            this.gbPath.TabIndex = 25;
            this.gbPath.TabStop = false;
            this.gbPath.Text = "Select file(s);";
            // 
            // ecuBindingSource
            // 
            this.ecuBindingSource.DataSource = typeof(PrgTool.Ecu);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(PrgTool.Job);
            // 
            // jobArgBindingSource
            // 
            this.jobArgBindingSource.DataSource = typeof(PrgTool.JobArg);
            // 
            // jobResultBindingSource
            // 
            this.jobResultBindingSource.DataSource = typeof(PrgTool.JobResult);
            // 
            // ecuNameDataGridViewTextBoxColumn
            // 
            this.ecuNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ecuNameDataGridViewTextBoxColumn.DataPropertyName = "EcuName";
            this.ecuNameDataGridViewTextBoxColumn.FillWeight = 15F;
            this.ecuNameDataGridViewTextBoxColumn.HeaderText = "ECU Name";
            this.ecuNameDataGridViewTextBoxColumn.Name = "ecuNameDataGridViewTextBoxColumn";
            this.ecuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EcuDescription
            // 
            this.EcuDescription.DataPropertyName = "EcuDescription";
            this.EcuDescription.FillWeight = 30F;
            this.EcuDescription.HeaderText = "Description";
            this.EcuDescription.Name = "EcuDescription";
            this.EcuDescription.ReadOnly = true;
            this.EcuDescription.Width = 247;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.FillWeight = 15F;
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revisionDataGridViewTextBoxColumn
            // 
            this.revisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.revisionDataGridViewTextBoxColumn.DataPropertyName = "Revision";
            this.revisionDataGridViewTextBoxColumn.FillWeight = 15F;
            this.revisionDataGridViewTextBoxColumn.HeaderText = "Revision";
            this.revisionDataGridViewTextBoxColumn.Name = "revisionDataGridViewTextBoxColumn";
            this.revisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.FillWeight = 10F;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ecuCommentDataGridViewTextBoxColumn
            // 
            this.ecuCommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ecuCommentDataGridViewTextBoxColumn.DataPropertyName = "EcuComment";
            this.ecuCommentDataGridViewTextBoxColumn.FillWeight = 15F;
            this.ecuCommentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.ecuCommentDataGridViewTextBoxColumn.Name = "ecuCommentDataGridViewTextBoxColumn";
            this.ecuCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobNameDataGridViewTextBoxColumn
            // 
            this.jobNameDataGridViewTextBoxColumn.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn.HeaderText = "Job Name";
            this.jobNameDataGridViewTextBoxColumn.Name = "jobNameDataGridViewTextBoxColumn";
            this.jobNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobCommentDataGridViewTextBoxColumn
            // 
            this.jobCommentDataGridViewTextBoxColumn.DataPropertyName = "JobComment";
            this.jobCommentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.jobCommentDataGridViewTextBoxColumn.Name = "jobCommentDataGridViewTextBoxColumn";
            this.jobCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultNameDataGridViewTextBoxColumn
            // 
            this.resultNameDataGridViewTextBoxColumn.DataPropertyName = "ResultName";
            this.resultNameDataGridViewTextBoxColumn.HeaderText = "Result Name";
            this.resultNameDataGridViewTextBoxColumn.Name = "resultNameDataGridViewTextBoxColumn";
            this.resultNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultTypeDataGridViewTextBoxColumn
            // 
            this.resultTypeDataGridViewTextBoxColumn.DataPropertyName = "ResultType";
            this.resultTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.resultTypeDataGridViewTextBoxColumn.Name = "resultTypeDataGridViewTextBoxColumn";
            this.resultTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultCommentDataGridViewTextBoxColumn
            // 
            this.resultCommentDataGridViewTextBoxColumn.DataPropertyName = "ResultComment";
            this.resultCommentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.resultCommentDataGridViewTextBoxColumn.Name = "resultCommentDataGridViewTextBoxColumn";
            this.resultCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argNameDataGridViewTextBoxColumn
            // 
            this.argNameDataGridViewTextBoxColumn.DataPropertyName = "ArgName";
            this.argNameDataGridViewTextBoxColumn.FillWeight = 40F;
            this.argNameDataGridViewTextBoxColumn.HeaderText = "Argument Name";
            this.argNameDataGridViewTextBoxColumn.Name = "argNameDataGridViewTextBoxColumn";
            this.argNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argTypeDataGridViewTextBoxColumn
            // 
            this.argTypeDataGridViewTextBoxColumn.DataPropertyName = "ArgType";
            this.argTypeDataGridViewTextBoxColumn.FillWeight = 20F;
            this.argTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.argTypeDataGridViewTextBoxColumn.Name = "argTypeDataGridViewTextBoxColumn";
            this.argTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argCommentDataGridViewTextBoxColumn
            // 
            this.argCommentDataGridViewTextBoxColumn.DataPropertyName = "ArgComment";
            this.argCommentDataGridViewTextBoxColumn.FillWeight = 40F;
            this.argCommentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.argCommentDataGridViewTextBoxColumn.Name = "argCommentDataGridViewTextBoxColumn";
            this.argCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 869);
            this.Controls.Add(this.splitContainer0);
            this.MinimumSize = new System.Drawing.Size(960, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRG Tool";
            this.splitContainer0.Panel1.ResumeLayout(false);
            this.splitContainer0.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer0)).EndInit();
            this.splitContainer0.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcus)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ctxResult.ResumeLayout(false);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbPath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ecuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobArgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFileBrowse;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnShowBookmarks;
        private System.Windows.Forms.BindingSource ecuBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource jobResultBindingSource;
        private System.Windows.Forms.BindingSource jobArgBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer0;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvEcus;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.DataGridView dgvArgs;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.ContextMenuStrip ctxResult;
        private System.Windows.Forms.ToolStripMenuItem ctxResultAddToBookmarks;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lbPaths;
        private System.Windows.Forms.GroupBox gbPath;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EcuDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultCommentDataGridViewTextBoxColumn;
    }
}

