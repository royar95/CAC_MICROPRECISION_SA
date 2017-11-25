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
    
    public partial class Venta
    {
        public Venta()
        {
            this.DetalleVenta = new HashSet<DetalleVenta>();
            this.Factura = new HashSet<Factura>();
        }
    
        public int IdVenta { get; set; }
        public int IdUsuario { get; set; }
        public decimal Total { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public System.DateTime FechaAgrega { get; set; }
        public Nullable<System.DateTime> FechaElimina { get; set; }
        public byte Eliminado { get; set; }
        public int IdEstado { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public int IdTipoPago { get; set; }
        public System.DateTime FechaVenta { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual TipoPago TipoPago { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
