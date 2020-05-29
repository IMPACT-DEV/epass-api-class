using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace epass.modeles
{

    public class UserPreference
    {
        [Key]
        public Guid Id { set; get; }
        public int AdminId { set; get; }
        public string Langue { set; get; }
        public int DeviseId { set; get; }
        public int Pin { set; get; }
        public Boolean TouchId { set; get; }

        //navigation Admin
        [ForeignKey(nameof(AdminId))]
        public Admin Admin { set; get; }

        [ForeignKey(nameof(DeviseId))]
        public Devise Devise { set; get; }
    }
}