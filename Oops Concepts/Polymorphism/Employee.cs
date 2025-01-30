using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Employee
    {
        public int Empid { get; set; }
        public string? EmpName { get; set; }

        public Employee(int Empid, string EmpName)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
        }

        public virtual void Display()
        {

            Console.WriteLine($"Employee ID:  {Empid } \n Employee Name: {EmpName}");
        }
    }
}
