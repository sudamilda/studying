#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0219 // Variable is assigned but its value is never used
#pragma warning disable IDE0059 // Unnecessary assignment of a value

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_19
{
    public class Program
    {
        public static void Main()
        {
            const int secondsPerDay = 60 * 60 * 24;
            const int secondsPerWeek = secondsPerDay * 7;

            // ...
        }
    }
}

// 상수식

// 한 번 초기화 되면 수정할 수 없음

// 다른 사람이 수정하지 못하게 상수화