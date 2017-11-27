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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Venta = new HashSet<Venta>();
        }
    
        public int IdCliente { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaAgrega { get; set; }
        public Nullable<System.DateTime> FechaElimina { get; set; }
        public string UsuarioAgrega { get; set; }
        public byte Eliminado { get; set; }
        public int IdEstado { get; set; }

        public string toString()
        {
            return "Descripcion: " + Descripcion + ", Fecha agregado: " + FechaAgrega + ", Fecha Eliminado: " + FechaElimina +
                ", Agregador por: " + UsuarioAgrega + ", Eliminado: " + Eliminado + ", Estado:" + IdEstado;
        }

        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
