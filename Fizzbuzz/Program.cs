using System;

namespace Fizzbuzz
{
    class Program
    {

        static string IsMultiple(int number, int divider, string message)
        {
            string nothing = string.Empty; 
            
            if (number % divider == 0)
            {
                return message;
            }
            else
            {
                return nothing;
            }
        }

        static void FizzBuzz(int maxNumber)
        {
            for (int i = 0; i < maxNumber+1; i++)
            {
                string text = IsMultiple(i, 3, "Fizz") + IsMultiple(i, 5, "Buzz");
                if (text == string.Empty)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(text);
                }
                // Console.WriteLine(i+IsMultiple(i,3,"Fizz")+IsMultiple(i,5,"Buzz"));
            }
        }
        
        static void Main(string[] args)
        {
            FizzBuzz(100);
        }
    }
}