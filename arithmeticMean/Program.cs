using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmeticMean
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double count = 0;
            double sum = 0;

            while (a <= b)
            {
                if(a % 3 == 0)
                {
                    sum = sum + a;
                    count++;
                }
                a++;
            }
            Console.WriteLine(sum / count);
            Console.ReadKey();
        }
    }
}