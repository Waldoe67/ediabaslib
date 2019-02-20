using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrgTool {
    public partial class MainForm : Form {
        private List<Ecu> _ecus = new List<Ecu>();

        private bool _parsing = false;
        private bool IsParsing {
            get {
                return this._parsing;
            }

            set {
                this._parsing = value;

                this.lbPaths.Enabled = this._parsing;
                this.btnFileBrowse.Enabled = !this._parsing;
                this.btnParse.Enabled = (!this._parsing && this.lbPaths.Items.Count > 0);
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
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.Multiselect = true;
                ofd.Filter = "PRG files|*.prg";
                ofd.ReadOnlyChecked = true;
                ofd.Title = "Select PRG file";

                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && ofd.FileNames.Length > 0) {
                    this.lbPaths.Items.Clear();
                    this.lbPaths.Items.AddRange(ofd.FileNames);
                }

                this.btnParse.Enabled = (this.lbPaths.Items.Count > 0);
            }
        }
        
        private void btnParse_Click(object sender, EventArgs e) {
            this.IsParsing = true;

            if (this.lbPaths.Items.Count == 0) {
                MessageBox.Show("Please selected some .prg files first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                this._ecus.Clear();

                foreach (string p in this.lbPaths.Items) {
                    FileInfo fi = new FileInfo(p.Trim());

                    if (fi.Exists) {
                        using (FileStream fs = fi.OpenRead()) {
                            try {
                                this._ecus.Add(EcuUtil.parseEcu(fi.Name.Remove(fi.Name.Length - 4), fs));
                            } catch (Exception ex) {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    } else {
                        MessageBox.Show("The selected path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.clearGrids();

                this._ecus = this._ecus.OrderBy(ec => ec.EcuName).ToList();

                if (this._ecus.Count > 0) {
                    this.dgvEcus.DataSource = this._ecus;
                    this.dgvEcus.Rows[0].Selected = true;
                    this.txtSearch.Enabled = true;
                }
            }

            this.IsParsing = false;
        }

        private void dgvEcus_SelectionChanged(object sender, EventArgs e) {
            DataGridView dgv = (sender as DataGridView);

            int? rowIndex = (dgv.SelectedRows.Count > 0 ? dgv.SelectedRows[0].Index : -1);

            if (rowIndex >= 0 && rowIndex < (sender as DataGridView).Rows.Count) {
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

            if (rowIndex >= 0 && rowIndex < (sender as DataGridView).Rows.Count) {
                Job job = (dgv.Rows[rowIndex.Value].DataBoundItem as Job);

                if (job != null) {
                    this.dgvArgs.DataSource = job.Arguments.OrderBy(a => a.ArgName).ToList();

                    this.dgvResults.DataSource = job.Results.OrderBy(r => r.ResultName).ToList();
                    this.dgvResults.ContextMenuStrip = (job.Results.Count > 0 ? this.ctxResult : null);
                }
            }
        }

        private void ctxResultAddToBookmarks_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow r in this.dgvResults.SelectedRows) {
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

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            this.btnSearch.Enabled = (this.txtSearch.Text.Length > 0);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                this.performSearch();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            this.performSearch();
        }

        private void performSearch() {
            this.clearGrids();

            this.dgvEcus.DataSource = this.filterEcus(this.txtSearch.Text);

            if (this.dgvEcus.Rows.Count > 0) {
                this.dgvEcus.Rows[0].Selected = true;
            }

            this.btnClearSearch.Enabled = true;
        }

        private List<Ecu> filterEcus(string filterString) {
            List<Ecu> filtered = new List<Ecu>();

            foreach (Ecu ecu in this._ecus) {
                List<Job> jobs = new List<Job>();

                foreach (Job j in ecu.Jobs) {
                    IEnumerable<JobResult> results = j.Results.Where(r => r.ResultName.IndexOf(filterString, StringComparison.OrdinalIgnoreCase) > 0
                                                                || r.ResultComment.IndexOf(filterString, StringComparison.OrdinalIgnoreCase) > 0);

                    if (results.Count() == 0 && (j.JobName.IndexOf(filterString, StringComparison.OrdinalIgnoreCase) > 0
                                                                || j.JobComment.IndexOf(filterString, StringComparison.OrdinalIgnoreCase) > 0)) {
                        results = j.Results;   
                    }

                    if (results.Count() > 0) {
                        jobs.Add(new Job() {
                            JobName = j.JobName,
                            JobComment = j.JobComment,
                            Results = results.ToList()
                        });
                    }
                }

                if (jobs.Count > 0) {
                    filtered.Add(new Ecu() {
                        Author = ecu.Author,
                        EcuComment = ecu.EcuComment,
                        EcuDescription = ecu.EcuDescription,
                        EcuName = ecu.EcuName,
                        Jobs = jobs,
                        Origin = ecu.Origin,
                        Revision = ecu.Revision
                    });
                }
            }

            return filtered;
        }

        private void btnClearSearch_Click(object sender, EventArgs e) {
            this.txtSearch.Clear();
            this.btnClearSearch.Enabled = false;

            this.clearGrids();

            this.dgvEcus.DataSource = this._ecus;
            this.dgvEcus.Rows[0].Selected = true;
        }

        private void clearGrids() {
            this.dgvEcus.DataSource = null;
            this.dgvJobs.DataSource = null;
            this.dgvArgs.DataSource = null;
            this.dgvResults.DataSource = null;
        }
        #endregion

    }
}
