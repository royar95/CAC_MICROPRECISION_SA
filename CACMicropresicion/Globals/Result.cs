using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACMicropresicion.Globals
{
    class Result
    {

        //Códigos
        public static int Processed = 001;
        public static int Failed = 002;

        //Mensajes
        public static string Inserted = "Registro ingresado de forma satisfactoria";
        public static string Modified = "Registro modificado de forma satisfactoria";
        public static string Deleted = "Registro eliminado de forma satisfactoria";

        //Estados
        public static string Exist = "Existe un registro con los datos ingresados";
        public static string FailedCredentials = "Credenciales incorrectos, por favor inténtelo de nuevo";
        public static string UserNotActive = "El usuario no se encuentra activo";

        public static string Empty = "Existen espacios en blanco, por favor validar";
        public static string Same = "No se ha registrado cambios";
        public static string NoItemsPurchase = "Debe seleccionar al menos un material para la compra";
        public static string CeroOrLess = "El monto total no puede ser inferior o igual a cero";
        public static string NoQuantity = "Debe indicar la cantidad de compra para cada uno de los items";

    }
}
