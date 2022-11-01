using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIne_Comparison
{
    class UC1
    {

        public static double Distance(double x1, double x2, double y1, double y2)
        {
            double temp1 = Math.Pow((x2 - x1), 2);
            double temp2 = Math.Pow((y2 - y1), 2);
            double result = Math.Sqrt(temp1 + temp2);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter x1 coordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 1 coordinates: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter x2 coordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter 2 coordinates: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double finalResult = Distance(x1, y1, x2, 2);
            Console.WriteLine("Distance between two points: " + finalResult);
        }
    }
}

