using ClassMethod;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    internal class EmployeeCRUD
    {
        //Create an aray of 5 employees
        //int[] ar =new int[5];

        private const int size = 5;
        Employee[] emps = new Employee[2]; //creating a list using array
        private int Empcount = 0;

        //methods to perform CRUD

        public void AddEmployee(int EmpId, string EmpName, string Dept, decimal Salary)
        {
            emps[Empcount] = new Employee(EmpId, EmpName, Dept, Salary);
            Empcount++;
            Console.WriteLine("Employee Added Successfully");

//            emps[Empcount] = new Employee(EmpId, EmpName, Dept, Salary);
        }
        public void ListEmployee()
        {
            for (int i = 0; i < Empcount; i++)
            {
                emps[i].Display();

            }
        }

        public void UpdateEmployee()
        {

        }

        public void DeleteEmployee()
        {

        }

    }
}
