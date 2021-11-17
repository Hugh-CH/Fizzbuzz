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
        
        
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(IsMultiple(i,3,"test"));
            }
        }
    }
}