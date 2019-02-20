using System.Collections.Generic;
using System.Windows.Forms;

namespace PrgTool {
    public partial class BookmarkForm : Form {

        public BookmarkForm() {
            this.InitializeComponent();

            string[] columns = new string[] {
                "Ecu Name",
                "Ecu Description",
                "Job Name",
                "Job Comment",
                "Result Name",
                "Result Type",
                "Result Comment"

            };

            this.dgvBookmarks.ColumnCount = columns.Length;

            for(int i = 0; i < columns.Length; i++) {
                this.dgvBookmarks.Columns[i].Name = columns[i];
            }

            foreach(KeyValuePair<string, BookmarkStore.BookmarkEntry> kvs in BookmarkStore.GetAllBookmarks()) {
                foreach(KeyValuePair<string, BookmarkStore.BookmarkJobEntry> kvj in kvs.Value.Jobs) {
                    foreach(JobResult r in kvj.Value.Results) {
                        this.dgvBookmarks.Rows.Add(
                            new string[] {
                                kvs.Key,
                                kvs.Value.EcuDescription,
                                kvj.Key,
                                kvj.Value.Jobcomment,
                                r.ResultName,
                                r.ResultType,
                                r.ResultComment
                            }
                        );
                    }
                }
            }
        }

        private void dgvBookmarks_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            BookmarkStore.removeBookmark(e.Row.Cells[0].Value.ToString(), e.Row.Cells[2].Value.ToString(), e.Row.Cells[4].Value.ToString());
        }

        private void btnExport_Click(object sender, System.EventArgs e) {

        }
    }
}
