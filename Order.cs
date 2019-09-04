using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubV3
{
    public class Order
    {
        public string OrderName { get; set; }
        public double OrderPrice { get; set; }

        

        //public double SubTotal { get; set; }
        //public double SalesTax { get; set; }
        //public double grandTotal = 0;

        List<Menu> menus = Menu.MenuItems();
       public List<Order> cart = new List<Order>();
        public void PrintMenu()
        {
            int i = 0;

            foreach (var n in menus)
            {
                i++;
                Console.WriteLine(i + ". " + n.Name+"\t| "+ n.Category+" \t |"+ n.Price);
            }
            Console.WriteLine(menus.Count + 1 + ". End Order and Procede to payment");
        }
        public List<Order> AddMenuItem(int input, int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                cart.Add(new Order { OrderName = menus[input].Name, OrderPrice = menus[input].Price });
            }
            return cart;
        }

        public double GetGrandTotal()
        {
            double SubTotal = cart.Sum(x => x.OrderPrice);
            double SalesTax = SubTotal * 0.07;

            double grandTotal = SubTotal + SalesTax;

            return grandTotal;

            }
            public void PrintCart()
        {
            double SubTotal = cart.Sum(cart => cart.OrderPrice);
            double SalesTax = SubTotal * 0.07;

            double grandTotal = SubTotal + SalesTax;

            int i = 0;
            foreach (Order item in cart)
            {
                i++;
                Console.WriteLine(i + "." + item.OrderName + "\t                                    " + item.OrderPrice);
            }
            Console.WriteLine("________________________________");
            Console.WriteLine("\n Sub Total: " + SubTotal.ToString("C2", CultureInfo.CurrentCulture));
           Console.WriteLine("\n Tax: " + SalesTax.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("\n Grand Total: " + grandTotal.ToString("C2", CultureInfo.CurrentCulture));
            Console.WriteLine("________________________________");
        }

        //public static void returnCart()
        // {
        //     double SubTotal = cart.Sum(cart => cart.OrderPrice);
        //     double SalesTax = SubTotal * 0.07;

        //     double grandTotal = SubTotal + SalesTax;
        //     Console.WriteLine(grandTotal);
        // }





        //public double ReturnCart()
        //{
        //    double SubTotal = 0;
        //    double Tax = SubTotal * 0.07;
        //    List<double> cartTotal = new List<double>();
        //    foreach (var item in cart)
        //    {
        //        cartTotal.Add(item.OrderPrice);
        //    }

        //      SubTotal = cartTotal.Sum(x => Convert.ToDouble(x));

        //    double grandTotal = SubTotal + Tax;
        //    return grandTotal;
        //}

    }
}

