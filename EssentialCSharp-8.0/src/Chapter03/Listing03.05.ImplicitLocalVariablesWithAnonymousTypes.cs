namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_05
{
    public class Program
    {
        public static void Main()
        {
            var patent1 =
                new { Title = "Bifocals",
                    YearOfPublication = "1784" };
            var patent2 =
                new { Title = "Phonograph",
                    YearOfPublication = "1877" };

            System.Console.WriteLine(
                $"{patent1.Title} ({patent1.YearOfPublication})");
            System.Console.WriteLine(
                $"{patent2.Title} ({patent2.YearOfPublication})");
        }
    }
}

// var 익명 변수 형식 C#이 스스로 변수형을 맞춰서 진행, C랑 C++이랑 다름

// 값 형식
// 참조 형식 값엔 주소가 존재, 주소값은 string이 HW를 가르키고 있음
// int[4] = (0 1 2 3) 0~1~~2~~3 int 1번 -> 0
// string이 주소값이 하나 밖에 없음