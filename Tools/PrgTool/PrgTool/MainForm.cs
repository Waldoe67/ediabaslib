using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PrgTool {
    public partial class MainForm : Form {
        [XmlRoot("ECU")]
        public class ECU {
            public const string KeyEcu = "ECU";
            public const string KeyEcuOrigin = "ORIGIN";
            public const string KeyEcuRevision = "REVISION";
            public const string KeyEcuAuthor = "AUTHOR";
            public const string KeyEcuComment = "ECUCOMMENT";

            public string EcuName { get; set; }
            public string Origin { get; set; }
            public string Revision { get; set; }
            public string Author { get; set; }
            public string EcuComment { get; set; }
            public List<Job> Jobs { get; set; }

            public ECU() {
                this.Jobs = new List<Job>();
            }
        }

        public class Job {
            public const string KeyJob = "JOB";
            public const string KeyJobName = "JOBNAME";
            public const string KeyJobComment = "JOBCOMMENT";

            public string JobName { get; set; }
            public string JobComment { get; set; }
            public List<JobArg> Arguments { get; set; }
            public List<JobResult> Results { get; set; }

            public Job() {
                this.Arguments = new List<JobArg>();
                this.Results = new List<JobResult>();
            }
        }

        public class JobArg {
            public const string KeyArg = "ARG";
            public const string KeyArgType = "ARGTYPE";
            public const string KeyArgComment = "ARGCOMMENT";

            public string ArgName { get; set; }
            public string ArgType { get; set; }
            public string ArgComment { get; set; }
        }

        public class JobResult {
            public const string KeyResult = "RESULT";
            public const string KeyResultType = "RESULTTYPE";
            public const string KeyResultComment = "RESULTCOMMENT";

            public string ResultName { get; set; }
            public string ResultType { get; set; }
            public string ResultComment { get; set; }
        }

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
                        Dictionary<string, string> errors = new Dictionary<string, string>();
                        ECU ecu = new ECU();

                        using(FileStream fs = fi.OpenRead()) {
                            EdiabasLib.EdiabasNet.DescriptionInfos desc = null;

                            try {
                                desc = EdiabasLib.EdiabasNet.ReadDescriptions(fs);
                                this.parseEcuHeader(desc.GlobalComments, ref ecu);
                                this.parseJobs(desc.JobComments, ref ecu);
                            } catch(Exception ex) {
                                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                        src.Add(ecu);
                        this.dgvEcus.DataSource = src;
                        
                    } else {
                        MessageBox.Show("The selected path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            this.IsParsing = false;
        }

        private void dgvEcus_CellClick(object sender, DataGridViewCellEventArgs e) {
            ECU ecu = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as ECU);

            if(ecu != null) {
                BindingSource src = new BindingSource();

                foreach(Job j in ecu.Jobs) {
                    src.Add(j);
                }

                this.dgvJobs.DataSource = src;
            }
        }

        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e) {
            Job job = ((sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Job);

            if(job != null) {
                BindingSource src = new BindingSource();

                foreach(JobArg a in job.Arguments) {
                    src.Add(a);
                }

                this.dgvArgs.DataSource = src;

                src = new BindingSource();

                foreach(JobResult r in job.Results) {
                    src.Add(r);
                }

                this.dgvResults.DataSource = src;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string markup = this.wbResult.DocumentText;

            if(string.IsNullOrEmpty(markup)) {
                MessageBox.Show("Nothing to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                using(SaveFileDialog sfd = new SaveFileDialog()) {
                    sfd.AddExtension = true;
                    sfd.CheckPathExists = true;
                    sfd.DefaultExt = ".html";
                    sfd.Filter = "HTML|*.html";
                    sfd.FileName = this.txtPath.Text.Split('\\').Last();
                    sfd.OverwritePrompt = true;
                    sfd.SupportMultiDottedExtensions = true;
                    sfd.Title = "Save output";

                    sfd.ShowDialog();
                }
            }
        }

        private void wbResult_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            this.btnSave.Enabled = (sender as WebBrowser).DocumentText.Length > 0;
        }

        #endregion

        #region ECU Parsing
        private void parseEcuHeader(List<string> globalComments, ref ECU ecu) {
            foreach(string[] split in globalComments.Select(s => s.Split(':'))) {
                switch(split[0].ToUpper()) {
                    case ECU.KeyEcu:
                        ecu.EcuName = split[1];
                        break;

                    case ECU.KeyEcuOrigin:
                        ecu.Origin = split[1];
                        break;

                    case ECU.KeyEcuRevision:
                        ecu.Revision = split[1];
                        break;

                    case ECU.KeyEcuAuthor:
                        ecu.Author = split[1];
                        break;

                    case ECU.KeyEcuComment:
                        ecu.EcuComment = string.Concat((ecu.EcuComment ?? ""), split[1]);
                        break;
                }
            }
        }

        private void parseJobs(Dictionary<string, List<string>> jobComments, ref ECU ecu) {
            foreach(KeyValuePair<string, List<string>> kv in jobComments) {
                Job job = new Job();
                ecu.Jobs.Add(job);

                foreach(string[] split in kv.Value.Where(s => s.StartsWith(Job.KeyJob)).Select(s => s.Split(':'))) {
                    switch(split[0].ToUpper()) {
                        case Job.KeyJobName:
                            job.JobName = split[1];
                            break;

                        case Job.KeyJobComment:
                            job.JobComment = string.Concat((job.JobComment ?? ""), split[1]);
                            break;
                    }
                }

                List<string> args = kv.Value.Where(s => s.StartsWith(JobArg.KeyArg)).ToList();
                JobArg arg = null;

                for(int i = 0; i < args.Count; i++) {
                    string[] split = args[i].Split(':');

                    if(string.CompareOrdinal(JobArg.KeyArg, split[0].ToUpper()) == 0) {
                        arg = new JobArg();
                        arg.ArgName = split[1];
                        job.Arguments.Add(arg);
                    } else {
                        switch(split[0].ToUpper()) {
                            case JobArg.KeyArgType:
                                arg.ArgType = split[1];
                                break;

                            case JobArg.KeyArgComment:
                                arg.ArgComment = string.Concat((arg.ArgComment ?? ""), split[1]);
                                break;
                        }
                    }
                }

                args = null;

                List<string> results = kv.Value.Where(s => s.StartsWith(JobResult.KeyResult)).ToList();
                JobResult result = null;

                for(int i = 0; i < results.Count; i++) {
                    string[] split = results[i].Split(':');

                    if(string.CompareOrdinal(JobResult.KeyResult, split[0].ToUpper()) == 0) {
                        result = new JobResult();
                        result.ResultName = split[1];
                        job.Results.Add(result);
                    } else {
                        switch(split[0].ToUpper()) {
                            case JobResult.KeyResultType:
                                result.ResultType = split[1];
                                break;

                            case JobResult.KeyResultComment:
                                result.ResultComment = string.Concat((result.ResultComment ?? ""), split[1]);
                                break;
                        }
                    }
                }
            }
        }

        #endregion
    }
}
