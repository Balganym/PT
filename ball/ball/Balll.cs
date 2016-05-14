using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace ball
{
    class Balll
    {
        Drawer drawer;
                
        public Balll()
        {
            Rectangle rect = new Rectangle(0, 100, 5, 5);
            drawer.draww(rect);
        }
    }
}
