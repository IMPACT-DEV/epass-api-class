using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class PaysContext : DbContext
    {
        public PaysContext(DbContextOptions<PaysContext> options)
           : base(options)
        {
        }

        public DbSet<Pays> Payss { get; set; }
    }
}
