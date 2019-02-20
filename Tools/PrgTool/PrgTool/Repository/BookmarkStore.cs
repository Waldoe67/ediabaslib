using System.Collections.Generic;

namespace PrgTool {

    public static class BookmarkStore {
        public class BookmarkEntry {
            public string EcuName { get; set; }

            public Dictionary<string, BookmarkJobEntry> Jobs { get; set; }
        }

        public class BookmarkJobEntry {
            public string Jobcomment { get; set; }
            public List<JobArg> Arguments { get; set; }

            public HashSet<JobResult> Results { get; set; }
        }

        private static readonly Dictionary<string, BookmarkEntry> _bookmarks = new Dictionary<string, BookmarkEntry>();

        public static void addBookmark(string ecuName, Job job, JobResult result) {
            if (!_bookmarks.ContainsKey(ecuName)) {
                _bookmarks.Add(ecuName, new BookmarkEntry() {
                    EcuName = ecuName,
                    Jobs = new Dictionary<string, BookmarkJobEntry>()
                });
            }

            if (!_bookmarks[ecuName].Jobs.ContainsKey(job.JobName)) {
                _bookmarks[ecuName].Jobs.Add(job.JobName, new BookmarkJobEntry() {
                    Jobcomment = job.JobComment,
                    Arguments = job.Arguments,
                    Results = new HashSet<JobResult>()
                });
            }

            _bookmarks[ecuName].Jobs[job.JobName].Results.Add(result);
        }

        public static void removeBookmark(string ecuName, string jobName, string resultName) {
            if (_bookmarks.ContainsKey(ecuName) && _bookmarks[ecuName].Jobs.ContainsKey(jobName)) {
                _bookmarks[ecuName].Jobs[jobName].Results.RemoveWhere(r => r.ResultName == resultName);

                if(_bookmarks[ecuName].Jobs[jobName].Results.Count == 0) {
                    _bookmarks[ecuName].Jobs.Remove(jobName);

                    if (_bookmarks[ecuName].Jobs.Count == 0) {
                        _bookmarks.Remove(ecuName);
                    }
                }
            }
        }

        public static Dictionary<string, BookmarkEntry> GetAllBookmarks() {
            return new Dictionary<string, BookmarkEntry>(_bookmarks);
        }
    }
}
