using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Customer
    {
        public int CustId;
        public string CustName;

        public void Display()
        {
            Console.WriteLine($"Customer Id: { CustId}\n Customer Name: {CustName}");
        }
    }
}
