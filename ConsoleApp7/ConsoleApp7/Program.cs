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
            name = n;
            this.id = id;
        }
        public int getId()
        {
            return this.id;
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
            Console.WriteLine(s.getId());
            s.getId();
            s.incrementYearOfStudy();
            Console.WriteLine(s.yearOfStudy);

            Console.ReadKey();
        }
    }
}





