using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Four.Model;

namespace Task_Four.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TaskFourDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>()
                .Property(p => p.Id)
                .UseIdentityColumn(10, 10); 

            modelBuilder.Entity<Project>()
                .Property(p => p.Name)
                .HasColumnType("varchar(50)")
                .HasDefaultValue("OurProject")
                .IsRequired();

            modelBuilder.Entity<Project>()
                .Property(p => p.Cost)
                .HasColumnType("money");
        }
    }
}
