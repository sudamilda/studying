namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_01
{
    public class Program
    {
        public static void Main()
        {
            
            int kk = 42; 

            System.Console.WriteLine(kk); //이렇게 써야함

            //리터럴 값(거의 안씀)
            System.Console.WriteLine(1.618034);

            char testChar = 'd';
            int testInt = 3;
            long testLong = 3;
            float testFloat = 3.3f; // f를 붙여야 소수점 오류 안남
            string testString = "Hello World";
            double testDouble = 3.3d;

            System.Console.WriteLine(testChar);
            System.Console.WriteLine(testInt);
            System.Console.WriteLine(testLong);
            System.Console.WriteLine(testFloat);
            System.Console.WriteLine(testString);
            System.Console.WriteLine(testDouble);
        }
    }
}
