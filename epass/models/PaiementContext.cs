using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class PaiementContext : DbContext
    {
        public PaiementContext(DbContextOptions<PaiementContext> options)
           : base(options)
        {
        }

        public DbSet<Paiement> Paiements { get; set; }
    }
}
