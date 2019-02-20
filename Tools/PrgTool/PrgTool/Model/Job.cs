using System.Collections.Generic;

namespace PrgTool {
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
}
