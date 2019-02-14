using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
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
        public int getId() // get id from private for work with it 
        {
            return this.id;
        }
        public void incrementYearOfStudy() // year of study should increase 
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

