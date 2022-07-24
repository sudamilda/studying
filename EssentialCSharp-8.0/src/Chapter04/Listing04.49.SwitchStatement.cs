namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_49
{
    public class Program
    {
        public static void Main()
        {

        }


        public static bool ValidateAndMove(
            int[] playerPositions, int currentPlayer, string input)
        {
            bool valid = false;

            // Check the current player's input
            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    // Save/move as the player directed
                    // ...
                    valid = true;
                    break;
                case "":
                case "quit":
                    valid = true; // switch문 빠져 나옴
                    break;
                default: // 모든 경우
                    // If none of the other case statements
                    // is encountered then the text is invalid
                    System.Console.WriteLine(
                    "\nERROR:  Enter a value from 1-9. "
                    + "Push ENTER to quit");
                    break;
            }

            return valid;
        }
    }
}

            /*

            string a = "";
            a = System.Console.ReadLine();

            switch (a)
            {
                case "1":
                    System.Console.WriteLine("Hello");
                    break;

                case "2":
                    System.Console.WriteLine("My");
                    break;

                case "3":
                    System.Console.WriteLine("Name");
                    break;

                case "4":
                    System.Console.WriteLine("is");
                    break;

                case "5":
                    System.Console.WriteLine("Suja");
                    break;

                default:
                    System.Console.WriteLine("End");
                    break;
            }


            bool istrue = true;

            while (istrue)
            {
                if (a == "2")
                {
                    return true;
                }

                else if (a == "3")
                {
                    continue;
                }

                else if (a == "4")
                {
                    break;
                }

                istrue = false;
            }


        }

    }
}
//return main끝 continue 더이상 읽지 않고 맨 처음으로 돌아감 break while문 깨고 끝
// 

            */