using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Lenght;
            double D = myDelegate(3);
            Console.WriteLine("Длина окружности при R=3");
            Console.WriteLine(D);
            Console.WriteLine();

            myDelegate = Area;
            double S = myDelegate(2);
            Console.WriteLine("Площадь круга при R=2");
            Console.WriteLine(S);
            Console.WriteLine();

            myDelegate = Volume;
            double V = myDelegate(1);
            Console.WriteLine("Объём шара при R=1");
            Console.WriteLine(V);

            Console.ReadKey();
        }
        static double Lenght(double r)
        {
            double D = (double)Math.PI * 2 * r;         
            return D;
        }
        static double Area(double r)
        {
            double S = (double)Math.PI * r * r;
            return S;
        }
        static double Volume(double r)
        {
            double V = (double)Math.PI * 4 / 3 * r * r * r;
            return V;
        }
    }
}
