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
    using System;
    using System.Collections.Generic;
    
    public partial class CIUDad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CIUDad()
        {
            this.SUCUrsals = new HashSet<SUCUrsal>();
        }
    
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public int CodigoDepartamento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUCUrsal> SUCUrsals { get; set; }
        public virtual DEPArtamento DEPArtamento { get; set; }
    }
}
