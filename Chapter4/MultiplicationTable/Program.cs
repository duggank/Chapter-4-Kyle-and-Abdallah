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
            for (int i = 1; i <= 10; i++)
            {
                total *= i;
                Console.Write(i + "    ");
                Console.WriteLine(total);
            }
        }
    }
}
