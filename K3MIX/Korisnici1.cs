using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    public partial class Korisnici
    {
        /// <summary>
        /// User instance, consumer will be null
        /// </summary>
        /// <param name="consumer">if true, user will be null, otherwise consumer will be null</param>
        public Korisnici(bool consumer)
        {
            if (!consumer)
            {
                this.Dodatni_podaci_konzumenta = null;
                this.Dodatni_podaci_korisnika = new HashSet<Dodatni_podaci_korisnika>();
            }
            else
            {
                this.Dodatni_podaci_konzumenta = new HashSet<Dodatni_podaci_konzumenta>();
                this.Dodatni_podaci_korisnika = null;
            }

           this.Pracenje_po_datumima = new HashSet<Pracenje_po_datumima>();
           this.Pracenje_po_datumima1 = new HashSet<Pracenje_po_datumima>();
        }
    }
}
