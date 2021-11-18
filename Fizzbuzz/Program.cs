using System;
using System.Collections.Generic;


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

        static List<string> AppendWordIfMultiple(int number,int divider, string word,List<string> text)
        {
            if (IsMultiple(number, divider))
            {
                text.Add(word);
            }

            return text;
        }
        
        static void FizzBuzz(int maxNumber)
        {
            for (int i = 1; i < maxNumber+1; i++)
            {
                List<string> text = new List<string>();
                

                text = AppendWordIfMultiple(i, 3 , "Fizz", text);
                text = AppendWordIfMultiple(i, 13, "Fezz", text);
                text = AppendWordIfMultiple(i, 5 , "Buzz", text);
                text = AppendWordIfMultiple(i, 7 , "Bang", text);
                
                
                if (IsMultiple(i, 11))
                {
                    text = new List<string>() {"Bong"};
                    if (IsMultiple(i, 13))
                    {
                        text.Insert(0,"Fezz");
                    }
                }

                if (IsMultiple(i, 17))
                {
                    text.Reverse();
                }

                if (text.Count == 0)
                {
                     Console.WriteLine(i);
                }
                else
                {
                     Console.WriteLine(string.Join("",text));
                }
            }
        }

        static int WelcomeQuestion()
        {
            Console.WriteLine("Welcome to FizzBuzz");
            Console.WriteLine("===================");
            Console.WriteLine("Enter max. number:");
            int maximum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===================");
            return maximum;
        }

        static void Main()
        {
            int maxNumber = WelcomeQuestion();
            FizzBuzz(maxNumber);
        }
    }
}