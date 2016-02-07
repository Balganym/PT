using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Snake.Models
{
    public class Drawer
    {
        public ConsoleColor color;
        public char sign;
        public List<Point> body = new List<Point>();        

        public Drawer() { }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }

        }

        public void Save()
        {
            string FileName = "";
            if (sign == 'O')
                FileName = "snake.xml";
            if (sign == '*')
                FileName = "food.xml";
            if (sign == '=')
                FileName = "wall.xml";

            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());
            xs.Serialize(fs, this);
            fs.Close();
        }

        public void Resume()
        {
            string FileName = "";
            if (sign == 'O')
                FileName = "snake.xml";
            if (sign == '*')
                FileName = "food.xml";
            if (sign == '=')
                FileName = "wall.xml";

            FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(GetType());

            if (sign == '*')
                Game.food = xs.Deserialize(fs) as Food;
            if (sign == '=')
                Game.wall = xs.Deserialize(fs) as Wall;

            if (sign == 'O')
                Game.snake = xs.Deserialize(fs) as Snake;

            fs.Close();

        }


    }
}
