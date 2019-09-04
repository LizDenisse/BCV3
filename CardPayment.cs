using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Globalization;

namespace BreakfastClubV3


{
    public class CardPayment : Order
    {
        public void CreditCardPaymentNumber(/*string crnumber,string date,string cvv*/)
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter your credit card number: ");
                decimal crnumber = decimal.Parse(Console.ReadLine());
                string crnumberstring = crnumber.ToString();
                if (crnumberstring.Length != 16)
                {
                    Console.WriteLine("You did not enter a valid credit card number. Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    con = false;
                }
            }
        }
        public void GetCreditCardDate()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter the expiration date (enter two digits for month and four for year): ");
                int date = int.Parse(Console.ReadLine());
                string datestring = date.ToString();
                string substring1 = datestring.Substring(0, 2);
                int datesubstring1 = Int32.Parse(substring1);
                string substring2 = datestring.Substring(2);
                int datesubstring2 = Int32.Parse(substring2);

                if (datestring.Length != 6 || datesubstring1 > 12 || datesubstring2 > 3000 || datesubstring2 < 1900 || datesubstring1 < 0)
                {
                    Console.WriteLine("You did not enter a valid date.Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("Thank you!");
                    con = false;
                }
            }
        }
        public void Getcreditcardcvv()
        {
            bool con = true;
            while (con)
            {
                Console.WriteLine("Please enter the number on the back of your card(cvv): ");
                int cvv = int.Parse(Console.ReadLine());
                string cvvstring = cvv.ToString();
                if (cvvstring.Length != 3)
                {
                    Console.WriteLine("You did not enter a cvv number.Please try again");
                    con = true;
                }
                else
                {
                    Console.WriteLine("We have received your payment.Thank you for your business");
                    con = false;
                }
            }
        }
    }
}
