using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class OperationContext : DbContext
    {
        public OperationContext(DbContextOptions<OperationContext> options)
           : base(options)
        {
        }

        public DbSet<Operation> Operations { get; set; }
    }
}
