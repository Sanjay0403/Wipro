using AbstractMethods;

internal class Program
{
    private static void Main(string[] args)
    {
        //Flight fli = new Flight();
        //object initializer - at the time of object creation,initialzie the values

        //abstract class connot be instantiated
        //it is not mandatory to have abstract method in aabstract
        //generally we go for abstract  in order to show essential features and hide method implementation

        FlightFare flightFare = new FlightFare()
        {
            FlightNo = 11,
            FlightName = "Airindia",
            durationinhrs = 6,
            typedes = "International"
        };

        flightFare.FlightDetails();
        flightFare.FareDetails();

        Flight ff = new FlightFare() { FlightNo = 12, FlightName = "Spicejet", durationinhrs = 3, typedes = "Domestic" };
        ff.FlightDetails();
        ff.FareDetails();
    }
}