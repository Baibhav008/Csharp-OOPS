using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Rectange : Shape,IShape
    {
        double _length, _breadth;

        public Rectange(double length, double breadth)
        {
            _length = length;
            _breadth = breadth;
        }

        public Rectange() { }
        
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }

        public void calArea()
        {
            Console.WriteLine("Area of Rectangle : " + _length * _breadth);
        }
        public void calPerimeter()
        {
            Console.WriteLine("Perimeter of Rectangle : " + 2 * (_length + _breadth));
        }

    }
}
