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
    enum MennyisegiEgyseg
    {
        M,
        M2,
        Fm
    }
    public partial class Szolgaltatasok
    {
       
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Szolgaltatasok()
        {
            this.projekt_szolgaltatasok = new HashSet<Projekt_szolgaltatasok>();
        }
    
        public int id { get; set; }
        public string nev { get; set; }
        public string leiras { get; set; }
        public int egyseg_ar { get; set; }
        public string mennyisegi_egyseg { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projekt_szolgaltatasok> projekt_szolgaltatasok { get; set; }
    }
}
