using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\c##\week2\1.txt.txt");

            string s = sr.ReadLine();

            bool isTrue;

            while(s != null)
            {
                isTrue = true;

                for ( int i = 0; i <=s.Length / 2; i++)
                {
                    if( s[i] != s[s.Length - i - 1])
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)

                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
                sr.Close();
            }
            Console.ReadKey();
        }
    }
}
