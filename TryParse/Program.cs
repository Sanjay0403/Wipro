namespace TryParseExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Test different inputs here
            string input = null;

            int result;
            bool isParse = int.TryParse(input, out result);
            if (isParse)
            {
                Console.WriteLine($"Parsed successfully: {result}");
            }
            else
            {
                Console.WriteLine("TryParse failed");
            }

            try
            {
                int resConvert = Convert.ToInt32(input);
                Console.WriteLine($"Convert.ToInt32 succeeded: {resConvert}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Convert.ToInt32 failed: {ex.Message}");
            }

            int age = GetValidInteger("Enter your current age: ");
            int birthYear = GetValidInteger("Enter your birth year: ");

            Console.WriteLine($"You entered:\nAge: {age}\nBirth Year: {birthYear}");
        }

        private static int GetValidInteger(string prompt)
        {
            int value;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}
