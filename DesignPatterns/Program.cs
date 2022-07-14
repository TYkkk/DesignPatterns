using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //DesignPatterns_AbstractFactory.AbstractFactory abstractFactory = new DesignPatterns_AbstractFactory.AbstractFactory();
            //abstractFactory.Run();

            Console.WriteLine("Start");

            Stopwatch sw = new Stopwatch();
            sw.Start();

            List<string> result = new List<string>(32);

            var dirves = DriveInfo.GetDrives();
            foreach (var dirve in dirves)
            {
                CheckFileByExtension(dirve.RootDirectory, ".pdf", result);
            }

            foreach (var path in result)
            {
                Console.WriteLine(path);
            }

            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine($"End,Time:{ts}");

            Console.ReadLine();
        }

        private static void CheckFileByExtension(DirectoryInfo directoryInfo, string match, List<string> result)
        {
            if (result == null || directoryInfo == null)
            {
                return;
            }

            try
            {
                var files = directoryInfo.GetFiles();
                foreach (var file in files)
                {
                    if (file.Extension == match)
                    {
                        result.Add(file.FullName);
                    }
                }

                var childDirectorys = directoryInfo.GetDirectories();
                if (childDirectorys == null || childDirectorys.Length == 0)
                {
                    return;
                }

                foreach (var child in childDirectorys)
                {
                    CheckFileByExtension(child, match, result);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
        }
    }
}
