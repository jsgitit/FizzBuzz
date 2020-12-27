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
                if (i % 15 == 0)
                    result = "FizzBuzz";
                else if (i % 3 == 0)
                    result = "Fizz";
                else if (i % 5 == 0)
                    result = "Buzz";
                else
                    result = i.ToString();
                Console.WriteLine(result);
            }
        }
    }
}