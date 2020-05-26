using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{
    public class compte
    {
        public int compte_id { set; get; }
        public int telephone { set; get; }
        public string password { set; get; }
        public char[] hash { set; get; }
        public char[] stamp { set; get; }
        public bool locked { set; get; }
        public bool enable { set; get; }
        public int OTP { set; get; }
        public string indicatif { set; get; }
    }
}

