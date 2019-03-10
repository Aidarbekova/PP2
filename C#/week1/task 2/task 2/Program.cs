using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
        private int id = 0; //create int id 
        public string name = ""; //create string name
        public int yearOfStudy = 0; //create int YearOfStudy type int

        //public Student() { }

        public Student(string n, int id) //create constructer student

        {
            name = n; //annex to name=n
            this.id = id;//annex this id = id
        }
        public int getId() // get id from private for work with it write functiom getId
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
            Student s = new Student("a", 1); //create variable consists from name and YOS 

            Console.WriteLine(s.getId());

            s.getId(); //induce function

            s.incrementYearOfStudy();//induce function

            Console.WriteLine(s.yearOfStudy); //deduce YOS on a screen


            Console.ReadKey();
        }
    }
}

