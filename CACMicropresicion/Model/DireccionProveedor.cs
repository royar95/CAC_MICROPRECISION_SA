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
    
    public partial class DireccionProveedor
    {

        public DireccionProveedor()
        {

        }

        public DireccionProveedor(string provincia, string canton, string distrito, string direccion, 
            DateTime fechaAgrega, DateTime fechaElimina, byte eliminado, string usuarioAgrega, int IdProveedor, 
            int IdEstado)
        {
            this.Provincia = provincia;
            this.Canton = canton;
            this.Distrito = distrito;
            this.DireccionExacta = direccion;
            this.FechaAgrega = fechaAgrega;
            this.FechaElimina = fechaElimina;
            this.Eliminado = eliminado;
            this.UsuarioAgrega = usuarioAgrega;
            this.IdProveedor = IdProveedor;
            this.IdEstado = IdEstado;

        }

        public int IdDireccionProveedor { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string DireccionExacta { get; set; }
        public System.DateTime FechaAgrega { get; set; }
        public Nullable<System.DateTime> FechaElimina { get; set; }
        public byte Eliminado { get; set; }
        public string UsuarioAgrega { get; set; }
        public int IdProveedor { get; set; }
        public int IdEstado { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
