namespace MathGame;

public class Menu
{
    private readonly GameEngine _engine;
    private readonly List<IGame> _games;

    public Menu(GameEngine engine, List<IGame> games)
    {
        _engine = engine;
        _games = games;
    }

    public void ShowMenu(string name, DateTime date)
    {
        Console.Clear();
        Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");
        Console.WriteLine("Press any key to show menu");
        Console.ReadLine();
        Console.WriteLine("\n");

        var isGameOn = true;

        do
        {
            Console.Clear();
            Console.WriteLine(@$"
What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
R - Random Game
Q - Quit the program");
            Console.WriteLine("---------------------------------------------");

            var gameSelected = Console.ReadLine();

            DifficultyLevel difficulty = DifficultyLevel.Easy; // Default difficulty
            if (gameSelected?.Trim().ToLower() != "v" && gameSelected?.Trim().ToLower() != "q")
            {
                difficulty = SelectDifficulty();
            }

            switch (gameSelected?.Trim().ToLower())
            {
                case "v":
                    Helpers.PrintGames();
                    break;
                case "a":
                    var additionGame = _games.First(g => g.Name == "Addition");
                    int additionScore = _engine.Play(additionGame, difficulty);
                    Helpers.AddToHistory(additionScore, Helpers.GetGameType(additionGame.Name), difficulty);
                    break;
                case "s":
                    var subtractionGame = _games.First(g => g.Name == "Subtraction");
                    int subtractionScore = _engine.Play(subtractionGame, difficulty);
                    Helpers.AddToHistory(subtractionScore, Helpers.GetGameType(subtractionGame.Name), difficulty);
                    break;
                case "m":
                    var multiplicationGame = _games.First(g => g.Name == "Multiplication");
                    int multiplicationScore = _engine.Play(multiplicationGame, difficulty);
                    Helpers.AddToHistory(multiplicationScore,Helpers.GetGameType(multiplicationGame.Name), difficulty);
                    break;
                case "d":
                    var divisionGame = _games.First(g => g.Name == "Division");
                    int divisionScore = _engine.Play(divisionGame, difficulty);
                    Helpers.AddToHistory(divisionScore, Helpers.GetGameType(divisionGame.Name), difficulty);
                    break;
                case "r":
                    var randomGame = _games.First(g => g.Name == "Random") as RandomGame;
                    int randomScore = randomGame.Play(difficulty, _engine);
                    Helpers.AddToHistory(randomScore, Helpers.GetGameType(randomGame.Name), difficulty);
                    break;
                case "q":
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    isGameOn = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        } while (isGameOn);
    }

    private DifficultyLevel SelectDifficulty()
    {
        Console.Clear();
        Console.WriteLine(@"
Select difficulty level:
E - Easy
M - Medium
H - Hard");
        Console.WriteLine("---------------------------------------------");

        var difficultyInput = Console.ReadLine()?.Trim().ToLower();

        return difficultyInput switch
        {
            "e" => DifficultyLevel.Easy,
            "m" => DifficultyLevel.Medium,
            "h" => DifficultyLevel.Hard,
            _ => DifficultyLevel.Easy // Default to Easy
        };
    }
}