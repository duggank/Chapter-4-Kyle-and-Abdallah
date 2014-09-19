using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetVowel.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char user;

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Enter a vowel: ");
                input = Console.ReadLine();
                user = Convert.ToChar(input);


                if (user == '!')
                    break;

                switch (user)
                {
                    case 'a': Console.WriteLine("OK");
                        break;
                    case 'e': Console.WriteLine("OK");
                        break;
                    case 'i': Console.WriteLine("OK");
                        break;
                    case 'o': Console.WriteLine("OK");
                        break;
                    case 'u': Console.WriteLine("OK");
                        break;
                    case 'A': Console.WriteLine("OK");
                        break;
                    case 'E': Console.WriteLine("OK");
                        break;
                    case 'I': Console.WriteLine("OK");
                        break;
                    case 'O': Console.WriteLine("OK");
                        break;
                    case 'U': Console.WriteLine("OK");
                        break;
                    default: Console.WriteLine("ERROR!");
                        break;
                }
            }

        }
    }
}
