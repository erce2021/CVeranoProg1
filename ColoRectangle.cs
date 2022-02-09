using System;
using System.Collections.Generic;
using System.Text;

namespace HerenciaMultinivel
{
    class ColorRectangle : Rectangle
    {
        string rcolor;

        public ColorRectangle(string c, string s, double w, double l) : base(s, w, l)
        {
            rcolor = c;
        }

        public ColorRectangle()
        {

          
        }
        public string Rcolor
        {
            get { return rcolor; }
            set { this.rcolor  = value; }
        }

        
        public void DisplayColor()
        {
            Console.WriteLine("Color es " + rcolor);
        }
    }
}
