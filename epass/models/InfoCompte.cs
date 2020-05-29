using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{

    public class InfoCompte
    {
         [System.ComponentModel.DataAnnotations.Key] 
         public Guid Id {set;get;}
         public string Nom {set;get;}
         public string Prenom {set;get;}
         public string Alias {set;get;}
         public byte[] PhotoProfil {set;get;}
         public DateTime Naissance {set;get;}
         public string PieceIdentite {set;get;}
         public Enum Sexe {set;get;}
         public string Adresse {set;get;}
         public string VilleId { set; get; }
         public string PaysId { set; get; }
         public string Email { set; get; }
         public string Nationalite {set;get;}
         public int CompteId {set;get;}
         public string Activite {set;get;}


        //navigagtion
        [ForeignKey(nameof(PaysId))]
        public Pays Pays { set; get; }

        [ForeignKey(nameof(VilleId))]
        public Ville Ville { set; get; }

        [ForeignKey(nameof(CompteId))]
        public Compte Compte { set; get; }
    }
}