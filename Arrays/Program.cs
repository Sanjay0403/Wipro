using System;

namespace Arrays
{
    internal class Program
    {
        static void FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max) // Condition
                {
                    max = arr[i];
                }
            }
            Console.WriteLine($"Maximum element: {max}"); 
        }

        private static void Main(string[] args)
        {
            int[] arr = new int[4]; // Declaring array
            arr[1] = 30;
            arr[2] = 40;

            // Display array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int[] arr2 = { 10, 20, 30, 25, 40, 15 };
            Program.show(arr2);

            // Accessing static method using class name
            Program.FindMax(arr2);

            Console.WriteLine("Enter the size of an array:");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] aruser = new int[size];
            for (int i = 0; i < aruser.Length; i++)
            {
                Console.WriteLine($"Enter the value for {i + 1}th/st element: ");
                aruser[i] = Convert.ToInt32(Console.ReadLine());
            }
            show(aruser);
            Array.Sort(aruser);
            Console.WriteLine();
            show(aruser);
            Array.Reverse(aruser);  
            Console.WriteLine();
            show(aruser);
        }

        // Traverse an array using FOREACH
        public static void show(int[] arr2)
        {
            foreach (int val in arr2)
            {
                Console.WriteLine(val);
            }
        }
    }
}
