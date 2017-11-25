using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Globals
{
    class UserTypes
    {

        public static byte Admin = 1;
        public static byte Operator = 2;

        public byte value { get; set; }
        public string display { get; set; }

        public UserTypes(byte value, string display) {
            this.value = value;
            this.display = display;
        }

    }
}
