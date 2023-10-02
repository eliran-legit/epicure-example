using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.src.Entity;
using Microsoft.EntityFrameworkCore;
using src.Entity;

namespace src.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Chef> Chef { get; set; }
        public DbSet<Dish> Dish { get; set; }
    }
}