using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Circle : Shape1
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle()
        {
            this.radius = 0;
        }
        public double area()
        {
            return Math.PI * this.radius * this.radius;
        }
        public double perimeter()
        {
            return 2 * Math.PI * this.radius;
        }
        public String toString()
        {
            return "Circle";
        }
    }
}
