//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjektManager
{
    using System;
    using System.Collections.Generic;
    
    enum AlkalmazottStatusz
    {
        Akt�v,
        Inakt�v
    }
    public partial class Alkalmazottak
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alkalmazottak()
        {
            this.ceg_alkalmazottak = new HashSet<ceg_alkalmazottak>();
        }
    
        public int id { get; set; }
        public string vezeteknev { get; set; }
        public string keresztnev { get; set; }
        public string email { get; set; }
        public string telefonszam { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ceg_alkalmazottak> ceg_alkalmazottak { get; set; }
    }
}