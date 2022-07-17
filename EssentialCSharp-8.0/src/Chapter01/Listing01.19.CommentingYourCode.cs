namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_19
{
    public class Program
    {
        public static void Main()
        {
            string firstName; //Variable for storing the first name
            string lastName; //Variable for storing the last name

            System.Console.WriteLine("Hey you!");

            System.Console.Write /* No new line */ (
                "Enter your first name: ");
            firstName = System.Console.ReadLine();

            System.Console.Write /* No new line */ (
                "Enter your last name: ");
            lastName = System.Console.ReadLine();

            /* Display a greeting to the console 
              using composite fomatting. */

            System.Console.WriteLine("Your full name is {1}, {0}.", 
                firstName, lastName);
            // This is the end
            // of the program listing

            // 주석에 대한 내용 설명
            /*
             
             사이에는 컴파일 안됨

             */ 

            /* 
             프로세서 처리기: 처리기(CPU 같은 명령어를 해석하는 컴퓨터의 한 부분)
            어셈블리: 컴퓨터가 읽는 프로그래밍을 보기 좋게 해주는 언어
            기계어: 0과 1로 이루어진 언어 -> 사람이 못알아봄

            공용 중간 언어(CIL): 사이에서 번역과 조율을 해주는 중간 언어

            C# 컴파일러는 씨샵 소스코드를 중간 언어로 변환. 이를 CIL 기계어로 변경함

            컴파일: 코드 전체를 다른 언어로 바꿔주는 과정
             
             */
        }
    }
}