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

        static string AppendWordIfMultiple(int number,int divider, string word,string text)
        {
            if (IsMultiple(number, divider))
            {
                text += word;
            }

            return text;
        }

        static string ReorderWords(string message)
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

                text = AppendWordIfMultiple(i, 3 , "Fizz", text);
                text = AppendWordIfMultiple(i, 13, "Fezz", text);
                text = AppendWordIfMultiple(i, 5 , "Buzz", text);
                text = AppendWordIfMultiple(i, 7 , "Bang", text);
                
                
                if (IsMultiple(i, 11))
                {
                    text = IsMultiple(i, 13) ? "FezzBong" : "Bong";
                }

                if (IsMultiple(i, 17))
                {
                    text = ReorderWords(text);
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
            FizzBuzz(143);
        }
    }
}