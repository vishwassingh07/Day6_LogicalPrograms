using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReversingANumber
    {
        public void ReversedNum()
        {
            Console.Write("Enter the number you want to reverse : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reversedNum = 0;

            string digit = Convert.ToString(number);

            for(int i = digit.Length - 1; i >= 0; i--)
            {
                reversedNum += (number % 10) * (int)Math.Pow(10, i);
                number = number / 10;
            }
            Console.WriteLine("The reversed number of given number is : " + reversedNum);
        }
    }
}
