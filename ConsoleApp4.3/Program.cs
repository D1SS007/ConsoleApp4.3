using System;

namespace ConsoleApp4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isConverted = true;

            while(isConverted)
            {
                Console.WriteLine("Ведите число");

                string userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int value))
                {
                    Console.WriteLine("Число переобразовано в : " + value);
                    isConverted = false;
                }
                else
                {
                    Console.WriteLine($"Невозможно преобразовать {userInput} в число с типом int!");
                }
            }            
        }
    }
}
