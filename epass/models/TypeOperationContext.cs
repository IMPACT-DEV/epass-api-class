using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class TypeOperationContext : DbContext
    {
        public TypeOperationContext(DbContextOptions<TypeOperationContext> options)
           : base(options)
        {
        }

        public DbSet<TypeOperation> TypeOperations { get; set; }
    }
}
