using Microsoft.EntityFrameworkCore;

namespace StudentReport.Data
{
    public class StudentsDbContext:DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)
        { Database.EnsureCreated(); }

        public DbSet<Students> Students { get; set; }
        public DbSet<Classes> Classes { get; set; }
        public DbSet<Countries> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>().HasData(GetClasses());
            modelBuilder.Entity<Countries>().HasData(GetCountries());
            modelBuilder.Entity<Students>().HasData(GetStudents());
            base.OnModelCreating(modelBuilder);
        }

        private List<Students> GetStudents()
        {
            return new List<Students>
            {
                new Students { Id = 1, ClassId=1,CountryId=1,Name="John",DOB=DateOnly.FromDateTime(new DateTime(1989,04,08))},
                new Students { Id = 2, ClassId=2,CountryId=3,Name="Abdul",DOB=DateOnly.FromDateTime(new DateTime(1982,08,07))},
                new Students { Id = 3, ClassId=4,CountryId=2,Name="Prasad",DOB=DateOnly.FromDateTime(new DateTime(1972,09,01))},
                new Students { Id = 4, ClassId=3,CountryId=1,Name="Kiran",DOB=DateOnly.FromDateTime(new DateTime(1986,12,23))},
                new Students { Id = 5, ClassId=4,CountryId=2,Name="Mathew",DOB=DateOnly.FromDateTime(new DateTime(1995,07,12))},
                new Students { Id = 6, ClassId=2,CountryId=3,Name="Priya",DOB=DateOnly.FromDateTime(new DateTime(1976,06,18))},
            };
        }

        private List<Classes> GetClasses()
        {
            return new List<Classes>
            {
                new Classes { Id = 1, ClassName="Physics"},
                new Classes { Id = 2, ClassName="Chemistry"},
                new Classes { Id = 3, ClassName="Mathematics"},
                new Classes { Id = 4, ClassName="Biology"}
            };
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
