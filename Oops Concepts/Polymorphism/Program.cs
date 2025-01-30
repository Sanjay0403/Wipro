using Polymorphism;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            //Employee emp = new Employee();
            //emp.Empid = 11;
            //emp.EmpName = "Sanjay";

            ////emp.Display();

            //Department dpt = new Department(); //creating an instance for the derived class

            //dpt.Empid = 22;
            //dpt.EmpName = "Deep"; 
            //dpt.DeptName = "Dev";
            //dpt.Salary = 100000;

            //Console.WriteLine();

            //dpt.Display();
            // dpt.Show();

            //Manager mgr = new Manager();

            //mgr.Empid = 22;
            //mgr.EmpName = "Deep";
            //mgr.DeptName = "Dev";
            //mgr.Salary = 100000;
            //Console.Write("Enter Manager Name: ");
            //mgr.ManagerName = Console.ReadLine();
            ////mgr.ManagerName = " DIVINE ";

            //mgr.Display();
            Console.WriteLine("Enter Employee ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of the Employee: ");
            string name = Console.ReadLine();
            Console.WriteLine("enter department name: ");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter salary");
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Manager name: ");
 
            string mname = Console.ReadLine();
            Manager mgrcon = new Manager(id, name, dname, sal, mname);
            mgrcon.Display();

        }

    }
}
