using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs......");
            bool end = true;
            Console.WriteLine("1. Fibonacci Series\n2. Perfect Number\n3. End the program");
            while (end == true)
            {
                Console.WriteLine("Choose an option to execute.....");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.Fibonacci();
                        break;
                    case 2:
                        PerfectNumber perfect = new PerfectNumber();
                        perfect.PerfectNum();
                        break;
                    case 3:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }
            }
        }
    }
}