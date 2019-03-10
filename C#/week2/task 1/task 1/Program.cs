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
            StreamReader sr = new StreamReader(@"C:\Users\Asus\Desktop\c#\c##\week2\1.txt"); //read inform from file

            string s = sr.ReadLine(); //read all string

            bool isTrue; // create type of premise which is initially equal to true

            while (s != null)
            {
                isTrue = true; //Fuction is working 

                for (int i = 0; i <= s.Length / 2; i++) //read this loop
                {
                    if (s[i] != s[s.Length - i - 1]) // if a letter from different sides aren't equal to each others
                    {
                        isTrue = false; // it will be not polindrom
                        break; // stop operation in this part
                    }
                }
                if (isTrue) // if it is polindrom

                {
                    Console.WriteLine("Yes"); //write Yes
                }
                else
                {
                    Console.WriteLine("No"); //if no write No
                }
                s = sr.ReadLine(); //read all string
            }
                sr.Close();
            Console.WriteLine(s); //deduce word
            Console.ReadKey(); //for not okladka
        }
    }
}
