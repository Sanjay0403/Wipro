using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class Employee
    {
        public int Empid { get; set; }
        public string? EmpName { get; set; }

        public virtual void Display()
        {

            Console.WriteLine(Empid + " " + EmpName);
        }
    }
}
