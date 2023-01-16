using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimer.Models
{
    public class Job
    {
        public TimeSpan TotalTime { get; set; }
        public TimeSpan RemainingTime { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public bool IsContinue { get; set; }
        public bool IsStart { get; set; }


        private static List<Job> _jobs = new();
        public static List<Job> Jobs
        {
            get
            {
                _jobs.Clear();
                if (_jobs.Count == 0)
                    using (StreamReader sr = new(Paths.Paths.ConfigFilePath))
                        while (!sr.EndOfStream)
                        {
                            string satir = sr.ReadLine() ?? "";
                            _jobs.Add(new()
                            {
                                Name = satir.Split(">>>")[0],
                                TotalTime = TimeSpan.Parse(satir.Split(">>>")[1]),
                                RemainingTime = TimeSpan.Parse(satir.Split(">>>")[2]),
                                IsStart = false,
                                IsContinue = false,
                                IsCompleted = false,
                            });
                        }

                return _jobs;
            }
        }
    }
}
