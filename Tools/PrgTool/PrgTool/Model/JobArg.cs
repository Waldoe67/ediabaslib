namespace PrgTool {
    public class JobArg {
        public const string KeyArg = "ARG";
        public const string KeyArgType = "ARGTYPE";
        public const string KeyArgComment = "ARGCOMMENT";

        public string ArgName { get; set; }
        public string ArgType { get; set; }
        public string ArgComment { get; set; }
    }
}
