using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball
{
    public partial class Form1 : Form
    {       
        Drawer drawer;
        public int x = 0, y = 0, w = 20, h = 20, dx = 10, dy = 10;
        public int rx = 200, ry = 280, rw = 200, rh = 20;
        SolidBrush sb;
        public Form1()       
        {
            InitializeComponent();                             
            sb = new SolidBrush(Color.Black);
            timer1.Start();
            timer1.Interval = 100;
            drawer = new Drawer(pictureBox1);          
        }
       /* private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + w > pictureBox1.Width)
            {
                dx = -10;
                if (sb.Color == Color.Black)
                    sb.Color = Color.Yellow;
                else
                    sb.Color = Color.Black;
            }
            if (x < 0)
            {
                dx = 10;
                if (sb.Color == Color.Black)
                    sb.Color = Color.Yellow;
                else
                    sb.Color = Color.Black;
            }
            if (y + h > pictureBox1.Height)
            {
                dy = -10;
                if (sb.Color == Color.Black)
                    sb.Color = Color.Yellow;
                else
                    sb.Color = Color.Black;
            }
            if (y < 0)
            {
                dy = 10;
                if (sb.Color == Color.Black)
                    sb.Color = Color.Yellow;
                else
                    sb.Color = Color.Black;
            }
            x += dx;
            y += dy;
            Refresh();
        }
        */
       // private void Form1_Paint(object sender, PaintEventArgs e)
        //{
           // drawer.g.FillEllipse(sb, x, y, w, h);
           // drawer.g.FillRectangle(Brushes.Black, rx, ry, rw, rh);
        //}
    }
}