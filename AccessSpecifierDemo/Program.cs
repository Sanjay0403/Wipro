using AccessModifiers;

namespace AccessSpecifierDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Customer cst = new Customer();
            cst.CustId = 123;
            cst.CustName = "Sanjaydeep";
            cst.Display();

        
        
        }
    }
}