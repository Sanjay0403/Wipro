using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Department : Employee //inheritance - department
    {
        public string? DeptName {  get; set; }
        public decimal Salary { get; set; }

        //public void Show()
        //{
        //    Console.WriteLine(DeptName+ " " +Salary);
        //}

        public override void Display()
        {
            base.Display();
            Console.WriteLine(DeptName + " " + Salary);

        }
    }
}
