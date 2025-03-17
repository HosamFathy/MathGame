﻿using MathGame;

public class AdditionGame : IGame
{
    private readonly Random _random = new Random();

    public string Name => "Addition";

    public int[] GenerateNumbers(int minValue, int maxValue)
    {
        return new int[] { _random.Next(minValue, maxValue), _random.Next(minValue, maxValue) };
    }

    public string GetOperator() => "+";

    public int CalculateCorrectAnswer(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }
}