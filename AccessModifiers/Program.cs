namespace AccessModifiers
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the ProductId");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Product name:");
            string? nm = Console.ReadLine();

            Product product = new Product(id,nm);
            product.PublicMthd();

            Customer cust = new Customer();

            Console.WriteLine("Enter Customer ID: ");
            int CustId= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name: ");
            cust.CustName = Console.ReadLine();

            cust.Display();

        }

    }

}