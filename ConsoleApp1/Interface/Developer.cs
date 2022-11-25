using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{
    internal class Developer:Employee
    {
        public bool IsFreelancer { get; set; }
       
public override void CalculateSalary()
        {
            Console.WriteLine(MonthlyWorkingHour + Salary + PerHour );
        }

        public override void GetSumInfo()
        {
            Console.WriteLine($"{Name},{Surname},{Age}");
        }
    }
}
