using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Rectangle
    {
        private double width, length;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle()
        {
            this.width = 0;
            this.length = 0;
        }
        public double area()
        {
            return this.length * this.width;
        }
        public double perimeter()
        {
            return 2 * (this.length + this.width);
        }
        public String toString()
        {
            return "Rectangle";
        }

    }
}
