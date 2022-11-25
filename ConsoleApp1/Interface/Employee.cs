using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal abstract class Employee:Person
    {
        public int MonthlyWorkingHour { get; set; }
        public string Salary { get; set; }
        public int PerHour { get; set; }

        public abstract void CalculateSalary();
       
    }
}
