//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibrosEDM.ModeloAplicacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleDeAutor
    {
        public int Id { get; set; }
        public int LibroId { get; set; }
        public int AutorId { get; set; }
    
        public virtual Libro Libro { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
