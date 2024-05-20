using System;

namespace Karakter_Değiştirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            if (input.Length > 1)
            {
                char firstChar = input[0];
                char lastChar = input[input.Length - 1];
                string swappedString = lastChar + input.Substring(1, input.Length - 2) + firstChar;
                Console.WriteLine($"The swapped string is: {swappedString}");
            }
            else
            {
                Console.WriteLine("The string must have at least two characters.");
            }
            Console.ReadKey();
        }
    }
}
