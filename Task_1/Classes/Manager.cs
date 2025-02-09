using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    public class Manager : Employee
    {
        private double _salary;

        public Manager(string name , int age , double salary) : base(name,age)
        {
            this._salary = salary;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("Manager Salary : " + _salary);
        }
    }
}
