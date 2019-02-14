using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\c#\lab 2\1.txt\1.txt");
            string s = sr.ReadLine();
            bool isTrue;
            while(s != null)
            {
                isTrue = true;
                for (int i = 0; i <= s.Length / 2; i++)
                {
                    if (s[i] != s[s.Length - i - 1])
                    {
                        isTrue = false;
                        break;
                    }
                }
                if (isTrue)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                sr.Close();
            }
            Console.ReadKey();
        }
    }
}
