using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<PortfoiloItem>().Property(x => x.Id).HasDefaultValue("NEWID()");
            modelBuilder.Entity<Owner>().HasData(
                new Owner()
                {
                    Id=Guid.NewGuid(),
                    Avatar="avatar.jpg",
                    FullName="Alraies Makktof",
                    Profile="Backend Web Programmer"
                }
                );
        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<PortfoiloItem> portfoiloItems { get; set; }
       
        
    }
}
