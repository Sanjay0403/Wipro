using System;
using System.Text;

namespace StringAppend
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //immutable 
            string? str = "Hello"; //memory will be allocataed
            //for(int i = 0; i < 5; i++)
            //{
            str += "World"; //new string in memory will be created
            // New memory
            //str = "sanjay";
            //}
            Console.WriteLine(str);


            //STRING BUILDER - MUTABLE 
            StringBuilder sb = new StringBuilder("Hello");//memory will appended and stored in the same memory
            sb.Append("World. This is Sanjaydeep");
            Console.WriteLine(sb);

            //
            Console.WriteLine("Enter the string");
            string? userinput = Console.ReadLine();
            Console.WriteLine("Enter the string to get appended:");
            string? appendedstr = Console.ReadLine();
            userinput += appendedstr; //a+=b = a+b
            Console.WriteLine(userinput);
            
            Console.WriteLine("Enter string builder input: ");
            string? strsb = Console.ReadLine();

            StringBuilder sbobj = new StringBuilder(strsb);

            // StringBuilder sbobj = new StringBuilder(Console.ReadLine());
            sbobj.Append(appendedstr);
            Console.WriteLine(sbobj);
        }

    }

}