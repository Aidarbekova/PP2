using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = "Stick.txt";
            string SourcePath = @"C:\Users\Asus\Desktop\c#\lab 2\task 4\task 4\bin\Debug\task 4.exe";
            string targetPath = @"C:\Users\Asus\Desktop\c#\lab 2\task 4\task 4\bin\Debug\task 4.exe";

            string sourceFile = System.IO.Path.Combine(SourcePath, FileName);
            string destFile = System.IO.Path.Combine(targetPath, FileName);

            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }

            System.IO.File.Copy(sourceFile, destFile, true);

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                foreach (string s in files)
                {
                    FileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, FileName);
                    System.IO.File.Copy(s, destFile, true);
                }

            }
            else
            {
                Console.WriteLine("source path does not exist!");
            }
            if (System.IO.File.Exists(@"C:\Users\Asus\Desktop\c#\lab 2\task 4\task 4\bin\Debug\Stick"));

            try
            {
                System.IO.File.Delete(@"c:\Users\Asus\Desktop\c#\lab 2\task 4\task 4\bin\Debug\stick.txt");
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
