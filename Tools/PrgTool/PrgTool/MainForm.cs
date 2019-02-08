using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrgTool {
    public partial class MainForm : Form {

        private bool _parsing = false;
        private readonly List<EdiabasLib.EdiabasNet.DescriptionInfos> _descriptionInfos = new List<EdiabasLib.EdiabasNet.DescriptionInfos>();
        private const string _ecuTemplateBegin = "<html>" +
                                                "<head>" +
                                                "	<title>ECU parse</title>" +
                                                "	<style>" +
                                                "		table {" +
                                                "			width: 100%;" +
                                                "			border-collapse: collapse;" +
                                                "		}" +
                                                "		th, td {" +
                                                "			border: 1px solid black;" +
                                                "			width: 100px;" +
                                                "		}" +
                                                "		table tr:nth-child(even) {" +
                                                "			background-color: #fff;" +
                                                "		}" +
                                                "		table tr:nth-child(odd) {" +
                                                "			background-color: #eee;" +
                                                "		}" +
                                                "	</style>" +
                                                "</head>" +
                                                "<body>";

        public MainForm() {
            this.InitializeComponent();
        }

        private void btnFileBrowse_Click(object sender, EventArgs e) {
            using(OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.CheckFileExists = true;
                ofd.CheckPathExists = true;
                ofd.Multiselect = false;
                ofd.Filter = "PRG files|*.prg";
                ofd.ReadOnlyChecked = true;
                ofd.Title = "Select PRG file";

                DialogResult result = ofd.ShowDialog();

                if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName)) {
                    this.txtPath.Text = ofd.FileName;
                }
            }
        }

        private bool IsParsing {
            get {
                return this._parsing;
            }

            set {
                this._parsing = value;

                this.txtPath.ReadOnly = this._parsing;
                this.btnFileBrowse.Enabled = !this._parsing;
                this.btnParse.Enabled = !this._parsing;
            }
        }
        private void btnParse_Click(object sender, EventArgs e) {
            this.IsParsing = true;

            if(string.IsNullOrEmpty(this.txtPath.Text)) {
                MessageBox.Show("Please selected a path first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(!this.txtPath.Text.ToLower().EndsWith(".prg")) {
                MessageBox.Show("Wrong file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                FileInfo fi = new FileInfo(this.txtPath.Text);

                if(fi.Exists) {
                    this._descriptionInfos.Clear();

                    Dictionary<string, string> errors = new Dictionary<string, string>();
                    string markup = _ecuTemplateBegin;

                    using(FileStream fs = fi.OpenRead()) {
                        EdiabasLib.EdiabasNet.DescriptionInfos desc = null;
                        List<string> headers = new List<string>();
                        List<string> colums = new List<string>();

                        try {
                            desc = EdiabasLib.EdiabasNet.ReadDescriptions(fs);
                            foreach(string[] split in desc.GlobalComments.Select(s => s.Split(':'))) {
                                headers.Add(string.Format("<th>{0}</th>", split[0]));
                                colums.Add(string.Format("<td>{0}</td>", split[1]));
                            }
                            markup += string.Format("<table><tr>{0}</tr><tr>&nbsp;{1}</tr></table>", string.Join("", headers), string.Join("", colums));

                            foreach(KeyValuePair<string, List<string>> kv in desc.JobComments) {
                                headers.Clear();
                                colums.Clear();

                                foreach(string[] split in kv.Value.Where(s => !s.StartsWith("RESULT")).Select(s => s.Split(':'))) {
                                    headers.Add(string.Format("<th style=\"background-color: black; color: white;\">{0}</th>", split[0]));
                                    colums.Add(string.Format("<td>{0}</td>", split[1]));
                                }
                                markup += string.Format("<table style=\"margin-bottom: -20px;\"><tr>{0}</tr><tr>&nbsp;{1}</tr></table>", string.Join("", headers), string.Join("", colums));

                                headers.Clear();
                                colums.Clear();

                                SortedDictionary<int, string> h = new SortedDictionary<int, string>();
                                List<string> results = kv.Value.Where(s => s.StartsWith("RESULT")).ToList();

                                for(int i = 0, j = 0, k = 0; i < results.Count; i++, j++) {
                                    string[] split = results[i].Split(':');

                                    if(string.CompareOrdinal("RESULT", split[0]) == 0) {
                                        j = 0;
                                        colums.Add("<tr>");
                                        k = colums.Count - 1;
                                    }

                                    h[j] = string.Format("<th style=\"background-color: grey; color: white;\">{0}</th>", split[0]);
                                    colums[k] += string.Format("<td>{0}</td>", string.Join("", split.ToList().GetRange(1, split.Length - 1)));
                                }

                                markup += string.Format("<table><tr>{0}</tr>&nbsp;{1}</table>", string.Join("", h.Values), string.Join("</tr>", colums));
                            }
                            this._descriptionInfos.Add(desc);
                        } catch(Exception ex) {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    markup += "</body></html>";
                    this.wbResult.DocumentText = markup;
                    this.wbResult.Focus();
                } else {
                    MessageBox.Show("The selected path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.IsParsing = false;
        }
    }
}
