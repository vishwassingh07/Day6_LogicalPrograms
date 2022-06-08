using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        public void DistinctCoupon()
        {
            int unique = 0, count = 0, coupon;
            Console.Write("Enter coupon number : ");
            coupon = Convert.ToInt32(Console.ReadLine());
            bool[] listOfCoupons = new bool[coupon];
            while(unique < coupon)
            {
                Random random = new Random();
                int option = random.Next(1,100);
                int newCoupon = (int)(random.NextDouble() * coupon);
                count++;
                if (!listOfCoupons[newCoupon])
                {
                    unique++;
                    listOfCoupons[newCoupon] = true;
                }
            }
            Console.WriteLine("Random numbers needed to have all distinct coupons : "+ count);
        }
    }
}
