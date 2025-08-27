using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your mark (0-100): ");
            int mark = int.Parse(Console.ReadLine());

            //Check which grade the mark belongs to using switch statement
            switch (mark)
            {
                case int n when (n >= 70 && n <= 100):
                    Console.WriteLine("You have passed with a grade A");
                    break;
                case int n when (n >= 60 && n < 70):
                    Console.WriteLine("You have passed with a grade B");
                    break;
                case int n when (n >= 50 && n < 60):
                    Console.WriteLine("You have passed with a grade C");
                    break;
                case int n when (n >= 40 && n < 50):
                    Console.WriteLine("You have failed: You must resit the exam");
                    break;
                case int n when (n >= 30 && n < 40):
                    Console.WriteLine("You have failed: You must resit the exam");
                    break;
                case int n when (n >= 0 && n < 30):
                    Console.WriteLine("You have failed: You cannot resit the exam");
                    break;
                default:
                    Console.WriteLine("Unknown result");
                    break;
                    //Loop until valid input is received
                    int num;
                    while (true)
                    {
                        Console.Write("Enter a number between 1 and 100: ");

                        //Check if user input a valid integer
                        if (int.TryParse(Console.ReadLine(), out num))
                        {
                            //Check if number is within 1 to 100 range
                            if (num >= 1 && num <= 100)
                            {
                                break; //Valid input received, exit loop
                            }
                        }

                        Console.WriteLine("Invalid input. Number should be between 1 and 100");
                    }

                    //Check which group the number belongs to using switch statement
                    switch (num)
                    {
                        case int n when (n >= 10 && n <= 20):
                            Console.WriteLine($"{num} belongs to Group 1");
                            break;
                        case int n when (n > 20 && n <= 30):
                            Console.WriteLine($"{num} belongs to Group 2");
                            break;
                        case int n when (n > 30 && n <= 40):
                            Console.WriteLine($"{num} belongs to Group 3");
                            break;
                        case int n when (n > 40 && n <= 50):
                            Console.WriteLine($"{num} belongs to Group 4");
                            break;
                        case int n when (n > 50 && n <= 60):
                            Console.WriteLine($"{num} belongs to Group 5");
                            break;
                        case int n when (n > 60 && n <= 70):
                            Console.WriteLine($"{num} belongs to Group 6");
                            break;
                        case int n when (n > 70 && n <= 80):
                            Console.WriteLine($"{num} belongs to Group 7");
                            break;
                        case int n when (n > 80 && n <= 90):
                            Console.WriteLine($"{num} belongs to Group 8");
                            break;
                        case int n when (n > 90 && n <= 100):
                            Console.WriteLine($"{num} belongs to Group 9");
                            break;
                    }
            }
        }
    }
}
