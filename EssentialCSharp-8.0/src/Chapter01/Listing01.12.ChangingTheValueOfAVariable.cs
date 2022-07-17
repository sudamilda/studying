namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_12
{
    public class MiracleMax
    {
        public static void Main()
        {
            string valerie;
            string miracleMax = "Have fun storming the castle!"; // 변수 할당(초기화) -, 할당 연산자 =

            valerie = "Think it will work?";//변수 할당

            System.Console.WriteLine(miracleMax);
            System.Console.WriteLine(valerie);

            miracleMax = "It would take a miracle."; // 새롭게 변수 할당
            System.Console.WriteLine(miracleMax); // 새로운 miraclemax 나옴
        }
    }
}
