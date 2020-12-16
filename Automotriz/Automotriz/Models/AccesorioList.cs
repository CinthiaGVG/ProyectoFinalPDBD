//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Automotriz.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccesorioList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccesorioList()
        {
            this.Accesorios = new HashSet<Accesorio>();
        }
    
        public int IdAccesorioList { get; set; }
        public string Numero { get; set; }
        public string Nombre { get; set; }
        public Nullable<int> IdAutoModelo { get; set; }
        public Nullable<int> IdAnios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accesorio> Accesorios { get; set; }
        public virtual Anio Anio { get; set; }
        public virtual AutoModelo AutoModelo { get; set; }
    }
}
