// Justification: Demonstrating the equivalent operators
#pragma warning disable IDE0054 // Use compound assignment
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int spaceCount = 0;

            spaceCount = spaceCount + 1; // spacecount = 1
            spaceCount += 1; // 위랑 같은 문장
            spaceCount++; // 위와 같은 문장

            int value = 0;
            System.Console.Write(++value); // 1
            System.Console.Write(++value); // 2
            System.Console.Write(++value); // 3

            System.Console.Write(value++); // 3
            System.Console.Write(value++); // 4
            System.Console.Write(value++); // 5
            // value = 6
        }
    }
}

// 증가 연산자

/*
 
++Value 와 value++
전위 증가 연산자와 후위 증가 연산자

더해진 채 시작 과 문장이 끝난 다음 더함


*/