using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

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

        // True when every delivery field has been filled in
        public static bool IsComplete =>
            Recipient != "" && Contact != "" && Province != "" && City != "" &&
            Barangay != "" && Street != "" && Postal != "";

        public static void Clear()
        {
            Recipient = Contact = Province = City = Barangay = Street = Postal = "";
            Payment = "Cash on Delivery";
        }

        // Reads the customer's saved details from the database
        public static void LoadFromProfile()
        {
            if (!Session.IsLoggedIn) return;

            var dt = Db.Query(
                "SELECT recipient_name, contact_no, province, city, barangay, street, " +
                "postal_code, payment_pref FROM users WHERE user_id = @u",
                new SqlParameter("@u", Session.UserId));
            if (dt.Rows.Count == 0) return;
            var r = dt.Rows[0];

            Recipient = Get(r, "recipient_name");
            Contact = Get(r, "contact_no");
            Province = Get(r, "province");
            City = Get(r, "city");
            Barangay = Get(r, "barangay");
            Street = Get(r, "street");
            Postal = Get(r, "postal_code");
            string pay = Get(r, "payment_pref");
            Payment = pay != "" ? pay : "Cash on Delivery";
        }

        // Saves the current details to the customer's account
        public static void SaveToProfile()
        {
            if (!Session.IsLoggedIn) return;

            Db.Execute(
                "UPDATE users SET recipient_name=@rn, contact_no=@cn, province=@pr, city=@ci, " +
                "barangay=@ba, street=@st, postal_code=@po, payment_pref=@pm WHERE user_id=@u",
                new SqlParameter("@rn", Recipient),
                new SqlParameter("@cn", Contact),
                new SqlParameter("@pr", Province),
                new SqlParameter("@ci", City),
                new SqlParameter("@ba", Barangay),
                new SqlParameter("@st", Street),
                new SqlParameter("@po", Postal),
                new SqlParameter("@pm", Payment),
                new SqlParameter("@u", Session.UserId));
        }

        private static string Get(System.Data.DataRow r, string col) =>
            r[col] == DBNull.Value ? "" : r[col].ToString()!;
    }
}
