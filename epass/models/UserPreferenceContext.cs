using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class UserPreferenceContext : DbContext
    {
        public UserPreferenceContext(DbContextOptions<UserPreferenceContext> options)
           : base(options)
        {
        }

        public DbSet<UserPreference> UserPreferences { get; set; }
    }
}
