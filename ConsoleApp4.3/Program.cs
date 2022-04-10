using System;

namespace ConsoleApp4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            GetNumber();           
        }

        static int GetNumber()
        {
            bool isNotConverted = true;

            int value=0;

            while (isNotConverted)
            {
                Console.WriteLine("Ведите число");

                string userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out value))
                {
                    Console.WriteLine("Число преобразовано в : " + value);
                    
                    isNotConverted = false;                    
                }
                else
                {
                    Console.WriteLine($"Невозможно преобразовать {userInput} в число с типом int!");
                }
            }
            return value;
        }
    }
}
