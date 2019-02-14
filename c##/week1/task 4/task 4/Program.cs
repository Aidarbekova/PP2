using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            string[,] doubleArray = new string[n, n];  //this sign means a doubleArray

                string pattern = "[*]"; // pattern means template

            for ( int i = 0; i < n; i++)
            {
                for ( int j = 0; j <= i; j++)
                {
                    doubleArray[i, j] = pattern; // we should make on this places this sign
                }
            }
            for ( int i = 0; i < n ; i++)
            {
                for ( int j = 0; j < n ; j++)
                {
                    Console.Write(doubleArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
