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
            int n = int.Parse(Console.ReadLine()); //конвертирует стринг в инт и обуславливаем память для нашего инта
            string s = Console.ReadLine(); //считывать полностью строку
            string[] input = s.Split(' '); //разделяем нашу строку с помощью пробелов

            for (int i = 0; i < input.Length; i++)
            {
                int current = int.Parse(input[i]); //наши нынешние инты делим так же спэйсами
                bool isPrime = true; //создаем тип данных бул и допустим что все числа изначально прайм
                    
                for (int j = 2; j <= Math.Sqrt(current); j++) //для ускорения процесса мы создаем ряд чисел начинающийся с подкоренного 2 и подкоренного каррента 
                {
                    if (current % j == 0) //если карент делится на одно из рядовых чисел без остатка то он н прайм
                    {

                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && current != 1) //а если не делится и число не один, то мы записываем его и идем дальше
                {
                    Console.Write(current + " "); //с пробелами
                }
            }
            Console.ReadKey();
        }
    }
}

 
