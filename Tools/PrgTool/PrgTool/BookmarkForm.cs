using System.Collections.Generic;
using System.Windows.Forms;

namespace PrgTool {
    public partial class BookmarkForm : Form {
        
        public BookmarkForm() {
            InitializeComponent();

            this.dgvBookmarks.ColumnCount = 4;
            this.dgvBookmarks.Columns[0].Name = "Ecu Name";
            this.dgvBookmarks.Columns[1].Name = "Job Name";
            this.dgvBookmarks.Columns[2].Name = "Result Name";
            this.dgvBookmarks.Columns[3].Name = "Result Type";

            foreach(KeyValuePair<string, BookmarkStore.BookmarkEntry> kvs in BookmarkStore.GetAllBookmarks()) {
                foreach(KeyValuePair <string, BookmarkStore.BookmarkJobEntry> kvj in kvs.Value.Jobs) {
                    foreach(JobResult r in kvj.Value.Results) {
                        this.dgvBookmarks.Rows.Add(
                            new string[] {
                                kvs.Key,
                                kvj.Key,
                                r.ResultName,
                                r.ResultType
                            }
                        );
                    }
                }
            }
        }

        private void dgvBookmarks_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            BookmarkStore.removeBookmark(e.Row.Cells[0].Value.ToString(), e.Row.Cells[1].Value.ToString(), e.Row.Cells[2].Value.ToString());
        }
    }
}
