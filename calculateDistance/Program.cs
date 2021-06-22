using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = int.Parse(Console.ReadLine());
            double y = int.Parse(Console.ReadLine());
            int day = 1;

            while(x < y)
            {
                double percent = (x * 10) / 100;
                x += percent;
                day++;
            }
            Console.WriteLine(day);
            Console.ReadKey();
        }
    }
}