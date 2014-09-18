using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000;
            int sum = 0;
            for (int i = 1; i < n; i++) 
            {
                sum = 0;

                for (int factor = 1; factor < i; factor++) 
                {
                    if (i % factor == 0) 
                    {
                        sum += factor;
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
