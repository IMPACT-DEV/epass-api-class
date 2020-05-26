using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{

    public class pays
    {
        public int pays_id { set; get; }
        public string nom { set; get; }
        public int indicatif { set; get; }
        public string code_pays { set; get; }
    }
}