using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint_class
{
    public partial class Form1 : Form
    {
        Drawer drawer;              
        public Form1()
        {
            InitializeComponent();
            drawer = new Drawer(pictureBox1);
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (drawer.sh == Shape.brush)
                {
                    drawer.fill(e.Location);
                    drawer.g = Graphics.FromImage(drawer.bm);
                    pictureBox1.Image = drawer.bm;
                }
                   
                else
                {
                    drawer.prev = e.Location;
                    drawer.start = true;
                }                             
            }
                       
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawer.start)
            {
                drawer.Draw(e.Location);
            }           
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawer.start = false;
            drawer.saveLastPath();           
        }         

        private void pencilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.pencil;
            //pictureBox1.Cursor = Cursors.PanNE;
        }       

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.rectangle;            
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.circle;
        }

        private void erasorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.erasor;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();            
            drawer.pen = new Pen(colorDialog1.Color);
            drawer.sb = new SolidBrush(colorDialog1.Color);
            drawer.color = colorDialog1.Color;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (drawer.sh == Shape.pencil || drawer.sh == Shape.circle || drawer.sh == Shape.rectangle || drawer.sh==Shape.line)
                drawer.pen.Width = trackBar1.Value;
            if (drawer.sh == Shape.erasor)
                drawer.er.Width = trackBar1.Value;           
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.line;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.g.Clear(Color.White);
            drawer.path = null;
            pictureBox1.Refresh();            
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.triangle;
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.rectangle;
        }

        private void solidToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            drawer.sh = Shape.solidrect;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG files (*.jpg)|*.jpg|PNG files(*.png)|*.png";
            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                drawer.SaveImage(saveFileDialog1.FileName);
            }
        }      

        private void button8_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Green);
            drawer.color = Color.Green;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Fuchsia);
            drawer.color = Color.Fuchsia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.White);
            drawer.sb = new SolidBrush(Color.White);
            drawer.color = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Black);
            drawer.sb = new SolidBrush(Color.Black);
            drawer.color = Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Salmon);
            drawer.sb = new SolidBrush(Color.Salmon);
            drawer.color = Color.Salmon;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            drawer.pen = new Pen(Color.Red);
            drawer.sb = new SolidBrush(Color.Red);
            drawer.pen.Width = trackBar1.Value;
            drawer.color = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            drawer.pen = new Pen(Color.DarkGray);
            drawer.sb = new SolidBrush(Color.DarkGray);
            drawer.pen.Width = trackBar1.Value;
            drawer.color = Color.DarkGray;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.RosyBrown);
            drawer.sb = new SolidBrush(Color.RosyBrown);
            drawer.color = Color.RosyBrown;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Blue);
            drawer.sb = new SolidBrush(Color.Blue);
            drawer.color = Color.Blue;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.LightBlue);
            drawer.sb = new SolidBrush(Color.LightBlue);
            drawer.color = Color.LightBlue;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Yellow);
            drawer.sb = new SolidBrush(Color.Yellow);
            drawer.color = Color.Yellow;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Olive);
            drawer.sb = new SolidBrush(Color.Olive);
            drawer.color = Color.Olive;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.DarkMagenta);
            drawer.sb = new SolidBrush(Color.DarkMagenta);
            drawer.color = Color.DarkMagenta;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Maroon);
            drawer.sb = new SolidBrush(Color.Maroon);
            drawer.color = Color.Maroon;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Brown);
            drawer.sb = new SolidBrush(Color.Brown);
            drawer.color = Color.Brown;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.LimeGreen);
            drawer.sb = new SolidBrush(Color.LimeGreen);
            drawer.color = Color.LimeGreen;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.LightGray);
            drawer.sb = new SolidBrush(Color.LightGray);
            drawer.color = Color.LightGray;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            drawer.pen.Width = trackBar1.Value;
            drawer.pen = new Pen(Color.Pink);
            drawer.sb = new SolidBrush(Color.Pink);
            drawer.color = Color.Pink;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                drawer.openImage(openFileDialog1.FileName);
            }           
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.brush;      
            //drawer.fill(drawer.prev);                                
        }

        private void triangleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.triangle1;
        }

        private void rombToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.romb;
        }

        private void trapeciyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.trap;
        }

        private void cubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawer.sh = Shape.cube;
        }
    }
}
