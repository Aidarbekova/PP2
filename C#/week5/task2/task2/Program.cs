using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace task2
{
    public class Mark
    {
    

        public int points;

    public Mark()

    {



    }

    public Mark(int p)

    {

        points = p;

    }

    public void GetAssessment()

    {

        if (points < 50)

        {

            Console.WriteLine("F");

        }

        else if (points < 54)

        {

            Console.WriteLine("D");

        }

        else if (points < 60)

        {

            Console.WriteLine("D+");

        }

        else if (points < 65)

        {

            Console.WriteLine("C-");

        }

        else if (points < 70)

        {

            Console.WriteLine("C");

        }

        else if (points < 75)

        {

            Console.WriteLine("C+");

        }

        else if (points < 80)

        {

            Console.WriteLine("B-");

        }

        else if (points < 85)

        {

            Console.WriteLine("B");

        }

        else if (points < 90)

        {

            Console.WriteLine("B+");

        }

        else if (points < 95)

        {

            Console.WriteLine("A-");

        }

        else if (points <= 100)

        {

            Console.WriteLine("A");

        }



    }

}


class Program
    {
        static void Main(string[] args)
        {
            List<Mark> s = new List<Mark>();

            s.Add(new Mark() { points = 51 });

            s.Add(new Mark() { points = 91 });

            s.Add(new Mark() { points = 71 });

            foreach (var v in s)

            {

                v.GetAssessment();

            }

            FileStream fs = new FileStream("List.xml", FileMode.Create, FileAccess.Write);

            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));

            xs.Serialize(fs, s);



            fs.Close();

            FileStream fs1 = new FileStream("List.xml", FileMode.Open, FileAccess.Read);

            List<Mark> s1 = xs.Deserialize(fs1) as List<Mark>;

            foreach (var v in s1)

            {

                v.GetAssessment();

            }

            fs1.Close();
            Console.ReadKey();
        }
    }
}
