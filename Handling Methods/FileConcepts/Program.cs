using FileConcepts;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        FileStream fs = new FileStream("sample.txt", FileMode.OpenOrCreate);
        //StreamWriter sw = new StreamWriter(fs);

        //sw.WriteLine("Welcome to File Concepts");
        //sw.WriteLine("Second Line");

        //Console.WriteLine("File Created successfully");

        StreamReader sr = new StreamReader(fs);
        //Console.WriteLine(sr.Read());

        //Console.WriteLine(sr.ReadLine()); //prints only first line
        //Console.WriteLine(sr.ReadToEnd()); // prints all the lines
        string res = " ";
        while((res=sr.ReadLine())!=null)
        {
            Console.WriteLine(res);
        }


        //Account[] acc = new Account[3];
        //for(int i = 0; i < acc.Length; i++)
        //{
        //    acc[i] = new Account();
        //    {
        //        Console.WriteLine("Enter id, Name, balance: ");
        //        int id = Convert.ToInt32(Console.ReadLine());
        //        string name = Console.ReadLine();
        //        int bal = Convert.ToInt32(Console.ReadLine());
        //        acc[i] = new Account() { Accid = id, AccName= name, Accbalance = bal };

        //    }
        //    
        //}
        Account acc = new Account();
        string data = JsonConvert.SerializeObject(acc);
        Console.WriteLine(acc);


        sr.Close();
        fs.Close();

    }
}