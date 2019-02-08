using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] input = s.Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                int current = int.Parse(input[i]);
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(current); j++)
                {
                    if (current % j == 0)
                    {

                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && current != 1)
                {
                    Console.Write(current + " ");
                }
            }
            Console.ReadKey();
        }
    }
}

 
