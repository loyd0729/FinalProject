using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesDBApp.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesDBApp.Data
{
    public class GamesContext : DbContext
    {
        public GamesContext(DbContextOptions<GamesContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().ToTable("Game");
        }
    }
}
