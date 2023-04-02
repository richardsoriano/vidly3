using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vidly3.Models;

namespace vidly3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Customer>  Customers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}