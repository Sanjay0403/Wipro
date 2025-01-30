using GetSetmethods;
using System.Security.Cryptography.X509Certificates;

namespace GetSetmethod
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Student stu = new Student();
            stu.Stuid = 11;
            stu.Name = "Sanjay";
            stu.Age = 4;

            Console.WriteLine(stu.Stuid);
            Console.WriteLine(stu.Name);
            Console.WriteLine(stu.Age);


            //stu.SId = 111;
            //Console.WriteLine(stu.SId);

        }
    }
}