using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Fibonacci()
        {
            int num, a = 0, b = 1, c;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
