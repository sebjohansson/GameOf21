using System;

namespace GameOf21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------");
            Console.WriteLine("Game of 21");
            Console.WriteLine("----------");
            Console.WriteLine("   Menu");
            Random random = new Random();
            string menuChoice = "0";
            string lastWinner = "No previous winner";
            while (menuChoice != "4")
            {
                Console.WriteLine("----------");
                Console.WriteLine("1. Play");
                Console.WriteLine("2. Last winner");
                Console.WriteLine("3. Rules");
                Console.WriteLine("4. Quit");
                Console.WriteLine("----------");
                menuChoice = Console.ReadLine();
                Console.WriteLine();

                switch (menuChoice)
                {
                    case "1":
                        int computerPoints = 0;
                        int playerPoints = 0;

                        Console.WriteLine("Drawing 2 cards for both players.");
                        computerPoints += random.Next(1, 11);
                        computerPoints += random.Next(1, 11);
                        playerPoints += random.Next(1, 11);
                        playerPoints += random.Next(1, 11);

                        string cardChoice = "";
                        while (cardChoice != "n" && playerPoints <= 21)
                        {
                            Console.WriteLine($"Player points {playerPoints}");
                            Console.WriteLine($"Computer points {computerPoints}");
                            Console.WriteLine();
                            Console.WriteLine("Draw another card? Y/N");
                            cardChoice = Console.ReadLine();

                            switch (cardChoice)
                            {
                                case "y":
                                    int newScore = random.Next(1, 11);
                                    playerPoints += newScore;
                                    Console.WriteLine($"You drew {newScore}.");
                                    Console.WriteLine($"You have {playerPoints} points.");
                                    break;

                                case "n":

                                    break;

                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                        }

                        if (playerPoints > 21)
                        {
                            Console.WriteLine("You drew over 21 and lost.");
                            break;
                        }
                        while (computerPoints < playerPoints && computerPoints <= 21)
                        {
                            int computerNewScore = random.Next(1, 11);
                            computerPoints += computerNewScore;
                            Console.WriteLine($"Computer drew {computerNewScore} points.");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Your score: {playerPoints}");
                        Console.WriteLine($"Computer score: {computerPoints}");
                        Console.WriteLine();

                        if (computerPoints > 21)
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine("Enter your name");
                            lastWinner = Console.ReadLine();
                        }
                        else if (computerPoints == playerPoints)
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            lastWinner = "Computer";
                            Console.WriteLine("Computer wins!");
                        }
                        break;

                    case "2":
                        Console.WriteLine($"Last winner: {lastWinner}.");
                        break;

                    case "3":
                        Console.WriteLine("You play against the computer to either reach 21 first or the opponent draws higher.\nYou recieve points from drawing cards, every card has 1-10 points.");
                        Console.WriteLine("If you draw more than 21 points you lose.\nBoth you and the computer gets two cards in the beginning. Thereafter you");
                        Console.WriteLine("draw cards until you are either happy or pass 21 points.\nWhen you are done the computer keeps drawing cards until it either beats your score or draws over 21.");
                        break;

                    case "4":
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
