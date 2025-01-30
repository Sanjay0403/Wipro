using Oops;

namespace oops
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            Employee emp = new Employee();
            emp.Empid = 11;
            emp.EmpName = "Sanjay";

            //emp.Display();

            Department dpt = new Department(); //creating an instance for the derived class

            dpt.Empid = 22;
            dpt.EmpName = "Deep"; 
            dpt.DeptName = "Dev";
            dpt.Salary = 100000;

            Console.WriteLine();

            //dpt.Display();
           // dpt.Show();

            Manager mgr = new Manager();
            
            mgr.Empid = 22;
            mgr.EmpName = "Deep";
            mgr.DeptName = "Dev";
            mgr.Salary = 100000;
            Console.Write("Enter Manager Name: ");
            mgr.ManagerName = Console.ReadLine();
            //mgr.ManagerName = " DIVINE ";

            mgr.Display();

        }

    }
}
