using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Globals
{
    class Status
    {

        public static int Active = 10;
        public static int Inactive = 15;
        public static int Deleted = 20;

        public const int Registered = 25;
        public const int Proforma = 30;
        public const int WaitingForPayment = 35;
        public const int Paid = 40;
        public const int Canceled = 45;

    }
}
