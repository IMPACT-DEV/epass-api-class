using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{

    public class info_compte
    {
         public int info_compte_id {set;get;}
         public string nom {set;get;}
         public string prenom {set;get;}
         public string alias {set;get;}
         public string photo_profil {set;get;}
         public DateTime naissance {set;get;}
         public int piece_identite {set;get;}
         public string sexe {set;get;}
         public string adresse {set;get;}
         public string ville_id { set; get; }
         public string pays_id { set; get; }
         public char[] email { set; get; }
         public string nationalite {set;get;}
         public int compte_id {set;get;}
         public string activite {set;get;}
    }
}