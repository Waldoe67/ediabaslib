using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PrgTool {
    public static class EcuUtil {
        public static Ecu parseEcu(string ecuName, Stream stream) {
            Ecu ecu = new Ecu();
            ecu.EcuName = ecuName;

            EdiabasLib.EdiabasNet.DescriptionInfos desc = EdiabasLib.EdiabasNet.ReadDescriptions(stream);
            parseEcuHeader(desc.GlobalComments, ref ecu);
            parseJobs(desc.JobComments, ref ecu);

            return ecu;
        }

        private static void parseEcuHeader(List<string> globalComments, ref Ecu ecu) {
            foreach (string[] split in globalComments.Select(s => s.Split(':'))) {
                switch (split[0].ToUpper()) {
                    case Ecu.KeyEcu:
                        ecu.EcuDescription = split[1];
                        break;

                    case Ecu.KeyEcuOrigin:
                        ecu.Origin = split[1];
                        break;

                    case Ecu.KeyEcuRevision:
                        ecu.Revision = split[1];
                        break;

                    case Ecu.KeyEcuAuthor:
                        ecu.Author = split[1];
                        break;

                    case Ecu.KeyEcuComment:
                        ecu.EcuComment = string.Concat((ecu.EcuComment ?? ""), split[1]);
                        break;
                }
            }
        }

        private static void parseJobs(Dictionary<string, List<string>> jobComments, ref Ecu ecu) {
            foreach (KeyValuePair<string, List<string>> kv in jobComments) {
                Job job = new Job();
                ecu.Jobs.Add(job);

                foreach (string[] split in kv.Value.Where(s => s.StartsWith(Job.KeyJob)).Select(s => s.Split(':'))) {
                    switch (split[0].ToUpper()) {
                        case Job.KeyJobName:
                            job.JobName = split[1];
                            break;

                        case Job.KeyJobComment:
                            job.JobComment = string.Concat((job.JobComment ?? ""), split[1]);
                            break;
                    }
                }

                List<string> args = kv.Value.Where(s => s.StartsWith(JobArg.KeyArg)).ToList();
                JobArg arg = null;

                for (int i = 0; i < args.Count; i++) {
                    string[] split = args[i].Split(':');

                    if (string.CompareOrdinal(JobArg.KeyArg, split[0].ToUpper()) == 0) {
                        arg = new JobArg();
                        arg.ArgName = split[1];
                        job.Arguments.Add(arg);
                    } else {
                        switch (split[0].ToUpper()) {
                            case JobArg.KeyArgType:
                                arg.ArgType = split[1];
                                break;

                            case JobArg.KeyArgComment:
                                arg.ArgComment = string.Concat((arg.ArgComment ?? ""), split[1]);
                                break;
                        }
                    }
                }

                args = null;

                List<string> results = kv.Value.Where(s => s.StartsWith(JobResult.KeyResult)).ToList();
                JobResult result = null;

                for (int i = 0; i < results.Count; i++) {
                    string[] split = results[i].Split(':');

                    if (string.CompareOrdinal(JobResult.KeyResult, split[0].ToUpper()) == 0) {
                        result = new JobResult();
                        result.ResultName = split[1];
                        job.Results.Add(result);
                    } else {
                        switch (split[0].ToUpper()) {
                            case JobResult.KeyResultType:
                                result.ResultType = split[1];
                                break;

                            case JobResult.KeyResultComment:
                                result.ResultComment = string.Concat((result.ResultComment ?? ""), split[1]);
                                break;
                        }
                    }
                }
            }
        }
    }
}
