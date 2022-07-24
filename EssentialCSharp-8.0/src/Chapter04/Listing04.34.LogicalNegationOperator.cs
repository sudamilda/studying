namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_34
{
    public class Program
    {
        public static void Main()
        {
            bool valid = false;
            bool result = !valid; // !는 bool형 일때만 사용, 반전기능 따라서 true가 됨
            // Displays "result = True"
            System.Console.WriteLine($"result = { result }");
        }
    }
}
