using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int user, total = 0;
            for (int i = 0; i <= 100; i++)
            {
                Console.Write("Enter a number from 1 - 998: ");
                input = Console.ReadLine();
                user = Convert.ToInt32(input);
                
                if (user == 999 || user > 999)
                    break;
                    
                if (user < 999)
                        total += user;
                Console.WriteLine(total);

                if (total >= 999)
                    break;
            }
        }
    }
}
