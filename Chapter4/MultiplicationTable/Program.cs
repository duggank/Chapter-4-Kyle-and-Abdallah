using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            Console.WriteLine("{0,4}|{1,4}|{2,4}|{3,4}|{4,4}|{5,4}|{6,4}|{7,4}|{8,4}|{9,4}|{10,4}", "", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("----+----+----+----+----+----+----+----+----+----+----+");
            

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0,4}|{1,4}|{2,4}|{3,4}|{4,4}|{5,4}|{6,4}|{7,4}|{8,4}|{9,4}|{10,4}|", i, i*1, i*2, i*3, i*4, i*5, i*6, i*7, i*8, i*9, i*10);
                Console.WriteLine("----+----+----+----+----+----+----+----+----+----+----+");
                //Console.WriteLine(total);
            }
        }
    }
}
