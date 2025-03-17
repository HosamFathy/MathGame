using MathGame;

public class RandomGame : IGame
{
    private readonly List<IGame> _games;
    private readonly Random _random = new Random();

    public RandomGame(List<IGame> games)
    {
        _games = games;
    }

    public string Name => "Random";

    public int[] GenerateNumbers(int minValue, int maxValue)
    {
        throw new NotImplementedException();
    }

    public string GetOperator()
    {
        throw new NotImplementedException();
    }

    public int CalculateCorrectAnswer(int firstNumber, int secondNumber)
    {
        throw new NotImplementedException();
    }

    public int Play(DifficultyLevel difficulty, GameEngine engine)
    {
        int score = 0;

        for (int i = 0; i < 5; i++) // Only 5 rounds in total
        {
            Console.Clear();
            // Randomly select a game
            var game = _games[_random.Next(_games.Count)];
            Console.WriteLine($"Playing {game.Name} game:");

            // Play one round of the selected game
            score += engine.PlaySingleRound(game, difficulty);
            
        }

        return score;
    }
}