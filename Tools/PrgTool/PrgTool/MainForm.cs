using System;
using System.IO;
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

            this.dgvEcus.CellClick += this.dgvEcus_CellClick;
            this.dgvJobs.CellClick += this.dgvJobs_CellClick;
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
                BindingSource src = new BindingSource();

                foreach(string p in this.txtPath.Text.Split(';')) {
                    FileInfo fi = new FileInfo(p.Trim());

                    if(fi.Exists) {
                        using(FileStream fs = fi.OpenRead()) {
                            try {
                                src.Add(EcuUtil.parseEcu(fi.Name.Remove(fi.Name.Length - 4), fs));
                            } catch(Exception ex) {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        
                    } else {
                        MessageBox.Show("The selected path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.dgvEcus.DataSource = src;
            }
            this.IsParsing = false;
        }

        private void dgvEcus_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.RowIndex < (sender as DataGridView).Rows.Count) {
                Ecu ecu = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Ecu);

                if (ecu != null) {
                    BindingSource src = new BindingSource();

                    foreach (Job j in ecu.Jobs) {
                        src.Add(j);
                    }

                    this.dgvJobs.DataSource = src;
                }
            }
        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.RowIndex < (sender as DataGridView).Rows.Count) {

                Job job = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Job);

                if (job != null) {
                    BindingSource src = new BindingSource();

                    foreach (JobArg a in job.Arguments) {
                        src.Add(a);
                    }

                    this.dgvArgs.DataSource = src;

                    src = new BindingSource();

                    foreach (JobResult r in job.Results) {
                        src.Add(r);
                    }

                    this.dgvResults.DataSource = src;

                    this.dgvResults.ContextMenuStrip = (src.Count > 0 ? ctxResult : null);                    
                }
            }
        }

        private void ctxResultAddToBookmarks_Click(object sender, EventArgs e) {
            foreach(DataGridViewRow r in this.dgvResults.SelectedRows) {
                BookmarkStore.addBookmark(
                    (this.dgvEcus.SelectedRows[0].DataBoundItem as Ecu).EcuName,
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
