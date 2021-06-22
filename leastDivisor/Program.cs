using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leastDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 2;

            while(num % count != 0)
            {
                count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}