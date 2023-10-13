namespace MyFirstC_Program
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math game. That's great that you're working on improving yourself\n");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                            V - View previous games
                            A - Addition
                            S - Subtraction
                            M - Multiplication
                            D - Division
                            Q - Quit the program");

                Console.WriteLine("----------------------------");

                var gameSelected = Console.ReadLine();


                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition Game");
                        break;
                    case "s":
                        gameEngine.SubtractionGame("Subtraction Game");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication Game");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division Game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            } while (isGameOn);

        }
    }
}
