using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace level
{
    class Program
    {
        public static void printSpace(int level)
        {
            for (int i = 1; i <= level * 4; i++)
            {
                Console.Write(" ");
            }
        }
        public static void showDirectory(DirectoryInfo d, int level)
        {
            DirectoryInfo[] arrayOfDirectories = d.GetDirectories();

            FileInfo[] arrayOfFiles = d.GetFiles();

            foreach (FileInfo f in arrayOfFiles)
            {
                printSpace(level);
                Console.WriteLine(f.Name);
            }
            foreach(DirectoryInfo di in arrayOfDirectories)
            {
                printSpace(level);
                Console.WriteLine(di.Name);
                showDirectory(di, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\C#");

            showDirectory(di, 0);

            Console.ReadKey();

        }
    }
}
