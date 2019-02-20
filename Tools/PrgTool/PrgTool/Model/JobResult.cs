namespace PrgTool {
    public class JobResult {
        public const string KeyResult = "RESULT";
        public const string KeyResultType = "RESULTTYPE";
        public const string KeyResultComment = "RESULTCOMMENT";

        public string ResultName { get; set; }
        public string ResultType { get; set; }
        public string ResultComment { get; set; }
    }
}
