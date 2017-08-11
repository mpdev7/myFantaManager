using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFantaManager.Models
{
    public class FantaDbContext: DbContext
    {
        public FantaDbContext(DbContextOptions<FantaDbContext> options): base(options)
        {
            
        }

        public DbSet<PlayerContainer> PlayersContainers { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}
