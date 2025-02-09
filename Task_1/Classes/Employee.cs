using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    public abstract class Employee
    {
        private string Name;
        private int Age;
        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void CalculateSalary();
    }
}
