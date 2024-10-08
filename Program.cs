﻿using Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserSettings userSettings = new UserSettings();

            GameStats.ShowTopScores();

            int gameSpeed = GameMenu.ShowMenu();
            Console.Clear();

            Walls walls = new Walls(80, 25, userSettings.WallColor);
            walls.Draw();

            Point startPoint = new Point(4, 5, '*');
            Snake snake = new Snake(startPoint, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25);
            FoodPoint food = (FoodPoint)foodCreator.CreateFood();
            food.Draw();

            GameStats gameStats = new GameStats();
            GameDisplay gameDisplay = new GameDisplay(gameStats);

            while (true)
            {
                // Проверка на нажатие клавиш
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key); // Управление змеей
                }

                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    Console.WriteLine($"Sa valisid {gameStats.Points} punktid");
                    gameStats.SaveScore(userSettings.PlayerName);
                    GameStats.ShowTopScores();

                    Console.WriteLine("Väljumiseks vajutage suvalist klahvi...");
                    Console.ReadKey();
                    return;
                }

                if (snake.Eat(food))
                {
                    gameStats.AddPoints(food.Points);
                    food = (FoodPoint)foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                gameDisplay.UpdateDisplay();

                Thread.Sleep(gameSpeed);
            }
        }
    }



    //Point p1 = new Point(1, 3, '*');
    //p1.Draw();

    //Point p2 = new Point(4, 5, '#');
    //p2.Draw();




    //HorizontalLine upline = new HorizontalLine(0, 78, 0, '+');
    //upline.Drow();

    //HorizontalLine downline = new HorizontalLine(0, 78, 24, '+');
    //downline.Drow();

    //VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
    //leftline.Drow();

    //VerticalLine rightline = new VerticalLine(0, 24, 78, '+');
    //rightline.Drow();

    //Snake snake = new Snake(p2, 4, Direction.RIGHT);
    //snake.Drow();

    //while (true)
    //{
    //    if(Console.KeyAvailable)
    //    {
    //        ConsoleKeyInfo key = Console.ReadKey();
    //        snake.HandleKey(key.Key);
    //    }
    //    Thread.Sleep( 100 );
    //    snake.Move();
    //}
    ////loome sööke
    //FoodCreator foodCreator = new FoodCreator(80, 25, '$');
    //Point food = foodCreator.CreateFood();
    //food.Draw();

    //while (true)
    //{
    //    if (snake.Eat(food))
    //    {
    //        food = foodCreator.CreateFood();
    //        food.Draw();
    //    }
    //    else
    //    {
    //        snake.Move();
    //    }
    //}

    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();
    //Thread.Sleep(300);
    //snake.Move();

    /* //salvestab täisarvuliste elementide loendi
     List<int> numList = new List<int>();
     numList.Add(0);
     numList.Add(1);
     numList.Add(2);

     int x = numList[0];
     int y = numList[1];
     int z = numList[2];

     //tsükkel loendi kõigi väärtuste järjestikuseks liikumiseks

     foreach (int i in numList)
     {
         Console.WriteLine(i);
     }
     //remove-konkreetse elemendi eemaldamiseks
     numList.RemoveAt(0);

     //luua loend, mis sisaldab mitut punkti

     List<Point> plist = new List<Point>();
     plist.Add(p1);
     plist.Add(p2);

     */
    //!!!Kapseldamine - on klasside omadus peita nende rakendamise üksikasju!!!
    //Console.ReadLine();
}

