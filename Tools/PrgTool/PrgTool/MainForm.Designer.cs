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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnFileBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.wbResult = new System.Windows.Forms.WebBrowser();
            this.menuStripMain.SuspendLayout();
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
            this.lblPath.Size = new System.Drawing.Size(65, 13);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Select Path:";
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
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(15, 68);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 4;
            this.btnParse.Text = "Parse Files";
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
            this.wbResult.Size = new System.Drawing.Size(1009, 424);
            this.wbResult.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 575);
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
    }
}

