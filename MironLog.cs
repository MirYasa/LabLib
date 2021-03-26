using System;
using Lab.core;
using System.IO;

namespace Lab.MironGurevich
{
    public class MironLog : LogAbstract, LogInterface
    {
        private static MironLog instance;
        private MironLog() { }
        public static MironLog GetInstance()
        {
            if (instance == null)
            {
                instance = new MironLog();
            }
            return instance;
        }
        public static void Log(string str)
        {
            GetInstance()._log(str);
        }
        public override void _write()
        {
            var result = String.Join("\r\n", log);
            Console.WriteLine(result);

            string path = $"Log";
            string pathFile = $"{path}/{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss.ffff").Trim()}.log";

            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            using (StreamWriter sw = new StreamWriter(pathFile))
            {
                sw.WriteLine(result.Trim());
            }
        }

        public override void _log(string str)
        {
            GetInstance().log.Add(str);
        }

        public static void Write()
        {
            GetInstance()._write();
        }
    }
}