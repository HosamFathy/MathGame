using System.Threading.Channels;

namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<IGame>
            {
                new AdditionGame(),
                new SubtractionGame(),
                new MultiplicationGame(),
                new DivisionGame(),
                new RandomGame(new List<IGame>
                {
                    new AdditionGame(),
                    new SubtractionGame(),
                    new MultiplicationGame(),
                    new DivisionGame()
                })
            };

            var engine = new GameEngine();
            var menu = new Menu(engine, games);

            var date = DateTime.UtcNow;
            string name = Helpers.GetName();

            menu.ShowMenu(name, date);
        }
    }
}
