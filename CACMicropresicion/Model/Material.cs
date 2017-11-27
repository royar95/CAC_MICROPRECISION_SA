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
    
    public partial class Material
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Material()
        {
            this.DetalleCompra = new HashSet<DetalleCompra>();
        }
    
        public int IdMaterial { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaAgrega { get; set; }
        public Nullable<System.DateTime> FechaElimina { get; set; }
        public string UsuarioAgrega { get; set; }
        public byte Eliminado { get; set; }
        public int IdEstado { get; set; }
        public int IdTipoMaterial { get; set; }
        public Nullable<int> IdProveedor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual TipoMaterial TipoMaterial { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}
