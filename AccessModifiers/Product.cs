using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Product
    {
        int Proid; //class members
        string ProName; //class members

        public Product(int id,string name)
        {
            Proid = id;
            ProName = name;

        }

        //define a method
        private void SampleMthd()
        {
            Console.WriteLine("private method");
        }
        public void PublicMthd()
        {
            Console.WriteLine("public methods" + Proid+ "  " +ProName);
        }
    }
}