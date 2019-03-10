using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace task1
{
    public class Complex
    {
        public int real, img;
        public Complex() { }
        public void PrintNum()
        {
            Console.WriteLine($"{real} + {img}i");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex s = new Complex();
            s.real = 5;
            s.img = 4;
            s.PrintNum();

            FileStream fs = new FileStream("Complex.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            xs.Serialize(fs, s);

            fs.Close();
            FileStream fs1 = new FileStream("Complex.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs1 = new XmlSerializer(typeof(Complex));
            Complex s1 = xs.Deserialize(fs1) as Complex;
            s1.PrintNum();
            fs1.Close();


            Console.ReadKey();
        }
    }
}
