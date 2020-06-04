using epass.modeles;
using Microsoft.EntityFrameworkCore;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epass.models
{
    public class EventLogContext : DbContext
    {
        public EventLogContext(DbContextOptions<EventLogContext> options)
          : base(options)
        {
        }

        public DbSet<EventLog> EventLogs { get; set; }
    }
}
