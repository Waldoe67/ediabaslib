using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrgTool {
    public partial class MainForm : Form {

        private bool _parsing = false;
        private bool IsParsing {
            get {
                return this._parsing;
            }

            set {
                this._parsing = value;

                this.txtPath.ReadOnly = this._parsing;
                this.btnFileBrowse.Enabled = !this._parsing;
                this.btnParse.Enabled = (!this._parsing && !string.IsNullOrEmpty(this.txtPath.Text));
            }
        }

        public MainForm() {
            this.InitializeComponent();

            this.dgvEcus.SelectionChanged += this.dgvEcus_SelectionChanged;
            this.dgvJobs.SelectionChanged += this.dgvJobs_SelectionChanged;
            this.ctxResultAddToBookmarks.Click += this.ctxResultAddToBookmarks_Click;
        }

        #region UI Events

        private void btnFileBrowse_Click(object sender, EventArgs e) {
            using(OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.Multiselect = true;
                ofd.Filter = "PRG files|*.prg";
                ofd.ReadOnlyChecked = true;
                ofd.Title = "Select PRG file";

                DialogResult result = ofd.ShowDialog();

                if(result == DialogResult.OK && ofd.FileNames.Length > 0) {
                    this.txtPath.Text = string.Join("; ", ofd.FileNames);
                }
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e) {
            if(string.IsNullOrWhiteSpace((sender as TextBox).Text)) {
                this.btnParse.Enabled = false;
            } else {
                this.btnParse.Enabled = true;
            }
        }

        private void btnParse_Click(object sender, EventArgs e) {
            this.IsParsing = true;

            if(string.IsNullOrEmpty(this.txtPath.Text)) {
                MessageBox.Show("Please selected a path first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(!this.txtPath.Text.ToLower().EndsWith(".prg")) {
                MessageBox.Show("Wrong file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                List<Ecu> ecus = new List<Ecu>();

                foreach(string p in this.txtPath.Text.Split(';')) {
                    FileInfo fi = new FileInfo(p.Trim());

                    if(fi.Exists) {
                        using(FileStream fs = fi.OpenRead()) {
                            try {
                                ecus.Add(EcuUtil.parseEcu(fi.Name.Remove(fi.Name.Length - 4), fs));
                            } catch(Exception ex) {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                        
                    } else {
                        MessageBox.Show("The selected path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
                this.dgvJobs.DataSource = null;
                this.dgvArgs.DataSource = null;
                this.dgvResults.DataSource = null;

                this.dgvEcus.DataSource = ecus.OrderBy(ec => ec.EcuName).ToList();
                this.dgvEcus.Rows[0].Selected = true;
            }

            this.IsParsing = false;
        }

        private void dgvEcus_SelectionChanged(object sender, EventArgs e) {
            DataGridView dgv = (sender as DataGridView);

            int? rowIndex = (dgv.SelectedRows.Count > 0 ? dgv.SelectedRows[0].Index : -1);

            if(rowIndex >= 0 && rowIndex < (sender as DataGridView).Rows.Count) {
                Ecu ecu = (dgv.Rows[rowIndex.Value].DataBoundItem as Ecu);

                if (ecu != null) {
                    this.dgvArgs.DataSource = null;
                    this.dgvResults.DataSource = null;

                    this.dgvJobs.DataSource = ecu.Jobs.OrderBy(j => j.JobName).ToList();
                    this.dgvJobs.Rows[0].Selected = true;
                }
            }
        }

        private void dgvJobs_SelectionChanged(object sender, EventArgs e) {
            DataGridView dgv = (sender as DataGridView);

            int? rowIndex = (dgv.SelectedRows.Count > 0 ? dgv.SelectedRows[0].Index : -1);

            if(rowIndex >= 0 && rowIndex < (sender as DataGridView).Rows.Count) {
                Job job = (dgv.Rows[rowIndex.Value].DataBoundItem as Job);

                if (job != null) {
                    this.dgvArgs.DataSource = job.Arguments.OrderBy(a => a.ArgName).ToList();

                    this.dgvResults.DataSource = job.Results.OrderBy(r => r.ResultName).ToList();
                    this.dgvResults.ContextMenuStrip = (job.Results.Count > 0 ? ctxResult : null);
                }
            }
        }

        private void ctxResultAddToBookmarks_Click(object sender, EventArgs e) {
            foreach(DataGridViewRow r in this.dgvResults.SelectedRows) {
                BookmarkStore.addBookmark(
                    (this.dgvEcus.SelectedRows[0].DataBoundItem as Ecu),
                    this.dgvJobs.SelectedRows[0].DataBoundItem as Job,
                    r.DataBoundItem as JobResult);
            }
        }

        private void btnShowBookmarks_Click(object sender, EventArgs e) {
            BookmarkForm sl = new BookmarkForm();
            sl.ShowDialog();
        }

        #endregion
    }
}
