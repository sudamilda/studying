namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_11
{ 
    public class Program
    { 
        public static void Main()
        {
            string[] languages = new string[] {
                "C#", "COBOL", "Java",
                "C++", "TypeScript", "Visual Basic",
                "Python", "Lisp", "JavaScript" };
        }
    }
}
// stirng[] languages; // 1차원
// int[,] cells; // 2차원 표처럼 (0,0)~(3,2) int[2] 호출하면 (2,0) (2,1) (2,2) 나옴 {1,0,2} [^3]끝에서 세번째꺼 나옴
// int[] Array = new int[3] 0번 1번 2번
// Array[1] -> 1번째 불러옴

// string[] languages = {"C#", ...} []안에 아무것도 없으면 그냥 더 늘려도 무방

