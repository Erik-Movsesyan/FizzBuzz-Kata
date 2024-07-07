using System;

namespace FizzBuzz_Kata
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzz.Calculate(i));
            }
        }
    }
}
