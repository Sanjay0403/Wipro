using Class;
namespace Class
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee emp = new Employee();
            {
                emp.emp_Id = 1;
                emp.name = "Sanjay";

                Console.WriteLine($"Employee ID: {emp.emp_Id}");
                Console.WriteLine($"Employee Name: {emp.name}");
                //reading the inputs
                Console.WriteLine("Enter the Employee Id:");
                int id = Convert.ToInt32( Console.ReadLine() );

                Console.WriteLine("Enter the Employee Name:");
                string? name = Console.ReadLine();
                //creating instance
                Employee emp2 = new Employee(id, name); //CONSTRUCTOR WILL BE CALLED INSTANCE CREATION
                //displaying instance
                Console.WriteLine($"Emplyee ID: {emp2.emp_Id}");
                Console.WriteLine($"Employee Name: {emp2.name}");
            }
        }
    }
}