//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace K3MIX
{
    using System;
    using System.Collections.Generic;
    
    public partial class Status
    {
        public Status()
        {
            this.Dodatni_podaci_korisnika = new HashSet<Dodatni_podaci_korisnika>();
        }
    
        public int ID_status { get; set; }
        public string Naziv { get; set; }
    
        public virtual ICollection<Dodatni_podaci_korisnika> Dodatni_podaci_korisnika { get; set; }
    }
}
