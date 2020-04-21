namespace BetterUnitTesting.FizzBuzz
{
    public static class FizzBuzzer
    {
        public static string GetFizzOrBuzz(int value)
        {
            bool IsFizz(int input) => input % 3 == 0;
            bool IsBuzz(int input) => input % 5 == 0;
            bool IsFizzBuzz(int input) => IsFizz(input) && IsBuzz(input);

            return value switch
            {
                _ when IsFizzBuzz(value) => "FizzBuzz",
                _ when IsFizz(value) => "Fizz",
                _ when IsBuzz(value) => "Buzz",
                _ => value.ToString()
            };
        }
    }
}