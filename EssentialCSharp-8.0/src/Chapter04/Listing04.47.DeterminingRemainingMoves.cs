namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_47
{
    public class TicTacToe // Declares the TicTacToe class
    {
        public static void Main() // Declares the entry point of the program
        {
            // Hardcode initial board as follows
            // ---+---+---
            //  1 | 2 | 3
            // ---+---+---
            //  4 | 5 | 6
            // ---+---+---
            //  7 | 8 | 9
            // ---+---+---
            char[] cells = {
                '1', '2', '3', '4', '5', '6', '7', '8', '9'
            };

            System.Console.Write(
                "The available moves are as follows: ");

            // Write out the initial available moves
            foreach(char cell in cells)
            {
                if(cell != 'O' && cell != 'X')
                {
                    System.Console.Write($"{ cell } ");
                }
            }

            int[] intArray = { 1,2,3,4,5,6,7,8};
            foreach(int number in intArray)
            {
                System.Console.WriteLine(number + 3);
            }
        }
    }
}

// foreach
// 변수명과 사용 할 배열을 
