using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Globals
{
    class ContactInfoType
    {

        public static int Email = 1;
        public static int WorkTel = 2;
        public static int PersonalTeñ = 3;
        public static int HomeTel = 4;

        public byte value { get; set; }
        public string display { get; set; }

        public ContactInfoType (byte value, string display)
        {
            this.value = value;
            this.display = display;
        }

    }
}
