using Bootcamp.Practica3.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Practica3.API
{
    public class CarContext : DbContext
    {
        public CarContext(DbContextOptions<CarContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>(eb =>
            {
                eb.HasKey(c => new { c.Id });
            });
        }

        public DbSet<Car> Car { get; set; }
    }
}
