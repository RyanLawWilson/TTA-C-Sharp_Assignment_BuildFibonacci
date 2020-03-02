using System;

namespace BuildFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program creates a Fibonacci sequence from two numbers.");
            System.Threading.Thread.Sleep(750);

            Fibonacci fib = new Fibonacci();

            bool loop = true;
            while (loop)
            {
                int num1 = 0;
                // Get number 1
                bool badNumber1 = true;
                while (badNumber1)
                {
                    Console.Write("Enter integer 1:  ");
                    try
                    {
                        num1 = Convert.ToInt32(Console.ReadLine());
                        badNumber1 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter an INTEGER, please...\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unknown exception: {0}", e.GetType());
                    }
                }

                System.Threading.Thread.Sleep(150);

                int num2 = 0;
                // Get number 2
                bool badNumber2 = true;
                while (badNumber2)
                {
                    Console.Write("Enter integer 2:  ");
                    try
                    {
                        num2 = Convert.ToInt32(Console.ReadLine());
                        badNumber2 = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter an INTEGER, please...\n");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unknown exception: {0}", e.GetType());
                    }
                }

                // Making the Fibonacci sequence
                fib.printSequence(first: num1, second: num2);

                // Go again?
                Console.Write("Do you want to enter new numbers? (y or n) ");
                string loopChoice = Console.ReadLine();
                if (loopChoice != "y")
                {
                    loop = false;
                }
            }

            Console.WriteLine("See ya later!");
            Console.ReadLine();
        }
    }
}