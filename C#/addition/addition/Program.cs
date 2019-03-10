using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int cnt = 0;
                for(int i = 0; i < s.Length; i++)
            {
                if((s[i]=='a') || (s[i] == 'e') || (s[i] =='i') || (s[i] == 'o') || (s[i] == 'u') || (s[i]== 'y'))
                {
                    cnt++;
                }
            }
            Console.WriteLine(cnt);

            Console.ReadKey();
        }
    }
}
