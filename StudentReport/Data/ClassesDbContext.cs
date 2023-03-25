using Microsoft.EntityFrameworkCore;

namespace StudentReport.Data
{
    public class ClassesDbContext:DbContext
    {
        public ClassesDbContext(DbContextOptions<ClassesDbContext> options):base(options)
        { }

        public DbSet<Classes> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Classes>().HasData(GetClasses());
            base.OnModelCreating(modelBuilder);
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
    }
}
