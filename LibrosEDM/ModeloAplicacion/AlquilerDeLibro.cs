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
    
    public partial class AlquilerDeLibro
    {
        public int Id { get; set; }
        public string CodigoDeAlquiler { get; set; }
        public System.DateTime FechaDelAlquiler { get; set; }
        public System.DateTime FechaEstimadaDevolucion { get; set; }
        public System.DateTime FechaRealDevolucion { get; set; }
        public int ClienteId { get; set; }
        public int CopiaDeLibroId { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual CopiaDeLibro CopiaDeLibro { get; set; }
    }
}