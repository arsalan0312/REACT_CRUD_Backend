using Microsoft.EntityFrameworkCore;
using REACT_CRUD.Entity;

namespace REACT_CRUD.ContextDB
{
    public class TestDBContext : DbContext
    {
        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }
        public DbSet<DepartmentType> DepartmentTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentType>().HasData(DepartmentTypesData.DepartmentTypes.Values.ToArray());

            modelBuilder
               .Entity<Employee>()
               .HasOne(entity => entity.DepartmentTypes)
               .WithMany(entity => entity.Employees)
               .HasForeignKey(entity => entity.DepartmentTypeId);

            modelBuilder
              .Entity<DepartmentType>()
              .HasMany(entity => entity.Employees)
              .WithOne(entity => entity.DepartmentTypes)
              .HasForeignKey(entity => entity.DepartmentTypeId)
              .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
