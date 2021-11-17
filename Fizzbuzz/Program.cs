using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Fizzbuzz
{
    class Program
    {

        static bool IsMultiple(int number, int divider)
        {
            if (number % divider == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static string ReorderString(string message)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < message.Length; i++)
            {
                if (i % 4 == 0)
                    sb.Append(' ');
                sb.Append(message[i]);
            }

            string withSpaces = sb.ToString();
            string[] array = withSpaces.Split(' ');
            Array.Reverse(array);
            message = string.Join("", array);
            return message;
        }

        static void FizzBuzz(int maxNumber)
        {
            for (int i = 1; i < maxNumber+1; i++)
            {
                string text = string.Empty;

                if (IsMultiple(i, 3))
                {
                    text += "Fizz";
                }
                if (IsMultiple(i, 13))
                {
                    text += "Fezz";
                }
                if (IsMultiple(i, 5))
                {
                    text += "Buzz";
                }
                if (IsMultiple(i, 7))
                {
                    text += "Bang";
                }
                if (IsMultiple(i, 11))
                {
                    text = IsMultiple(i, 13) ? "FezzBong" : "Bong";
                }

                if (IsMultiple(i, 17))
                {
                    text = ReorderString(text);
                }
                
                if (text == string.Empty)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(text);
                }
            }
        }
        
        static void Main()
        {
            FizzBuzz(195);
        }
    }
}