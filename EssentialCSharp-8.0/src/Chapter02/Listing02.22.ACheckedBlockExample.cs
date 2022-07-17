namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22
{
    public class Program
    {
        public static void Main()
        {
            checked
            {
                // int.MaxValue equals 2147483647
                int n = int.MaxValue;
                n = n + 1;
                System.Console.WriteLine(n);
            }
        }
    }
}

// checked 블록: 값이 오버플로 할당이 발생한 경우 예외처리
// unchecked 그냥 출력