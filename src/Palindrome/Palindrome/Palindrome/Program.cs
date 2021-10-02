using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write any number");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                var count = 0;
                for (var i = 0; i < input.Length / 2; i++)
                {
                    if (input[i] == input[input.Length - 1 - i])
                        count++;
                }

                if (count == input.Length / 2)
                    Console.WriteLine("This is a palindrome \n");
                else
                    Console.WriteLine("This is not a palindrome" + "\n");
            }



        }
    }
}
