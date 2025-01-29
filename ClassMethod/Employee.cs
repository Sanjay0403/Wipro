using ClassMethod;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    internal class Employee
    {
        //class consists attributes / properties / data members
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Dept { get; set; }
        public decimal Salary { get; set; }

        //constructor
        public Employee(int EmpId, String EmpName, string Dept, decimal Salary)
        {
            //Initialization

            this.EmpId = EmpId; // this - current property
            this.EmpName = EmpName;
            this.Dept = Dept;
            this.Salary = Salary;

        }

        //methods
        public void Display()
        {
            Console.WriteLine("Employee Details: ");
            Console.WriteLine($"Employee ID:{EmpId} Employee Name: {EmpName} Empluee Salary: {Salary}");

        }


    }
}
