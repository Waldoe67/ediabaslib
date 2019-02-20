using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace PrgTool {

    public static class BookmarkStore {
        public class BookmarkEntry {
            public string EcuDescription { get; set; }

            public Dictionary<string, BookmarkJobEntry> Jobs { get; set; }
        }

        public class BookmarkJobEntry {
            public string Jobcomment { get; set; }
            public List<JobArg> Arguments { get; set; }

            public HashSet<JobResult> Results { get; set; }
        }

        private static string _bookmarkFilePath = Path.Combine(System.Environment.CurrentDirectory, "bookmarks.txt");
        private static Dictionary<string, BookmarkEntry> _bookmarks = new Dictionary<string, BookmarkEntry>();

        static BookmarkStore() {
            if (File.Exists(_bookmarkFilePath)) {
                try {
                     _bookmarks = JsonConvert.DeserializeObject<Dictionary<string, BookmarkEntry>>(File.ReadAllText(_bookmarkFilePath));
                } catch {
                    /* Ignore */
                }
            }

            if (_bookmarks == null) {
                _bookmarks = new Dictionary<string, BookmarkEntry>();
            }
        }


        public static void addBookmark(Ecu ecu, Job job, JobResult result) {
            if (!_bookmarks.ContainsKey(ecu.EcuName)) {
                _bookmarks.Add(ecu.EcuName, new BookmarkEntry() {
                    EcuDescription = ecu.EcuDescription,
                    Jobs = new Dictionary<string, BookmarkJobEntry>()
                });
            }

            if (!_bookmarks[ecu.EcuName].Jobs.ContainsKey(job.JobName)) {
                _bookmarks[ecu.EcuName].Jobs.Add(job.JobName, new BookmarkJobEntry() {
                    Jobcomment = job.JobComment,
                    Arguments = job.Arguments,
                    Results = new HashSet<JobResult>()
                });
            }

            if(!_bookmarks[ecu.EcuName].Jobs[job.JobName].Results.Contains(result)) {
                _bookmarks[ecu.EcuName].Jobs[job.JobName].Results.Add(result);
                SaveBookmarks();
            }
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

                SaveBookmarks();
            }
        }

        public static Dictionary<string, BookmarkEntry> GetAllBookmarks() {
            return new Dictionary<string, BookmarkEntry>(_bookmarks);
        }

        private static void SaveBookmarks() {
            File.WriteAllText(_bookmarkFilePath, JsonConvert.SerializeObject(_bookmarks));
        }
    }
}
