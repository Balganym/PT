using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_class
{
    public enum Shape {pencil, rectangle, circle, erasor, line, triangle, solidrect, triangle1,trap, brush, romb, cube};

    class Drawer
    {
        public Graphics g;
        public SolidBrush sb;
        public Bitmap bm;
                
        public GraphicsPath path;
        public Color color;
        public PictureBox picture;
        public Shape sh;
        public Pen pen, er;
        public bool start = false;
        public Point prev;

        bool[,] used = new bool[801, 501];
        Queue<Point> q = new Queue<Point>();

        public Drawer (PictureBox p)
        {
            picture = p;                       
            pen = new Pen(Color.Black);
            er = new Pen(Color.White);
            sb = new SolidBrush(Color.Black);

            openImage("");

            picture.Paint += Picture_Paint;
        }
        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null)
                e.Graphics.DrawPath(pen, path);
        }
        
        public void Draw(Point cur)
        {
            switch (sh)
            {
                case Shape.pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.rectangle:
                    path = new GraphicsPath();
                    if (prev.X > cur.X) {
                        if (prev.Y > cur.Y)
                            path.AddRectangle(new Rectangle(cur.X, cur.Y, prev.X - cur.X, prev.Y-cur.Y));
                        if(prev.Y<cur.Y)
                            path.AddRectangle(new Rectangle(cur.X, prev.Y, prev.X - cur.X, cur.Y - prev.Y));
                    }
                    else
                    {
                        if((prev.Y < cur.Y))
                            path.AddRectangle(new Rectangle(prev.X, prev.Y,cur.X - prev.X, cur.Y - prev.Y));
                        else
                            path.AddRectangle(new Rectangle(prev.X, cur.Y, cur.X - prev.X, prev.Y-cur.Y));
                    }                           
                    break;                                   
                case Shape.circle:
                    path = new GraphicsPath();
                    path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));                    
                    break;
               
                case Shape.triangle1:
                    path = new GraphicsPath();
                    Point[] p = new Point[3];
                        p[1] = prev;
                        p[0] = cur;
                        p[2] = new Point(prev.X, cur.Y);                    
                    path.AddPolygon(p);         
                    break;
                case Shape.line:
                    path = new GraphicsPath();
                    path.AddLine(prev, cur);                    
                    break;
                case Shape.solidrect:
                    path = new GraphicsPath();
                    if (cur.X < prev.X)
                        path.AddRectangle(new Rectangle(cur.X, cur.Y, prev.X - cur.X, prev.Y - cur.Y));                    
                    else
                    path.AddRectangle(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    break;
                case Shape.triangle:
                    path = new GraphicsPath();
                    Point[] pp = new Point[3];
                    pp[0] = prev;
                    pp[1] = cur;
                    pp[2] = new Point(cur.X - 2 * (cur.X - prev.X), cur.Y);
                    path.AddPolygon(pp);
                    break;
                case Shape.erasor:
                    path = null;
                    g.DrawLine(er, prev, cur);
                    prev = cur;
                    break;
                case Shape.romb:
                    path = new GraphicsPath();
                    Point[] r = new Point[4];
                    r[0] = prev;
                    r[1] = cur;
                    r[2] = new Point(prev.X, cur.Y + (cur.Y - prev.Y));
                    r[3] = new Point(prev.X - (cur.X - prev.X), cur.Y);
                    path.AddPolygon(r);
                    break;
                case Shape.cube:
                    Point[] c = new Point[18];
                    c[0] = prev;
                    c[1] = new Point(prev.X + 20, prev.Y - 20);
                    c[2] = new Point(prev.X + 40, prev.Y - 20);
                    c[3] = new Point(prev.X + 60, prev.Y);
                    c[4] = prev;
                    c[5] = new Point(prev.X, prev.Y + 40);
                    c[6] = new Point(prev.X + 40, prev.Y + 40);
                    c[7] = new Point(prev.X + 40, prev.Y);
                    c[8] = new Point(prev.X + 60, prev.Y - 20);
                    c[9] = new Point(prev.X + 60, prev.Y + 20);
                    c[10] = new Point(prev.X + 40, prev.Y + 40);
                    c[11] = new Point(prev.X, prev.Y + 40);
                    c[12] = new Point(70, 70);
                    c[13] = new Point(70, 30);
                    c[14] = new Point(70, 70);
                    c[15] = new Point(110, 70);
                    c[16] = new Point(90, 90);
                    c[17] = new Point(50, 90);
                    break;
                case Shape.trap:
                    path = new GraphicsPath();
                    Point[] t = new Point[4];
                    t[0] = prev;
                    t[1] = new Point(prev.X + cur.Y - prev.Y, prev.Y);
                    t[2] = cur;
                    t[3] = new Point(prev.X - (cur.X - prev.X - cur.Y + prev.Y), cur.Y);
                    path.AddPolygon(t);
                    break;
                default:
                    break;
            }
            picture.Refresh();
        }

        public void saveLastPath()
        {
            if (path != null)
            {
                if (sh != Shape.solidrect)
                {
                    g.DrawPath(pen, path);
                    path = null;
                }
                    
                else
                {
                    g.FillPath(sb, path);
                    path = null;
                }              
            }
        }
        public void SaveImage(string filename)
        {
            bm.Save(filename);
        }

        public void openImage(string filename)
        {
            // bm = filename == "" ? new Bitmap(picture.Width, picture.Height) : new Bitmap(filename);
            if (filename == "")
                bm = new Bitmap(picture.Width, picture.Height);
            else
            {
                Bitmap image = new Bitmap(filename);
                for (int i=0; i<image.Width; i++)
                {
                    for(int j=0; j<image.Height; j++)
                    {
                        Color curcolor = image.GetPixel(i, j);
                        Color newColor = Color.FromArgb(255, curcolor.R, curcolor.G, curcolor.B);
                    }
                }
                bm = new Bitmap(image);
            }
            g = Graphics.FromImage(bm);
            picture.Image = bm;
        }

        public void fill(Point cur)
        {
            for (int i = 0; i < 800; i++)
                for (int j = 0; j < 500; j++)
                    used[i, j] = false; 
                   
            Color clicked_color = bm.GetPixel(cur.X, cur.Y);
            used[cur.X, cur.Y] = true;
            q.Enqueue(cur);
            bm.SetPixel(cur.X, cur.Y, color);
            while (q.Count > 0)
            {
                Point p = q.Dequeue();
                checkNeighbors(p.X + 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y + 1, clicked_color);
                checkNeighbors(p.X - 1, p.Y, clicked_color);
                checkNeighbors(p.X, p.Y - 1, clicked_color);
            }
            picture.Refresh();                        
        }

        public void checkNeighbors(int x, int y, Color clicked_color)
        {
            if (x > 0 && y > 0 && x < picture.Width && y < picture.Height)
            {
                if (used[x, y] == false && bm.GetPixel(x, y) == clicked_color)
                {
                    used[x, y] = true;
                    q.Enqueue(new Point(x, y));
                    bm.SetPixel(x, y, color);                                       
                }
            }
        }
    }
}
 