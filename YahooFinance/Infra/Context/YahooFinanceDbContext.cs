using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YahooFinance.Domain.Entities;

namespace Infra.Context
{
    public class YahooFinanceDbContext : DbContext
    {

        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Pre> Pres { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Regular> Regulars { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<ValidRanges> ValidRanges { get; set; }
        public DbSet<Indicators> Indicators { get; set; }
        public DbSet<CurrentTradingPeriod> CurrentTradingPeriods { get; set; }
        public DbSet<TradingPeriod> TradingPeriod { get; set; }
        public DbSet<AtivoFull> AtivoFull { get; set; }
        public DbSet<AssetVariation> AssetVariations { get; set; }


        public YahooFinanceDbContext(DbContextOptions<YahooFinanceDbContext> options) : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(YahooFinanceDbContext).Assembly);

            modelBuilder.Entity<AssetVariation>()
                .Property(a => a.Valor)
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<TradingPeriod>()
                .Property(a => a.Gmtoffset)
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<Ativo>()
                .Property(a => a.Gmtoffset)
                .HasColumnType("decimal(5,2)");


            modelBuilder.Entity<Ativo>()                
                .HasMany(a => a.TradingPeriods)
                .WithOne(); ;

            modelBuilder.Entity<Ativo>()
                .HasMany(a => a.ValidRanges)
                .WithOne();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
            }
        }




    }
}
