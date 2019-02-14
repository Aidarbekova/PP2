using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            string[] firstArray = s.Split(' ');

            string[] secondArray = new string[2 * n];

            int cnt = -1;

            for (int i = 0; i < firstArray.Length; i++)
            {
                cnt++;

                secondArray[cnt] = firstArray[i];

                cnt++;

                secondArray[cnt] = firstArray[i];
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write(secondArray[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
       