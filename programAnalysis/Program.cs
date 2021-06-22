using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                if (2 * i > 9)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}