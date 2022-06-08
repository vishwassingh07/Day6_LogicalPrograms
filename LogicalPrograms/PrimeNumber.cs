using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void PrimeNum()
        {
            int num, i;
            Console.Write("Enter the number you want to check for prime : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(i = 2; i <= num; i++)
            {
                if(num % i == 0)
                {
                    break;
                }
            }
            if(i == num)
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
            }
        }
    }
}
