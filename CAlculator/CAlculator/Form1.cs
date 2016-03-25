using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAlculator
{   
    public partial class Form1 : Form
    {
        private Calc c = new Calc();
        public string one_op;
        public double save;
        public bool m = false;
        public bool res = false;

        public Form1()
        {            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Num_click(object sender, EventArgs e)
        {
            res = false;
            if (display.Text == "0" || m)             
                display.Clear();            
           Button btn = sender as Button;
            display.Text += btn.Text;
            m = false;         
        }

        private void Operation_click(object sender, EventArgs e)
        {
            res = false;
            Button btn = sender as Button;
            c.first = double.Parse(display.Text);     
            c.operation = btn.Text;
            display.Text = "";
            equation.Text = c.first + " " + c.operation;      
        }

        private void result_click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if (!res)
            {
                c.second = double.Parse(display.Text);                               
                c.calculate();
            }
            else
            {
                if(c.operation == "+")
                c.Result = c.second + double.Parse(display.Text);
                if (c.operation == "-")
                    c.Result = double.Parse(display.Text) - c.second;
                if (c.operation == "*")
                    c.Result = c.second * double.Parse(display.Text);
                if (c.operation == "/")
                    c.Result = double.Parse(display.Text) / c.second;

            }       
            equation.Text = "";
            display.Text = c.Result.ToString();
            res = true;                  
        }       

        private void Clear_all(object sender, EventArgs e)
        {
            res = false;
            equation.Text = "";                      
            c.first = 0;
            c.second = 0;
            c.Result = 0;
            c.operation = "";
            display.Text = "0";
        }

        private void last_Click(object sender, EventArgs e)
        {
            res = false;            
                display.Text = "0"; 
        }

        private void one_operation(object sender, EventArgs e)
        {
            res = false;
            Button btn = sender as Button;
            one_op = btn.Text;
            if (one_op == "sqrt")
            {
                double number = Double.Parse(display.Text);
                display.Text = Math.Sqrt(number).ToString();
            }
            if(one_op == "1/x")
            {
                double number = Double.Parse(display.Text);
                display.Text = (1/number).ToString();
            }                  
        }

        private void factorial(object sender, EventArgs e)
        {
            res = false;
            int fact;
            fact = int.Parse(display.Text);
            double f = 1;            
            for (int i = 2; i<= fact; i++)            
                f *= i;
            display.Text = Convert.ToString(f);

        }

        private void backspace(object sender, EventArgs e)
        {
            if (display.Text != "" && display.Text != "0")
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);                 
            }
            else
            {
                return;
            }
        }

        private void dot(object sender, EventArgs e)
        {
            if (!display.Text.Contains(","))
                display.Text = display.Text + ",";
            else
                return;
        }

        private void m_clear(object sender, EventArgs e)
        {
            save = 0;
        }

        private void m_save(object sender, EventArgs e)
        {
            if (display.Text != "")
                save = double.Parse(display.Text);
            else
                return;
            m = true;                     
        }       

        private void m_return(object sender, EventArgs e)
        {
            display.Text = save.ToString();
            m = true;
        }

        private void m_plus(object sender, EventArgs e)
        {
            save += double.Parse(display.Text);
        }

        private void m_minus(object sender, EventArgs e)
        {
            save -= double.Parse(display.Text);
        }

        private void plus_minus(object sender, EventArgs e)
        {
            display.Text = (double.Parse(display.Text) * -1).ToString();
        }
        
    }
}
