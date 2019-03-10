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
        public static void showDirectory(FileSystemInfo f, int level)
        {
            printSpace(level);
            Console.Write(f.Name + '\n');
            if (f.GetType() == typeof(DirectoryInfo))
            {

                var items = (f as DirectoryInfo).GetFileSystemInfos();
                foreach (var i in items)
                {
                    printSpace(level);
                    if (f.GetType() == typeof(DirectoryInfo))
                        showDirectory(i, level + 1);
                }
            }
            
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Asus\Desktop\cpp");
            showDirectory(dir, 0);
            Console.ReadKey();

        }
    }
}
