namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_14
{
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine(); //해당 줄 읽기 및 할당하기

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();
        }
    }
}
