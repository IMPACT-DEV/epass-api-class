using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class InfoCompteContext : DbContext
    {
        public InfoCompteContext(DbContextOptions<InfoCompteContext> options)
           : base(options)
        {
        }

        public DbSet<InfoCompte> InfoComptes { get; set; }
    }
}
