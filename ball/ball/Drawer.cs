using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball
{
    class Drawer
    {
        public Graphics g;
        public Bitmap bm;
        public PictureBox picture;
        public int wy = 0,wx = 0;       
        public SolidBrush sb;
        public Rectangle rect;

        public Drawer(PictureBox p)
        {
            this.picture = p;
            sb = new SolidBrush(Color.Black);
            bm = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bm);
            picture.Image = bm;
            SolidBrush s = new SolidBrush(Color.Red);                              
        }
        public void draww(Rectangle r)
        {
            rect = r;
            picture.Paint += Picture_Paint;
        }
        
        public void Picture_Paint(object sender, PaintEventArgs e)
        {          
            g.FillRectangle(Brushes.Blue, rect);          
        }
    }    
}
   

