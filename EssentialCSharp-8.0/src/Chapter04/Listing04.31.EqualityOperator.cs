namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_31
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            string input = args[0];
            string currentPlayer = args[1];

            if (input.Length == 0 || input == "quit") // ||는 or 
            {
                System.Console.WriteLine($"Player {currentPlayer} quit!!");
            }
        }
    }
}

/*
 not - 비트 반전 0->1 1->0
and & 0110 0100 일 때 and 0100  
or 0110
Layer: 렌더링 stencil 한 부분만 안보이게 하는 기능 object, outline, stencil 상태 -> 이항 연산자 검색
Tag
 
 
 */