using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Snake : Drawer
    {
        public Snake()
        {
            
            color = ConsoleColor.Yellow;
            sign = 'O';
            body.Add(new Point(10, 10));
        }

        public void move(int dx, int dy)
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            int k = body.Count;

            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x == Game.food.body[0].x && body[0].y == Game.food.body[0].y)
            {
                
                Game.food.NewRandomPosition();
                body.Add(new Point(body[0].x, body[0].y));                
            }

           for (int i = 0; i < Game.wall.body.Count - 1; i++)
            {
                if(body[0].x == Game.wall.body[i].x && body[0].y == Game.wall.body[i].y)
                {
                    Game.GameOver = true;
                }
            }

            for (int i = 0; i <= 50; i++)
            {
                if (body[0].x == i && body[0].y == 0 || body[0].x == i && body[0].y == 25)
                    Game.GameOver = true;    
            }

            for (int i = 0; i<=25; i++)
            {
                if (body[0].x == 0 && body[0].y == i || body[0].x == 50 && body[0].y == i)
                    Game.GameOver = true;
            }

            if (body.Count > 10)
            {
                int a = body[0].x;
                int b = body[0].y;
                body.Clear();
                body.Add(new Point(a, b));
            }
            
        }           

        
    }
}
