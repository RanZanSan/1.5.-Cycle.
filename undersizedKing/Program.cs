using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace undersizedKing
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 1; i <= 20; i++)
            {
                int growth = int.Parse(Console.ReadLine());

                if(growth > 160)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}