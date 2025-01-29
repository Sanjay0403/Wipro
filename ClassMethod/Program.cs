

using ClassMethod;
using System.Numerics;

namespace ClassMEthod
{
    internal class Program
    {
        //static void Display(int n)
        //without int the origina effects doesnt affect
        //static void Display(ref int n)//method definition
        //                              // ref int a changes the orgiinal value too
        //{
        //    n *= 20;
        //    Console.WriteLine("Static Method value: " + n);
        //}
        //static void OutSample(out int n)//method definition
        //                                // OUT Parameter
        //{
        //    // n *= 20; //OUT PARAMETER DOESNT TAKE INTIALIZING VALUES
        //    int a = 20;
        //    n = a * 20;
        //    Console.WriteLine("Static Method value: " + n);
        //}
        ////division class
        ////static int Division(int a,int b, out res n)
        ////{
        ////    n = a / b;
        ////    Console.WriteLine("Division metod: " +n);
        ////}
        //void Show() //instance method
        //{
        //    Console.WriteLine("Instance Method");
        //}

        ////method with return type
        //int add(int a, int b)
        //{
        //    return a + b;
        //}
        private static void Main(string[] args)
        {
            //Console.WriteLine("Method calling");
            //Program pgm = new Program();
            //pgm.Show();
            //int a =4 ;

            //Console.WriteLine("Value of a is: " +a);
            //Display(ref a);
            ////Display(a);
            //Console.WriteLine("the value of a after calling is: "+a);
            ////Console.WriteLine("After Addition: "+pgm.add(10, 20));
            //int result = pgm.add(10,20);
            //Console.WriteLine(pgm.add(10,20));

            ////Out parametet
            //OutSample(out a);
            //Console.WriteLine("THe value of a after calling outsample method is:" +a);
            //int res;
            //Console.WriteLine(Division(100,5,out res));
            //Console.WriteLine(res);

            //Employee[] emp = new Employee[2];
            //for (int i = 0; i < emp.Length; i++)
            //{
            //    Console.WriteLine("Enter EmployeeId: ");
            //    int id = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter EmployeeName: ");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Enter Dept: ");
            //    string dpt = Console.ReadLine();
            //    Console.WriteLine("Enter Salary: ");
            //    decimal sal = Convert.ToDecimal(Console.ReadLine());
            //    emp[i] = new Employee(id, name, dpt, sal);
            //}
            //for (int i = 0; i < emp.Length; i++)
            //{

            //    Console.WriteLine(emp[i].EmpId + "  " + emp[i].EmpName);
            //}
            Console.WriteLine("Employee MAnagement System");
            Console.WriteLine("1.AddEmployee\n 2.Display\n 3.Update\n 4.Delete");
            Console.WriteLine("Enter the choice to perform: ");
            string choice = Console.ReadLine();

            EmployeeCRUD empCRUD = new EmployeeCRUD();


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter EmployeeId: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter EmployeeName: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Dept: ");
                    string dpt = Console.ReadLine();
                    Console.WriteLine("Enter Salary: ");
                    decimal sal = Convert.ToDecimal(Console.ReadLine());

                    empCRUD.AddEmployee(id, name, dpt, sal);
                    break;


                case "2":
                    empCRUD.ListEmployee();
                    break;


                default:
                    Console.WriteLine("Enter the valid option!!");
                    break;

            }

        }
    }
}
