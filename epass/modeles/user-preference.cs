using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{

    public class user_preference
    {
        public int user_preference_id { set; get; }
        public int admin_id { set; get; }
        public string langue { set; get; }
        public int devise_id { set; get; }
        public int pin { set; get; }
        public char[] touch_id { set; get; }
    }
}