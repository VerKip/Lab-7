using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Task_2
{
    internal class Program
    {
        static void GetAreaVolumeCube (double x, out double s, out double v)
        {
            s = 6 * x * x;
            v = x * x * x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба");
            double x = Convert.ToDouble(Console.ReadLine());
            double s;
            double v;  
            GetAreaVolumeCube (x, out s, out v);
            Console.WriteLine("{0:F2}, {1:F2}",s,v);
            Console.ReadKey();
        }
    }
}
