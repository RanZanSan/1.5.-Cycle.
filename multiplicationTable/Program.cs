using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for(int count = 1; count <= 9; count++)
            {
                Console.WriteLine(count + " * " + num + " " + "= " + count * num);
            }
            Console.ReadKey();
        }
    }
}