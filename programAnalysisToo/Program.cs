using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysisToo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 1)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}