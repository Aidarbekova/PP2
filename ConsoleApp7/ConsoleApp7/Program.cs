using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student
    {
        private int id = 0;
        public string name = "";
        public int yearOfStudy = 0;

        public Student() { }

        public Student(string n, int id)

        {
            name = n; //мы присвоили 
            this.id = id;
        }
        public int getId() //мы вызвали функцию гет айди для работы с ним
        {
            return this.id; //функция возвращения этого айди
        }
        public void incrementYearOfStudy()
        {
            this.yearOfStudy++;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student("a", 1);

            Console.WriteLine(s.getId()); //выписывает текстовые представления

            s.getId(); //вытащить айди

            s.incrementYearOfStudy(); //функция позволяет нам менять свой год обучения
            Console.WriteLine(s.yearOfStudy); //выпис текст предсавление 

            Console.ReadKey();
        }
    }
}





