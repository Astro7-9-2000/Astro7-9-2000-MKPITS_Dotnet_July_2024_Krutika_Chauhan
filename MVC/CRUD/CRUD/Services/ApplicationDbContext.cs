using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Services
{
    // The ApplicationDbContext class is declared within the CRUD.Services namespace.
    // This helps organize the code and avoid naming conflicts with other classes.
    // The class inherits from DbContext, which is a base class provided by Entity Framework Core.
    // This inheritance allows ApplicationDbContext to interact with the database.
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        // This property represents a collection of Product entities in the database.
        // The DbSet<T> class is a part of Entity Framework Core and is used to query and save instances of T (in this case, Product) to the database.
        // The Products property allows you to perform CRUD operations on the Product entities, such as adding, updating, deleting, and querying products.
        public DbSet<Product> Products { get; set; }
    }

}

