using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DotNetSaleCore.ConsoleApp.Models
{
    /// <summary>
    /// [5] DbContext Class
    /// </summary>
    public class SaleDbContext : DbContext
    {
        // Install-Package Microsoft.EntityFrameworkCore.SqlServer
        // Install-Package Microsoft.EntityFrameworkCore.InMemory
        // Install-Package System.Configuration.ConfigurationManager

        public SaleDbContext()
        {
            // Empty
            // ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public SaleDbContext(DbContextOptions<SaleDbContext> options)
            : base(options)
        {
            // 공식과 같은 코드 
            // ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //// 닷넷 프레임워크 기반에서 호출되는 코드 영역: 
            //// App.config 또는 Web.config의 연결 문자열 사용
            //// 직접 데이터베이스 연결문자열 설정 가능
            //if (!optionsBuilder.IsConfigured)
            //{
            //    string connectionString = ConfigurationManager.ConnectionStrings[
            //        "ConnectionString"].ConnectionString;
            //    optionsBuilder.UseSqlServer(connectionString);
            //}
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=Sale;trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
            //modelBuilder.Entity<Order>().HasOne(o => o.Customer);

            //// Categories Seed Data
            //modelBuilder.Entity<Category>().HasData(
            //    new Category { Id = 1, Name = "책"},    
            //    new Category { Id = 2, Name = "강의"},    
            //    new Category { Id = 3, Name = "컴퓨터"}
            //);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
