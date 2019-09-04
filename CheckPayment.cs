using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubV3
{
  public  class CheckPayment : Order
    {

        public void Check()

        {
            //double SubTotal = cart.Sum(cart => cart.OrderPrice);
            //double SalesTax = SubTotal * 0.07;

            double grandTotal = GetGrandTotal();
            //  double grandTotal =GetGrandTotal();

            Console.WriteLine("Please enter your check card number: ");
            decimal cknumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Thank you a payment for {0} has been procesed", grandTotal);

        }
    }
}
