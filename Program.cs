using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = "";
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result = "FizzBuzz";
                    Console.WriteLine(result);
                }
                else if (i % 3 == 0)
                {
                    result = "Fizz";
                    Console.WriteLine(result);
                }
                else if (i % 5 == 0)
                {
                    result = "Buzz";
                    Console.WriteLine(result);
                }
                else
                {
                    result = i.ToString();
                    Console.WriteLine(result);
                }
            }
        }
    }
}