using Microsoft.EntityFrameworkCore;
using RepositoryPractice2.Models;

namespace RepositoryPractice2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<tblCustomer> tblCustomer { get; set; }
        public DbSet<tblIssue> tblIssue { get; set; }
        public DbSet<ViewTblCustomerWithIssue> View_CustomerWithIssue { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ViewTblCustomerWithIssue>(Entity =>
            {
                Entity.HasNoKey().ToView("View_CustomerWithIssue");
                Entity.Property(e => e.CustomerId).HasColumnName("CustomerId");
                Entity.Property(e => e.CustomerName).HasMaxLength(50).HasColumnName("CustomerName");
                Entity.Property(e => e.Problem).HasMaxLength(50).HasColumnName("Problem");
                Entity.Property(e => e.PaymentStatus).HasMaxLength(10).HasColumnName("PaymentStatus");
                Entity.Property(e => e.WorkStatus).HasMaxLength(10).HasColumnName("WorkStatus");

                
            }); 
               
            base.OnModelCreating(modelBuilder);
        }
    }
}
