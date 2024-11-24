using System.Collections.Generic;
using System.Data.Entity;

// https://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx

public class MyDbContext : DbContext
{
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Staff> Staffs { get; set; }
}

public class Organization
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Street { get; set; }

    public string Zip {  get; set; }  

    public string City { get; set; }

    public string CountryCode { get; set; }

    public ICollection<Staff> Staff { get; set; }
}

public class Staff
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public Organization Organization { get; set; }
}