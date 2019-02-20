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

        private static readonly Dictionary<string, BookmarkEntry> _saveList = new Dictionary<string, BookmarkEntry>();

        public static void addBookmark(string ecuName, Job job, JobResult result) {
            if (!_saveList.ContainsKey(ecuName)) {
                _saveList.Add(ecuName, new BookmarkEntry() {
                    EcuName = ecuName,
                    Jobs = new Dictionary<string, BookmarkJobEntry>()
                });
            }

            if (!_saveList[ecuName].Jobs.ContainsKey(job.JobName)) {
                _saveList[ecuName].Jobs.Add(job.JobName, new BookmarkJobEntry() {
                    Jobcomment = job.JobComment,
                    Arguments = job.Arguments,
                    Results = new HashSet<JobResult>()
                });
            }

            _saveList[ecuName].Jobs[job.JobName].Results.Add(result);
        }

        public static void removeBookmark(string ecuName, string jobName, string resultName) {
            if (_saveList.ContainsKey(ecuName) && _saveList[ecuName].Jobs.ContainsKey(jobName)) {
                _saveList[ecuName].Jobs[jobName].Results.RemoveWhere(r => r.ResultName == resultName);

                if(_saveList[ecuName].Jobs[jobName].Results.Count == 0) {
                    _saveList[ecuName].Jobs.Remove(jobName);

                    if (_saveList[ecuName].Jobs.Count == 0) {
                        _saveList.Remove(ecuName);
                    }
                }
            }
        }

        public static Dictionary<string, BookmarkEntry> GetAllBookmarks() {
            return new Dictionary<string, BookmarkEntry>(_saveList);
        }
    }
}
