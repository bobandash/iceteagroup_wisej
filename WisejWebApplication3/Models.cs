using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

// https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx
// https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

namespace WisejWebApplication3
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=MyDbContext;Integrated Security=True")
        {
            Database.SetInitializer<MyDbContext>(new CreateDatabaseIfNotExists<MyDbContext>());
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }

    public class Organization
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Street { get; set; }

        public string Zip { get; set; }

        public string City { get; set; }

        public string CountryCode { get; set; }

        public virtual ICollection<Staff> Staff { get; set; } = new List<Staff>();
    }

    public class Staff
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
