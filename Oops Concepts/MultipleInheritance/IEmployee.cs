using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal interface IEmployee
    {
        void BasicDetails();

        void SalaryDetails();
    }
        interface IMeeting
    {
        void AttendMeetings();

    }

    class PermanentEmployee : IEmployee, IMeeting //multiple inheritance
    {
            public int empid { get; set; }
            public string? empname { get; set; }
            public decimal salary { get; set; }

            public void BasicDetails()
            {
                Console.WriteLine(empid + " " + empname);
            }

            public void SalaryDetails()
            {
                Console.WriteLine(salary);
            }
        }
        class TemporaryEmployee : IEmployee
        {
            public int empid { get; set; }
            public string? empname { get; set; }
            public decimal salary { get; set; }

            public void AttendMeeting
        {

        }

            public void BasicDetails()
            {
                Console.WriteLine(empid + " " + empname);
            }

            public void SalaryDetails()
            {
                Console.WriteLine(salary);
            }
        }
    }

