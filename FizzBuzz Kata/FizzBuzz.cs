namespace FizzBuzz_Kata
{
    public class FizzBuzz
    {
        public static string Calculate (int number)
        {
            return number switch
            {
                _ when number % 5 == 0 && number % 3 == 0 => "FizzBuzz",
                _ when number % 3 == 0 => "Fizz",
                _ when number % 5 == 0 => "Buzz",
                _ => number.ToString()
            };
        }
    }
}
