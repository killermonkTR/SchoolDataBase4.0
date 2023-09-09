using System;
using System.IO;
namespace CodeTester
{
    class StringInterpolation
    {
        public string Path1 { get; set; }
            
            
            
        static void Main(string[] args)
        {
            //string path = Environment.CurrentDirectory;

            // This will get the current WORKING directory (i.e. \bin\Debug)
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT bin directory (ie ../bin/)
            //string path2 = Directory.GetParent(workingDirectory).Parent.FullName;
            // StringInterpolation si = new StringInterpolation();
            //  string si.Path1 = Environment.CurrentDirectory
            //string path2 = Path.Combine(si.Path1 + , "..", "..");
            //Console.WriteLine("The dir is " + path2);

            //string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            //Console.WriteLine("The dir is3 " + directory);

            // This will get the current PROJECT directory
            //string path3 = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}\\Resources\\Tails.png", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\..\..")));
            Console.WriteLine("The dir is " + FileName);

             //System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames();

        }
    }
}
