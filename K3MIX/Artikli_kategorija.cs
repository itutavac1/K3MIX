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
    
    public partial class Artikli_kategorija
    {
        public Artikli_kategorija()
        {
            this.Artikli_podkategorija = new HashSet<Artikli_podkategorija>();
        }
    
        public int ID_artikal_kategorija { get; set; }
        public string Naziv { get; set; }
    
        public virtual ICollection<Artikli_podkategorija> Artikli_podkategorija { get; set; }
    }
}
