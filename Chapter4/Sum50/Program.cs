using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sum50
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            for (int i = 1; i <= 50; i++) 
            {
                total += i;
                Console.WriteLine(total);
            }
        }
    }
}
