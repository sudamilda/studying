namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_17
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

            // 중괄호를 사용한 변수 가져와 사용하기 위치 구분자
            System.Console.WriteLine(
                "Your full name is {0} {1}.", firstName, lastName);
        }
    }
}
