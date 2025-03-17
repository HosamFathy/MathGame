using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public interface IGame
    {
        string Name { get; }
        int[] GenerateNumbers(int minValue, int maxValue);
        string GetOperator();
        int CalculateCorrectAnswer(int firstNumber, int secondNumber);
    }

}
