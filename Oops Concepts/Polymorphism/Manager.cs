using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Manager : Department
    {
        public string? ManagerName { get; set; }
        //calling base class
        public Manager(int eid, string ename, string dname, decimal dsal, string? ManagerName) : base(eid, ename, dname, dsal)
        {
            this.ManagerName = ManagerName;
        }

        public override void Display()
        {
            base.Display(); //call display method of department class
            Console.WriteLine("Manager Name: " + ManagerName);


        }

    }
}
