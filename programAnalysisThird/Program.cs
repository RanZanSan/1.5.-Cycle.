using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysisThird
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                if (i % 3 == 1)
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}