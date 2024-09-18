using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameDisplay
    {
        private GameStats _gameStats;

        public GameDisplay(GameStats gameStats)
        {
            _gameStats = gameStats;
        }

        public void UpdateDisplay()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Punktid: {_gameStats.Points}");
            TimeSpan gameTime = _gameStats.GetGameTime();
            Console.WriteLine($"Aeg: {gameTime.Minutes}m {gameTime.Seconds}s");
        }
    }
}

