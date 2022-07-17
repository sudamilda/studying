namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19
{
    public class Program
    {
        public static void Main()
        {
            int? age;

            //...

            // Clear the value of age
            age = null;

            //...

            System.Console.WriteLine($"The age is: {age}");  
        }
    }
}

// null 소개

/*
 0이 아닌 없다라는 개념
아무것도 없음을 뜻함

변수 앞에 ?를 붙임으로서 해당 변수가 null을 가질 수 있도록 지정 (null 허용 한정자)
 */