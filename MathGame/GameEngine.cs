using MathGame;
using System.Diagnostics;

public class GameEngine
{
    private readonly Random _random = new Random();

    public int Play(IGame game, DifficultyLevel difficulty)
    {
        int score = 0;
        int minValue, maxValue;

        
        switch (difficulty)
        {
            case DifficultyLevel.Easy:
                minValue = 1;
                maxValue = 9;
                break;
            case DifficultyLevel.Medium:
                minValue = 10;
                maxValue = 50;
                break;
            case DifficultyLevel.Hard:
                minValue = 50;
                maxValue = 100;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, null);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine($"{game.Name} Game");

            
            var numbers = game.GenerateNumbers(minValue, maxValue);
            int firstNumber = numbers[0];
            int secondNumber = numbers[1];

            Console.WriteLine($"{firstNumber} {game.GetOperator()} {secondNumber}");

            
            string result = Console.ReadLine();
            result = Helpers.ValidateResult(result);

            
            if (int.Parse(result) == game.CalculateCorrectAnswer(firstNumber, secondNumber))
            {
                Console.WriteLine("Your answer was correct! Type any key for the next question");
                score++;
            }
            else
            {
                Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            }
            Console.ReadLine();
        }

        return score;
    }
    public int PlaySingleRound(IGame game, DifficultyLevel difficulty)
    {
        int minValue, maxValue;

        
        switch (difficulty)
        {
            case DifficultyLevel.Easy:
                minValue = 1;
                maxValue = 9;
                break;
            case DifficultyLevel.Medium:
                minValue = 10;
                maxValue = 50;
                break;
            case DifficultyLevel.Hard:
                minValue = 50;
                maxValue = 100;
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(difficulty), difficulty, null);
        }

        
        var numbers = game.GenerateNumbers(minValue, maxValue);
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];

        Console.Clear(); 
        Console.WriteLine($"{game.Name} Game");
        Console.WriteLine($"{firstNumber} {game.GetOperator()} {secondNumber}");

        
        string result = Console.ReadLine();
        result = Helpers.ValidateResult(result);

        
        if (int.Parse(result) == game.CalculateCorrectAnswer(firstNumber, secondNumber))
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question");
            Console.ReadLine(); 
            return 1; 
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for the next question");
            Console.ReadLine(); 
            return 0; 
        }
    }
}