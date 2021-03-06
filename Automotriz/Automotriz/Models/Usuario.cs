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
    
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            this.Mantenimientoes = new HashSet<Mantenimiento>();
            this.Origen_Fabrica = new HashSet<Origen_Fabrica>();
            this.Origen_Traspaso = new HashSet<Origen_Traspaso>();
            this.Origen_Traspaso1 = new HashSet<Origen_Traspaso>();
            this.VentaAutoes = new HashSet<VentaAuto>();
        }
    
        public int IdUsuario { get; set; }
        public string NomUsuario { get; set; }
        public string Contrasena { get; set; }
        public Nullable<bool> Acceso { get; set; }
        public Nullable<int> IdEmpleado { get; set; }
    
        public virtual Empleado Empleado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mantenimiento> Mantenimientoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Origen_Fabrica> Origen_Fabrica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Origen_Traspaso> Origen_Traspaso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Origen_Traspaso> Origen_Traspaso1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VentaAuto> VentaAutoes { get; set; }
    }
}
