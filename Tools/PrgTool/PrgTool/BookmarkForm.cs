using System.Collections.Generic;
using System.Linq;
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

            Dictionary<string, BookmarkStore.BookmarkEcuEntry> bookmarks = BookmarkStore.GetAllBookmarks();

            foreach(string ekey in bookmarks.Keys.OrderBy(s => s)) {
                BookmarkStore.BookmarkEcuEntry ecu = bookmarks[ekey];

                Dictionary<string, BookmarkStore.BookmarkJobEntry> jobs = ecu.Jobs;

                foreach(string jkey in jobs.Keys.OrderBy(s => s)) {
                    BookmarkStore.BookmarkJobEntry job = jobs[jkey];

                    foreach(JobResult r in job.Results.OrderBy(jr => jr.ResultName)) {
                        this.dgvBookmarks.Rows.Add(
                            new string[] {
                                ekey,
                                ecu.EcuDescription,
                                jkey,
                                job.Jobcomment,
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
