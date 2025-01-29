namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jagged array

            //int[][] jagarr = new int[4][];
            //jagarr[0]= new int[]  { 10, 20, 30};
            //jagarr[1] = new int[] { 20, 24 };
            //jagarr[2] = new int[] { 45, 78, 89, 99 };
            //jagarr[3] = new int[] { 45, 78, 89, 99 };

            ////display / traverse the elements
            //for(int i = 0; i < jagarr.Length; i++)
            //{
            //    Console.Write($"outer array: Row {i+1}" + " ");
            //    for (int j=0; j < jagarr[i].Length; j++)
            //    {
            //        Console.Write(jagarr[i][j]+" ");
            //    }
            //    Console.WriteLine();
            //}
            Console.WriteLine("Enter the no.of teams: ");
            int teams = Convert.ToInt32(Console.ReadLine());
            int[][] jagarruser = new int[teams][];
            //reading the values

            for (int i = 0; i < teams; i++)
            {
                Console.WriteLine($"\nEnter the number of rounds played by team {i + 1}: ");
                int rounds = Convert.ToInt32(Console.ReadLine());
                jagarruser[i] = new int[rounds];

                Console.WriteLine($"Enter the scores for each round for team {i + 1}:");
                for (int j = 0; j < rounds; j++)
                {
                    jagarruser[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //display the scores
            for (int i = 0; i < jagarruser.Length; i++)
            {
                Console.Write($"Scores for team {i + 1}: ");
                int sum = 0; //sum
                for (int j = 0; j < jagarruser[i].Length; j++)
                {
                    Console.Write(jagarruser[i][j] + " "); 
                    sum += jagarruser[i][j]; //sum 
                }
                Console.WriteLine($"Total score: {sum} \n"); // Display total score for the team
            }

        }
    }
}