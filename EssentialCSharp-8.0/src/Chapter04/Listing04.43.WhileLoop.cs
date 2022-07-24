namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_43
{
    public class FibonacciCalculator
    {
        public static void Main()
        {
            decimal current;
            decimal previous;
            decimal temp;
            decimal input;

            System.Console.Write("Enter a positive integer:");

            // decimal.Parse convert the ReadLine to a decimal
            input = decimal.Parse(System.Console.ReadLine()); // 9 넣으면

            // Initialize current and previous to 1, the first
            // two numbers in the Fibonacci series
            current = previous = 1;

            // While the current Fibonacci number in the series is
            // less than the value input by the user
            while (current <= input) // true라 진행
            {
                temp = current;
                current = previous + current;
                previous = temp; // Executes even if previous
                // statement caused current to exceed input
            }

            System.Console.WriteLine(
                      $"The Fibonacci number following this is { current }");
        }
    }
}
/*
 while 문
계속 반복하니까 아래 값을 바꿔줘야함

do while문
일단 하고 while문 접해짐
 */