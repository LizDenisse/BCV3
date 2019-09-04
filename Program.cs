using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubV3
{
    class Program
    {

        public static void Main(string[] args)
        {
            BreakfastClubApp run = new BreakfastClubApp();
            run.RunApp();

            Order totalprice = new Order();

            double checktotal = totalprice.GetGrandTotal();

            Console.WriteLine("Grand Total: " + checktotal);
        }
    }
}
