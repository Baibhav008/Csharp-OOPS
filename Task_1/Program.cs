using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Classes;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Circle circle = new Circle(4);
            Rectange rect = new Rectange(2,4);

            s.Draw();
            circle.Draw();
            rect.Draw(); 

            circle.calArea();
            circle.calPerimeter();

            rect.calArea();
            rect.calPerimeter();


            Manager manager = new Manager("John", 45, 52000);
            Developer developer = new Developer("Cena", 25, 100000);

            manager.CalculateSalary();
            developer.CalculateSalary();



        }
    }
}
