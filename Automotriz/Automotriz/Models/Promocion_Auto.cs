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
    
    public partial class Promocion_Auto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Promocion_Auto()
        {
            this.AutoClientes = new HashSet<AutoCliente>();
        }
    
        public int IdPromocion_Auto { get; set; }
        public Nullable<int> IdAutoModelo { get; set; }
        public Nullable<int> IdAnios { get; set; }
        public Nullable<int> IdPromocion { get; set; }
        public Nullable<int> IdConcesinaria { get; set; }
        public Nullable<bool> Vigente { get; set; }
    
        public virtual Anio Anio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoCliente> AutoClientes { get; set; }
        public virtual AutoModelo AutoModelo { get; set; }
        public virtual Concesinaria Concesinaria { get; set; }
        public virtual PromocionList PromocionList { get; set; }
    }
}
