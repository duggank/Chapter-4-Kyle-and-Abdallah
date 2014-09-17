using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableOfSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int square;
            for (int i = 1; i <= 20; i++) 
            {
                Console.Write(i + "       squared:     ");
                square = i * i;
                Console.WriteLine(square);
            }
        }
    }
}
