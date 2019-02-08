using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] doubleArray = new string[n, n];

            string pattern = "[*]";

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    doubleArray[i, j] = pattern;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(doubleArray[i, j]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
          }
        }
    }
