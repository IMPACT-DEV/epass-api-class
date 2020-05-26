using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{
    public class paiement
    {
        public int paiement_id { set; get; }
        public string libelle_paiement { set; get; }
        public string pays { set; get; }
        public string nature { set; get; }
    }
}