using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    class Game
    {
        public static Food food = new Food();

        public Game()
        {
            Init();
            Play();
        }
        public void Play()
        {           
               Draw();
        }

        public void Init()
        {
            food.NewRandomPosition();
        }

        public void Draw()
        {
            Console.Clear();
            food.Draw();
        }


    }
}
