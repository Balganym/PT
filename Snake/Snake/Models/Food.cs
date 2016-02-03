using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    class Food : Drawer
    {
        public Food()
        {
            color = ConsoleColor.DarkRed;
            sign = '*';
        }

        public void NewRandomPosition()
        {
            int x = (new Random().Next()) % 30;
            int y = (new Random().Next()) % 30;
            if (body.Count == 0)
                body.Add(new Point(x, y));
            else {
                body[0].x = x;
                body[0].y = y;
            }
        }
    }
}
