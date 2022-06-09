using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs......");
            bool end = true;
            Console.WriteLine("1. Fibonacci Series\n2. Perfect Number\n3. Prime Number\n4." +
                " Reverse a Number\n5. Distinct Coupon Number\n6. " +
                "Stopwatch Program\n7. End the program");
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
                        PrimeNumber checkPrime = new PrimeNumber();
                        checkPrime.PrimeNum();
                        break;
                    case 4:
                        ReversingANumber reversing = new ReversingANumber();
                        reversing.ReversedNum();
                        break;
                    case 5:
                        CouponNumbers distinctCoupon = new CouponNumbers();
                        distinctCoupon.DistinctCoupon();
                        break;
                    case 6:
                        StopwatchProgram stopwatch = new StopwatchProgram();
                        stopwatch.Stopwatch();
                        break;
                    case 7:
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