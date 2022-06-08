using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public bool Factors(int number, int potentialFactor)
        {
            if(number % potentialFactor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void PerfectNum()
        {
            int sumOfFactors = 0;
            Console.Write("Enter the number you want to check for perfect number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= number/2; i++)
            {
                if (Factors(number, i))
                {
                    sumOfFactors += i;
                }
            }
            if(sumOfFactors == number)
            {
                Console.WriteLine(number + " is a perfect number ");
            }
            else
            {
                Console.WriteLine(number + " is not a perfect number ");
            }
        }
    }
}
