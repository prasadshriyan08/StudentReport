using Microsoft.EntityFrameworkCore;

namespace StudentReport.Data
{
    public class CountriesDbContext:DbContext
    {
        public CountriesDbContext(DbContextOptions<CountriesDbContext> options) : base(options)
        { }

        public DbSet<Countries> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Countries>().HasData(GetCountries());
            base.OnModelCreating(modelBuilder);
        }

        private List<Countries> GetCountries()
        {
            return new List<Countries>
            {
                new Countries { Id = 1, CountryName="India"},
                new Countries { Id = 2, CountryName="America"},
                new Countries { Id = 3, CountryName="Canada"}
            };
        }
    }
}
