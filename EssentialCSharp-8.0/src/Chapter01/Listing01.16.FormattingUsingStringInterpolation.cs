namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_16
{
    public class Program
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();

            //문자열 출력하기 (&에 주목)
            System.Console.WriteLine(
                $"Your full name is { firstName } { lastName }.");

            //단순 변수 입력도 가능
            // System.Console.Writeline(firstName);

        }
    }
}
