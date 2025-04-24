using System.Reflection.Metadata;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                                  Random random = new Random();

                                  string[] Choices = { "Rock", "Paper", "Scissors" };
                                  string RandChoice = Choices[random.Next(Choices.Length)];
                      */
            Console.WriteLine("\t\t\t\t\t\t==Welcome to BATO BATO PICK Game==");
            Console.WriteLine("\n\t\t\t\t\t\tPress enter to start the game\t\t\t\t\t\t");
            Console.ReadKey();
            Console.Clear();

            string PlayAgain;
            do
            {
                Console.Write("\t\t\t\t\t\t====================");
                Console.Write("\n\t\t\t\t\t\t||Choose Options: ||\n");
                Console.Write("\t\t\t\t\t\t|| Rock           ||\n");
                Console.Write("\t\t\t\t\t\t|| Paper          ||\n");
                Console.Write("\t\t\t\t\t\t|| Scissors       ||\n");
                Console.Write("\t\t\t\t\t\t====================");

                /*
                           foreach (string c in Choices)
                           {
                               Console.WriteLine("\t\t\t\t\t\t\t\t\t" + c);
                           }
               */

                int life = 5;
                int Human_Win = 0, Human_lose = 0, Com_Win = 0, Com_lose = 0;


                while (life != 0)
                {
                    Random random = new Random();

                    string[] Choices = { "Rock", "Paper", "Scissors" };
                    string RandChoice = Choices[random.Next(Choices.Length)];



                    Console.WriteLine("\nLife: " + life);

                c:
                    Console.Write("\t\t\t\t\t\tYou: ");
                    string choice = Console.ReadLine();

                    /*
                                int x = 0;
                                for (int i = 0; i < x; i++)
                                {
                                    if (choice != Choices[i])
                                    {
                                        Console.WriteLine("Invalid choice");
                                        x++;
                                    }

                                }
                    */
                    if (!(choice.Equals("rock", StringComparison.InvariantCultureIgnoreCase)) && !(choice.Equals("paper", StringComparison.InvariantCultureIgnoreCase)) && !(choice.Equals("scissors", StringComparison.InvariantCultureIgnoreCase)))
                    {
                        Console.WriteLine("Invalid input");
                        goto c;
                    }

                    Console.Write("\t\t\t\t\t\tComputer: " + RandChoice);

                    //tie
                    if (choice.Equals("rock", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[0])
                    {
                        Console.WriteLine("\n\n\t\t\t\t\t\tTie, You've Both pick \"{0}\" ", Choices[0]);
                    }
                    else if (choice.Equals("paper", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[1])
                    {
                        Console.WriteLine("\n\n\t\t\t\t\t\tTie, You've Both pick \"{0}\" ", Choices[1]);

                    }
                    else if (choice.Equals("Scissors", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[2])
                    {
                        Console.WriteLine("\n\n\t\t\t\t\t\tTie, You've Both pick \"{0}\" ", Choices[2]);

                    }

                    //rock     
                    else if (choice.Equals("rock", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t\t\t\t\tYou Lose, Computer Win!");
                        Console.ResetColor();
                        life--;
                        Human_lose++;
                        Com_Win++;


                    }
                    else if (choice.Equals("rock", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[2])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\t\t\t\t\t\tYou Win!");
                        Console.ResetColor();
                        Human_Win++;
                        Com_lose++;

                    }


                    //paper
                    else if (choice.Equals("paper", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\t\t\t\t\t\tYou Win!");
                        Console.ResetColor();
                        Human_Win++;
                        Com_lose++;

                    }
                    else if (choice.Equals("paper", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[2])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t\t\t\t\tYou Lose, Computer Win!");
                        Console.ResetColor();
                        life--;
                        Human_lose++;
                        Com_Win++;
                    }

                    //scissor
                    else if (choice.Equals("scissors", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n\n\t\t\t\t\t\tYou Lose, Computer Wins!");
                        Console.ResetColor();
                        life--;
                        Human_lose++;
                        Com_Win++;

                    }
                    else if (choice.Equals("scissors", StringComparison.InvariantCultureIgnoreCase) && RandChoice == Choices[1])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n\n\t\t\t\t\t\tYou Win!");
                        Console.ResetColor();
                        Human_Win++;
                        Com_lose++;

                    }
                    //  life--;
                }
                if (life == 0)
                {
                    Console.WriteLine("Out of Lives\n");
                }

                Console.WriteLine("Press Enter to see the Results....");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("\n\n\t\t\t\t\t\t========= Your Scores =========");
                Console.WriteLine("\t\t\t\t\t\tWin      : " + Human_Win);
                Console.WriteLine("\t\t\t\t\t\tLose     : " + Human_lose);

                Console.WriteLine("\n\n\t\t\t\t\t\t========= Computer Scores =========");
                Console.WriteLine("\t\t\t\t\t\tWin      : " + Com_Win);
                Console.WriteLine("\t\t\t\t\t\tLose     : " + Com_lose);

                Console.Write("\n\t\t\t\t\t\tOverall Winner: ");
                if (Human_Win > Com_Win)
                {
                    if (Human_lose < Com_lose)
                    {
                        Console.WriteLine("Congratss, You Win! ");
                    }
                }
                else Console.WriteLine("Computer Win! \n\t\t\t\t\t\t\t\tBawi Next Time");

                again:
                Console.Write("\n\nDo you want to Play Again? [y/n]: ");
                PlayAgain = Console.ReadLine();

                if (PlayAgain == "Y" || PlayAgain == "y")
                {
                    Console.Clear();
                }
                else if (PlayAgain == "n" || PlayAgain == "N")
                {
                    Console.WriteLine("\n\nTHANK YOU FOR PLAYING\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t - JBits");
                    break;
                }
                else 
                { 
                    Console.WriteLine("Invalid Input!");
                    goto again;
                }


            } while (PlayAgain=="Y" || PlayAgain=="y");

            


        }

    }
}

