using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CodeFirst.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Entities.Movie> Students { get; set; } // StudentEntity yapılarının tutulacağı veritablonuzun adını Students olarak belirlediniz.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // @ -> ters slash sorun yaratmasın diye.

            // Windows Authentication için
            optionsBuilder.UseNpgsql("Host=217.182.78.155;Port=5433;Username=patika;Password=patika;Database=PatikaCodeFirstDb1");

            // Sql Server Authentication için
            // optionsBuilder.UseSqlServer(@"server=SrtnWorkBook-2; database=PatikaFirstDB; uid=sa; pwd=sa; TrustServerCertificate=true");


            base.OnConfiguring(optionsBuilder);
        }
    }
}
