using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequenceOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            while(num != 0)
            {
                count++;
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}