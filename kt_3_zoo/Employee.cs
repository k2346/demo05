using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_3_zoo
{
    class Employee
    {public string Name { get; set; }
    public string Duty { get; set; }
    public int Salary { get; set; }

        public override string ToString()
        {
            return "Employee Name: " + Name + "Duty: " + Duty + "Salary: " + Salary;
        }
    }
}
