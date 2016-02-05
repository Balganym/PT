using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Game 
    {
        public static bool GameOver = false;
        public static Food food = new Food();
        public static Snake snake = new Snake();
        public static Wall wall = new Wall(1);

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
                ConsoleKeyInfo button = Console.ReadKey();
                if (button.Key == ConsoleKey.LeftArrow)
                    snake.move(-1, 0);
                if (button.Key == ConsoleKey.RightArrow)
                    snake.move(1, 0);
                if (button.Key == ConsoleKey.UpArrow)
                    snake.move(0, -1);
                if (button.Key == ConsoleKey.DownArrow)
                    snake.move(0, 1);

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

        public void Draw()
        {
            Console.Clear();
            food.Draw();
            snake.Draw();
            wall.Draw();
        }


    }
}
