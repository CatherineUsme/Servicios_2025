//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios_jueves.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TELEfono
    {
        public int Codigo { get; set; }
        public string Numero { get; set; }
        public string Documento { get; set; }
        public int CodigoTipoTelefono { get; set; }
    
        public virtual CLIEnte CLIEnte { get; set; }
        public virtual TIpoTElefono TIpoTElefono { get; set; }
    }
}
