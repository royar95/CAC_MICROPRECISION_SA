//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CACMicropresicion.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public short Renglon { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Nullable<int> IdProducto { get; set; }
        public int IdVenta { get; set; }
    
        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
