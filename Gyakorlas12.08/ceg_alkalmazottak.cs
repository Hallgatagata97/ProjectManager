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
    
    public partial class ceg_alkalmazottak
    {
        public int id { get; set; }
        public int ceg_id { get; set; }
        public int alkalmazott_id { get; set; }
        public string beosztas { get; set; }
        public string alkalmazott_statusz { get; set; }
    
        public virtual Alkalmazottak alkalmazottak { get; set; }
        public virtual Cegek cegek { get; set; }
    }
}
