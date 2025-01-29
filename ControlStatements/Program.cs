namespace ControlStatements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number: ");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            //Console.WriteLine("enter the marks: ");
            //int mark = Convert.ToInt32(Console.ReadLine());
            //string? grade= " ";
            
            ////IF ELSE 

            //if (mark > 95 && mark <= 100)
            //{
            //    Console.WriteLine("O Grade");
            //    grade = "O";
            //}
            //else if (mark > 90 && mark <= 95)
            //{
            //    Console.WriteLine("A+ Grade");
            //    grade = "A+";
            //}
            //else if (mark > 85 && mark <= 90)
            //{
            //    Console.WriteLine("A Grade");
            //    grade = "A";
            //}
            //else if (mark > 75 && mark <= 85)
            //{
            //    Console.WriteLine("B Grade");
            //    grade = "B";
            //}
            //else if (mark > 60 && mark <= 75) 
            //{
            //    Console.WriteLine("C Grade");
            //    grade = "C";
            //}
            //else if (mark >= 0 && mark <= 60)
            //{
            //    Console.WriteLine("Better luck next time");
            //    grade = "";
            //}
            //else
            //{
            //    Console.WriteLine("Invalid marks entered!");
            //    return;
            //}

            //// SWITCH CASES 

            //switch (grade)
            //{
            //    case "O": Console.WriteLine("OUTSTANDING");
            //        break;
            //    case "A+": Console.WriteLine("EXCELLENT");
            //        break;
            //    case "A":
            //        Console.WriteLine("VERY GOOD");
            //        break;
            //    case "B":
            //        Console.WriteLine("GOOD");
            //        break;
            //    case "C":
            //        Console.WriteLine("NEED TO IMPROVE");
            //        break;
            //    default: Console.WriteLine("TRY AGAIN LATER");
            //        break;
            //}
            //int abc = 10;
            //for(; ;)
            //{
            //    Console.WriteLine(abc);
            //    if (abc <= 0)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        abc -= 3;
            //    }
            //}

            // DO WHILE 
            int y = 0;
            while (y < 5)
            {
                if (y == 2)
                    //break;
                    continue;
                Console.WriteLine("while loop"+y);
                y++;
            }
            //do
            //{
            //    Console.WriteLine("do.... while "+y);
            //} while (y < 5);
        }
    }
}
