using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class DeviseContext : DbContext
    {
        public DeviseContext(DbContextOptions<DeviseContext> options)
           : base(options)
        {
        }

        public DbSet<Devise> Devises { get; set; }
    }
}
