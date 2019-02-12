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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.btnSave = new System.Windows.Forms.Button();
            this.eCUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.resultNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobResultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEcus = new System.Windows.Forms.DataGridView();
            this.ecuNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.revisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ecuCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvJobs = new System.Windows.Forms.DataGridView();
            this.jobNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvArgs = new System.Windows.Forms.DataGridView();
            this.jobArgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.argNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.argCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eCUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultBindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArgs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobArgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1039, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "Main Menu";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 24);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(59, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Select File:";
            // 
            // btnFileBrowse
            // 
            this.btnFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFileBrowse.Location = new System.Drawing.Point(952, 39);
            this.btnFileBrowse.Name = "btnFileBrowse";
            this.btnFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnFileBrowse.TabIndex = 2;
            this.btnFileBrowse.Text = "Browse ...";
            this.btnFileBrowse.UseVisualStyleBackColor = true;
            this.btnFileBrowse.Click += new System.EventHandler(this.btnFileBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(13, 41);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(922, 20);
            this.txtPath.TabIndex = 3;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // btnParse
            // 
            this.btnParse.Enabled = false;
            this.btnParse.Location = new System.Drawing.Point(15, 68);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Parse File";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(15, 122);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result:";
            // 
            // wbResult
            // 
            this.wbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbResult.Location = new System.Drawing.Point(18, 139);
            this.wbResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResult.Name = "wbResult";
            this.wbResult.Size = new System.Drawing.Size(1009, 718);
            this.wbResult.TabIndex = 6;
            this.wbResult.Visible = false;
            this.wbResult.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbResult_DocumentCompleted);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(96, 68);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Output";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // eCUBindingSource
            // 
            this.eCUBindingSource.DataSource = typeof(PrgTool.MainForm.ECU);
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataSource = typeof(PrgTool.MainForm.Job);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resultNameDataGridViewTextBoxColumn,
            this.resultTypeDataGridViewTextBoxColumn,
            this.resultCommentDataGridViewTextBoxColumn});
            this.dgvResults.DataSource = this.jobResultBindingSource1;
            this.dgvResults.Location = new System.Drawing.Point(356, 166);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvResults, 2);
            this.dgvResults.Size = new System.Drawing.Size(650, 212);
            this.dgvResults.TabIndex = 10;
            // 
            // resultNameDataGridViewTextBoxColumn
            // 
            this.resultNameDataGridViewTextBoxColumn.DataPropertyName = "ResultName";
            this.resultNameDataGridViewTextBoxColumn.HeaderText = "ResultName";
            this.resultNameDataGridViewTextBoxColumn.Name = "resultNameDataGridViewTextBoxColumn";
            this.resultNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultTypeDataGridViewTextBoxColumn
            // 
            this.resultTypeDataGridViewTextBoxColumn.DataPropertyName = "ResultType";
            this.resultTypeDataGridViewTextBoxColumn.HeaderText = "ResultType";
            this.resultTypeDataGridViewTextBoxColumn.Name = "resultTypeDataGridViewTextBoxColumn";
            this.resultTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultCommentDataGridViewTextBoxColumn
            // 
            this.resultCommentDataGridViewTextBoxColumn.DataPropertyName = "ResultComment";
            this.resultCommentDataGridViewTextBoxColumn.HeaderText = "ResultComment";
            this.resultCommentDataGridViewTextBoxColumn.Name = "resultCommentDataGridViewTextBoxColumn";
            this.resultCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobResultBindingSource1
            // 
            this.jobResultBindingSource1.DataSource = typeof(PrgTool.MainForm.JobResult);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEcus, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvJobs, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvResults, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvArgs, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 719);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // dgvEcus
            // 
            this.dgvEcus.AllowUserToAddRows = false;
            this.dgvEcus.AllowUserToDeleteRows = false;
            this.dgvEcus.AutoGenerateColumns = false;
            this.dgvEcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEcus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ecuNameDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.revisionDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.ecuCommentDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvEcus, 2);
            this.dgvEcus.DataSource = this.eCUBindingSource;
            this.dgvEcus.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvEcus.Location = new System.Drawing.Point(3, 3);
            this.dgvEcus.Name = "dgvEcus";
            this.dgvEcus.ReadOnly = true;
            this.dgvEcus.Size = new System.Drawing.Size(347, 157);
            this.dgvEcus.TabIndex = 9;
            // 
            // ecuNameDataGridViewTextBoxColumn
            // 
            this.ecuNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ecuNameDataGridViewTextBoxColumn.DataPropertyName = "EcuName";
            this.ecuNameDataGridViewTextBoxColumn.HeaderText = "EcuName";
            this.ecuNameDataGridViewTextBoxColumn.Name = "ecuNameDataGridViewTextBoxColumn";
            this.ecuNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.FillWeight = 50F;
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // revisionDataGridViewTextBoxColumn
            // 
            this.revisionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.revisionDataGridViewTextBoxColumn.DataPropertyName = "Revision";
            this.revisionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.revisionDataGridViewTextBoxColumn.HeaderText = "Revision";
            this.revisionDataGridViewTextBoxColumn.Name = "revisionDataGridViewTextBoxColumn";
            this.revisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.FillWeight = 50F;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ecuCommentDataGridViewTextBoxColumn
            // 
            this.ecuCommentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ecuCommentDataGridViewTextBoxColumn.DataPropertyName = "EcuComment";
            this.ecuCommentDataGridViewTextBoxColumn.HeaderText = "EcuComment";
            this.ecuCommentDataGridViewTextBoxColumn.Name = "ecuCommentDataGridViewTextBoxColumn";
            this.ecuCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.AutoGenerateColumns = false;
            this.dgvJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jobNameDataGridViewTextBoxColumn,
            this.jobCommentDataGridViewTextBoxColumn});
            this.dgvJobs.DataSource = this.jobBindingSource;
            this.dgvJobs.Location = new System.Drawing.Point(3, 166);
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.ReadOnly = true;
            this.dgvJobs.Size = new System.Drawing.Size(347, 212);
            this.dgvJobs.TabIndex = 10;
            // 
            // jobNameDataGridViewTextBoxColumn
            // 
            this.jobNameDataGridViewTextBoxColumn.DataPropertyName = "JobName";
            this.jobNameDataGridViewTextBoxColumn.HeaderText = "JobName";
            this.jobNameDataGridViewTextBoxColumn.Name = "jobNameDataGridViewTextBoxColumn";
            this.jobNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobCommentDataGridViewTextBoxColumn
            // 
            this.jobCommentDataGridViewTextBoxColumn.DataPropertyName = "JobComment";
            this.jobCommentDataGridViewTextBoxColumn.HeaderText = "JobComment";
            this.jobCommentDataGridViewTextBoxColumn.Name = "jobCommentDataGridViewTextBoxColumn";
            this.jobCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dgvArgs
            // 
            this.dgvArgs.AllowUserToAddRows = false;
            this.dgvArgs.AllowUserToDeleteRows = false;
            this.dgvArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArgs.AutoGenerateColumns = false;
            this.dgvArgs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArgs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArgs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.argNameDataGridViewTextBoxColumn,
            this.argTypeDataGridViewTextBoxColumn,
            this.argCommentDataGridViewTextBoxColumn});
            this.dgvArgs.DataSource = this.jobArgBindingSource;
            this.dgvArgs.Location = new System.Drawing.Point(3, 384);
            this.dgvArgs.Name = "dgvArgs";
            this.dgvArgs.ReadOnly = true;
            this.dgvArgs.Size = new System.Drawing.Size(347, 335);
            this.dgvArgs.TabIndex = 11;
            // 
            // jobArgBindingSource
            // 
            this.jobArgBindingSource.DataSource = typeof(PrgTool.MainForm.JobArg);
            // 
            // argNameDataGridViewTextBoxColumn
            // 
            this.argNameDataGridViewTextBoxColumn.DataPropertyName = "ArgName";
            this.argNameDataGridViewTextBoxColumn.HeaderText = "ArgName";
            this.argNameDataGridViewTextBoxColumn.Name = "argNameDataGridViewTextBoxColumn";
            this.argNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argTypeDataGridViewTextBoxColumn
            // 
            this.argTypeDataGridViewTextBoxColumn.DataPropertyName = "ArgType";
            this.argTypeDataGridViewTextBoxColumn.HeaderText = "ArgType";
            this.argTypeDataGridViewTextBoxColumn.Name = "argTypeDataGridViewTextBoxColumn";
            this.argTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // argCommentDataGridViewTextBoxColumn
            // 
            this.argCommentDataGridViewTextBoxColumn.DataPropertyName = "ArgComment";
            this.argCommentDataGridViewTextBoxColumn.HeaderText = "ArgComment";
            this.argCommentDataGridViewTextBoxColumn.Name = "argCommentDataGridViewTextBoxColumn";
            this.argCommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 869);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.wbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnFileBrowse);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "PRG Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eCUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobResultBindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEcus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArgs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobArgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnFileBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.WebBrowser wbResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource eCUBindingSource;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jobResultBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvEcus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn revisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ecuCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvJobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvArgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn argNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn argCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jobArgBindingSource;
    }
}

