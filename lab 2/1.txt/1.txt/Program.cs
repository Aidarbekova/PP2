
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1.txt
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\1..txt");
            string s = sr.ReadLine();
            bool isTrue;
            while (s != null)
            {
                isTrue = true;
                for ( int i = 0; i <=s.Length / 2;i++)
                {
                    if(s[i] !=s[s.Length - i - 1])
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
                s = sr.ReadLine();
            }
            sr.Close();

            Console.ReadKey();
        }
    }
}
