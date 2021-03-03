using Microsoft.EntityFrameworkCore;
using StealJobs.Entities.Model;
using System;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<EmploymentType> EmploymentTypes { get; set; }
        public DbSet<Bookmark> Bookmarks { get; set; }
        public DbSet<User> Users { get; set; }

    }

    public static class RepositoryExtensions 
    {
        public static void AddDummyData(this RepositoryContext ctx)
        {
            // TODO add data
            ctx.Categories.Add(new Category
            {
                CategoryName = "IT"
            });

            ctx.Categories.Add(new Category
            {
                CategoryName = "Accounting"
            });

            ctx.Locations.Add(new Location
            {
                Country = "Armenia",
                Region = "Yerevan,",
                City = "Yerevan,"
            });

            ctx.Locations.Add(new Location
            {
                Country = "Russia",
                Region = "Moscow",
                City = "Moscow,"
            });

            ctx.EmploymentTypes.Add(new EmploymentType
            {
                TypeName = "Full Time"
            });

            ctx.EmploymentTypes.Add(new EmploymentType
            {
                TypeName = "Part Time"
            });

            ctx.EmploymentTypes.Add(new EmploymentType
            {
                TypeName = "Contractor"
            });

            ctx.SaveChanges();

            ctx.Jobs.Add(new Job
            {
                Title = ".Net Developer",
                CategoryId = 1,
                LocationId = 1,
                EmploymentTypeId = 1,
            });

            ctx.Jobs.Add(new Job
            {
                Title = "QA Engineer",
                CategoryId = 1,
                LocationId = 2,
                EmploymentTypeId = 2,
            });

            ctx.SaveChanges();
        }
    }
}
