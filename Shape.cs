using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaMultinivel
{
    class Shape
    {
        double a_width;
        double b_length;

        public Shape()
        {
            a_width = b_length = 0.0;
        }

        public Shape(double w, double l)
        {
            a_width = w;
            b_length = l;
        }
        public Shape(double y)
        {
            a_width = b_length = y;

        }
        public double Width
        {
            get { return a_width; }
            set { a_width = value; }
        }
        public double Length
        {
            get { return b_length; }
            set { b_length = value < 0 ? -value : value; }
        }
        public void DisplayDim()
        {
            Console.WriteLine("Width and Length are: " + Width + " and " + Length);
        }
    }
}
