
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{
    public class ops
    {

        public int ops_id { set; get; }
        public string libelle { set; get; }
        public int type_ops_id { set; get; }
        public DateTime ops_date { set; get; }
        public DateTime ops_date_valeur { set; get; }
        public string sourece { set; get; }
        public string destination { set; get; }
        public int montant { set; get; }
        public int operateur_id { set; get; }
        public int admin_id { set; get; }
        
    }
}