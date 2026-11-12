using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyMartB2C
{
    public static class CheckoutInfo
    {
        public static string Recipient = "";
        public static string Contact = "";
        public static string Province = "";
        public static string City = "";
        public static string Barangay = "";
        public static string Street = "";
        public static string Postal = "";
        public static string Payment = "Cash on Delivery";
        public static int LastOrderId;

        public static string FullAddress =>
            Street + ", Brgy. " + Barangay + ", " + City + ", " + Province + " " + Postal;

        public static void Clear()
        {
            Recipient = Contact = Province = City = Barangay = Street = Postal = "";
            Payment = "Cash on Delivery";
        }
    }
}
