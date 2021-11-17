using System;

namespace Fizzbuzz
{
    class Program
    {

        static string IsMultiple(int number, int divider, string message)
        {
            if (number % divider == 0)
            {
                return message;
            }
            else
            {
                return string.Empty;
            }
        }

        static void FizzBuzz(int maxNumber)
        {
            for (int i = 1; i < maxNumber+1; i++)
            {
                string text = IsMultiple(i, 3, "Fizz") + IsMultiple(i, 5, "Buzz") + IsMultiple(i,7,"Bang");
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
        
        static void Main()
        {
            FizzBuzz(100);
        }
    }
}