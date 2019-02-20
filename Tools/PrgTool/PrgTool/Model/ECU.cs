using System.Collections.Generic;

namespace PrgTool {
    public class Ecu {
        public const string KeyEcu = "ECU";
        public const string KeyEcuOrigin = "ORIGIN";
        public const string KeyEcuRevision = "REVISION";
        public const string KeyEcuAuthor = "AUTHOR";
        public const string KeyEcuComment = "ECUCOMMENT";

        public string EcuName { get; set; }
        public string EcuLongName { get; set; }
        public string Origin { get; set; }
        public string Revision { get; set; }
        public string Author { get; set; }
        public string EcuComment { get; set; }
        public List<Job> Jobs { get; set; }

        public Ecu() {
            this.Jobs = new List<Job>();
        }
    }
}
