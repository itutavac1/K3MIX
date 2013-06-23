using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.EntityModel;

namespace K3MIX
{
    public partial class Korisnici
    {
        /// <summary>
        /// User instance, consumer will be null
        /// </summary>
        /// <param name="x">Does nothing</param>
        public Korisnici(int x)
        {
           this.Dodatni_podaci_konzumenta = null;
           this.Dodatni_podaci_korisnika = new HashSet<Dodatni_podaci_korisnika>();
           this.Pracenje_po_datumima = new HashSet<Pracenje_po_datumima>();
           this.Pracenje_po_datumima1 = new HashSet<Pracenje_po_datumima>();
        }
    }
}
