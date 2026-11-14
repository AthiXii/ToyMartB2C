using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyMartB2C;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

    public static class Session
    {
        public static int UserId;
        public static string UserName = "";
        public static string Role = "";
    public static bool IsLoggedIn => UserId != 0;

    public static void Clear()
    {
        UserId = 0;
        UserName = "";
        Role = "";
        CheckoutInfo.Clear();
    }
}
