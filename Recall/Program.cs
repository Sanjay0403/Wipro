namespace TwoDarray

{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the columns: ");
            int cols = int.Parse(Console.ReadLine());

            // Declare 2D array
            int[,] mtrx = new int[rows, cols];

            // Read input
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.WriteLine($"Element[{i},{j}]: ");
                    mtrx[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Display matrix
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(mtrx[i, j] + " ");
                }
                Console.WriteLine(); // Move to the next line after each row
            }

            // Calculate the sum
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += mtrx[i, j];
                }
            }
            Console.WriteLine("The sum is: " + sum);
        }
    }
}
