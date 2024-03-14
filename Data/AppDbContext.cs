using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autoclean.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoclean.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {
            
        }

        public virtual DbSet<Car> Cars {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
            .HasData(new Car[]
            {
                new Car{Id=1,Name="BMW",Model="2023",Price=2000000},
                new Car{Id=2,Name="Mar",Model="2024",Price=3000000},
                new Car{Id=3,Name="Toyota",Model="2022",Price=4000000},
                new Car{Id=4,Name="Mazda",Model="2021",Price=5000000}
            });
        }
    }
}