namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_32
{
    public class Palindrome
    {
        public static void Main()
        {
            string reverse, palindrome;
            char[] temp;

            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();

            // Remove spaces and convert to lowercase
            reverse = palindrome.Replace(" ", ""); // 띄어쓰기 없앴음
            reverse = reverse.ToLower(); // 싹 다 소문자로

            // Convert to an array
            temp = reverse.ToCharArray(); // 형 변환 

            // Reverse the array
            System.Array.Reverse(temp); //dllow 이렇게 뒤집어짐

            // Convert the array back to a string and
            // check if reverse string is the same
            if(reverse == new string(temp))
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\" is a palindrome.");
            }
            else
            {
                System.Console.WriteLine(
                    $"\"{palindrome}\" is NOT a palindrome.");
            }
        }
    }
}

// 배열 사용 가능 기능
/*
sort: 정렬하기
BinarySearch: 검색(이진탐색)
reverse: 뒤집기
clear: 지우기
*/
