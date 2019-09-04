using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubV3
{

    public class CashPayment : Order
    {

        public void Cash()
        {
            //Order totalprice = new Order();
            //double checktotal = totalprice.GetGrandTotal(); 
            double grandTotal = GetGrandTotal();
            Console.WriteLine("How much cash do you want to insert: ");
            string a = Console.ReadLine();
            double amount = double.Parse(a);
          //  double amount = double.Parse(Console.ReadLine());7


            if (grandTotal < amount)
            {
                double change = amount - grandTotal;
                Console.WriteLine("Her is your change: " + change.ToString("C2", CultureInfo.CurrentCulture));
            }
            if (grandTotal == amount)
            {
                Console.WriteLine(" Payment Accepted.  Thank you");
            }

            else
            {
                Console.WriteLine("That's not enough money. you need {0}.  try Again", amount - grandTotal);
                Console.WriteLine("How much cash do you want to insert: ");
                 a = Console.ReadLine();
                 amount = double.Parse(a);
                //   amount = double.Parse(Console.ReadLine());

            }
        }
    }
}
    