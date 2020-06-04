using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class VilleContext : DbContext
    {
        public VilleContext(DbContextOptions<VilleContext> options)
           : base(options)
        {
        }

        public DbSet<Ville> Villes { get; set; }
    }
}
