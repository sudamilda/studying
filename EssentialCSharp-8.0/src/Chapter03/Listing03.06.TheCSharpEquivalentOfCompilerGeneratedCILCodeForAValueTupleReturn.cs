namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{



    public class Program
    {
        public static void Main()
        {
            (string Frist, string Second, string Thrid) namedFruits = ("apple", "orange", "banana");

            var nameFruits2 = ("Apples,", "Orange", "Etc...");
                
            namedFruits.Frist = "Eat";
        }

    }
}

// 튜플 형식: 값 형식을 튜플로 원하는 형식으로 다중 구현하는 방식

/*
 namespace Chapter03
    {
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "Second" })]
        public System.ValueTuple<string, string> ParseNames(string fullName)
        {
            // ...
        }

    }
 */