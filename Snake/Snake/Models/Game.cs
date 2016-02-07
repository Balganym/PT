using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Snake.Models
{
    public class Game 
    {
        public static int level = 1;
        public static bool GameOver = false;
        public static Food food = new Food();
        public static Snake snake = new Snake();     
        public static Wall wall = new Wall(level);

        public Game()
        {            
            Init();
            Play();
        }
        public void Play()
        {
            Console.SetWindowSize(50, 25);
            while (!GameOver)
            {
                Draw();
                if (Game.snake.body.Count() == 3)
                {
                    level += 1;
                    wall = new Wall(level);
                    
                        int a = Game.snake.body[0].x;
                        int b = Game.snake.body[0].y;
                        Game.snake.body.Clear();
                    

                     Game.snake.body.Add(new Point(a, b));                    
                }
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Food: {0}, level: {1}", Game.snake.body.Count(), level);
                              
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);
                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);
                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);
                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);
                if (button.Key == ConsoleKey.F2)
                    Save();
                if (button.Key == ConsoleKey.F3)
                    Resume();               
            }
            
            Console.SetCursorPosition(18, 12);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
        }

        public void Init()
        {
            food.NewRandomPosition();
            snake.body.Add(new Point(10, 10));
        }

        public void Save()
        {
            snake.Save();
            wall.Save();
            food.Save();

        }

        public void Resume()
        {
            snake.Resume();
            wall.Resume();
            food.Resume();
           
        }
        public void Draw()
        {
            Console.Clear();
            food.Draw();
            snake.Draw();
            wall.Draw();           
        }


    }
}
