using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    internal class Program
    {
        static double GetTriangleArea (double a, double b, double c)
        {
            return Math.Sqrt ((a+b+c)/2*((a + b + c) / 2-a)*((a + b + c) / 2-b)*((a + b + c) / 2-c));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double S1 = GetTriangleArea(x1, y1, z1);
            Console.WriteLine("Введите длины сторон второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S2 = GetTriangleArea(x2, y2, z2);
            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (S2 > S1)
                Console.WriteLine("Площадь второго треугольника больше");
            else
                Console.WriteLine("Площади треугольников равны");
            Console.ReadKey();

        }
    }
}
