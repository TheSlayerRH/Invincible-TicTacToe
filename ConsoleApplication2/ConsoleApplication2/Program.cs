using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {

        static String LINE = "------------------------------------";
        static String lineForBoard = LINE + LINE.Substring(0, 18);
        static int TURN = 1;
        static String fullName = "";
        static bool isWinner = false;

        static void Main(string[] args)
        {
            Console.Title = "Invincible TicTacToe! ^_^";

            String firstName = "";
            String lastName = "";

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("Hello, please enter your first name and last name:");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("First name:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (firstName == "")
            {
                firstName = Console.ReadLine();
                if (firstName == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("First name cannot be empty.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Last name:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (lastName.Equals(""))
            {
                lastName = Console.ReadLine();
                if (lastName.Equals(""))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Last name cannot be empty.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }

            fullName = firstName + " " + lastName;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine(LINE);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Hello " + fullName + ", welcome to the invincible TicTacToe game.");
            Console.WriteLine("Enjoy...");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Please choose shape: X or O");

            Console.ForegroundColor = ConsoleColor.Yellow;
            String playerShape = Console.ReadLine();
            String computerShape;
            while (!playerShape.Equals("x") && !playerShape.Equals("X")
                 && !playerShape.Equals("o") && !playerShape.Equals("O"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (playerShape.Equals(""))
                {
                    Console.WriteLine("Must choose shape.");
                }
                else
                {
                    Console.WriteLine("Must choose X or O (not case sensitive).");
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                playerShape = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;

            if (playerShape.Equals("x") || playerShape.Equals("X"))
            {
                computerShape = "O";
                playerShape = "X";
            }
            else
            {
                computerShape = "X";
                playerShape = "O";
            }

            bool play = true;
            while (play)
            {
                String one = "1", two = "2", three = "3", four = "4", five = "5", six = "6", seven = "7", eight = "8", nine = "9";
                while (TURN <= 9 && !isWinner)
                {
                    Console.Clear();
                    printBoard(playerShape, computerShape, one, two, three, four, five, six, seven, eight, nine);
                    Console.WriteLine("Choose the place you want to place your shape according to\nthe board above and press enter.\n(number between 1 and 9)");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    String choice = choice = Console.ReadLine();

                    while (!choice.Equals("1") && !choice.Equals("2") && !choice.Equals("3")
                        && !choice.Equals("4") && !choice.Equals("5") && !choice.Equals("6")
                        && !choice.Equals("7") && !choice.Equals("8") && !choice.Equals("9"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Must enter a number between 1 and 9.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        choice = Console.ReadLine();
                    }
                    while ((choice.Equals("1") && !one.Equals("1")) || (choice.Equals("2") && !two.Equals("2")) || (choice.Equals("3") && !three.Equals("3"))
                        || (choice.Equals("4") && !four.Equals("4")) || (choice.Equals("5") && !five.Equals("5")) || (choice.Equals("6") && !six.Equals("6"))
                        || (choice.Equals("7") && !seven.Equals("7")) || (choice.Equals("8") && !eight.Equals("8")) || (choice.Equals("9") && !nine.Equals("9")))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("This place is already taken. Choose another place.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        choice = Console.ReadLine();
                        while (!choice.Equals("1") && !choice.Equals("2") && !choice.Equals("3")
                        && !choice.Equals("4") && !choice.Equals("5") && !choice.Equals("6")
                        && !choice.Equals("7") && !choice.Equals("8") && !choice.Equals("9"))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Must enter a number between 1 and 9.");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            choice = Console.ReadLine();
                        }
                    }

                    if (choice.Equals("1"))
                    {
                        one = playerShape;
                    }
                    else if (choice.Equals("2"))
                    {
                        two = playerShape;
                    }
                    else if (choice.Equals("3"))
                    {
                        three = playerShape;
                    }
                    else if (choice.Equals("4"))
                    {
                        four = playerShape;
                    }
                    else if (choice.Equals("5"))
                    {
                        five = playerShape;
                    }
                    else if (choice.Equals("6"))
                    {
                        six = playerShape;
                    }
                    else if (choice.Equals("7"))
                    {
                        seven = playerShape;
                    }
                    else if (choice.Equals("8"))
                    {
                        eight = playerShape;
                    }
                    else if (choice.Equals("9"))
                    {
                        nine = playerShape;
                    }
                    TURN++;

                    int computerChoice = computerMove(playerShape, computerShape, one, two, three, four, five, six, seven, eight, nine);
                    if (computerChoice == 1)
                    {
                        one = computerShape;
                    }
                    else if (computerChoice == 2)
                    {
                        two = computerShape;
                    }
                    else if (computerChoice == 3)
                    {
                        three = computerShape;
                    }
                    else if (computerChoice == 4)
                    {
                        four = computerShape;
                    }
                    else if (computerChoice == 5)
                    {
                        five = computerShape;
                    }
                    else if (computerChoice == 6)
                    {
                        six = computerShape;
                    }
                    else if (computerChoice == 7)
                    {
                        seven = computerShape;
                    }
                    else if (computerChoice == 8)
                    {
                        eight = computerShape;
                    }
                    else if (computerChoice == 9)
                    {
                        nine = computerShape;
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                if (isWinner)
                {
                    printWinningBoard(playerShape, computerShape, one, two, three, four, five, six, seven, eight, nine);
                    Console.WriteLine("Computer won!");
                }
                else
                {
                    printBoard(playerShape, computerShape, one, two, three, four, five, six, seven, eight, nine);
                    Console.WriteLine("Its a tie!");
                }
                one = "1"; two = "2"; three = "3"; four = "4"; five = "5"; six = "6"; seven = "7"; eight = "8"; nine = "9";

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Whould you like to play again?");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("[Write \"YES\" to keep playing or \"NO\" to exit, then press enter]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                String answer = Console.ReadLine();
                while (!answer.Equals("YES") && !answer.Equals("NO"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The only two commands are: \"YES\", \"NO\".\nCan't accept \"" + answer + "\". Try again.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    answer = Console.ReadLine();
                }

                if (answer.Equals("YES"))
                {
                    Console.Clear();
                    isWinner = false;
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    TURN = 1;
                }
                else
                {
                    play = false;
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        public static int computerMove(String playerShape, String computerShape, String one, String two, String three, String four, String five, String six, String seven, String eight, String nine)
        {
            TURN++;

            if (TURN == 3)
            {
                if (five.Equals("5"))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
            else if (TURN == 5)
            {
                if (five.Equals(playerShape)) //five = x
                {
                    if (two.Equals(playerShape)) //five = x, two = x
                    {
                        return 8;
                    }
                    else if (three.Equals(playerShape)) //five = x, three = x
                    {
                        return 7;
                    }
                    else if (four.Equals(playerShape)) //five = x, four = x
                    {
                        return 6;
                    }
                    else if (six.Equals(playerShape)) //five = x, six = x
                    {
                        return 4;
                    }
                    else if (seven.Equals(playerShape)) //five = x, seven = x
                    {
                        return 3;
                    }
                    else if (eight.Equals(playerShape)) //five = x, eight = x
                    {
                        return 2;
                    }
                    else if (nine.Equals(playerShape)) //five = x, nine = x
                    {
                        return 3;
                    }
                }
                else //Five = O
                {
                    if (one.Equals(playerShape)) //one = x
                    {
                        if (two.Equals(playerShape)) //one = x, two = x
                        {
                            return 3;
                        }
                        else if (three.Equals(playerShape)) //one = x, three = x
                        {
                            return 2;
                        }
                        else if (four.Equals(playerShape)) //one = x, four = x
                        {
                            return 7;
                        }
                        else if (six.Equals(playerShape)) //one = x, six = x
                        {
                            return 9;
                        }
                        else if (seven.Equals(playerShape)) //one = x, seven = x
                        {
                            return 4;
                        }
                        else if (eight.Equals(playerShape)) //one = x, eight = x
                        {
                            return 9;
                        }
                        else if (nine.Equals(playerShape)) //one = x, nine = x
                        {
                            return 2;
                        }
                    }
                    else if (two.Equals(playerShape)) //two = x
                    {
                        if (three.Equals(playerShape)) //two = x, three = x
                        {
                            return 1;
                        }
                        else if (four.Equals(playerShape)) //two = x, four = x
                        {
                            return 1;
                        }
                        else if (six.Equals(playerShape)) //two = x, six = x
                        {
                            return 3;
                        }
                        else if (seven.Equals(playerShape)) //two = x, seven = x
                        {
                            return 3;
                        }
                        else if (eight.Equals(playerShape)) //two = x, eight = x
                        {
                            return 7;
                        }
                        else if (nine.Equals(playerShape)) //two = x, nine = x
                        {
                            return 1;
                        }
                    }
                    else if (three.Equals(playerShape))//three = x
                    {
                        if (four.Equals(playerShape)) //three = x, four = x
                        {
                            return 7;
                        }
                        else if (six.Equals(playerShape)) //three = x, six = x
                        {
                            return 9;
                        }
                        else if (seven.Equals(playerShape)) //three = x, seven = x
                        {
                            return 8;
                        }
                        else if (eight.Equals(playerShape)) //three = x, eight = x
                        {
                            return 7;
                        }
                        else if (nine.Equals(playerShape)) //three = x, nine = x
                        {
                            return 6;
                        }
                    }
                    else if (four.Equals(playerShape))//four = x
                    {
                        if (six.Equals(playerShape)) //four = x, six = x
                        {
                            return 3;
                        }
                        else if (seven.Equals(playerShape)) //four = x, seven = x
                        {
                            return 1;
                        }
                        else if (eight.Equals(playerShape)) //four = x, eight = x
                        {
                            return 7;
                        }
                        else if (nine.Equals(playerShape)) //four = x, nine = x
                        {
                            return 1;
                        }
                    }
                    else if (six.Equals(playerShape))//six = x
                    {
                        if (seven.Equals(playerShape)) //six = x, seven = x
                        {
                            return 3;
                        }
                        else if (eight.Equals(playerShape)) //six = x, eight = x
                        {
                            return 9;
                        }
                        else if (nine.Equals(playerShape)) //six = x, nine = x
                        {
                            return 3;
                        }
                    }
                    else if (seven.Equals(playerShape))//seven = x
                    {
                        if (eight.Equals(playerShape)) //seven = x, eight = x
                        {
                            return 9;
                        }
                        else if (nine.Equals(playerShape)) //seven = x, nine = x
                        {
                            return 8;
                        }
                    }
                    else if (eight.Equals(playerShape))//seven = x
                    {
                        if (nine.Equals(playerShape)) //seven = x, nine = x
                        {
                            return 7;
                        }
                    }
                }
            }
            else if (TURN == 7)
            {
                if (five.Equals(playerShape)) //five = x
                {
                    if (two.Equals(playerShape) && eight.Equals(computerShape)) //one = o, eight = o, five = x, two = x
                    {
                        if (three.Equals(playerShape))
                        {
                            return 7;
                        }
                        else if (four.Equals(playerShape))
                        {
                            return 6;
                        }
                        else if (six.Equals(playerShape))
                        {
                            return 4;
                        }
                        else if (seven.Equals(playerShape))
                        {
                            return 3;
                        }
                        else if (nine.Equals(playerShape))
                        {
                            return 4;
                        }
                    }
                    else if (three.Equals(playerShape) && seven.Equals(computerShape)) //one = o, seven = o, five = x, three = x
                    {
                        if (four.Equals(playerShape))
                        {
                            return 6;
                        }
                        else
                        {
                            isWinner = true;
                            return 4;
                        }
                    }
                    else if (four.Equals(playerShape) && six.Equals(computerShape)) //one = o, six = o, five = x, four = x
                    {
                        if (two.Equals(playerShape))
                        {
                            return 8;
                        }
                        else if (three.Equals(playerShape))
                        {
                            return 7;
                        }
                        else if (seven.Equals(playerShape))
                        {
                            return 3;
                        }
                        else if (eight.Equals(playerShape))
                        {
                            return 2;
                        }
                        else if (nine.Equals(playerShape))
                        {
                            return 3;
                        }
                    }
                    else if (six.Equals(playerShape) && four.Equals(computerShape)) //one = o, four = o, five = x, six = x
                    {
                        if (seven.Equals(playerShape))
                        {
                            return 3;
                        }
                        else
                        {
                            isWinner = true;
                            return 7;
                        }
                    }
                    else if (seven.Equals(playerShape) && three.Equals(computerShape)) //one = o, three = o, five = x, seven = x
                    {
                        if (two.Equals(playerShape))
                        {
                            return 8;
                        }
                        else
                        {
                            isWinner = true;
                            return 2;
                        }
                    }
                    else if (eight.Equals(playerShape) && two.Equals(computerShape)) //one = o, two = o, five = x, eight = x
                    {
                        if (three.Equals(playerShape))
                        {
                            return 7;
                        }
                        else
                        {
                            isWinner = true;
                            return 3;
                        }
                    }
                    else if (nine.Equals(playerShape) && three.Equals(computerShape)) //one = o, three = o, five = x, nine = x
                    {
                        if (two.Equals(playerShape))
                        {
                            return 8;
                        }
                        else
                        {
                            isWinner = true;
                            return 2;
                        }
                    }
                }
                else //Five = O
                {
                    if (one.Equals(playerShape)) //one = x
                    {
                        if (two.Equals(playerShape) && three.Equals(computerShape)) //one = x, two = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape))
                            {
                                return 4;
                            }
                            else
                            {
                                isWinner = true;
                                return 7;
                            }
                        }
                        if (three.Equals(playerShape) && two.Equals(computerShape)) //one = x, three = x, two = o, five = o
                        {
                            if (eight.Equals(playerShape))
                            {
                                return 6;
                            }
                            else
                            {
                                isWinner = true;
                                return 8;
                            }
                        }
                        if (four.Equals(playerShape) && seven.Equals(computerShape)) //one = x, four = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape))
                            {
                                return 2;
                            }
                            else
                            {
                                isWinner = true;
                                return 3;
                            }
                        }
                        if (six.Equals(playerShape) && nine.Equals(computerShape)) //one = x, six = x, nine = o, five = o
                        {
                            if (two.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (three.Equals(playerShape))
                            {
                                return 2;
                            }
                            else if (four.Equals(playerShape))
                            {
                                return 7;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 4;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 7;
                            }
                        }
                        if (seven.Equals(playerShape) && four.Equals(computerShape)) //one = x, seven = x, four = o, five = o
                        {
                            if (six.Equals(playerShape))
                            {
                                return 8;
                            }
                            else
                            {
                                isWinner = true;
                                return 6;
                            }
                        }
                        if (eight.Equals(playerShape) && nine.Equals(computerShape)) //one = x, eight = x, nine = o, five = o
                        {
                            if (two.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (three.Equals(playerShape))
                            {
                                return 2;
                            }
                            else if (four.Equals(playerShape))
                            {
                                return 7;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 7;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 4;
                            }
                        }
                        if (nine.Equals(playerShape) && two.Equals(computerShape)) //one = x, nine = x, two = o, five = o
                        {
                            if (eight.Equals(playerShape))
                            {
                                return 7;
                            }
                            else
                            {
                                isWinner = true;
                                return 8;
                            }
                        }
                    }
                    if (two.Equals(playerShape)) //two = x
                    {
                        if (three.Equals(playerShape) && one.Equals(computerShape)) //two = x, three = x, one = o, five = o
                        {
                            if (nine.Equals(playerShape))
                            {
                                return 6;
                            }
                            else
                            {
                                isWinner = true;
                                return 9;
                            }
                        }
                        if (four.Equals(playerShape) && one.Equals(computerShape)) //two = x, four = x, one = o, five = o
                        {
                            if (nine.Equals(playerShape))
                            {
                                return 3;
                            }
                            else
                            {
                                isWinner = true;
                                return 9;
                            }
                        }
                        if (six.Equals(playerShape) && three.Equals(computerShape)) //two = x, six = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape))
                            {
                                return 1;
                            }
                            else
                            {
                                isWinner = true;
                                return 7;
                            }
                        }
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //two = x, seven = x, three = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 4;
                            }
                            else if (four.Equals(playerShape))
                            {
                                return 1;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 1;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 9;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 8;
                            }
                        }
                        if (eight.Equals(playerShape) && seven.Equals(computerShape)) //two = x, eight = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape))
                            {
                                return 1;
                            }
                            else
                            {
                                isWinner = true;
                                return 3;
                            }
                        }
                        if (nine.Equals(playerShape) && one.Equals(computerShape)) //two = x, nine = x, one = o, five = o
                        {
                            if (three.Equals(playerShape))
                            {
                                return 6;
                            }
                            else if (four.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 8;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 7;
                            }
                        }
                    }
                    if (three.Equals(playerShape))//three = x
                    {
                        if (four.Equals(playerShape) && seven.Equals(computerShape)) //three = x, four = x, seven = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 2;
                            }
                            else if (two.Equals(playerShape))
                            {
                                return 1;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 9;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 9;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 6;
                            }
                        }
                        if (six.Equals(playerShape) && nine.Equals(computerShape)) //three = x, six = x, nine = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 2;
                            }
                            else
                            {
                                isWinner = true;
                                return 1;
                            }
                        }
                        if (seven.Equals(playerShape) && eight.Equals(computerShape)) //three = x, seven = x, eight = o, five = o
                        {
                            if (two.Equals(playerShape))
                            {
                                return 1;
                            }
                            else
                            {
                                isWinner = true;
                                return 2;
                            }
                        }
                        if (eight.Equals(playerShape) && seven.Equals(computerShape)) //three = x, eight = x, seven = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 2;
                            }
                            else if (two.Equals(playerShape))
                            {
                                return 1;
                            }
                            else if (four.Equals(playerShape))
                            {
                                return 9;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 9;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 6;
                            }
                        }
                        if (nine.Equals(playerShape) && six.Equals(computerShape)) //three = x, nine = x, six = o, five = o
                        {
                            if (four.Equals(playerShape))
                            {
                                return 2;
                            }
                            else
                            {
                                isWinner = true;
                                return 4;
                            }
                        }
                    }
                    if (four.Equals(playerShape))//four = x
                    {
                        if (six.Equals(playerShape) && three.Equals(computerShape)) //four = x, six = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape))
                            {
                                return 1;
                            }
                            else
                            {
                                isWinner = true;
                                return 7;
                            }
                        }
                        if (seven.Equals(playerShape) && one.Equals(computerShape)) //four = x, seven = x, one = o, five = o
                        {
                            if (nine.Equals(playerShape))
                            {
                                return 8;
                            }
                            else
                            {
                                isWinner = true;
                                return 9;
                            }
                        }
                        if (eight.Equals(playerShape) && seven.Equals(computerShape)) //four = x, eight = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape))
                            {
                                return 9;
                            }
                            else
                            {
                                isWinner = true;
                                return 3;
                            }
                        }
                        if (nine.Equals(playerShape) && one.Equals(computerShape)) //four = x, nine = x, one = o, five = o
                        {
                            if (two.Equals(playerShape))
                            {
                                return 7;
                            }
                            else if (three.Equals(playerShape))
                            {
                                return 6;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 8;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 7;
                            }
                        }
                    }
                    if (six.Equals(playerShape))//six = x
                    {
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //six = x, seven = x, three = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 4;
                            }
                            else if (two.Equals(playerShape))
                            {
                                return 1;
                            }
                            else if (four.Equals(playerShape))
                            {
                                return 1;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 9;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 8;
                            }
                        }
                        if (eight.Equals(playerShape) && nine.Equals(computerShape)) //six = x, eight = x, nine = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 7;
                            }
                            else
                            {
                                isWinner = true;
                                return 1;
                            }
                        }
                        if (nine.Equals(playerShape) && three.Equals(computerShape)) //six = x, nine = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape))
                            {
                                return 8;
                            }
                            else
                            {
                                isWinner = true;
                                return 7;
                            }
                        }
                    }
                    if (seven.Equals(playerShape))//seven = x
                    {
                        if (eight.Equals(playerShape) && nine.Equals(computerShape)) //seven = x, eight = x, nine = o, five = o
                        {
                            if (one.Equals(playerShape))
                            {
                                return 4;
                            }
                            else
                            {
                                isWinner = true;
                                return 1;
                            }
                        }
                        if (nine.Equals(playerShape) && eight.Equals(computerShape)) //seven = x, nine = x, eight = o, five = o
                        {
                            if (two.Equals(playerShape))
                            {
                                return 6;
                            }
                            else
                            {
                                isWinner = true;
                                return 2;
                            }
                        }
                    }
                    if (eight.Equals(playerShape))//eight = x
                    {
                        if (nine.Equals(playerShape) && seven.Equals(computerShape)) //eight = x, nine = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape))
                            {
                                return 6;
                            }
                            else
                            {
                                isWinner = true;
                                return 3;
                            }
                        }
                    }
                }
            }
            else if (TURN == 9)
            {
                if (five.Equals(playerShape)) //five = x
                {
                    if (two.Equals(playerShape) && eight.Equals(computerShape)) //one = o, eight = o, five = x, two = x
                    {
                        if (three.Equals(playerShape) && seven.Equals(computerShape)) //one = o, eight = o, seven = o, five = x, two = x, three = x
                        {
                            if (four.Equals(playerShape))
                            {
                                isWinner = true;
                                return 9;
                            }
                            else
                            {
                                isWinner = true;
                                return 4;
                            }
                        }
                        if (four.Equals(playerShape) && six.Equals(computerShape)) //one = o, eight = o, six = o, five = x, two = x, four = x
                        {
                            if (three.Equals(playerShape))
                            {
                                return 7;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 3;
                            }
                        }
                        if (six.Equals(playerShape) && four.Equals(computerShape)) //one = o, eight = o, four = o, five = x, two = x, six = x
                        {
                            if (seven.Equals(playerShape))
                            {
                                return 3;
                            }
                            else
                            {
                                isWinner = true;
                                return 7;
                            }
                        }
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //one = o, eight = o, three = o, five = x, two = x, seven = x
                        {
                            if (four.Equals(playerShape))
                            {
                                return 6;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 4;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 4;
                            }
                        }
                        if (nine.Equals(playerShape) && four.Equals(computerShape)) //one = o, eight = o, four = o, five = x, two = x, nine = x
                        {
                            if (seven.Equals(playerShape))
                            {
                                return 3;
                            }
                            else
                            {
                                isWinner = true;
                                return 7;
                            }
                        }
                    }
                    if (three.Equals(playerShape) && seven.Equals(computerShape)) //one = o, seven = o, five = x, three = x
                    {
                        if (four.Equals(playerShape) && six.Equals(computerShape)) //one = o, seven = o, six = o, five = x, three = x, four = x
                        {
                            if (two.Equals(playerShape))
                            {
                                return 8;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 2;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 2;
                            }
                        }
                    }
                    if (four.Equals(playerShape) && six.Equals(computerShape)) //one = o, six = o, five = x, four = x
                    {
                        if (two.Equals(playerShape) && eight.Equals(computerShape)) //one = o, six = o, eight = o, five = x, four = x, two = x
                        {
                            if (three.Equals(playerShape))
                            {
                                return 7;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 3;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 3;
                            }
                        }
                        if (three.Equals(playerShape) && seven.Equals(computerShape)) //one = o, six = o, seven = o, five = x, four = x, three = x
                        {
                            if (two.Equals(playerShape))
                            {
                                return 8;
                            }
                            else if (eight.Equals(playerShape))
                            {
                                return 2;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 2;
                            }
                        }
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //one = o, six = o, three = o, five = x, four = x, seven = x
                        {
                            if (two.Equals(playerShape))
                            {
                                isWinner = true;
                                return 9;
                            }
                            else
                            {
                                isWinner = true;
                                return 2;
                            }
                        }
                        if (eight.Equals(playerShape) && two.Equals(computerShape)) //one = o, six = o, two = o, five = x, four = x, eight = x
                        {
                            if (three.Equals(playerShape))
                            {
                                return 7;
                            }
                            else
                            {
                                isWinner = true;
                                return 3;
                            }
                        }
                        if (nine.Equals(playerShape) && three.Equals(computerShape)) //one = o, six = o, three = o, five = x, four = x, nine = x
                        {
                            if (two.Equals(playerShape))
                            {
                                return 8;
                            }
                            else
                            {
                                isWinner = true;
                                return 2;
                            }
                        }
                    }
                    if (six.Equals(playerShape) && four.Equals(computerShape)) //one = o, four = o, five = x, six = x
                    {
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //one = o, four = o, three = o, five = x, six = x, seven = x
                        {
                            if (two.Equals(playerShape))
                            {
                                return 8;
                            }
                            else
                            {
                                isWinner = true;
                                return 2;
                            }
                        }
                    }
                    if (seven.Equals(playerShape) && three.Equals(computerShape)) //one = o, three = o, five = x, seven = x
                    {
                        if (two.Equals(playerShape) && eight.Equals(computerShape)) //one = o, three = o, eight = o, five = x, seven = x, two = x
                        {
                            if (four.Equals(playerShape))
                            {
                                return 6;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 4;
                            }
                            else if (nine.Equals(playerShape))
                            {
                                return 4;
                            }
                        }
                    }
                    if (eight.Equals(playerShape) && two.Equals(computerShape)) //one = o, two = o, five = x, eight = x
                    {
                        if (three.Equals(playerShape) && seven.Equals(computerShape)) //one = o, two = o, seven = o, five = x, eight = x, three = x
                        {
                            if (four.Equals(playerShape))
                            {
                                return 6;
                            }
                            else
                            {
                                isWinner = true;
                                return 4;
                            }
                        }
                    }
                    if (nine.Equals(playerShape) && three.Equals(computerShape)) //one = o, three = o, five = x, nine = x
                    {
                        if (two.Equals(playerShape) && eight.Equals(computerShape)) //one = o, three = o, eight = o, five = x, nine = x, two = x
                        {
                            if (four.Equals(playerShape))
                            {
                                return 6;
                            }
                            else if (six.Equals(playerShape))
                            {
                                return 4;
                            }
                            else if (seven.Equals(playerShape))
                            {
                                return 4;
                            }
                        }
                    }
                }
                else //Five = O
                {
                    if (one.Equals(playerShape)) //one = x
                    {
                        if (two.Equals(playerShape) && three.Equals(computerShape)) //one = x, two = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape) && four.Equals(computerShape)) //one = x, two = x, seven = x, four = o, three = o, five = o
                            {
                                if (six.Equals(playerShape))
                                {
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 6;
                                }
                            }
                        }
                        if (three.Equals(playerShape) && two.Equals(computerShape)) //one = x, three = x, two = o, five = o
                        {
                            if (eight.Equals(playerShape) && six.Equals(computerShape)) //one = x, three = x, eight = x, six = o, two = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                        if (four.Equals(playerShape) && seven.Equals(computerShape)) //one = x, four = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape) && two.Equals(computerShape)) //one = x, four = x, three = x, two = o, seven = o, five = o
                            {
                                if (eight.Equals(playerShape))
                                {
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 8;
                                }
                            }
                        }
                        if (six.Equals(playerShape) && nine.Equals(computerShape)) //one = x, six = x, nine = o, five = o
                        {
                            if (two.Equals(playerShape) && three.Equals(computerShape)) //one = x, six = x, two = x, three = o, nine = o, five = o
                            {
                                if (seven.Equals(playerShape))
                                {
                                    return 4;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 7;
                                }
                            }
                            else if (three.Equals(playerShape) && two.Equals(computerShape)) //one = x, six = x, three = x, two = o, nine = o, five = o
                            {
                                if (eight.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 8;
                                }
                            }
                            else if (four.Equals(playerShape) && seven.Equals(computerShape)) //one = x, six = x, four = x, seven = o, nine = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                            else if (seven.Equals(playerShape) && four.Equals(computerShape)) //one = x, six = x, seven = x, four = o, nine = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 3;
                                }
                                else if (three.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else if (eight.Equals(playerShape))
                                {
                                    return 3;
                                }
                            }
                            else if (eight.Equals(playerShape) && seven.Equals(computerShape)) //one = x, six = x, eight = x, seven = o, nine = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                        }
                        if (seven.Equals(playerShape) && four.Equals(computerShape)) //one = x, seven = x, four = o, five = o
                        {
                            if (six.Equals(playerShape) && eight.Equals(computerShape)) //one = x, seven = x, six = x, eight = o, four = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 3;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                        }
                        if (eight.Equals(playerShape) && nine.Equals(computerShape)) //one = x, eight = x, nine = o, five = o
                        {
                            if (two.Equals(playerShape) && three.Equals(computerShape)) //one = x, eight = x, two = x, three = o, nine = o, five = o
                            {
                                if (six.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 6;
                                }
                            }
                            else if (three.Equals(playerShape) && two.Equals(computerShape)) //one = x, eight = x, three = x, two = o, nine = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else if (six.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else if (seven.Equals(playerShape))
                                {
                                    return 4;
                                }
                            }
                            else if (four.Equals(playerShape) && seven.Equals(computerShape)) //one = x, eight = x, four = x, seven = o, nine = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                            else if (six.Equals(playerShape) && seven.Equals(computerShape)) //one = x, eight = x, six = x, seven = o, nine = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                            else if (seven.Equals(playerShape) && four.Equals(computerShape)) //one = x, eight = x, seven = x, four = o, nine = o, five = o
                            {
                                if (six.Equals(playerShape))
                                {
                                    return 3;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 6;
                                }
                            }
                        }
                        if (nine.Equals(playerShape) && two.Equals(computerShape)) //one = x, nine = x, two = o, five = o
                        {
                            if (eight.Equals(playerShape) && seven.Equals(computerShape)) //one = x, nine = x, eight = x, seven = o, two = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                        }
                    }
                    if (two.Equals(playerShape)) //two = x
                    {
                        if (three.Equals(playerShape) && one.Equals(computerShape)) //two = x, three = x, one = o, five = o
                        {
                            if (nine.Equals(playerShape) && six.Equals(computerShape)) //two = x, three = x, nine = x, six = o, one = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                        if (four.Equals(playerShape) && one.Equals(computerShape)) //two = x, four = x, one = o, five = o
                        {
                            if (nine.Equals(playerShape) && three.Equals(computerShape)) //two = x, four = x, nine = x, three = o, one = o, five = o
                            {
                                if (seven.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 7;
                                }
                            }
                        }
                        if (six.Equals(playerShape) && three.Equals(computerShape)) //two = x, six = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape) && one.Equals(computerShape)) //two = x, six = x, seven = x, one = o, three = o, five = o
                            {
                                if (nine.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 9;
                                }
                            }
                        }
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //two = x, seven = x, three = o, five = o
                        {
                            if (one.Equals(playerShape) && four.Equals(computerShape)) //two = x, seven = x, one = x, four = o, three = o, five = o
                            {
                                if (six.Equals(playerShape))
                                {
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 6;
                                }
                            }
                            else if (four.Equals(playerShape) && one.Equals(computerShape)) //two = x, seven = x, four = x, one = o, three = o, five = o
                            {
                                if (nine.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 9;
                                }
                            }
                            else if (six.Equals(playerShape) && one.Equals(computerShape)) //two = x, seven = x, six = x, one = o, three = o, five = o
                            {
                                if (nine.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 9;
                                }
                            }
                            else if (eight.Equals(playerShape) && nine.Equals(computerShape)) //two = x, seven = x, eight = x, nine = o, three = o, five = o
                            {
                                if (six.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 1;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 6;
                                }
                            }
                            else if (nine.Equals(playerShape) && eight.Equals(computerShape)) //two = x, seven = x, nine = x, eight = o, three = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 4;
                                }
                                else if (four.Equals(playerShape))
                                {
                                    return 1;
                                }
                                else if (six.Equals(playerShape))
                                {
                                    return 1;
                                }
                            }
                        }
                        if (eight.Equals(playerShape) && seven.Equals(computerShape)) //two = x, eight = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape) && one.Equals(computerShape)) //two = x, eight = x, three = x, one = o, seven = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                        if (nine.Equals(playerShape) && one.Equals(computerShape)) //two = x, nine = x, one = o, five = o
                        {
                            if (three.Equals(playerShape) && six.Equals(computerShape)) //two = x, nine = x, three = x, six = o, one = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                            else if (four.Equals(playerShape) && three.Equals(computerShape)) //two = x, nine = x, four = x, three = o, one = o, five = o
                            {
                                if (seven.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 7;
                                }
                            }
                            else if (six.Equals(playerShape) && three.Equals(computerShape)) //two = x, nine = x, six = x, three = o, one = o, five = o
                            {
                                if (seven.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 7;
                                }
                            }
                            else if (seven.Equals(playerShape) && eight.Equals(computerShape)) //two = x, nine = x, seven = x, eight = o, one = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else if (four.Equals(playerShape))
                                {
                                    return 3;
                                }
                                else if (six.Equals(playerShape))
                                {
                                    return 3;
                                }
                            }
                            else if (eight.Equals(playerShape) && seven.Equals(computerShape)) //two = x, nine = x, eight = x, seven = o, one = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 3;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                    }
                    if (three.Equals(playerShape))//three = x
                    {
                        if (four.Equals(playerShape) && seven.Equals(computerShape)) //three = x, four = x, seven = o, five = o
                        {
                            if (one.Equals(playerShape) && two.Equals(computerShape)) //three = x, four = x, one = x, two = o, seven = o, five = o
                            {
                                if (eight.Equals(playerShape))
                                {
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 8;
                                }
                            }
                            else if (two.Equals(playerShape) && one.Equals(computerShape)) //three = x, four = x, two = x, one = o, seven = o, five = o
                            {
                                if (nine.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 9;
                                }
                            }
                            else if (six.Equals(playerShape) && nine.Equals(computerShape)) //three = x, four = x, six = x, nine = o, seven = o, five = o
                            {
                                if (eight.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 1;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 8;
                                }
                            }
                            else if (eight.Equals(playerShape) && nine.Equals(computerShape)) //three = x, four = x, eight = x, nine = o, seven = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 1;
                                }
                            }
                            else if (nine.Equals(playerShape) && six.Equals(computerShape)) //three = x, four = x, nine = x, six = o, seven = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else if (two.Equals(playerShape))
                                {
                                    return 1;
                                }
                                else if (eight.Equals(playerShape))
                                {
                                    return 1;
                                }
                            }
                        }
                        if (six.Equals(playerShape) && nine.Equals(computerShape)) //three = x, six = x, nine = o, five = o
                        {
                            if (one.Equals(playerShape) && two.Equals(computerShape)) //three = x, six = x, one = x, two = o, nine = o, five = o
                            {
                                if (eight.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 8;
                                }
                            }
                        }
                        if (seven.Equals(playerShape) && eight.Equals(computerShape)) //three = x, seven = x, eight = o, five = o
                        {
                            if (two.Equals(playerShape) && one.Equals(computerShape)) //three = x, seven = x, two = x, one = o, eight = o, five = o
                            {
                                if (nine.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 9;
                                }
                            }
                        }
                        if (eight.Equals(playerShape) && seven.Equals(computerShape)) //three = x, eight = x, seven = o, five = o
                        {
                            if (one.Equals(playerShape) && two.Equals(computerShape)) //three = x, eight = x, one = x, two = o, seven = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else if (six.Equals(playerShape))
                                {
                                    return 9;
                                }
                                else if (nine.Equals(playerShape))
                                {
                                    return 6;
                                }
                            }
                            else if (two.Equals(playerShape) && one.Equals(computerShape)) //three = x, eight = x, two = x, one = o, seven = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                            else if (four.Equals(playerShape) && nine.Equals(computerShape)) //three = x, eight = x, four = x, nine = o, seven = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 1;
                                }
                            }
                            else if (six.Equals(playerShape) && nine.Equals(computerShape)) //three = x, eight = x, six = x, nine = o, seven = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 1;
                                }
                            }
                            else if (nine.Equals(playerShape) && six.Equals(computerShape)) //three = x, eight = x, nine = x, six = o, seven = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                        if (nine.Equals(playerShape) && six.Equals(computerShape)) //three = x, nine = x, six = o, five = o
                        {
                            if (four.Equals(playerShape) && two.Equals(computerShape)) //three = x, nine = x, four = x, two = o, six = o, five = o
                            {
                                if (eight.Equals(playerShape))
                                {
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 8;
                                }
                            }
                        }
                    }
                    if (four.Equals(playerShape))//four = x
                    {
                        if (six.Equals(playerShape) && three.Equals(computerShape)) //four = x, six = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape) && one.Equals(computerShape)) //four = x, six = x, seven = x, one = o, three = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                        }
                        if (seven.Equals(playerShape) && one.Equals(computerShape)) //four = x, seven = x, one = o, five = o
                        {
                            if (nine.Equals(playerShape) && eight.Equals(computerShape)) //four = x, seven = x, nine = x, eight = o, one = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                        }
                        if (eight.Equals(playerShape) && seven.Equals(computerShape)) //four = x, eight = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape) && nine.Equals(computerShape)) //four = x, eight = x, three = x, nine = o, seven = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 1;
                                }
                            }
                        }
                        if (nine.Equals(playerShape) && one.Equals(computerShape)) //four = x, nine = x, one = o, five = o
                        {
                            if (two.Equals(playerShape) && seven.Equals(computerShape)) //four = x, nine = x, two = x, seven = o, one = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                            else if (three.Equals(playerShape) && six.Equals(computerShape)) //four = x, nine = x, three = x, six = o, one = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else if (seven.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else if (eight.Equals(playerShape))
                                {
                                    return 7;
                                }
                            }
                            else if (six.Equals(playerShape) && three.Equals(computerShape)) //four = x, nine = x, six = x, three = o, one = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 7;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                            else if (seven.Equals(playerShape) && eight.Equals(computerShape)) //four = x, nine = x, seven = x, eight = o, one = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 3;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                            else if (eight.Equals(playerShape) && seven.Equals(computerShape)) //four = x, nine = x, eight = x, seven = o, one = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 6;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                        }
                    }
                    if (six.Equals(playerShape))//six = x
                    {
                        if (seven.Equals(playerShape) && three.Equals(computerShape)) //six = x, seven = x, three = o, five = o
                        {
                            if (one.Equals(playerShape) && four.Equals(computerShape)) //six = x, seven = x, one = x, four = o, three = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else if (eight.Equals(playerShape))
                                {
                                    return 9;
                                }
                                else if (nine.Equals(playerShape))
                                {
                                    return 8;
                                }
                            }
                            else if (two.Equals(playerShape) && one.Equals(computerShape)) //six = x, seven = x, two = x, one = o, three = o, five = o
                            {
                                if (nine.Equals(playerShape))
                                {
                                    return 8;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 9;
                                }
                            }
                            else if (four.Equals(playerShape) && one.Equals(computerShape)) //six = x, seven = x, four = x, one = o, three = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    isWinner = true;
                                    return 9;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                            else if (eight.Equals(playerShape) && nine.Equals(computerShape)) //six = x, seven = x, eight = x, nine = o, three = o, five = o
                            {
                                if (one.Equals(playerShape))
                                {
                                    return 4;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 1;
                                }
                            }
                            else if (nine.Equals(playerShape) && eight.Equals(computerShape)) //six = x, seven = x, nine = x, eight = o, three = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 4;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                        }
                        if (eight.Equals(playerShape) && nine.Equals(computerShape)) //six = x, eight = x, nine = o, five = o
                        {
                            if (one.Equals(playerShape) && seven.Equals(computerShape)) //six = x, eight = x, one = x, seven = o, nine = o, five = o
                            {
                                if (three.Equals(playerShape))
                                {
                                    return 2;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 3;
                                }
                            }
                        }
                        if (nine.Equals(playerShape) && three.Equals(computerShape)) //six = x, nine = x, three = o, five = o
                        {
                            if (seven.Equals(playerShape) && eight.Equals(computerShape)) //six = x, nine = x, seven = x, eigth = o, three = o, five = o
                            {
                                if (two.Equals(playerShape))
                                {
                                    return 1;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 2;
                                }
                            }
                        }
                    }
                    if (seven.Equals(playerShape))//seven = x
                    {
                        if (eight.Equals(playerShape) && nine.Equals(computerShape)) //seven = x, eight = x, nine = o, five = o
                        {
                            if (one.Equals(playerShape) && four.Equals(computerShape)) //seven = x, eight = x, one = x, four = o, nine = o, five = o
                            {
                                if (six.Equals(playerShape))
                                {
                                    return 3;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 6;
                                }
                            }
                        }
                        if (nine.Equals(playerShape) && eight.Equals(computerShape)) //seven = x, nine = x, eight = o, five = o
                        {
                            if (two.Equals(playerShape) && six.Equals(computerShape)) //seven = x, nine = x, two = x, six = o, eight = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 1;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                    }
                    if (eight.Equals(playerShape))//eight = x
                    {
                        if (nine.Equals(playerShape) && seven.Equals(computerShape)) //eight = x, nine = x, seven = o, five = o
                        {
                            if (three.Equals(playerShape) && six.Equals(computerShape)) //eight = x, nine = x, three = x, six = o, seven = o, five = o
                            {
                                if (four.Equals(playerShape))
                                {
                                    return 1;
                                }
                                else
                                {
                                    isWinner = true;
                                    return 4;
                                }
                            }
                        }
                    }
                }
            }

            return 0;
        }

        public static void printBoard(String playerShape, String computerShape, String one, String two, String three, String four, String five, String six, String seven, String eight, String nine)
        {
            ConsoleColor lastColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            String halfLineForBoard = lineForBoard.Substring(0, (lineForBoard.Length - 12 - fullName.Length) / 2);

            Console.Write(halfLineForBoard);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(fullName + " VS Computer");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(halfLineForBoard + LINE.Substring(0, lineForBoard.Length - halfLineForBoard.Length * 2 - 12 - fullName.Length));

            Console.Write("\t      |      |      \t    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player shape: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(playerShape);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Write("\t   ");
            if(!one.Equals("1"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(one);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if(!two.Equals("2"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(two);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if(!three.Equals("3"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(three);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t    Computer shape: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(computerShape);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\t      |      |");


            Console.WriteLine("\t--------------------");


            Console.WriteLine("\t      |      |");

            Console.Write("\t   ");
            if (!four.Equals("4"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(four);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!five.Equals("5"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(five);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!six.Equals("6"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(six);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\t      |      |");


            Console.WriteLine("\t--------------------");


            Console.WriteLine("\t      |      |");

            Console.Write("\t   ");
            if (!seven.Equals("7"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(seven);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!eight.Equals("8"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(eight);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!nine.Equals("9"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(nine);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\t      |      |");

            Console.WriteLine(lineForBoard);

            Console.ForegroundColor = lastColor;
        }

        public static void printWinningBoard(String playerShape, String computerShape, String one, String two, String three, String four, String five, String six, String seven, String eight, String nine)
        {
            ConsoleColor lastColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            String halfLineForBoard = lineForBoard.Substring(0, (lineForBoard.Length - 12 - fullName.Length) / 2);

            Console.Write(halfLineForBoard);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(fullName + " VS Computer");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(halfLineForBoard + LINE.Substring(0, lineForBoard.Length - halfLineForBoard.Length*2-12-fullName.Length));

            Console.Write("\t");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |   ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |   ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\t    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Player shape: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(playerShape);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Write("\t");
            if (one.Equals(two) && two.Equals(three))
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            Console.Write("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (!one.Equals("1"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(one);
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!two.Equals("2"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(two);
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (!three.Equals("3"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(three);
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t    Computer shape: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(computerShape);
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.Write("\t   ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|   ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            Console.Write("\t---");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("--");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("---");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("--");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("---");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("--");


            Console.Write("\t   ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|   ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  ");

            Console.Write("\t");
            if (four.Equals(five) && five.Equals(six))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            if (!four.Equals("4"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("   ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(four);
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (!five.Equals("5"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(five);
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!six.Equals("6"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(six);
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("\t   ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|   ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");


            Console.Write("\t---");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("--");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("---");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("--");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("---");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("-");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("--");


            Console.Write("\t   ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("|   ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            Console.Write("\t");
            if (seven.Equals(eight) && eight.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            if (!seven.Equals("7"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(seven);
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |   ");
            if (!eight.Equals("8"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(eight);
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("  |  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (!nine.Equals("9"))
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(nine);
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("  ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("\t");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("  ");
            if (three.Equals(five) && five.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (one.Equals(four) && four.Equals(seven))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |   ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (two.Equals(five) && five.Equals(eight))
                Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  |   ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write(" ");
            if (three.Equals(six) && six.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  ");
            if (one.Equals(five) && five.Equals(nine))
                Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(lineForBoard);

            Console.ForegroundColor = lastColor;
        }
    }
}
