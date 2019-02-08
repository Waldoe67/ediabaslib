using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InitializeComponent();
        }

        private void btnFileBrowse_Click(object sender, EventArgs e) {
            using(var fbd = new FolderBrowserDialog()) {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    this.txtPath.Text = fbd.SelectedPath;
                }
            }
        }

        private bool IsParsing {
            get {
                return _parsing;
            }

            set {
                _parsing = value;

                this.txtPath.ReadOnly = _parsing;
                this.btnFileBrowse.Enabled = !_parsing;
                this.btnParse.Enabled = !_parsing;
            }
        }
        private void btnParse_Click(object sender, EventArgs e) {
            this.IsParsing = true;

            //this.txtPath.Text = "C:\\Users\\christiang\\Code\\ECU";

            DirectoryInfo di = new DirectoryInfo(this.txtPath.Text);

            if (di.Exists) {
                _descriptionInfos.Clear();

                FileInfo[] files = di.GetFiles("*.prg");
                Dictionary<string, string> errors = new Dictionary<string, string>();
                string markup = _ecuTemplateBegin;

                foreach(FileInfo f in files) {
                    using(FileStream fs = f.OpenRead()) {
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
                            _descriptionInfos.Add(desc);
                        } catch (Exception ex) {
                            errors.Add(f.Name, ex.Message);
                        }                        
                    }
                }

                markup += "</body></html>";
                this.wbResult.DocumentText = markup;
                this.wbResult.Focus();
            } else {
                MessageBox.Show("The selected path does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.IsParsing = false;
        }
    }
}
