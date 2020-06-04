using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class AdminRoleContext : DbContext
    {
        public AdminRoleContext(DbContextOptions<AdminRoleContext> options)
           : base(options)
        {
        }

        public DbSet<AdminRole> AdminRoles { get; set; }
    }
}
