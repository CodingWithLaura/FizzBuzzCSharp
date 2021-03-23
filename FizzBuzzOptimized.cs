using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                string finalResult= FizzBuzz(i); 
                Console.WriteLine(finalResult);
            }
            Console.Read();
        }
        static string FizzBuzz(int number) =>
            number switch
            {
                var n when check_fizz(n) && check_buzz(n) => "fizzbuzz",
                var n when check_buzz(n) => "buzz",
                var n when check_fizz(n) => "fizz",
                _ => number.ToString()
            };

        private static bool check_fizz(int zahl) => zahl % 3 == 0;

        private static bool check_buzz(int zahl) => zahl % 5 == 0;
    }
}