using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\c##\week2\input.txt");

            string s = sr.ReadLine();

            bool isTrue;

            string[] input = s.Split(' ');

            StreamWriter sr = new StreamReader(@"C:\Users\Asus\Desktop\c##\week2\input.txt");

            string s = sr.ReadLine();

            bool isTrue;

            string[] input = s.Split(' ');

            StreamWriter sw = new StreamWriter(@"C:\Users\Asus\Desktop\c##\week2\output.txt");

            for ( int i = 0; i < input.Length; i++)
            {
                int current = int.Parse(input[i]);
                isTrue = true;
                for (int j = 2; j <= Math.Sqrt(current); j++)
                {
                    if(current % j == 0)
                    {
                        isTrue = false;
                        break;
                    }
                }
                if ( isTrue && current != 1)
                {
                    sw.Write(current + " ");
                }
            }
            sr.Close();
            Console.ReadKey();
        }
    }
}
