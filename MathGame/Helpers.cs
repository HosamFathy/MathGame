namespace MathGame;

public class Helpers
{
    public static List<Game> games = [];

    public static GameType GetGameType(string gameName)
    {
        return gameName switch
        {
            "Addition" => GameType.Addition,
            "Subtraction" => GameType.Subtraction,
            "Multiplication" => GameType.Multiplication,
            "Division" => GameType.Division,
            "Random" => GameType.Random,
            _ => throw new ArgumentException("Invalid game name", nameof(gameName))
        };
    }

    public static void AddToHistory(int gameScore, GameType gameType, DifficultyLevel difficulty)
    {
        games.Add(new Game
        {
            Date = DateTime.Now,
            Score = gameScore,
            Type = gameType,
            Difficulty = difficulty
        });
    }
    
    public static void PrintGames()
    {
        Console.Clear();
        Console.WriteLine("Games History");
        Console.WriteLine("---------------------------");
        foreach (var game in games)
        {
            Console.WriteLine($"{game.Date} - {game.Type} (Difficulty: {game.Difficulty}): {game.Score}pts");
        }
        Console.WriteLine("---------------------------\n");
        Console.WriteLine("Press any key to return to Main Menu");
        Console.ReadLine();
    }
    
    public static string ValidateResult(string? result)
    {
        while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
        {
            Console.WriteLine("Your answer needs to be an integer. Try again.");
            result = Console.ReadLine();
        }

        return result;
    }
    
    public static string GetName()
    {
        Console.WriteLine("Please type your name");
        var name = Console.ReadLine();

        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name can't be empty");
            name = Console.ReadLine();
        }

        return name;
    }
}