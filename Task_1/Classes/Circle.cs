using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Circle : Shape, IShape
    {
        private double _radius;
        public Circle() { }
        public Circle(double radius)
        {
               this._radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
        public void calArea()
        {
            Console.WriteLine("Area of Circle : " + _radius * _radius * Math.PI);
        }
        public void calPerimeter()
        {
            Console.WriteLine("Perimeter of Circle : " + 2 * Math.PI * _radius);
        }
    }

}
