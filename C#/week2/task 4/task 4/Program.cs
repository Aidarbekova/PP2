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
            string filename = "file.txt"; //create a string with name 

            string copy = @"C:\Users\Asus\Desktop\c#\c##\week2\copy"; //read info from files


            string delete = @"C:\Users\Asus\Desktop\c#\c##\week2\delete";// read info


            string sourcefile = Path.Combine(copy, filename); //перемещение операции transfrom of operatiom


            string destfile = Path.Combine(delete, filename); //копирование операции copy of operation


            FileStream fs = File.Create(sourcefile);

            StreamWriter wr = new StreamWriter(fs);

            wr.WriteLine("Test1");
            wr.WriteLine("Test2");


            wr.Close();
            fs.Close();

            File.Copy(sourcefile, destfile, true); //true for overwrite
            File.Delete(sourcefile);
        }
    }
}
