using epass.modeles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class PieceIdentiteContext : DbContext
    {
        public PieceIdentiteContext(DbContextOptions<PieceIdentiteContext> options)
           : base(options)
        {
        }

        public DbSet<PieceIdentite> PieceIdentites { get; set; }
    }
}
