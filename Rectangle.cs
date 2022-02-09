using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaMultinivel
{
    class Rectangle : Shape
    {
        string Style;

        public Rectangle()
        {
            Style = "null";
        }

        public Rectangle(string s, double w, double l): base(w,l)
        {
            Style = s;
        }
        public Rectangle(double y) : base(y)
        {
            Style = "square";
        }
        public double Area()
        {
            return Width * Length;
        }
        public void DisplayStyle()
        {
            Console.WriteLine("Rectangle es " + Style);
        }
    }
}
