using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimer.Paths
{
    internal static class Paths
    {
        private static string _path = Application.StartupPath + @"\ConfigFile.txt";
        public static string ConfigFilePath
        {
            get
            {
                if (!File.Exists(_path))
                {
                    File.Create(_path).Close();
                    using (StreamWriter sw = new(_path))
                    {
                        string job1 = "Görev Adi 1>>>02:00:00>>>02:00:00";
                        string job2 = "Görev Adi 2>>>02:00:00>>>02:00:00";
                        string job3 = "Görev Adi 3>>>02:00:00>>>02:00:00";
                        string job4 = "Görev Adi 4>>>02:00:00>>>02:00:00";
                        string job5 = "Görev Adi 5>>>02:00:00>>>02:00:00";

                        sw.WriteLine(job1 + "\n" + job2 + "\n" + job3 + "\n" + job4 + "\n" + job5);
                    }
                }

                return _path;
            }
        }
    }
}
