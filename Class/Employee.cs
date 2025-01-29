using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Employee
    {
        // Members(Attributes) & Methods(Behaviour/functions)
        public int emp_Id { get; set; }
        public string name { get; set; }

        //Constructor - Parameter
        public Employee(int eid, string ename)
        {
            Console.WriteLine("Default Constructor");
            emp_Id = eid;   
            name = ename;
        }
        public Employee()
        {
            Console.WriteLine("Default Constructor");

        }

    }
}
