using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programReadsNumbersFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while(num <= 100)
            {
                if (num < 10)
                {
                    num = int.Parse(Console.ReadLine());
                    continue;
                }
                Console.WriteLine(num);
                num = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}