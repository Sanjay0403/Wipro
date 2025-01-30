using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethods
{
    abstract class Flight // if you want to add abstract then the class should also be in the form of an abstract class
    {

        public int FlightNo{  get; set; }
        public string FlightName {  get; set; }
        public void FlightDetails() //method definition -normal method { }
        {
            Console.WriteLine(FlightNo+" "+ FlightName);
        }

        public abstract void FareDetails(); //Method declaration - abstract keyword
    }
    class FlightFare : Flight
    {
        public decimal BasicFare {  get; private set; }
        public int durationinhrs { get; set; }
        public string typedes {  get; set; }

        public override void FareDetails()
        {
            if (durationinhrs > 4)
            {
                BasicFare = 8000;
            }
            else
            {
                BasicFare = 5000;

            }
            if (typedes.ToLower().Equals("International"))
            {
                BasicFare += 10000;
            }
            Console.WriteLine($"basicfare: {BasicFare}");
        
        }
    }

}
