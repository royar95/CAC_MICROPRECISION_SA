//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CACMicropresicion.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class InfoUsuario
    {

        public string toString()
        {
            return "Tipo: " + Tipo + ", Valor: " + Valor + ", Fecha agregado: " + FechaAgrega + ", Fecha Eliminado: " + FechaElimina +
                ", Agregador por: " + UsuarioAgrega + ", Eliminado: " + Eliminado + ", Cedula Usuario: " + Usuario.Cedula + ", Estado:" + IdEstado;
        }

        public int IdInfoUsuario { get; set; }
        public byte Tipo { get; set; }
        public string Valor { get; set; }
        public System.DateTime FechaAgrega { get; set; }
        public Nullable<System.DateTime> FechaElimina { get; set; }
        public string UsuarioAgrega { get; set; }
        public byte Eliminado { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstado { get; set; }
    
        public virtual Estado Estado { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
