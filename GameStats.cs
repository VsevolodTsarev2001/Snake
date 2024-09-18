using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class GameStats
    {
        public int Points { get; private set; }
        public DateTime StartTime { get; private set; }

        public GameStats()
        {
            Points = 0;
            StartTime = DateTime.Now;
        }

        public void AddPoints(int points)
        {
            Points += points;
        }

        public TimeSpan GetGameTime()
        {
            return DateTime.Now - StartTime;
        }

        public void SaveScore(string playerName)
        {
            TimeSpan gameTime = GetGameTime();
            string result = $"{playerName} - Points: {Points}, Time: {gameTime.Minutes}m {gameTime.Seconds}s\n";
            System.IO.File.AppendAllText(@"..\..\..\scores.txt", result);
        }

        public static void ShowTopScores()
        {
            if (System.IO.File.Exists(@"..\..\..\scores.txt"))
            {
                Console.WriteLine("Top Players:");
                string[] scores = System.IO.File.ReadAllLines(@"..\..\..\scores.txt");
                foreach (string score in scores)
                {
                    Console.WriteLine(score);
                }
            }
            else
            {
                Console.WriteLine("Vale.");
            }
        }
    }
}
