
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles {
    public class AdminRole
    {
        [System.ComponentModel.DataAnnotations.Key]
        public Guid Id { set; get; }

        //navigation Admin
        [ForeignKey(nameof(AdminId))]
        public Admin Admin { set; get; }
        public int AdminId { set; get; }

        //navigation Role
        [ForeignKey(nameof(RoleId))]
        public Role Role { set; get; }
        public int RoleId { set; get;}

        public string Valeur { set; get; }
        
    }
}
