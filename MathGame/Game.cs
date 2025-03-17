namespace MathGame;


public class Game
{
    public DateTime Date { get; set; }

    public int Score { get; set; }

    public GameType Type { get; set; }

    public DifficultyLevel Difficulty { get; set; }

}
public enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}
public enum DifficultyLevel
{
    Easy,
    Medium,
    Hard
}

