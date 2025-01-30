
namespace MthdOverloading
{

    class AddOpe
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //public int Add(int e,int f)
        //{
        //    return e + f;
        //}
        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b);
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        public void Add(double c, float d)
        {
            Console.WriteLine(c + d);
        }

        internal class Program
        {
            private static void Main(string[] args)
            {
                AddOpe op = new AddOpe();
                Console.WriteLine(op.Add("csharp", "training"));
                op.Add(10, 20,40);
            }
        }
    }
}