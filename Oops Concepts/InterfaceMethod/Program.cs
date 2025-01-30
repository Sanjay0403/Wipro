using InterfaceMethod;
using System.Data.SqlTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        string ch;
        do
        {

        //Shape shape= new Shape();
        Console.WriteLine("Enter the shape: 1.Square 2.Circle 3.Rectangle");
        string? type = Console.ReadLine();

        switch (type)
        {
            case "Circle":
                IShape ish = new Circle() { radius = 10 };
                ish.CalculateArea();
                break;

            case "Rectangle":
                IShape rec = new Rect() { l = 10, b = 5 };
                rec.CalculateArea();
                break;

            default:
                IShape sq = new Circle();
                sq.DefaultSquare(5);
                break;
        }


        

        Console.WriteLine("Do you want to continue (yes/no):");
        ch = Console.ReadLine();
    } 
    while (ch.Equals("yes"));
          
    }
}
