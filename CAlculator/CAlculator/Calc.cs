using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlculator
{
    class Calc
    {
        public double first, second;
        private double result;
        public string operation;       

        public void calculate()
        {
            switch (operation)
            {
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
                case "/":
                    result = first / second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "%":                                   
                    result = first * second / 100;
                    break;              
                case "x^y":                    
                    result = Math.Pow(first, second);
                    break;
                default:
                    break;
            }
        }
        public double Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
            
        }
    }
}
