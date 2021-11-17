using System;
using System.Linq;
using System.Text;

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

        static string ReorderString(string message)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 1; i < message.Length; i++)
            {
                if (i % 4 == 0)
                    sb.Append(' ');
                sb.Append(message[i]);
            }

            string with_spaces = sb.ToString();
            string[] array = with_spaces.Split(' ');
            Array.Reverse(array);
            message = string.Join("", array);
            return message;
        }

        static void FizzBuzz(int maxNumber)
        {
            for (int i = 1; i < maxNumber+1; i++)
            {
                string text = IsMultiple(i, 3, "Fizz") + IsMultiple(i,13,"Fezz") + IsMultiple(i, 5, "Buzz") + IsMultiple(i,7,"Bang")+IsMultiple(i,11,"Bong");
                if (text == string.Empty)
                {
                    Console.WriteLine(i);
                }
                else if (text.Contains("Bong"))
                {
                    if (text.Contains("Fezz"))
                    {
                        Console.WriteLine("FezzBong");
                    }
                    else
                    {
                        Console.WriteLine("Bong");
                    }
                }
                else
                {
                    Console.WriteLine(text);
                }
            }
        }
        
        static void Main()
        {
            FizzBuzz(143);
            //Console.WriteLine(ReorderString("aaaabbbbccccdddd"));
        }
    }
}