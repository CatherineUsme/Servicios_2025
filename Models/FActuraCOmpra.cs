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
    
    public partial class FActuraCOmpra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FActuraCOmpra()
        {
            this.DEtalleFacturaCompras = new HashSet<DEtalleFacturaCompra>();
        }
    
        public int Codigo { get; set; }
        public int CodigoEmpleado { get; set; }
        public string DocumentoProveedor { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.DateTime FechaPago { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEtalleFacturaCompra> DEtalleFacturaCompras { get; set; }
        public virtual EMpleadoCArgo EMpleadoCArgo { get; set; }
        public virtual PROVeedor PROVeedor { get; set; }
    }
}
