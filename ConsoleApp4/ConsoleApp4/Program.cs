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

            string[,] doubleArray = new string[n, n]; //это двумерный массив так делается

            string pattern = "[*]"; //это шаблон

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) //для того чтобы была нужная форма
                {
                    doubleArray[i, j] = pattern; //этот двойной массив итый джитый
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(doubleArray[i, j]); //вывести именно на те места которые вы предоставили для паттернов
                }
                Console.WriteLine(); //написать

            }
            Console.ReadKey();
          }
        }
    }
