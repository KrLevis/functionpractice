using System;

// Programm funktsioonide õppimiseks.

namespace functionpractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input1 = StringFetch();
            Console.WriteLine(input1);
            int length = StringLength(input1);
            Console.WriteLine($"Stringi pikkus on {length} tähte.");
            bool checker = StringChecker(input1, length);
            Console.WriteLine("Kas string ja stringi pikkus klapivad?");
            if (checker)
            {
                Console.WriteLine("Jah.");
            }
            else
            {
                Console.WriteLine("Ei.");
            }

            string input2 = StringFetch();

            switch (StringComparison(input1, input2))
            {
                case -1:
                    Console.WriteLine("Esimene string on lühem.");
                    break;
                case 0:
                    Console.WriteLine("Mõlemad stringid on sama pikad.");
                    break;
                case 1:
                    Console.WriteLine("Esimene string on pikem.");
                    break;
                default:
                    throw new ArgumentException("invalid function return value");
            }
        }

        private static string StringFetch()
        {
            string input;
            Console.WriteLine("Sisestage string.");
            input = Console.ReadLine();
            return input;
        }

        private static int StringLength(string input)
        {
            int length = input.Length;
            return length;
        }

        private static bool StringChecker(string input, int length)
        {
            if (input.Length == length)
            {
                return true;
            }
            return false;
        }

        private static int StringComparison(string input1, string input2)
        {
            int input1length = StringLength(input1);
            int input2length = StringLength(input2);

            if (input1length < input2length)
            {
                return -1;
            }
            else if (input1length > input2length)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}