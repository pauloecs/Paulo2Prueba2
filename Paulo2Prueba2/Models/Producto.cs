//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Paulo2Prueba2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int IdProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }
        public int IdCategoria { get; set; }
        public bool estado { get; set; }
    
        public virtual Categoria Categoria { get; set; }
    }
}
