using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Department : Employee //inheritance - department
    {
        public string? DeptName { get; set; }
        public decimal Salary { get; set; }

        public Department(int id, string name, string dname, decimal sal) : base(id, name)
        {
            DeptName = dname;
            Salary = sal;
        }

        //public void Show()
        //{
        //    Console.WriteLine(DeptName+ " " +Salary);
        //}

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Department Name: {DeptName } \n Salary: {Salary}");

        }
    }
}
