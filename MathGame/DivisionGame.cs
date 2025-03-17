using MathGame;

public class DivisionGame : IGame
{
    private readonly Random _random = new Random();

    public string Name => "Division";

    public int[] GenerateNumbers(int minValue, int maxValue)
    {
        int secondNumber = _random.Next(minValue, maxValue);
        int firstNumber = secondNumber * _random.Next(minValue, maxValue / secondNumber);
        return new int[] { firstNumber, secondNumber };
    }

    public string GetOperator() => "/";

    public int CalculateCorrectAnswer(int firstNumber, int secondNumber)
    {
        return firstNumber / secondNumber;
    }
}