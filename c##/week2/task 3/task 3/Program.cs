using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_3
{
    class Program
    {
        public static void printSpace(int level)
        {
            for ( int i = 1; i <= level * 4; i++)
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
                Console.WriteLine(d.Name);
                showDirectory(d, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Asus\Desktop\c##\");
            showDirectory(d, 0);

            Console.ReadKey();

        }
    }
}
