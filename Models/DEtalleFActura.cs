//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Servicios_jueves.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class DEtalleFActura
    {
        public int Codigo { get; set; }
        public int Numero { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad { get; set; }
        public int ValorUnitario { get; set; }

        [JsonIgnore] 
        public virtual PRODucto PRODucto { get; set; }
        
        [JsonIgnore] 
        public virtual FACTura FACTura { get; set; }
    }
}
